using DXRibbon.Seed.Commands;
using System;
using System.Windows.Forms;

namespace DXRibbon.Views
{
    public partial class CommandForm : Form
    {
        public CommandForm()
        {
            InitializeComponent();
        }

        private void CommandForm_Load(object sender, EventArgs e)
        {
            DataListControl commandsGrid = new DataListControl(new CommandSeed());
            this.Controls.Add(commandsGrid);
        }
    }
}
