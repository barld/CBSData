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
    public partial class SelectTabel : UserControl
    {
        public SelectTabel()
        {
            InitializeComponent();

            InitialLists();
        }

        private void InitialLists()
        {
            var AllTabels = Globals.LocalCatalog.Tables;

            this.TabelsList.Items.AddRange(AllTabels.ToArray());
        }
    }
}
