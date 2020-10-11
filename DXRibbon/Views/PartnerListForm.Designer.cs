namespace DXRibbon.Views
{
    partial class PartnerListForm
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
            this.gcPartnerList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcPartnerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPartnerList
            // 
            this.gcPartnerList.Location = new System.Drawing.Point(466, 13);
            this.gcPartnerList.MainView = this.gridView1;
            this.gcPartnerList.Name = "gcPartnerList";
            this.gcPartnerList.Size = new System.Drawing.Size(1357, 1252);
            this.gcPartnerList.TabIndex = 0;
            this.gcPartnerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 373;
            this.gridView1.GridControl = this.gcPartnerList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += gridView1_RowClick;
            // 
            // PartnerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 1289);
            this.Controls.Add(this.gcPartnerList);
            this.Name = "PartnerListForm";
            this.Text = "Parteneri";
            this.Load += new System.EventHandler(this.PartnerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPartnerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPartnerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}