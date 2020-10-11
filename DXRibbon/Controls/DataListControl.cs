using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXRibbon.Seed.Documents;
using DevExpress.XtraGrid.Views.Grid;
using DXRibbon.Seed;
using DXRibbon.Seed.Partners;

namespace DXRibbon.Views
{
    public partial class DataListControl : UserControl
    {
        frmMain parent;
        IDataSeed dataSeed;
        public DataListControl(IDataSeed dataSeed)
        {
            InitializeComponent();
            this.dataSeed = dataSeed;
            parent = (frmMain)this.ParentForm;
        }

        private void DataListControl_Load(object sender, EventArgs e)
        {
            switch(dataSeed)
            {
                case InvoiceSeed invoicesSeed:
                    {
                        gcDataList.DataSource = InvoiceSeed.SeedList();
                        break;
                    }
                case ClientSeed clientsSeed:
                    {
                        gcDataList.DataSource = ClientSeed.SeedList();
                        break;
                    }
                case ShipperSeed shippersSeed:
                    {
                        gcDataList.DataSource = ShipperSeed.SeedList();
                        break;
                    }
                case PartnerSeed partnersSeed:
                    {
                        gcDataList.DataSource = PartnerSeed.SeedList();
                        break;
                    }
                default: break;
            }
        }
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            Invoice selectedRowInvoice = (sender as GridView).GetFocusedRow() as Invoice;
            switch (selectedRowInvoice)
            {
                case Invoice invoice when invoice.InvoiceStatus == InvoiceSeed.Emitted:
                    {
                        parent.ChangeEnableOption_bbOpenClientInvoice(true);
                        break;
                    }
            }
        }
    }
}
