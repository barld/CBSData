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
    public partial class SelectTableInformationWait : UserControl
    {

        public SelectTableInformationWait(LocalCatalogTable t)
        {
            InitializeComponent();

            this.backgroundWorker1.RunWorkerAsync(t);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var t = e.Argument as LocalCatalogTable;
            e.Result = t.TableManeger.GetDataProperties();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Globals.MainWindow.SetInfoScreen(e.Result as List<string>);
        }


    }
}
