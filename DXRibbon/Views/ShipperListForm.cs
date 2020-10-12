using DevExpress.XtraGrid.Views.Grid;
using DXRibbon.Seed.Partners;
using System;
using System.Windows.Forms;

namespace DXRibbon.Views
{
    public partial class ShipperListForm : DevExpress.XtraEditors.XtraForm
    {
        frmMain parent = (frmMain)Application.OpenForms[0];
        public DataListControl ShippersGrid { get; private set; }
        public ShipperListForm()
        {
            InitializeComponent();
        }

        private void ShipperListForm_Load(object sender, EventArgs e)
        {
            ShippersGrid = new DataListControl(new ShipperSeed());
            this.Controls.Add(ShippersGrid);

            //parent.ChangeEnableOptions_RibbonInvoiceActionsGroup(false);

            //parent.ChangeEnableOption_bbCancelCommand(false);
            //parent.ChangeEnableOption_bbSaveCommand(false);
            //parent.ChangeEnableOption_bbCreateShipperCommand(false);

            //parent.ChangeVisibility_Filter(false);
        }
    }
}
