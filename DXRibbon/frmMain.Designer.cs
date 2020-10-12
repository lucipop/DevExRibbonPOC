using DevExpress.XtraGrid;
using DXRibbon.Properties;

namespace DXRibbon
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.repositoryItemTimeSpanEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.imageResourceCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonMainOptions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageActionGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbAddRow = new DevExpress.XtraBars.BarButtonItem();
            this.bbEditRow = new DevExpress.XtraBars.BarButtonItem();
            this.bbDeleteRow = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonInvoiceActionGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbOpenClientInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.bbEditInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.bbMarkAsSentInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.bbPayInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.bbStornoInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.bbCancelInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.bbAnnounceInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.bbLoginAsUser = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonOtherActionsGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbOrderClient = new DevExpress.XtraBars.BarButtonItem();
            this.bbOrderShipper = new DevExpress.XtraBars.BarButtonItem();
            this.bbNewCommand = new DevExpress.XtraBars.BarButtonItem();
            this.bbDuplicateOrder = new DevExpress.XtraBars.BarButtonItem();
            this.bbSagaExport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageSelectionGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbExportXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.bbRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbReset = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageFilterGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.beFilter = new DevExpress.XtraBars.BarEditItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.bbClose = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.bbSavePrecommand = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.bbSaveCommand = new DevExpress.XtraBars.BarButtonItem();
            this.bbCreateShipperCommand = new DevExpress.XtraBars.BarButtonItem();
            this.bbCancelCommand = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.bbDeleteUser = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageResourceCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemTimeSpanEdit1
            // 
            this.repositoryItemTimeSpanEdit1.AutoHeight = false;
            this.repositoryItemTimeSpanEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeSpanEdit1.Name = "repositoryItemTimeSpanEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager.MdiParent = this;
            this.xtraTabbedMdiManager.SelectedPageChanged += new System.EventHandler(this.tabControl_PageChanged);
            // 
            // imageResourceCollection
            // 
            this.imageResourceCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imageResourceCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageResourceCollection.ImageStream")));
            this.imageResourceCollection.InsertGalleryImage("settings_32x32.png", "images/edit/customization_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/customization_32x32.png"), 0);
            this.imageResourceCollection.Images.SetKeyName(0, "settings_32x32.png");
            this.imageResourceCollection.InsertGalleryImage("export_32x32.png", "images/export/export_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/export_32x32.png"), 1);
            this.imageResourceCollection.Images.SetKeyName(1, "export_32x32.png");
            this.imageResourceCollection.InsertGalleryImage("find_32x32.png", "images/find/find_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/find/find_32x32.png"), 2);
            this.imageResourceCollection.Images.SetKeyName(2, "find_32x32.png");
            // 
            // ribbonMainOptions
            // 
            this.ribbonMainOptions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageActionGroup,
            this.ribbonPageSelectionGroup,
            this.ribbonInvoiceActionGroup,
            this.ribbonOtherActionsGroup,
            this.ribbonPageFilterGroup});
            this.ribbonMainOptions.Name = "ribbonMainOptions";
            this.ribbonMainOptions.Text = "View";
            // 
            // ribbonPageActionGroup
            // 
            this.ribbonPageActionGroup.ItemLinks.Add(this.bbAddRow);
            this.ribbonPageActionGroup.ItemLinks.Add(this.bbEditRow);
            this.ribbonPageActionGroup.ItemLinks.Add(this.bbDeleteRow);
            this.ribbonPageActionGroup.Name = "ribbonPageActionGroup";
            this.ribbonPageActionGroup.Text = "Action Options";
            // 
            // bbAddRow
            // 
            this.bbAddRow.Caption = "Add";
            this.bbAddRow.Enabled = false;
            this.bbAddRow.Id = 2;
            this.bbAddRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbAddRow.ImageOptions.Image")));
            this.bbAddRow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbAddRow.ImageOptions.LargeImage")));
            this.bbAddRow.Name = "bbAddRow";
            this.bbAddRow.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbAddRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbAddRow_ItemClick);
            // 
            // bbEditRow
            // 
            this.bbEditRow.Caption = "Edit";
            this.bbEditRow.Enabled = false;
            this.bbEditRow.Id = 3;
            this.bbEditRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbEditRow.ImageOptions.Image")));
            this.bbEditRow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbEditRow.ImageOptions.LargeImage")));
            this.bbEditRow.Name = "bbEditRow";
            this.bbEditRow.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbEditRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbEditRow_ItemClick);
            // 
            // bbDeleteRow
            // 
            this.bbDeleteRow.Caption = "Delete";
            this.bbDeleteRow.Enabled = false;
            this.bbDeleteRow.Id = 4;
            this.bbDeleteRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbDeleteRow.ImageOptions.Image")));
            this.bbDeleteRow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbDeleteRow.ImageOptions.LargeImage")));
            this.bbDeleteRow.Name = "bbDeleteRow";
            this.bbDeleteRow.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbDeleteRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbDeleteRow_ItemClick);
            // 
            // ribbonInvoiceActionGroup
            // 
            this.ribbonInvoiceActionGroup.ItemLinks.Add(this.bbOpenClientInvoice);
            this.ribbonInvoiceActionGroup.ItemLinks.Add(this.bbEditInvoice);
            this.ribbonInvoiceActionGroup.ItemLinks.Add(this.bbMarkAsSentInvoice);
            this.ribbonInvoiceActionGroup.ItemLinks.Add(this.bbPayInvoice);
            this.ribbonInvoiceActionGroup.ItemLinks.Add(this.bbStornoInvoice);
            this.ribbonInvoiceActionGroup.ItemLinks.Add(this.bbCancelInvoice);
            this.ribbonInvoiceActionGroup.ItemLinks.Add(this.bbAnnounceInvoice);
            this.ribbonInvoiceActionGroup.ItemLinks.Add(this.bbLoginAsUser);
            this.ribbonInvoiceActionGroup.Name = "ribbonInvoiceActionGroup";
            this.ribbonInvoiceActionGroup.Text = "Acțiuni Linie Selectată";
            this.ribbonInvoiceActionGroup.Visible = false;
            // 
            // bbOpenClientInvoice
            // 
            this.bbOpenClientInvoice.Caption = "Deschide factura";
            this.bbOpenClientInvoice.Enabled = false;
            this.bbOpenClientInvoice.Hint = "Deschide factura clientului";
            this.bbOpenClientInvoice.Id = 30;
            this.bbOpenClientInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbOpenClientInvoice.ImageOptions.Image")));
            this.bbOpenClientInvoice.Name = "bbOpenClientInvoice";
            this.bbOpenClientInvoice.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbEditInvoice
            // 
            this.bbEditInvoice.Caption = "Modifică";
            this.bbEditInvoice.Enabled = false;
            this.bbEditInvoice.Hint = "Modifică";
            this.bbEditInvoice.Id = 31;
            this.bbEditInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbEditInvoice.ImageOptions.Image")));
            this.bbEditInvoice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbEditInvoice.ImageOptions.LargeImage")));
            this.bbEditInvoice.Name = "bbEditInvoice";
            this.bbEditInvoice.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbMarkAsSentInvoice
            // 
            this.bbMarkAsSentInvoice.Caption = "Marcare trimisă";
            this.bbMarkAsSentInvoice.Enabled = false;
            this.bbMarkAsSentInvoice.Hint = "Marcați ca trimisă";
            this.bbMarkAsSentInvoice.Id = 32;
            this.bbMarkAsSentInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbMarkAsSentInvoice.ImageOptions.Image")));
            this.bbMarkAsSentInvoice.Name = "bbMarkAsSentInvoice";
            this.bbMarkAsSentInvoice.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbPayInvoice
            // 
            this.bbPayInvoice.Caption = "Încasează";
            this.bbPayInvoice.Enabled = false;
            this.bbPayInvoice.Hint = "Încasează";
            this.bbPayInvoice.Id = 33;
            this.bbPayInvoice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbPayInvoice.ImageOptions.LargeImage")));
            this.bbPayInvoice.Name = "bbPayInvoice";
            this.bbPayInvoice.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbStornoInvoice
            // 
            this.bbStornoInvoice.Caption = "Storno";
            this.bbStornoInvoice.Enabled = false;
            this.bbStornoInvoice.Hint = "Storno";
            this.bbStornoInvoice.Id = 34;
            this.bbStornoInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbStornoInvoice.ImageOptions.Image")));
            this.bbStornoInvoice.Name = "bbStornoInvoice";
            this.bbStornoInvoice.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbCancelInvoice
            // 
            this.bbCancelInvoice.Caption = "Anulează";
            this.bbCancelInvoice.Enabled = false;
            this.bbCancelInvoice.Hint = "Anulează";
            this.bbCancelInvoice.Id = 35;
            this.bbCancelInvoice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbCancelInvoice.ImageOptions.LargeImage")));
            this.bbCancelInvoice.Name = "bbCancelInvoice";
            this.bbCancelInvoice.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbAnnounceInvoice
            // 
            this.bbAnnounceInvoice.Caption = "Memento plată";
            this.bbAnnounceInvoice.Enabled = false;
            this.bbAnnounceInvoice.Hint = "Memento plată";
            this.bbAnnounceInvoice.Id = 36;
            this.bbAnnounceInvoice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbAnnounceInvoice.ImageOptions.LargeImage")));
            this.bbAnnounceInvoice.Name = "bbAnnounceInvoice";
            this.bbAnnounceInvoice.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbLoginAsUser
            // 
            this.bbLoginAsUser.Caption = "Login";
            this.bbLoginAsUser.Enabled = false;
            this.bbLoginAsUser.Hint = "Login";
            this.bbLoginAsUser.Id = 38;
            this.bbLoginAsUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbLoginAsUser.ImageOptions.LargeImage")));
            this.bbLoginAsUser.Name = "bbLoginAsUser";
            this.bbLoginAsUser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonOtherActionsGroup
            // 
            this.ribbonOtherActionsGroup.ItemLinks.Add(this.bbOrderClient);
            this.ribbonOtherActionsGroup.ItemLinks.Add(this.bbOrderShipper);
            this.ribbonOtherActionsGroup.ItemLinks.Add(this.bbNewCommand);
            this.ribbonOtherActionsGroup.ItemLinks.Add(this.bbDuplicateOrder);
            this.ribbonOtherActionsGroup.ItemLinks.Add(this.bbSagaExport);
            this.ribbonOtherActionsGroup.Name = "ribbonOtherActionsGroup";
            this.ribbonOtherActionsGroup.Text = "Acțiuni Linie Selectată";
            this.ribbonOtherActionsGroup.Visible = false;
            // 
            // bbOrderClient
            // 
            this.bbOrderClient.Caption = "Comandă Client";
            this.bbOrderClient.Enabled = false;
            this.bbOrderClient.Hint = "Comandă Client";
            this.bbOrderClient.Id = 39;
            this.bbOrderClient.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbOrderClient.ImageOptions.LargeImage")));
            this.bbOrderClient.Name = "bbOrderClient";
            this.bbOrderClient.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbOrderShipper
            // 
            this.bbOrderShipper.Caption = "Comandă Transportator";
            this.bbOrderShipper.Enabled = false;
            this.bbOrderShipper.Hint = "Comandă Transportator";
            this.bbOrderShipper.Id = 40;
            this.bbOrderShipper.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbOrderShipper.ImageOptions.LargeImage")));
            this.bbOrderShipper.Name = "bbOrderShipper";
            // 
            // bbNewCommand
            // 
            this.bbNewCommand.Caption = "Comandă nouă";
            this.bbNewCommand.Enabled = false;
            this.bbNewCommand.Hint = "Comandă nouă";
            this.bbNewCommand.Id = 41;
            this.bbNewCommand.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbNewCommand.ImageOptions.LargeImage")));
            this.bbNewCommand.Name = "bbNewCommand";
            // 
            // bbDuplicateOrder
            // 
            this.bbDuplicateOrder.Caption = "Duplică Comanda";
            this.bbDuplicateOrder.Enabled = false;
            this.bbDuplicateOrder.Hint = "Duplică Comanda";
            this.bbDuplicateOrder.Id = 42;
            this.bbDuplicateOrder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbDuplicateOrder.ImageOptions.LargeImage")));
            this.bbDuplicateOrder.Name = "bbDuplicateOrder";
            // 
            // bbSagaExport
            // 
            this.bbSagaExport.Caption = "Export pentru Saga";
            this.bbSagaExport.Enabled = false;
            this.bbSagaExport.Hint = "Export pentru Saga";
            this.bbSagaExport.Id = 43;
            this.bbSagaExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbSagaExport.ImageOptions.LargeImage")));
            this.bbSagaExport.Name = "bbSagaExport";
            // 
            // ribbonPageSelectionGroup
            // 
            this.ribbonPageSelectionGroup.ItemLinks.Add(this.bbExportXLSX);
            this.ribbonPageSelectionGroup.ItemLinks.Add(this.bbRefresh);
            this.ribbonPageSelectionGroup.ItemLinks.Add(this.bbReset);
            this.ribbonPageSelectionGroup.Name = "ribbonPageSelectionGroup";
            // 
            // bbExportXLSX
            // 
            this.bbExportXLSX.Caption = "Exportă în XLSX";
            this.bbExportXLSX.Enabled = false;
            this.bbExportXLSX.Id = 10;
            this.bbExportXLSX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbExportXLSX.ImageOptions.Image")));
            this.bbExportXLSX.Name = "bbExportXLSX";
            this.bbExportXLSX.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbRefresh
            // 
            this.bbRefresh.Caption = "Refresh";
            this.bbRefresh.Enabled = false;
            this.bbRefresh.Id = 9;
            this.bbRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbRefresh.ImageOptions.Image")));
            this.bbRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbRefresh.ImageOptions.LargeImage")));
            this.bbRefresh.Name = "bbRefresh";
            this.bbRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbReset
            // 
            this.bbReset.Caption = "Reset";
            this.bbReset.Enabled = false;
            this.bbReset.Id = 11;
            this.bbReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbReset.ImageOptions.Image")));
            this.bbReset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbReset.ImageOptions.LargeImage")));
            this.bbReset.Name = "bbReset";
            this.bbReset.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPageFilterGroup
            // 
            this.ribbonPageFilterGroup.Enabled = false;
            this.ribbonPageFilterGroup.ItemLinks.Add(this.beFilter);
            this.ribbonPageFilterGroup.Name = "ribbonPageFilterGroup";
            this.ribbonPageFilterGroup.Text = "Filtru";
            // 
            // beFilter
            // 
            this.beFilter.Caption = "Ultimele 3 luni";
            this.beFilter.Edit = this.repositoryItemTimeSpanEdit1;
            this.beFilter.Id = 12;
            this.beFilter.Name = "beFilter";
            this.beFilter.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Refresh";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 8;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 13;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "barSubItem2";
            this.barSubItem2.Id = 14;
            this.barSubItem2.Name = "barSubItem2";
            this.barSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbClose
            // 
            this.bbClose.Id = 15;
            this.bbClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbClose.ImageOptions.Image")));
            this.bbClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbClose.ImageOptions.LargeImage")));
            this.bbClose.Name = "bbClose";
            this.bbClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbClose_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 16;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "barSubItem3";
            this.barSubItem3.Id = 17;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemButtonEdit1;
            this.barEditItem1.Id = 18;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 19;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // bbSavePrecommand
            // 
            this.bbSavePrecommand.ActAsDropDown = true;
            this.bbSavePrecommand.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbSavePrecommand.Caption = "Salvare Precomandă";
            this.bbSavePrecommand.Id = 20;
            this.bbSavePrecommand.Name = "bbSavePrecommand";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "barSubItem4";
            this.barSubItem4.Id = 21;
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 22;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemHypertextLabel1;
            this.barEditItem2.Id = 23;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // bbSaveCommand
            // 
            this.bbSaveCommand.Caption = "Salvează comandă";
            this.bbSaveCommand.Enabled = false;
            this.bbSaveCommand.Id = 24;
            this.bbSaveCommand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbSaveCommand.ImageOptions.Image")));
            this.bbSaveCommand.Name = "bbSaveCommand";
            // 
            // bbCreateShipperCommand
            // 
            this.bbCreateShipperCommand.Caption = "Comandă transportator";
            this.bbCreateShipperCommand.Enabled = false;
            this.bbCreateShipperCommand.Id = 25;
            this.bbCreateShipperCommand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbCreateShipperCommand.ImageOptions.Image")));
            this.bbCreateShipperCommand.Name = "bbCreateShipperCommand";
            // 
            // bbCancelCommand
            // 
            this.bbCancelCommand.Caption = "Anulează";
            this.bbCancelCommand.Enabled = false;
            this.bbCancelCommand.Id = 27;
            this.bbCancelCommand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbCancelCommand.ImageOptions.Image")));
            this.bbCancelCommand.Name = "bbCancelCommand";
            this.bbCancelCommand.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 28;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "barSubItem5";
            this.barSubItem5.Id = 29;
            this.barSubItem5.Name = "barSubItem5";
            // 
            // bbDeleteUser
            // 
            this.bbDeleteUser.Hint = "Șterge";
            this.bbDeleteUser.Id = 37;
            this.bbDeleteUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbDeleteUser.ImageOptions.Image")));
            this.bbDeleteUser.Name = "bbDeleteUser";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.barButtonItem1,
            this.bbAddRow,
            this.bbEditRow,
            this.bbDeleteRow,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barSubItem1,
            this.bbRefresh,
            this.bbExportXLSX,
            this.bbReset,
            this.beFilter,
            this.barButtonGroup1,
            this.barSubItem2,
            this.bbClose,
            this.barStaticItem1,
            this.barSubItem3,
            this.barEditItem1,
            this.barMdiChildrenListItem1,
            this.bbSavePrecommand,
            this.barSubItem4,
            this.barWorkspaceMenuItem1,
            this.barEditItem2,
            this.bbSaveCommand,
            this.bbCreateShipperCommand,
            this.bbCancelCommand,
            this.barButtonItem9,
            this.barSubItem5,
            this.bbOpenClientInvoice,
            this.bbEditInvoice,
            this.bbMarkAsSentInvoice,
            this.bbPayInvoice,
            this.bbStornoInvoice,
            this.bbCancelInvoice,
            this.bbAnnounceInvoice,
            this.bbDeleteUser,
            this.bbLoginAsUser,
            this.bbOrderClient,
            this.bbOrderShipper,
            this.bbNewCommand,
            this.bbDuplicateOrder,
            this.bbSagaExport});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl.MaxItemId = 44;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsMenuMinWidth = 422;
            this.ribbonControl.PageHeaderItemLinks.Add(this.bbClose);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonMainOptions});
            this.ribbonControl.Size = new System.Drawing.Size(2830, 364);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 364);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(581, 1004);
            this.panelControl1.TabIndex = 2;
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Comandă transportator";
            this.barButtonItem10.Id = 40;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2830, 1368);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "frmMain";
            this.Text = "My Transport Pal(Menu Redesign Proposal)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageResourceCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.Utils.ImageCollection imageResourceCollection;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bbAddRow;
        private DevExpress.XtraBars.BarButtonItem bbEditRow;
        private DevExpress.XtraBars.BarButtonItem bbDeleteRow;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem bbRefresh;
        private DevExpress.XtraBars.BarButtonItem bbExportXLSX;
        private DevExpress.XtraBars.BarButtonItem bbReset;
        private DevExpress.XtraBars.BarEditItem beFilter;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem bbClose;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarButtonItem bbSavePrecommand;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraBars.BarButtonItem bbSaveCommand;
        private DevExpress.XtraBars.BarButtonItem bbCreateShipperCommand;
        private DevExpress.XtraBars.BarButtonItem bbCancelCommand;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarButtonItem bbOpenClientInvoice;
        private DevExpress.XtraBars.BarButtonItem bbEditInvoice;
        private DevExpress.XtraBars.BarButtonItem bbMarkAsSentInvoice;
        private DevExpress.XtraBars.BarButtonItem bbPayInvoice;
        private DevExpress.XtraBars.BarButtonItem bbStornoInvoice;
        private DevExpress.XtraBars.BarButtonItem bbCancelInvoice;
        private DevExpress.XtraBars.BarButtonItem bbAnnounceInvoice;
        private DevExpress.XtraBars.BarButtonItem bbDeleteUser;
        private DevExpress.XtraBars.BarButtonItem bbLoginAsUser;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonMainOptions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageActionGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonInvoiceActionGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageSelectionGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageFilterGroup;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonOtherActionsGroup;
        private DevExpress.XtraBars.BarButtonItem bbOrderClient;
        private DevExpress.XtraBars.BarButtonItem bbOrderShipper;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem bbNewCommand;
        private DevExpress.XtraBars.BarButtonItem bbDuplicateOrder;
        private DevExpress.XtraBars.BarButtonItem bbSagaExport;
    }
}

