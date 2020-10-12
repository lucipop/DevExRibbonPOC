using DevExpress.XtraGrid.Views.Grid;
using DXRibbon.Seed.Documents;
using DXRibbon.Seed.Partners;
using System;
using System.Windows.Forms;

namespace DXRibbon.Views
{
    public partial class PartnerListForm : DevExpress.XtraEditors.XtraForm
    {
        frmMain parent = (frmMain)Application.OpenForms[0];
        public DataListControl PartnersGrid { get; private set; }
        public PartnerListForm()
        {
            InitializeComponent();
        }

        private void PartnerListForm_Load(object sender, EventArgs e)
        {
            PartnersGrid = new DataListControl(new PartnerSeed());
            this.Controls.Add(PartnersGrid);

            //parent.ChangeEnableOption_bbOpenClientInvoice(false);
            //parent.ChangeEnableOption_bbAnnounceInvoice(false);

            //parent.ChangeEnableOption_bbCancelCommand(false);
            //parent.ChangeEnableOption_bbSaveCommand(false);
            //parent.ChangeEnableOption_bbCreateShipperCommand(false);

            //parent.ChangeVisibility_Filter(false);
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
           
        }
    }
}
