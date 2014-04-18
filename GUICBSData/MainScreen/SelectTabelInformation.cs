using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICBSData.MainScreen
{
    public partial class SelectTabelInformation : UserControl
    {

        public SelectTabelInformation(List<string> list)
        {
            InitializeComponent();

            this.CatogoriesList.Items.AddRange(list.ToArray());
        }

    }
}
