using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkReport1
{
    public partial class YMchanged : Form
    {
        public YMchanged()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
