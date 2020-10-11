using DevExpress.XtraGrid.Views.Grid;
using DXRibbon.Seed.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXRibbon.Controls
{
    public partial class InvoiceListForm : DevExpress.XtraEditors.XtraForm
    {
        frmMain parent = (frmMain)Application.OpenForms[0];
        public InvoiceListForm()
        {
            InitializeComponent();
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {
            gCInvoiceList.DataSource = InvoiceSeed.SeedList();

            parent.ChangeVisibility_ActionListRibbonGroup(true);

            parent.ChangeEnableOption_bbCancelCommand(false);
            parent.ChangeEnableOption_bbSaveCommand(false);
            parent.ChangeEnableOption_bbCreateShipperCommand(false);

            parent.ChangeEnableOption_Filter(true);

            parent.ChangeEnableOption_LoginAsUser(false);
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            Invoice selectedRowInvoice = (sender as GridView).GetFocusedRow() as Invoice;
            switch (selectedRowInvoice)
            {
                case Invoice invoice when invoice.InvoiceStatus == InvoiceSeed.Emitted:
                    {
                        parent.ChangeEnableOption_bbMarkAsSentInvoice(true);
                        parent.ChangeEnableOption_bbPayInvoice(true);
                        parent.ChangeEnableOption_bbStornoInvoice(true);
                        parent.ChangeEnableOption_bbCancelInvoice(true);
                        parent.ChangeEnableOption_bbEditDataInvoice(true);

                        parent.ChangeEnableOption_bbOpenClientInvoice(false);
                        parent.ChangeEnableOption_bbAnnounceInvoice(false);
                        break;
                    }
                case Invoice invoice when invoice.InvoiceStatus == InvoiceSeed.Cancelled:
                    {
                        parent.ChangeEnableOption_bbEditDataInvoice(true);
                        parent.ChangeEnableOption_bbMarkAsSentInvoice(true);

                        parent.ChangeEnableOption_bbOpenClientInvoice(false);
                        parent.ChangeEnableOption_bbAnnounceInvoice(false);
                        parent.ChangeEnableOption_bbPayInvoice(false);
                        parent.ChangeEnableOption_bbStornoInvoice(false);
                        parent.ChangeEnableOption_bbCancelInvoice(false);
                        break;
                    }
                case Invoice invoice when invoice.InvoiceStatus == InvoiceSeed.Invoiced:
                    {
                        parent.ChangeEnableOption_bbEditDataInvoice(true);

                        parent.ChangeEnableOption_bbOpenClientInvoice(false);
                        parent.ChangeEnableOption_bbAnnounceInvoice(false);
                        parent.ChangeEnableOption_bbMarkAsSentInvoice(false);
                        parent.ChangeEnableOption_bbPayInvoice(false);
                        parent.ChangeEnableOption_bbStornoInvoice(false);
                        parent.ChangeEnableOption_bbCancelInvoice(false);
                        break;
                    }
                case Invoice invoice when invoice.InvoiceStatus == InvoiceSeed.Overdue:
                    {
                        parent.ChangeEnableOption_bbEditDataInvoice(true);
                        parent.ChangeEnableOption_bbAnnounceInvoice(true);
                        parent.ChangeEnableOption_bbPayInvoice(true);

                        parent.ChangeEnableOption_bbOpenClientInvoice(false);
                        parent.ChangeEnableOption_bbMarkAsSentInvoice(false);
                        parent.ChangeEnableOption_bbStornoInvoice(false);
                        parent.ChangeEnableOption_bbCancelInvoice(false);
                        break;
                    }
                case Invoice invoice when invoice.InvoiceStatus == InvoiceSeed.Sent:
                    {
                      
                        parent.ChangeEnableOption_bbPayInvoice(true);
                        parent.ChangeEnableOption_bbStornoInvoice(true);
                        parent.ChangeEnableOption_bbCancelInvoice(true);
                        parent.ChangeEnableOption_bbEditDataInvoice(true);

                        parent.ChangeEnableOption_bbOpenClientInvoice(false);
                        parent.ChangeEnableOption_bbAnnounceInvoice(false);
                        parent.ChangeEnableOption_bbMarkAsSentInvoice(false);
                        break;
                    }
            }
        }
    }
}
