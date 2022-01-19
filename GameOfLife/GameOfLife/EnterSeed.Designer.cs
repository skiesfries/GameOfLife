
namespace GameOfLife
{
    partial class EnterSeed
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
            this.enterSeedValue = new System.Windows.Forms.NumericUpDown();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enterSeedValue)).BeginInit();
            this.SuspendLayout();
            // 
            // enterSeedValue
            // 
            this.enterSeedValue.Location = new System.Drawing.Point(66, 35);
            this.enterSeedValue.Name = "enterSeedValue";
            this.enterSeedValue.Size = new System.Drawing.Size(112, 20);
            this.enterSeedValue.TabIndex = 0;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(32, 77);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 32);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(137, 77);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 32);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EnterSeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 121);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.enterSeedValue);
            this.Name = "EnterSeed";
            this.Text = "Enter Seed";
            ((System.ComponentModel.ISupportInitialize)(this.enterSeedValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown enterSeedValue;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button Cancel;
    }
}