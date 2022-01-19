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
    public partial class EnterSeed : Form
    {
        public EnterSeed()
        {
            InitializeComponent();
        }

        // numeric seed value that will be used to randomize
        public int Seed { get; set; }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Seed = int.Parse(enterSeedValue.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
