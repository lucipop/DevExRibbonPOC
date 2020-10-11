namespace DXRibbon.Controls
{
    partial class InvoiceListForm
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
            this.gCInvoiceList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gCInvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gCInvoiceList
            // 
            this.gCInvoiceList.Location = new System.Drawing.Point(466, 13);
            this.gCInvoiceList.MainView = this.gridView1;
            this.gCInvoiceList.Name = "gCInvoiceList";
            this.gCInvoiceList.Size = new System.Drawing.Size(1357, 1252);
            this.gCInvoiceList.TabIndex = 0;
            this.gCInvoiceList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 373;
            this.gridView1.GridControl = this.gCInvoiceList;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += gridView1_RowClick;
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // InvoiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 1289);
            this.Controls.Add(this.gCInvoiceList);
            this.Name = "InvoiceListForm";
            this.Text = "Facturi";
            this.Load += new System.EventHandler(this.InvoiceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gCInvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gCInvoiceList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}