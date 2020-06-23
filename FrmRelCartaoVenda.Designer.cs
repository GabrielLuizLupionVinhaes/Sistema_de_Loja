namespace LojaCL
{
    partial class FrmRelCartaoVenda
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DbLojaDataSet = new LojaCL.DbLojaDataSet();
            this.cartaovendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartaovendaTableAdapter = new LojaCL.DbLojaDataSetTableAdapters.cartaovendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DbLojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaovendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.cartaovendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LojaCL.RelCartaoVenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DbLojaDataSet
            // 
            this.DbLojaDataSet.DataSetName = "DbLojaDataSet";
            this.DbLojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartaovendaBindingSource
            // 
            this.cartaovendaBindingSource.DataMember = "cartaovenda";
            this.cartaovendaBindingSource.DataSource = this.DbLojaDataSet;
            // 
            // cartaovendaTableAdapter
            // 
            this.cartaovendaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelCartaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelCartaoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Cartão Venda";
            this.Load += new System.EventHandler(this.FrmRelCartaoVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbLojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaovendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cartaovendaBindingSource;
        private DbLojaDataSet DbLojaDataSet;
        private DbLojaDataSetTableAdapters.cartaovendaTableAdapter cartaovendaTableAdapter;
    }
}