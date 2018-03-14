namespace Test
{
    partial class AddUnit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.testDataSet = new Test.testDataSet();
            this.отделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отделTableAdapter = new Test.testDataSetTableAdapters.ОтделTableAdapter();
            this.iDотделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеотделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDотделаDataGridViewTextBoxColumn,
            this.названиеотделаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.отделBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(466, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(611, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(466, 361);
            this.dataGridView2.TabIndex = 1;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отделBindingSource
            // 
            this.отделBindingSource.DataMember = "Отдел";
            this.отделBindingSource.DataSource = this.testDataSet;
            // 
            // отделTableAdapter
            // 
            this.отделTableAdapter.ClearBeforeFill = true;
            // 
            // iDотделаDataGridViewTextBoxColumn
            // 
            this.iDотделаDataGridViewTextBoxColumn.DataPropertyName = "ID_отдела";
            this.iDотделаDataGridViewTextBoxColumn.HeaderText = "ID_отдела";
            this.iDотделаDataGridViewTextBoxColumn.Name = "iDотделаDataGridViewTextBoxColumn";
            // 
            // названиеотделаDataGridViewTextBoxColumn
            // 
            this.названиеотделаDataGridViewTextBoxColumn.DataPropertyName = "Название_отдела";
            this.названиеотделаDataGridViewTextBoxColumn.HeaderText = "Название_отдела";
            this.названиеотделаDataGridViewTextBoxColumn.Name = "названиеотделаDataGridViewTextBoxColumn";
            // 
            // AddUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 535);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddUnit";
            this.Text = "AddUnit";
            this.Load += new System.EventHandler(this.AddUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource отделBindingSource;
        private testDataSetTableAdapters.ОтделTableAdapter отделTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDотделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеотделаDataGridViewTextBoxColumn;
    }
}