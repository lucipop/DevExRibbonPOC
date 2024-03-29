﻿using DevExpress.XtraGrid.Views.Grid;
using DXRibbon.Seed.Documents;
using DXRibbon.Seed.Partners;
using System;
using System.Windows.Forms;

namespace DXRibbon.Views
{
    public partial class PartnerListForm : DevExpress.XtraEditors.XtraForm
    {
        frmMain parent = (frmMain)Application.OpenForms[0];
        public PartnerListForm()
        {
            InitializeComponent();
        }

        private void PartnerListForm_Load(object sender, EventArgs e)
        {
            gcPartnerList.DataSource = PartnerSeed.SeedList();

            parent.ChangeVisibility_ActionListRibbonGroup(false);

            parent.ChangeEnableOption_bbMarkAsSentInvoice(false);
            parent.ChangeEnableOption_bbPayInvoice(false);
            parent.ChangeEnableOption_bbStornoInvoice(false);
            parent.ChangeEnableOption_bbCancelInvoice(false);
            parent.ChangeEnableOption_bbEditDataInvoice(false);
            parent.ChangeEnableOption_LoginAsUser(false);

            parent.ChangeEnableOption_bbOpenClientInvoice(false);
            parent.ChangeEnableOption_bbAnnounceInvoice(false);

            parent.ChangeEnableOption_bbCancelCommand(false);
            parent.ChangeEnableOption_bbSaveCommand(false);
            parent.ChangeEnableOption_bbCreateShipperCommand(false);

            parent.ChangeEnableOption_Filter(false);
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
           
        }
    }
}
