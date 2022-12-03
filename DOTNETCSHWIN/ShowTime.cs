using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTNETCSHWIN
{
    public partial class ShowTime : Form
    {
        public ShowTime()
        {
            InitializeComponent();
        }

        private void ShowTime_Load(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToLongTimeString();
            MessageBox.Show(time);
        }
    }
}
