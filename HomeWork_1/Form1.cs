using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_1
{
    public partial class HomeWork_1 : Form
    {
        public HomeWork_1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
