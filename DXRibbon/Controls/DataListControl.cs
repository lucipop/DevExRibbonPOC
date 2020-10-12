using System;
using System.Windows.Forms;
using DXRibbon.Seed.Documents;
using DevExpress.XtraGrid.Views.Grid;
using DXRibbon.Seed;
using DXRibbon.Seed.Partners;
using DXRibbon.Seed.Masterdata;
using DXRibbon.Helpers;
using DXRibbon.Seed.Commands;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DXRibbon.Views
{
    public partial class DataListControl : UserControl
    {
        frmMain mainForm;
        IDataSeed dataSeed;
        public GridView GridView
        {
           get { return gridView1; } 
        }
        public DataListControl(IDataSeed dataSeed)
        {
            InitializeComponent();
            this.dataSeed = dataSeed;
            mainForm = (frmMain)Application.OpenForms[0];

            gridView1.OptionsBehavior.EditingMode = GridEditingMode.EditForm;
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
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
                case CommandSeed commandsSeed:
                    {
                        gcDataList.DataSource = CommandSeed.SeedList();
                        break;
                    }
                default: break;
            }

        }
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            var parentFormName = (sender as GridView).GridControl.FindForm().Name;
            
            //enable/disable ribbon action buttons
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
                case string formName when formName == FormListTypes.CommandListForm:
                    {
                        DisplayCommandsRibbonAction(sender);
                        break;
                    }
                default: break;
            }

            //enable  buttons
            mainForm.ChangeEnableOption_AddRow(true);
            mainForm.ChangeEnableOption_EditRow(true);
            mainForm.ChangeEnableOption_DeleteRow(true);
            mainForm.ChangeEnableOption_bbReset(true);
            mainForm.ChangeEnableOption_bbExportXLSX(true);
            mainForm.ChangeEnableOption_RefreshCommand(true);
        }

        private void DisplayInvoiceRibbonAction(object sender)
        {
            mainForm.ChangeVisibility_Filter(true);

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
            mainForm.ChangeEnableOptions_RibbonInvoiceActionsGroup(false);
            mainForm.ChangeVisibility_Filter(false);
        }

        private void DisplayPartnerRibbonAction(object sender)
        {
            mainForm.ChangeEnableOptions_RibbonInvoiceActionsGroup(false);
            mainForm.ChangeVisibility_Filter(false);
        }

        private void DisplayShipperRibbonAction(object sender)
        {
            mainForm.ChangeEnableOptions_RibbonInvoiceActionsGroup(false);
            mainForm.ChangeVisibility_Filter(false);
        }

        private void DisplayUsersRibbonAction(object sender)
        {
            mainForm.ChangeEnableOptions_RibbonInvoiceActionsGroup(false);
            mainForm.ChangeVisibility_Filter(true);
        }

        private void DisplayCommandsRibbonAction(object sender)
        {
            mainForm.ChangeEnableOptions_RibbonInvoiceActionsGroup(false);
            mainForm.ChangeVisibility_Filter(true);
        }
    }
}
