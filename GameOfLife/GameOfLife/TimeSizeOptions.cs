using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class TimeSizeOptions : Form
    {
        public TimeSizeOptions()
        {
            InitializeComponent();
        }

        public int Milliseconds { get; set; }
        public int UniverseWidth { get; set; }
        public int UniverseHeight { get; set; }
    }
}
