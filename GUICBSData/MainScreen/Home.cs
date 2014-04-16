using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CBSData;

namespace GUICBSData.MainScreen
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void SynchronsizeButton_Click(object sender, EventArgs e)
        {
            Globals.SychronisserCataloges();
        }

        private void SelectTabelButton_Click(object sender, EventArgs e)
        {
            Globals.MainWindow.ShowSelectTabel();
        }
    }
}
