
namespace GameOfLife
{
    partial class TimeSizeOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerationTimeInterval = new System.Windows.Forms.NumericUpDown();
            this.Confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.UWidth = new System.Windows.Forms.NumericUpDown();
            this.UHeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationTimeInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerationTimeInterval
            // 
            this.GenerationTimeInterval.Location = new System.Drawing.Point(237, 54);
            this.GenerationTimeInterval.Name = "GenerationTimeInterval";
            this.GenerationTimeInterval.Size = new System.Drawing.Size(102, 22);
            this.GenerationTimeInterval.TabIndex = 0;
            this.GenerationTimeInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(34, 268);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(128, 42);
            this.Confirm.TabIndex = 3;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Milliseconds between generations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Universe Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Universe Height";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(190, 268);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 42);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // UWidth
            // 
            this.UWidth.Location = new System.Drawing.Point(129, 131);
            this.UWidth.Name = "UWidth";
            this.UWidth.Size = new System.Drawing.Size(102, 22);
            this.UWidth.TabIndex = 8;
            this.UWidth.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // UHeight
            // 
            this.UHeight.Location = new System.Drawing.Point(129, 204);
            this.UHeight.Name = "UHeight";
            this.UHeight.Size = new System.Drawing.Size(102, 22);
            this.UHeight.TabIndex = 9;
            this.UHeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // TimeSizeOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 322);
            this.Controls.Add(this.UHeight);
            this.Controls.Add(this.UWidth);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.GenerationTimeInterval);
            this.Name = "TimeSizeOptions";
            this.Text = "Universe Time/Size";
            ((System.ComponentModel.ISupportInitialize)(this.GenerationTimeInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown GenerationTimeInterval;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown UWidth;
        private System.Windows.Forms.NumericUpDown UHeight;
    }
}