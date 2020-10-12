using DXRibbon.Seed.Commands;
using System;
using System.Windows.Forms;

namespace DXRibbon.Views
{
    public partial class CommandForm : Form
    {
        public DataListControl CommandsGrid { get; private set; }
        public CommandForm()
        {
            InitializeComponent();
        }

        private void CommandForm_Load(object sender, EventArgs e)
        {
            CommandsGrid = new DataListControl(new CommandSeed());
            this.Controls.Add(CommandsGrid);
        }
    }
}
