using GameOfLife.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {

        // The universe array
        bool[,] universe = new bool[30, 30];

        bool[,] scratchPad = new bool[30, 30];

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Red;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        // Alive cells count
        int livingCells = 0;

        //Show HUD
        private bool DisplayHUD = true;

        public Form1()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
            DefaultSettings();
        }

        private void NewUniverse(int width, int height)
        {
            universe = new bool[width, height];
            for (int w = 0; w < universe.GetLength(0); w++)
                for (int h = 0; h < universe.GetLength(1); h++)
                {
                    universe[w, h] = false;
                }

            scratchPad = new bool[width, height];
            for (int w = 0; w < scratchPad.GetLength(0); w++)
                for (int h = 0; h < scratchPad.GetLength(1); h++)
                {
                    scratchPad[w, h] = false;
                }
            
            graphicsPanel1.Invalidate();
        }

        private int CountNeighborsFinite(int x, int y)
        {
            int neighborCount = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;
                    // if xOffset and yOffset are both equal to 0 then continue
                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }
                    // if xCheck is less than 0 then continue
                    if (xCheck < 0)
                    {
                        continue;
                    }
                    // if yCheck is less than 0 then continue
                    if (yCheck < 0)
                    {
                        continue;
                    }
                    // if xCheck is greater than or equal too xLen then continue
                    if (xCheck >= xLen)
                    {
                        continue;
                    }
                    // if yCheck is greater than or equal too yLen then continue
                    if (yCheck >= yLen)
                    {
                        continue;
                    }
                    if (universe[xCheck, yCheck] == true) neighborCount++;
                }
            }
            return neighborCount;
        }

        private int CountNeighborsToroidal(int x, int y)
        {
            int neighborCount = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;
                    // if xOffset and yOffset are both equal to 0 then continue
                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }
                    // if xCheck is less than 0 then set to xLen - 1
                    if (xCheck < 0)
                    {
                        xCheck = xLen - 1;
                    }
                    // if yCheck is less than 0 then set to yLen - 1
                    if (yCheck < 0)
                    {
                        yCheck = yLen - 1;
                    }
                    // if xCheck is greater than or equal too xLen then set to 0
                    if (xCheck >= xLen)
                    {
                        xCheck = 0;
                    }
                    // if yCheck is greater than or equal too yLen then set to 0
                    if (yCheck >= yLen)
                    {
                        yCheck = 0;
                    }

                    if (universe[xCheck, yCheck] == true) neighborCount++;
                }
            }
            return neighborCount;
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            livingCells = 0;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (universe[x, y] == true)
                    {
                        livingCells++;
                    }
                    // set scratchpad and universe the same
                    scratchPad[x, y] = universe[x, y];
                    // decide finite or toroidal for next gen
                    int livingNeighbors;
                    if (finiteCountToolStripMenuItem.Checked)
                    {
                        livingNeighbors = CountNeighborsFinite(x, y);
                    }
                    else
                    {
                        livingNeighbors = CountNeighborsToroidal(x, y);
                    }

                    //Game of life rules
                    if (universe[x, y])
                    {
                        if (livingNeighbors < 2 || livingNeighbors > 3)
                        {
                            scratchPad[x, y] = false;
                        }
                        else if (livingNeighbors == 2 || livingNeighbors == 3)
                        {
                            scratchPad[x, y] = true;
                        }
                    }
                    else
                    {
                        if (livingNeighbors == 3)
                        {
                            scratchPad[x, y] = true;
                        }
                    }

                }
            }
            //swap universe and scratchpad for next gen
            bool[,] temp = universe;
            universe = scratchPad;
            scratchPad = temp;
            // Increment generation count
            generations++;
            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripStatusLabelLivingCells.Text = "Living Cells = " + livingCells.ToString();
            graphicsPanel1.Invalidate();
        }
        private int GenerateRandomSeed()
        {
            Random randomSeed = new Random();
            int rSeed = randomSeed.Next(-2147483647, 2147483647);
            return rSeed;
        }

        private void ShowNeighbors(int livingNeighbors, PaintEventArgs e, RectangleF cellRect, ToolStripMenuItem toolStripIcon)
        {

            var font = new Font("Arial", 8f);
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;


            if (toolStripIcon.Checked)
                e.Graphics.DrawString(livingNeighbors.ToString(), font, Brushes.Black, cellRect, stringFormat);
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            float cellWidth = graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);


            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    RectangleF cellRect = RectangleF.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;
                    int livingNeighbors;
                    if (finiteCountToolStripMenuItem.Checked)
                    {
                        livingNeighbors = CountNeighborsFinite(x, y);
                    }
                    else
                    {
                        livingNeighbors = CountNeighborsToroidal(x, y);
                    }

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                        //show neighbors on live cells
                        ShowNeighbors(livingNeighbors, e, cellRect, showNeighborCountToolStripMenuItem);
                    }
                    if (!universe[x, y] && livingNeighbors > 0)
                    {
                        //show moore's neighborhood
                        ShowNeighbors(livingNeighbors, e, cellRect, showNeighborhoodToolStripMenuItem);
                    }
                    // Toggle grid
                    if (showGridToolStripMenuItem.Checked)
                    {
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                    }
                    
                }
            }
            if (DisplayHUD)
            {
                string type = finiteCountToolStripMenuItem.Checked ? "Finite" : "Toroidal";
                Font font = new Font("Arial", 15f);
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Far,
                    LineAlignment = StringAlignment.Near
                };
                _ = new Rectangle(0, 0, 100, 100);
                e.Graphics.DrawString(
                    $@"Generations: {generations}{Environment.NewLine}Living Cells: {livingCells}{Environment.NewLine}Boundary Type: {type}{Environment.NewLine}Universe Size: (Width={universe.GetLength(0)}, Height={universe.GetLength(1)})",
                    font, Brushes.DarkGreen, ClientRectangle, stringFormat);
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                float cellWidth = graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
                float cellHeight = graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                float x = e.X / (float)cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                float y = e.Y / (float)cellHeight;

                // Toggle the cell's state
                universe[(int)x, (int)y] = !universe[(int)x, (int)y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        private void DefaultSettings()
        {
            graphicsPanel1.BackColor = Settings.Default.BackgroundColor;
            cellColor = Settings.Default.CellColor;
            gridColor = Settings.Default.GridColor;
            NewUniverse(Settings.Default.UniverseWidth, Settings.Default.UniverseHeight);
            timer.Interval = Settings.Default.Milliseconds;
            toroidalCountToolStripMenuItem.Checked = Settings.Default.Toroidal;
            finiteCountToolStripMenuItem.Checked = !Settings.Default.Toroidal;

            graphicsPanel1.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }
            generations = 0;
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripStatusLabelLivingCells.Text = "Living Cells = " + livingCells.ToString();
            graphicsPanel1.Invalidate();
        }

        private void playToolStripButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            graphicsPanel1.Invalidate();
        }

        private void pauseToolStripButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            graphicsPanel1.Invalidate();
        }

        private void nextStepToolStripButton_Click(object sender, EventArgs e)
        {
            NextGeneration();
            graphicsPanel1.Invalidate();
        }

        private void finiteCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toggle finite count in tool strip menu
            finiteCountToolStripMenuItem.Checked = true;
            toroidalCountToolStripMenuItem.Checked = false;

            graphicsPanel1.Invalidate();
        }

        private void toroidalCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toggle toroidal count in tool strip menu
            toroidalCountToolStripMenuItem.Checked = true;
            finiteCountToolStripMenuItem.Checked = false;

            graphicsPanel1.Invalidate();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }
            generations = 0;
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripStatusLabelLivingCells.Text = "Living Cells = " + livingCells.ToString();
            graphicsPanel1.Invalidate();
        }

        private void enterSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterSeed enterSeedDialog = new EnterSeed();

            if (DialogResult.OK == enterSeedDialog.ShowDialog())
            {
                Random seed = new Random(enterSeedDialog.Seed);
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        var randomizeCellState = seed.Next(0, 2);
                        if (randomizeCellState == 0)
                        {
                            universe[x, y] = true;
                        }
                        else
                        {
                            universe[x, y] = false;
                        }
                    }
                }
            }
            graphicsPanel1.Invalidate();
        }

        private void randomSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int randomSeed = GenerateRandomSeed();
            Random cellState = new Random(randomSeed);
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    var randomizeCellState = cellState.Next(0, 2);
                    if (randomizeCellState == 0)
                    {
                        universe[x, y] = true;
                    }
                    else
                    {
                        universe[x, y] = false;
                    }
                }
            }
            graphicsPanel1.Invalidate();
        }

        private void fromTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random cellState = new Random();
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    var randomizeCellState = cellState.Next(0, 2);
                    if (randomizeCellState == 0)
                    {
                        universe[x, y] = true;
                    }
                    else
                    {
                        universe[x, y] = false;
                    }
                }
            }
            graphicsPanel1.Invalidate();
        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save cells file";
            save.Filter = "All Files|*.*|Cells|*.cells";
            save.FilterIndex = 2;
            save.DefaultExt = "cells";

            if (DialogResult.OK == save.ShowDialog())
            {
                StreamWriter cellWriter = new StreamWriter(save.FileName);
                cellWriter.Write("!Conway's Game of Life cell file - By Teresa Ortiz");
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    string row = string.Empty;
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        if (universe[x, y] == true)
                        {
                            row = "O";
                        }
                        else
                        {
                            row = ".";
                        }
                        cellWriter.Write(row);
                        cellWriter.WriteLine();
                    }
                }
                cellWriter.Close();
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files|*.*|Cells|*.cells";
            open.FilterIndex = 2;

            if (DialogResult.OK == open.ShowDialog())
            {
                StreamReader reader = new StreamReader(open.FileName);

                int maxWidth = 0;
                int maxHeight = 0;
                int yPos = 0;
                //int rowCount = 0;


                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();
                    if (row[0] == '!')
                    {
                        continue;
                    }
                    // If the row is not a comment then it is a row of cells.
                    // Increment the maxHeight variable for each row read.
                    if (row[0] != '!')
                    {
                        maxHeight++;
                    }
                    maxWidth = row.Length;
                }
             
                NewUniverse(maxWidth, maxHeight);
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();

                    if (row[0] == '!')
                    {
                        continue;
                    }

                    for (int xPos = 0; xPos < row.Length; xPos++)
                    {
                        if (row[xPos] == 'O')
                        {
                            universe[xPos, yPos] = true;
                        }

                        else if (row[xPos] == '.')
                        {
                            universe[xPos, yPos] = false;
                        }
                        
                    }
                    yPos++;
                }
                reader.Close();
                graphicsPanel1.Invalidate();
            }
            
        }

        private void ShowHUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ShowHUDToolStripMenuItem.Checked)
            {
                DisplayHUD = false;
            }
            else
            {
                DisplayHUD = true;
            }
            graphicsPanel1.Invalidate();
        }

        private void editUniverseSizeTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeSizeOptions timeSizeOptions = new TimeSizeOptions();
            if (DialogResult.OK != timeSizeOptions.ShowDialog())
            {
                return;
            }

            int milliseconds = timeSizeOptions.Milliseconds;
            int universeWidth = timeSizeOptions.UniverseWidth;
            int universeHeight = timeSizeOptions.UniverseHeight;
            timer.Interval = milliseconds;

            Settings.Default.UniverseWidth = universeWidth;
            Settings.Default.UniverseHeight = universeHeight;
            Settings.Default.Milliseconds = milliseconds;

            NewUniverse(universeWidth, universeHeight);
            graphicsPanel1.Invalidate();
        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            DefaultSettings();
        }

        private void reloadSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            DefaultSettings();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void showGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicsPanel1.Invalidate();
        }

        private void editBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog background = new ColorDialog();
            background.Color = graphicsPanel1.BackColor;
            if (DialogResult.OK == background.ShowDialog())
            {
                graphicsPanel1.BackColor = background.Color;

                Settings.Default.BackgroundColor = background.Color;
                graphicsPanel1.Invalidate();
            }
        }

        private void editCellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cell = new ColorDialog();
            cell.Color = this.cellColor;
            if (DialogResult.OK == cell.ShowDialog())
            {
                cellColor = cell.Color;
                Settings.Default.CellColor = cell.Color;
                graphicsPanel1.Invalidate();
            }
        }

        private void editGridColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog grid = new ColorDialog();
            grid.Color = gridColor;
            if (DialogResult.OK == grid.ShowDialog())
            {
                gridColor = grid.Color;
                Settings.Default.GridColor = grid.Color;
                graphicsPanel1.Invalidate();
            }
        }
    }
}
