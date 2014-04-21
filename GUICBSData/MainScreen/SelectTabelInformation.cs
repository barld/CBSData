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
    public partial class SelectTabelInformation : UserControl
    {
        private LocalCatalogTable _table;

        public SelectTabelInformation(DataCriteria data, LocalCatalogTable table )
        {
            InitializeComponent();


            this._table = table;
            this.CatogoriesList.Items.AddRange(data.Select
                .Where(x=>!string.IsNullOrEmpty(x))//belangerijk dit verwijdert lege items
                .ToArray()
                );

            //trackbar
            this.LimitTo.Text = data.Limit.ToString();
            this.trackBar1.Maximum = data.Limit;
            this.trackBar1.Minimum = 1;

            if (data.Limit > 500)
            {
                this.trackBar1.Value = 500;
                this.limit.Text = "500";
            }
            if(data.Limit>10000)
            {
                this.LimitTo.Text = "10000";
                this.trackBar1.Maximum = 10000;
            }

        }

        private void GetData_Click(object sender, EventArgs e)
        {

            var t = this._table;

            if(t!=null && !this.DataTransfer.IsBusy)
            {
                var AllData = new { T = t, limit = trackBar1.Value, select = this.CatogoriesList };
                this.DataTransfer.RunWorkerAsync(AllData);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.limit.Text = this.trackBar1.Value.ToString();
        }

        private void DataTransfer_DoWork(object sender, DoWorkEventArgs e)
        {
            MessageBox.Show("De data wordt opgehaald en naar Excel geschreven dit kan even duren afhankelijk van de hoeveelheid data");
            dynamic argument = e.Argument;

            TableManager maneger = argument.T.TableManeger as TableManager;
            //zorg eerst dat de data beschikbaar is.

            DataCriteria criteria = new DataCriteria();
            criteria.Limit = argument.limit;
            if (argument.select.CheckedItems.Count > 0)
            {
                List<string> select = new List<string>();
                foreach (string val in argument.select.CheckedItems)
                {
                    select.Add(val);
                }
                criteria.Select = select;
            }




            maneger.GetAllData(criteria);

            //start Excelapplicatie
            WorkbookCreator.Workbook wb = new WorkbookCreator.Workbook();
            var sheet = wb.GetSheet("getallen", maneger.TableData.HeaderData, maneger.TableData.RowData);
            var infoSheet = wb.GetSheet("info", new List<string> {"dscription" }, new List<List<object>> { new List<object> { maneger.GetInfo() } });

            wb.Vissable = true;
        }        
    }
}
