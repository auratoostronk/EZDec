using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorForm
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string text)
        {
            InitializeComponent();
            this.LabelError.Text = text;
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
