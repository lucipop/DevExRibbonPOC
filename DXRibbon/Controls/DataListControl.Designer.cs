namespace DXRibbon.Views
{
    partial class DataListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gcDataList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDataList
            // 
            this.gcDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDataList.Location = new System.Drawing.Point(0, 0);
            this.gcDataList.MainView = this.gridView1;
            this.gcDataList.Name = "gcDataList";
            this.gcDataList.Size = new System.Drawing.Size(1415, 1119);
            this.gcDataList.TabIndex = 0;
            this.gcDataList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcDataList;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Adaugă";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // DataListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcDataList);
            this.Name = "DataListControl";
            this.Size = new System.Drawing.Size(1415, 1119);
            this.Load += new System.EventHandler(this.DataListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDataList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
