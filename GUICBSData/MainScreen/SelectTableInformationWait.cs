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
        private LocalCatalogTable _table;

        public SelectTableInformationWait(LocalCatalogTable t)
        {
            InitializeComponent();
            this._table = t;
            this.backgroundWorker1.RunWorkerAsync(t);

            this.DockChanged += SelectTableInformationWait_DockChanged;
            
        }

        void SelectTableInformationWait_DockChanged(object sender, EventArgs e)
        {
            pictureBox1.Left = (this.Width - pictureBox1.Width) / 2;             //VEEEEEEEEL BETER
            pictureBox1.Top = (this.Height - pictureBox1.Height) / 2;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var t = e.Argument as LocalCatalogTable;
            DataCriteria data = new DataCriteria();
            data.Select = t.TableManeger.GetDataProperties();
            data.Limit = t.TableManeger.CountRows();
            e.Result = data;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Globals.MainWindow.SetInfoScreen(e.Result as DataCriteria, this._table);
        }


    }
}
