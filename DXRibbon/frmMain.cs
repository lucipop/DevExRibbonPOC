using DevExpress.XtraLayout;
using DXRibbon.Controls;
using DXRibbon.Seed.Documents;
using DXRibbon.Seed.Partners;
using DXRibbon.Views;
using System;
using System.Windows.Forms;

namespace DXRibbon
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();

            RegisterNavBarActions();

            CustomizeIcons();
        }

        private void RegisterNavBarActions()
        {
            nbClientsModule.LinkClicked += ShowClientsList;
            nbShippersModule.LinkClicked += ShowShippersList;
            nbPartnerModule.LinkClicked += ShowPartnersList;
            nbInvoiceModule.LinkClicked += ShowInvoicesList;
            nbCommandListModule.LinkClicked += ShowNewCommandPage;
            nbUsersModule.LinkClicked += ShowUsersPage;
        }

        private void CustomizeIcons()
        {
            nbCommandListModule.ImageOptions.LargeImageSize.ExpandSize(100, nbCommandListModule.ImageOptions.LargeImageSize, true);
        }

        private Form FormActivation(Type formType)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.GetType() == formType)
                {
                    return f;
                }
            }
            return null;
        }

        private void ShowClientsList(object sender, EventArgs e)
        {
            Form form = FormActivation(typeof(ClientListForm));
            if (form == null)
            {
                ClientListForm f = new ClientListForm();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate();
            }
            //DataListControl clientsList = new DataListControl(new ClientSeed());
            //panelControlMain.Controls.Add(clientsList);
        }

        private void ShowShippersList(object sender, EventArgs e)
        {
            Form form = FormActivation(typeof(ShipperListForm));
            if (form == null)
            {
                ShipperListForm f = new ShipperListForm();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }
        private void ShowPartnersList(object sender, EventArgs e)
        {
            Form form = FormActivation(typeof(PartnerListForm));
            if (form == null)
            {
                PartnerListForm f = new PartnerListForm();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void ShowInvoicesList(object sender, EventArgs e)
        {
            Form form = FormActivation(typeof(InvoiceListForm));
            if (form == null)
            {
                InvoiceListForm f = new InvoiceListForm();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }
        //private void ShowInvoicesList(object sender, EventArgs e)
        //{
        //    DataListControl invoiceList = new DataListControl(new InvoiceSeed());
        //    panelControlMain.Controls.Add(invoiceList);
        //}

        private void ShowNewCommandPage(object sender, EventArgs e)
        {
            Form form = FormActivation(typeof(NewCommandForm));
            if (form == null)
            {
                NewCommandForm f = new NewCommandForm();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }
        private void ShowUsersPage(object sender, EventArgs e)
        {
            Form form = FormActivation(typeof(UsersForm));
            if (form == null)
            {
                UsersForm f = new UsersForm();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        public void ChangeEnableOption_bbOpenClientInvoice(bool enable)
        {
            bbOpenClientInvoice.Enabled = enable;
        }

        public void ChangeEnableOption_bbEditDataInvoice(bool enable)
        {
            bbEditInvoice.Enabled = enable;
        }

        public void ChangeEnableOption_bbMarkAsSentInvoice(bool enable)
        {
            bbMarkAsSentInvoice.Enabled = enable;
        }

        public void ChangeEnableOption_bbPayInvoice(bool enable)
        {
            bbPayInvoice.Enabled = enable;
        }

        public void ChangeEnableOption_bbStornoInvoice(bool enable)
        {
            bbStornoInvoice.Enabled = enable;
        }

        public void ChangeEnableOption_bbCancelInvoice(bool enable)
        {
            bbCancelInvoice.Enabled = enable;
        }

        public void ChangeEnableOption_bbAnnounceInvoice(bool enable)
        {
            bbAnnounceInvoice.Enabled = enable;
        }

        public void ChangeEnableOption_bbSaveCommand(bool enable)
        {
            bbSaveCommand.Enabled = enable;
        }
        public void ChangeEnableOption_bbCreateShipperCommand(bool enable)
        {
            bbCreateShipperCommand.Enabled = enable;
        }
        public void ChangeEnableOption_bbCancelCommand(bool enable)
        {
            bbCancelCommand.Enabled = enable;
        }
        public void ChangeEnableOption_bbExportXLSX(bool enable)
        {
            bbExportXLSX.Enabled = enable;
        }

        public void ChangeEnableOption_bbReset(bool enable)
        {
            bbReset.Enabled = enable;
        }

        public void ChangeEnableOption_Filter(bool enable)
        {
            beFilter.Enabled = enable;
        }

        public void ChangeEnableOption_LoginAsUser(bool enable)
        {
            bbLoginAsUser.Enabled = enable;
        }

        public void ChangeVisibility_ActionListRibbonGroup(bool visible)
        {
            ribbonSelectedLineActionGroup.Visible = visible;
        }

    }
}
