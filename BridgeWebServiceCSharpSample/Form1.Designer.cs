namespace BridgeWebServiceCSharpSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bridgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bridgenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bridgelengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bridgelengthSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bridgestructureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bridgewidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bridgewidthSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ledgernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ledgernumberSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowermaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.managementnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managementnumberSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spanSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uppermaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.bridgenameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.ageSpecifiedDataGridViewCheckBoxColumn,
            this.bridgelengthDataGridViewTextBoxColumn,
            this.bridgelengthSpecifiedDataGridViewCheckBoxColumn,
            this.bridgestructureDataGridViewTextBoxColumn,
            this.bridgewidthDataGridViewTextBoxColumn,
            this.bridgewidthSpecifiedDataGridViewCheckBoxColumn,
            this.idSpecifiedDataGridViewCheckBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.ledgernumberDataGridViewTextBoxColumn,
            this.ledgernumberSpecifiedDataGridViewCheckBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.lowermaterialDataGridViewTextBoxColumn,
            this.madeDataGridViewTextBoxColumn,
            this.madeSpecifiedDataGridViewCheckBoxColumn,
            this.managementnumberDataGridViewTextBoxColumn,
            this.managementnumberSpecifiedDataGridViewCheckBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.officeDataGridViewTextBoxColumn,
            this.routeDataGridViewTextBoxColumn,
            this.spanDataGridViewTextBoxColumn,
            this.spanSpecifiedDataGridViewCheckBoxColumn,
            this.uppermaterialDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bridgeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(704, 475);
            this.dataGridView1.TabIndex = 2;
            // 
            // bridgeBindingSource
            // 
            this.bridgeBindingSource.DataSource = typeof(BridgeWebServiceCSharpSample.BridgeServiceReference.bridge);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "管理番号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 78;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "所在地";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 66;
            // 
            // bridgenameDataGridViewTextBoxColumn
            // 
            this.bridgenameDataGridViewTextBoxColumn.DataPropertyName = "bridgename";
            this.bridgenameDataGridViewTextBoxColumn.HeaderText = "橋梁名";
            this.bridgenameDataGridViewTextBoxColumn.Name = "bridgenameDataGridViewTextBoxColumn";
            this.bridgenameDataGridViewTextBoxColumn.Width = 66;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 48;
            // 
            // ageSpecifiedDataGridViewCheckBoxColumn
            // 
            this.ageSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "ageSpecified";
            this.ageSpecifiedDataGridViewCheckBoxColumn.HeaderText = "ageSpecified";
            this.ageSpecifiedDataGridViewCheckBoxColumn.Name = "ageSpecifiedDataGridViewCheckBoxColumn";
            this.ageSpecifiedDataGridViewCheckBoxColumn.Width = 76;
            // 
            // bridgelengthDataGridViewTextBoxColumn
            // 
            this.bridgelengthDataGridViewTextBoxColumn.DataPropertyName = "bridgelength";
            this.bridgelengthDataGridViewTextBoxColumn.HeaderText = "bridgelength";
            this.bridgelengthDataGridViewTextBoxColumn.Name = "bridgelengthDataGridViewTextBoxColumn";
            this.bridgelengthDataGridViewTextBoxColumn.Width = 92;
            // 
            // bridgelengthSpecifiedDataGridViewCheckBoxColumn
            // 
            this.bridgelengthSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "bridgelengthSpecified";
            this.bridgelengthSpecifiedDataGridViewCheckBoxColumn.HeaderText = "bridgelengthSpecified";
            this.bridgelengthSpecifiedDataGridViewCheckBoxColumn.Name = "bridgelengthSpecifiedDataGridViewCheckBoxColumn";
            this.bridgelengthSpecifiedDataGridViewCheckBoxColumn.Width = 120;
            // 
            // bridgestructureDataGridViewTextBoxColumn
            // 
            this.bridgestructureDataGridViewTextBoxColumn.DataPropertyName = "bridgestructure";
            this.bridgestructureDataGridViewTextBoxColumn.HeaderText = "bridgestructure";
            this.bridgestructureDataGridViewTextBoxColumn.Name = "bridgestructureDataGridViewTextBoxColumn";
            this.bridgestructureDataGridViewTextBoxColumn.Width = 107;
            // 
            // bridgewidthDataGridViewTextBoxColumn
            // 
            this.bridgewidthDataGridViewTextBoxColumn.DataPropertyName = "bridgewidth";
            this.bridgewidthDataGridViewTextBoxColumn.HeaderText = "bridgewidth";
            this.bridgewidthDataGridViewTextBoxColumn.Name = "bridgewidthDataGridViewTextBoxColumn";
            this.bridgewidthDataGridViewTextBoxColumn.Width = 88;
            // 
            // bridgewidthSpecifiedDataGridViewCheckBoxColumn
            // 
            this.bridgewidthSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "bridgewidthSpecified";
            this.bridgewidthSpecifiedDataGridViewCheckBoxColumn.HeaderText = "bridgewidthSpecified";
            this.bridgewidthSpecifiedDataGridViewCheckBoxColumn.Name = "bridgewidthSpecifiedDataGridViewCheckBoxColumn";
            this.bridgewidthSpecifiedDataGridViewCheckBoxColumn.Width = 116;
            // 
            // idSpecifiedDataGridViewCheckBoxColumn
            // 
            this.idSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "idSpecified";
            this.idSpecifiedDataGridViewCheckBoxColumn.HeaderText = "idSpecified";
            this.idSpecifiedDataGridViewCheckBoxColumn.Name = "idSpecifiedDataGridViewCheckBoxColumn";
            this.idSpecifiedDataGridViewCheckBoxColumn.Width = 67;
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "latitude";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            this.latitudeDataGridViewTextBoxColumn.Width = 68;
            // 
            // ledgernumberDataGridViewTextBoxColumn
            // 
            this.ledgernumberDataGridViewTextBoxColumn.DataPropertyName = "ledgernumber";
            this.ledgernumberDataGridViewTextBoxColumn.HeaderText = "ledgernumber";
            this.ledgernumberDataGridViewTextBoxColumn.Name = "ledgernumberDataGridViewTextBoxColumn";
            this.ledgernumberDataGridViewTextBoxColumn.Width = 98;
            // 
            // ledgernumberSpecifiedDataGridViewCheckBoxColumn
            // 
            this.ledgernumberSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "ledgernumberSpecified";
            this.ledgernumberSpecifiedDataGridViewCheckBoxColumn.HeaderText = "ledgernumberSpecified";
            this.ledgernumberSpecifiedDataGridViewCheckBoxColumn.Name = "ledgernumberSpecifiedDataGridViewCheckBoxColumn";
            this.ledgernumberSpecifiedDataGridViewCheckBoxColumn.Width = 126;
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            this.longitudeDataGridViewTextBoxColumn.Width = 76;
            // 
            // lowermaterialDataGridViewTextBoxColumn
            // 
            this.lowermaterialDataGridViewTextBoxColumn.DataPropertyName = "lowermaterial";
            this.lowermaterialDataGridViewTextBoxColumn.HeaderText = "lowermaterial";
            this.lowermaterialDataGridViewTextBoxColumn.Name = "lowermaterialDataGridViewTextBoxColumn";
            this.lowermaterialDataGridViewTextBoxColumn.Width = 98;
            // 
            // madeDataGridViewTextBoxColumn
            // 
            this.madeDataGridViewTextBoxColumn.DataPropertyName = "made";
            this.madeDataGridViewTextBoxColumn.HeaderText = "made";
            this.madeDataGridViewTextBoxColumn.Name = "madeDataGridViewTextBoxColumn";
            this.madeDataGridViewTextBoxColumn.Width = 57;
            // 
            // madeSpecifiedDataGridViewCheckBoxColumn
            // 
            this.madeSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "madeSpecified";
            this.madeSpecifiedDataGridViewCheckBoxColumn.HeaderText = "madeSpecified";
            this.madeSpecifiedDataGridViewCheckBoxColumn.Name = "madeSpecifiedDataGridViewCheckBoxColumn";
            this.madeSpecifiedDataGridViewCheckBoxColumn.Width = 85;
            // 
            // managementnumberDataGridViewTextBoxColumn
            // 
            this.managementnumberDataGridViewTextBoxColumn.DataPropertyName = "managementnumber";
            this.managementnumberDataGridViewTextBoxColumn.HeaderText = "managementnumber";
            this.managementnumberDataGridViewTextBoxColumn.Name = "managementnumberDataGridViewTextBoxColumn";
            this.managementnumberDataGridViewTextBoxColumn.Width = 131;
            // 
            // managementnumberSpecifiedDataGridViewCheckBoxColumn
            // 
            this.managementnumberSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "managementnumberSpecified";
            this.managementnumberSpecifiedDataGridViewCheckBoxColumn.HeaderText = "managementnumberSpecified";
            this.managementnumberSpecifiedDataGridViewCheckBoxColumn.Name = "managementnumberSpecifiedDataGridViewCheckBoxColumn";
            this.managementnumberSpecifiedDataGridViewCheckBoxColumn.Width = 159;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.Width = 60;
            // 
            // officeDataGridViewTextBoxColumn
            // 
            this.officeDataGridViewTextBoxColumn.DataPropertyName = "office";
            this.officeDataGridViewTextBoxColumn.HeaderText = "office";
            this.officeDataGridViewTextBoxColumn.Name = "officeDataGridViewTextBoxColumn";
            this.officeDataGridViewTextBoxColumn.Width = 59;
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "route";
            this.routeDataGridViewTextBoxColumn.HeaderText = "route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            this.routeDataGridViewTextBoxColumn.Width = 56;
            // 
            // spanDataGridViewTextBoxColumn
            // 
            this.spanDataGridViewTextBoxColumn.DataPropertyName = "span";
            this.spanDataGridViewTextBoxColumn.HeaderText = "span";
            this.spanDataGridViewTextBoxColumn.Name = "spanDataGridViewTextBoxColumn";
            this.spanDataGridViewTextBoxColumn.Width = 54;
            // 
            // spanSpecifiedDataGridViewCheckBoxColumn
            // 
            this.spanSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "spanSpecified";
            this.spanSpecifiedDataGridViewCheckBoxColumn.HeaderText = "spanSpecified";
            this.spanSpecifiedDataGridViewCheckBoxColumn.Name = "spanSpecifiedDataGridViewCheckBoxColumn";
            this.spanSpecifiedDataGridViewCheckBoxColumn.Width = 82;
            // 
            // uppermaterialDataGridViewTextBoxColumn
            // 
            this.uppermaterialDataGridViewTextBoxColumn.DataPropertyName = "uppermaterial";
            this.uppermaterialDataGridViewTextBoxColumn.HeaderText = "uppermaterial";
            this.uppermaterialDataGridViewTextBoxColumn.Name = "uppermaterialDataGridViewTextBoxColumn";
            this.uppermaterialDataGridViewTextBoxColumn.Width = 99;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridgeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bridgeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bridgenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ageSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bridgelengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bridgelengthSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bridgestructureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bridgewidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bridgewidthSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn idSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ledgernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ledgernumberSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowermaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn madeSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managementnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn managementnumberSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn spanSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uppermaterialDataGridViewTextBoxColumn;
    }
}

