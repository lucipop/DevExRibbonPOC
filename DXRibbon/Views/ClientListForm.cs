using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DXRibbon.Seed.Partners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXRibbon.Views
{
    public partial class ClientListForm : DevExpress.XtraEditors.XtraForm
    {
        frmMain parent = (frmMain)Application.OpenForms[0];
        public DataListControl ClientGrid { get; private set; }

        public ClientListForm()
        {
            InitializeComponent();
        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {
            ClientGrid = new DataListControl(new ClientSeed());
            this.Controls.Add(ClientGrid);


            parent.ChangeEnableOptions_RibbonInvoiceActionsGroup(false);

            parent.ChangeEnableOption_bbCancelCommand(false);
            parent.ChangeEnableOption_bbSaveCommand(false);
            parent.ChangeEnableOption_bbCreateShipperCommand(false);

            parent.ChangeVisibility_Filter(false);
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
          
        }
    }
}
