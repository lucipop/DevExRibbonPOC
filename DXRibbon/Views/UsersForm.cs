﻿using DXRibbon.Seed.Masterdata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXRibbon.Views
{
    public partial class UsersForm : Form
    {
        frmMain parent = (frmMain)Application.OpenForms[0];
        public DataListControl UsersGrid { get; private set; }
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            UsersGrid = new DataListControl(new UsersSeed());
            this.Controls.Add(UsersGrid);
            //parent.ChangeEnableOptions_RibbonInvoiceActionsGroup(false);

            //parent.ChangeEnableOption_bbMarkAsSentInvoice(false);
            //parent.ChangeEnableOption_bbPayInvoice(false);
            //parent.ChangeEnableOption_bbStornoInvoice(false);
            //parent.ChangeEnableOption_bbCancelInvoice(false);
            //parent.ChangeEnableOption_bbEditDataInvoice(false);
            //parent.ChangeEnableOption_ChangePassword(false);

            //parent.ChangeEnableOption_bbOpenClientInvoice(false);
            //parent.ChangeEnableOption_bbAnnounceInvoice(false);

            //parent.ChangeEnableOption_bbCancelCommand(false);
            //parent.ChangeEnableOption_bbSaveCommand(false);
            //parent.ChangeEnableOption_bbCreateShipperCommand(false);

            //parent.ChangeVisibility_Filter(false);
        }
    }
}
    