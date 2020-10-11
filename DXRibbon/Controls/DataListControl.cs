using System;
using System.Windows.Forms;
using DXRibbon.Seed.Documents;
using DevExpress.XtraGrid.Views.Grid;
using DXRibbon.Seed;
using DXRibbon.Seed.Partners;
using DXRibbon.Seed.Masterdata;
using DXRibbon.Helpers;

namespace DXRibbon.Views
{
    public partial class DataListControl : UserControl
    {
        frmMain mainForm;
        IDataSeed dataSeed;
        public DataListControl(IDataSeed dataSeed)
        {
            InitializeComponent();
            this.dataSeed = dataSeed;
            mainForm = (frmMain)Application.OpenForms[0];

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
                case UsersSeed usersSeed:
                    {
                        gcDataList.DataSource = UsersSeed.SeedList();
                        break;
                    }
                default: break;
            }

        }
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            var parentFormName = (sender as GridView).GridControl.FindForm().Name;
            
            switch (parentFormName)
            {
                case string formName when formName == FormListTypes.InvoiceListForm:
                    {
                        DisplayInvoiceRibbonAction(sender);
                        break;
                    }
                case string formName when formName == FormListTypes.ClientListForm:
                    {
                        DisplayClientRibbonAction(sender);
                        break;
                    }
                case string formName when formName == FormListTypes.PartnerListForm:
                    {
                        DisplayPartnerRibbonAction(sender);
                        break;
                    }
                case string formName when formName == FormListTypes.ShipperListForm:
                    {
                        DisplayShipperRibbonAction(sender);
                        break;
                    }
                case string formName when formName == FormListTypes.UsersListForm:
                    {
                        DisplayUsersRibbonAction(sender);
                        break;
                    }
                default: break;
            }
        }

        private void DisplayInvoiceRibbonAction(object sender)
        {
            Invoice selectedRowInvoice = (sender as GridView).GetFocusedRow() as Invoice;
            switch (selectedRowInvoice)
            {
                case Invoice invoice when invoice.InvoiceStatus == InvoiceSeed.Emitted:
                    {
                        mainForm.ChangeEnableOption_bbMarkAsSentInvoice(true);
                        mainForm.ChangeEnableOption_bbPayInvoice(true);
                        mainForm.ChangeEnableOption_bbStornoInvoice(true);
                        mainForm.ChangeEnableOption_bbCancelInvoice(true);
                        mainForm.ChangeEnableOption_bbEditDataInvoice(true);

                        mainForm.ChangeEnableOption_bbOpenClientInvoice(false);
                        mainForm.ChangeEnableOption_bbAnnounceInvoice(false);
                        break;
                    }
                case Invoice invoice when invoice.InvoiceStatus == InvoiceSeed.Cancelled:
                    {
                        mainForm.ChangeEnableOption_bbEditDataInvoice(true);
                        mainForm.ChangeEnableOption_bbMarkAsSentInvoice(true);

                        mainForm.ChangeEnableOption_bbOpenClientInvoice(false);
                        mainForm.ChangeEnableOption_bbAnnounceInvoice(false);
                        mainForm.ChangeEnableOption_bbPayInvoice(false);
                        mainForm.ChangeEnableOption_bbStornoInvoice(false);
                        mainForm.ChangeEnableOption_bbCancelInvoice(false);
                        break;
                    }
                case Invoice invoice when invoice.InvoiceStatus == InvoiceSeed.Invoiced:
                    {
                        mainForm.ChangeEnableOption_bbEditDataInvoice(true);

                        mainForm.ChangeEnableOption_bbOpenClientInvoice(false);
                        mainForm.ChangeEnableOption_bbAnnounceInvoice(false);
                        mainForm.ChangeEnableOption_bbMarkAsSentInvoice(false);
                        mainForm.ChangeEnableOption_bbPayInvoice(false);
                        mainForm.ChangeEnableOption_bbStornoInvoice(false);
                        mainForm.ChangeEnableOption_bbCancelInvoice(false);
                        break;
                    }
                case Invoice invoice when invoice.InvoiceStatus == InvoiceSeed.Overdue:
                    {
                        mainForm.ChangeEnableOption_bbEditDataInvoice(true);
                        mainForm.ChangeEnableOption_bbAnnounceInvoice(true);
                        mainForm.ChangeEnableOption_bbPayInvoice(true);

                        mainForm.ChangeEnableOption_bbOpenClientInvoice(false);
                        mainForm.ChangeEnableOption_bbMarkAsSentInvoice(false);
                        mainForm.ChangeEnableOption_bbStornoInvoice(false);
                        mainForm.ChangeEnableOption_bbCancelInvoice(false);
                        break;
                    }
                case Invoice invoice when invoice.InvoiceStatus == InvoiceSeed.Sent:
                    {

                        mainForm.ChangeEnableOption_bbPayInvoice(true);
                        mainForm.ChangeEnableOption_bbStornoInvoice(true);
                        mainForm.ChangeEnableOption_bbCancelInvoice(true);
                        mainForm.ChangeEnableOption_bbEditDataInvoice(true);

                        mainForm.ChangeEnableOption_bbOpenClientInvoice(false);
                        mainForm.ChangeEnableOption_bbAnnounceInvoice(false);
                        mainForm.ChangeEnableOption_bbMarkAsSentInvoice(false);
                        break;
                    }
            }
        }

        private void DisplayClientRibbonAction(object sender)
        {
            mainForm.ChangeVisibility_RibbonInvoiceActionsGroup(false);

            mainForm.ChangeEnableOption_bbMarkAsSentInvoice(false);
            mainForm.ChangeEnableOption_bbPayInvoice(false);
            mainForm.ChangeEnableOption_bbStornoInvoice(false);
            mainForm.ChangeEnableOption_bbCancelInvoice(false);
            mainForm.ChangeEnableOption_bbEditDataInvoice(false);
            mainForm.ChangeEnableOption_LoginAsUser(false);

            mainForm.ChangeEnableOption_bbOpenClientInvoice(false);
            mainForm.ChangeEnableOption_bbAnnounceInvoice(false);
        }

        private void DisplayPartnerRibbonAction(object sender)
        {
            mainForm.ChangeVisibility_RibbonInvoiceActionsGroup(false);

            mainForm.ChangeEnableOption_bbMarkAsSentInvoice(false);
            mainForm.ChangeEnableOption_bbPayInvoice(false);
            mainForm.ChangeEnableOption_bbStornoInvoice(false);
            mainForm.ChangeEnableOption_bbCancelInvoice(false);
            mainForm.ChangeEnableOption_bbEditDataInvoice(false);
            mainForm.ChangeEnableOption_LoginAsUser(false);

        }

        private void DisplayShipperRibbonAction(object sender)
        {

        }

        private void DisplayUsersRibbonAction(object sender)
        {

        }
    }
}
