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
    public partial class NewCommandForm : Form
    {
        frmMain parent = (frmMain)Application.OpenForms[0];
        public NewCommandForm()
        {
            InitializeComponent();
        }

        private void NewCommandForm_Load(object sender, EventArgs e)
        {
            parent.ChangeEnableOption_bbMarkAsSentInvoice(false);
            parent.ChangeEnableOption_bbPayInvoice(false);
            parent.ChangeEnableOption_bbStornoInvoice(false);
            parent.ChangeEnableOption_bbCancelInvoice(false);
            parent.ChangeEnableOption_bbEditDataInvoice(false);
            parent.ChangeEnableOption_LoginAsUser(false);

            parent.ChangeEnableOption_bbOpenClientInvoice(false);
            parent.ChangeEnableOption_bbAnnounceInvoice(false);

            parent.ChangeEnableOption_bbCancelCommand(true);
            parent.ChangeEnableOption_bbSaveCommand(false);
            parent.ChangeEnableOption_bbCreateShipperCommand(false);

            parent.ChangeEnableOption_Filter(false);
        }
    }
    
}
