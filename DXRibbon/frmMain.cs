using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using DevExpress.XtraTabbedMdi;
using DXRibbon.Controls;
using DXRibbon.Helpers;
using DXRibbon.Views;
using System;
using System.Windows.Forms;

namespace DXRibbon
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeNavBar();
        }

        private void tabControl_PageChanged(object sender, EventArgs e)
        {
            XtraMdiTabPage selectedPage = xtraTabbedMdiManager.SelectedPage;
            if (selectedPage != null)
            {
                Form activeForm = selectedPage.MdiChild;
                if (activeForm != null)
                {
                    switch (activeForm.Name)
                    {
                        case string formName when formName == FormListTypes.InvoiceListForm:
                            {
                                ChangeEnableOptions_RibbonInvoiceActionsGroup(true);
                                ChangeVisibility_Filter(true);

                                ChangeEnableOptions_SelectionGroup(false);
                                break;
                            }
                        case string formName when formName == FormListTypes.ClientListForm:
                            {
                                ChangeEnableOptions_RibbonInvoiceActionsGroup(false);
                                ChangeVisibility_Filter(false);

                                ChangeEnableOptions_SelectionGroup(true);
                                break;
                            }
                        case string formName when formName == FormListTypes.PartnerListForm:
                            {
                                ChangeEnableOptions_RibbonInvoiceActionsGroup(false);
                                ChangeVisibility_Filter(false);

                                ChangeEnableOptions_SelectionGroup(true);
                                break;
                            }
                        case string formName when formName == FormListTypes.ShipperListForm:
                            {
                                ChangeEnableOptions_RibbonInvoiceActionsGroup(false);
                                ChangeVisibility_Filter(false);

                                ChangeEnableOptions_SelectionGroup(true);
                                break;
                            }
                        case string formName when formName == FormListTypes.UsersListForm:
                            {
                                ChangeEnableOptions_RibbonInvoiceActionsGroup(false);
                                ChangeVisibility_Filter(false);

                                ChangeEnableOptions_SelectionGroup(true);
                                break;
                            }
                        case string formName when formName == FormListTypes.CommandListForm:
                            {
                                ChangeEnableOptions_RibbonInvoiceActionsGroup(false);
                                ChangeVisibility_Filter(true);

                                ChangeEnableOptions_SelectionGroup(true);
                                break;
                            }
                        default: break;
                    }
                }
            }
            else
            {
                ChangeEnableOption_AddRow(false);
                ChangeEnableOption_RefreshCommand(false);
                ChangeEnableOption_DeleteRow(false);
                ChangeEnableOption_EditRow(false);
                ChangeEnableOption_bbReset(false);
                ChangeEnableOption_bbExportXLSX(false);
            }
        }

        private void InitializeNavBar()
        {
            NavBarControl navBar = new NavBarControl();
            this.Controls.Add(navBar);

            navBar.Parent = panelControl1;

            navBar.Dock = DockStyle.Fill;
            navBar.PaintStyleKind = NavBarViewKind.NavigationPane;

            NavBarGroup groupShipper = new NavBarGroup("Rutier");
            groupShipper.LargeImage = Properties.Resources.folder_documents_icon32;
            NavBarItem itemCommandList = new NavBarItem("Listă comenzi");
            itemCommandList.LargeImage = Properties.Resources.checklist_32x32;
            itemCommandList.LinkClicked += ShowCommandsPage;

            NavBarGroup groupPartners = new NavBarGroup("Parteneri");
            groupPartners.LargeImage = Properties.Resources.partners_32x32;
            NavBarItem itemClientsList = new NavBarItem("Listă clienți");
            itemClientsList.LargeImage = Properties.Resources.Office_Customer_Male_32x32;
            itemClientsList.LinkClicked += ShowClientsPage;
            NavBarItem itemShippersList = new NavBarItem("Listă transportatori");
            itemShippersList.LargeImage = Properties.Resources.TruckYellow_32x32;
            itemShippersList.LinkClicked += ShowShippersPage;
            NavBarItem itemPartnersList = new NavBarItem("Listă parteneri");
            itemPartnersList.LargeImage = Properties.Resources.checklist_32x32;
            itemPartnersList.LinkClicked += ShowPartnersPage;

            NavBarGroup groupDocuments = new NavBarGroup("Documente");
            groupDocuments.LargeImage = Properties.Resources.Documents_folder_32x32;
            NavBarItem itemInvoicesList = new NavBarItem("Facturi");
            itemInvoicesList.LargeImage = Properties.Resources.folder_documents_icon32;
            itemInvoicesList.LinkClicked += ShowInvoicesPage;

            NavBarGroup groupMasterdata = new NavBarGroup("Masterdata");
            groupMasterdata.LargeImage = Properties.Resources.MasterData_32x32;
            NavBarItem itemUsersList = new NavBarItem("Utilizatori");
            itemUsersList.LargeImage = Properties.Resources.User_Files_32x32;
            itemUsersList.LinkClicked += ShowUsersPage;

            navBar.BeginUpdate();

            navBar.Groups.Add(groupShipper);
            groupShipper.ItemLinks.Add(itemCommandList);
            groupShipper.GroupStyle = NavBarGroupStyle.LargeIconsText;

            navBar.Groups.Add(groupPartners);
            groupPartners.ItemLinks.Add(itemClientsList);
            groupPartners.ItemLinks.Add(itemShippersList);
            groupPartners.ItemLinks.Add(itemPartnersList);
            groupPartners.GroupStyle = NavBarGroupStyle.LargeIconsText;

            navBar.Groups.Add(groupDocuments);
            groupDocuments.ItemLinks.Add(itemInvoicesList);
            groupDocuments.GroupStyle = NavBarGroupStyle.LargeIconsText;

            navBar.Groups.Add(groupMasterdata);
            groupMasterdata.ItemLinks.Add(itemUsersList);
            groupMasterdata.GroupStyle = NavBarGroupStyle.LargeIconsText;

            navBar.ActiveGroup = groupShipper;
            navBar.LinkSelectionMode = LinkSelectionModeType.OneInGroupAndAllowAutoSelect;
            navBar.EndUpdate();
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

        private void ShowClientsPage(object sender, EventArgs e)
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
        }

        private void ShowShippersPage(object sender, EventArgs e)
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
        private void ShowPartnersPage(object sender, EventArgs e)
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

        private void ShowInvoicesPage(object sender, EventArgs e)
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

        private void ShowCommandsPage(object sender, EventArgs e)
        {
            Form form = FormActivation(typeof(CommandForm));
            if (form == null)
            {
                CommandForm f = new CommandForm();
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

        public void ChangeVisibility_Filter(bool visibility)
        {
            ribbonPageFilterGroup.Visible = visibility;
            ribbonPageFilterGroup.Enabled = visibility;
        }

        public void ChangeEnableOptions_SelectionGroup(bool visibility)
        {
            ribbonPageSelectionGroup.Visible = visibility;
            ribbonPageSelectionGroup.Enabled = visibility;
        }

        public void ChangeEnableOption_LoginAsUser(bool enable)
        {
            bbLoginAsUser.Enabled = enable;
        }

        public void ChangeEnableOption_AddRow(bool enable)
        {
            bbAddRow.Enabled = enable;
        }

        public void ChangeEnableOption_DeleteRow(bool enable)
        {
            bbDeleteRow.Enabled = enable;
        }

        public void ChangeEnableOption_EditRow(bool enable)
        {
            bbEditRow.Enabled = enable;
        }

        public void ChangeEnableOption_RefreshCommand(bool enable)
        {
            bbRefresh.Enabled = enable;
        }

        public void ChangeEnableOptions_RibbonInvoiceActionsGroup(bool enable)
        {
            ribbonInvoiceActionGroup.Visible = enable;
            ribbonInvoiceActionGroup.Enabled = enable;
        }
        
        public void ChangeEnableOptions_RibbonInvoiceActionGroup(bool enable)
        {
            ribbonInvoiceActionGroup.Visible = enable;
            ribbonInvoiceActionGroup.Enabled = enable;
        }

        private void bbClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        
        private void bbEditRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeForm = xtraTabbedMdiManager.SelectedPage.MdiChild;
            if (activeForm != null)
            {
                switch (activeForm.Name)
                {
                    case string formName when formName == FormListTypes.InvoiceListForm:
                        {
                            ((InvoiceListForm)activeForm).InvoicesGrid.GridView.ShowEditForm();
                            break;
                        }
                    case string formName when formName == FormListTypes.ClientListForm:
                        {
                            ((ClientListForm)activeForm).ClientGrid.GridView.ShowEditForm();
                            break;
                        }
                    case string formName when formName == FormListTypes.PartnerListForm:
                        {
                            ((PartnerListForm)activeForm).PartnersGrid.GridView.ShowEditForm();
                            break;
                        }
                    case string formName when formName == FormListTypes.ShipperListForm:
                        {
                            ((ShipperListForm)activeForm).ShippersGrid.GridView.ShowEditForm();
                            break;
                        }
                    case string formName when formName == FormListTypes.UsersListForm:
                        {
                            ((UsersForm)activeForm).UsersGrid.GridView.ShowEditForm();
                            break;
                        }
                    case string formName when formName == FormListTypes.CommandListForm:
                        {
                            ((CommandForm)activeForm).CommandsGrid.GridView.ShowEditForm();
                            break;
                        }
                    default: break;
                }
            }
        }

        private void bbAddRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeForm = xtraTabbedMdiManager.SelectedPage.MdiChild;
            if (activeForm != null)
            {
                switch (activeForm.Name)
                {
                    case string formName when formName == FormListTypes.InvoiceListForm:
                        {
                            ((InvoiceListForm)activeForm).InvoicesGrid.GridView.ShowEditor();
                            break;
                        }
                    case string formName when formName == FormListTypes.ClientListForm:
                        {
                            ((ClientListForm)activeForm).ClientGrid.GridView.ShowEditor();
                            break;
                        }
                    case string formName when formName == FormListTypes.PartnerListForm:
                        {
                            ((PartnerListForm)activeForm).PartnersGrid.GridView.ShowEditor();
                            break;
                        }
                    case string formName when formName == FormListTypes.ShipperListForm:
                        {
                            ((ShipperListForm)activeForm).ShippersGrid.GridView.ShowEditor();
                            break;
                        }
                    case string formName when formName == FormListTypes.UsersListForm:
                        {
                            ((UsersForm)activeForm).UsersGrid.GridView.ShowEditor();
                            break;
                        }
                    case string formName when formName == FormListTypes.CommandListForm:
                        {
                            ((CommandForm)activeForm).CommandsGrid.GridView.ShowEditor();
                            break;
                        }
                    default: break;
                }
            }
        }

        private void bbDeleteRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeForm = xtraTabbedMdiManager.SelectedPage.MdiChild;
            if (activeForm != null)
            {
                GridView gridView = new GridView();
                switch (activeForm.Name)
                {
                    case string formName when formName == FormListTypes.InvoiceListForm:
                        {
                            gridView = ((InvoiceListForm)activeForm).InvoicesGrid.GridView;
                            break;
                        }
                    case string formName when formName == FormListTypes.ClientListForm:
                        {
                            gridView = ((ClientListForm)activeForm).ClientGrid.GridView;
                            break;
                        }
                    case string formName when formName == FormListTypes.PartnerListForm:
                        {
                            gridView = ((PartnerListForm)activeForm).PartnersGrid.GridView;
                            break;
                        }
                    case string formName when formName == FormListTypes.ShipperListForm:
                        {
                            gridView = ((ShipperListForm)activeForm).ShippersGrid.GridView;
                            break;
                        }
                    case string formName when formName == FormListTypes.UsersListForm:
                        {
                            gridView = ((UsersForm)activeForm).UsersGrid.GridView;
                            break;
                        }
                    case string formName when formName == FormListTypes.CommandListForm:
                        {
                            gridView =  ((CommandForm)activeForm).CommandsGrid.GridView;
                            break;
                        }
                    default: break;
                }
                gridView.DeleteRow(gridView.FocusedRowHandle);
            }
        }
    }
}
