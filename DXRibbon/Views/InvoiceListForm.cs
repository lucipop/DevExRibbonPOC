using DevExpress.XtraGrid.Views.Grid;
using DXRibbon.Seed.Documents;
using DXRibbon.Views;
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
        public DataListControl InvoicesGrid { get; private set; }
        public InvoiceListForm()
        {
            InitializeComponent();
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {
            InvoicesGrid = new DataListControl(new InvoiceSeed());
            this.Controls.Add(InvoicesGrid);

            parent.ChangeEnableOptions_RibbonInvoiceActionsGroup(true);

            parent.ChangeEnableOption_bbCancelCommand(false);
            parent.ChangeEnableOption_bbSaveCommand(false);
            parent.ChangeEnableOption_bbCreateShipperCommand(false);

            parent.ChangeVisibility_Filter(true);

            parent.ChangeEnableOption_LoginAsUser(false);
        }
    }
}
