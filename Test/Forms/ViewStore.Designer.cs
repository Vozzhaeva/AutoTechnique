namespace Test
{
    partial class ViewStore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testDataSet = new Test.testDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.складBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.складTableAdapter = new Test.testDataSetTableAdapters.СкладTableAdapter();
            this.iDпартииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапоступленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиемоделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остатокнатекущиймоментDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.признактехникиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers21;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Техника на складе";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDпартииDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.датапоступленияDataGridViewTextBoxColumn,
            this.наименованиемоделиDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.cтоимостьDataGridViewTextBoxColumn,
            this.остатокнатекущиймоментDataGridViewTextBoxColumn,
            this.признактехникиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.складBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = global::Test.Properties.Resources._1496547746_close2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(956, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "   Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // складBindingSource1
            // 
            this.складBindingSource1.DataMember = "Склад";
            this.складBindingSource1.DataSource = this.testDataSet;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // iDпартииDataGridViewTextBoxColumn
            // 
            this.iDпартииDataGridViewTextBoxColumn.DataPropertyName = "ID_партии";
            this.iDпартииDataGridViewTextBoxColumn.HeaderText = "ID_партии";
            this.iDпартииDataGridViewTextBoxColumn.Name = "iDпартииDataGridViewTextBoxColumn";
            this.iDпартииDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDпартииDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_модели";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_модели";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // датапоступленияDataGridViewTextBoxColumn
            // 
            this.датапоступленияDataGridViewTextBoxColumn.DataPropertyName = "Дата_поступления";
            this.датапоступленияDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.датапоступленияDataGridViewTextBoxColumn.Name = "датапоступленияDataGridViewTextBoxColumn";
            this.датапоступленияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датапоступленияDataGridViewTextBoxColumn.Width = 200;
            // 
            // наименованиемоделиDataGridViewTextBoxColumn
            // 
            this.наименованиемоделиDataGridViewTextBoxColumn.DataPropertyName = "Наименование_модели";
            this.наименованиемоделиDataGridViewTextBoxColumn.HeaderText = "Наименование модели";
            this.наименованиемоделиDataGridViewTextBoxColumn.Name = "наименованиемоделиDataGridViewTextBoxColumn";
            this.наименованиемоделиDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиемоделиDataGridViewTextBoxColumn.Width = 300;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоDataGridViewTextBoxColumn.Width = 130;
            // 
            // cтоимостьDataGridViewTextBoxColumn
            // 
            this.cтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Cтоимость";
            this.cтоимостьDataGridViewTextBoxColumn.HeaderText = "Cтоимость, руб.";
            this.cтоимостьDataGridViewTextBoxColumn.Name = "cтоимостьDataGridViewTextBoxColumn";
            this.cтоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.cтоимостьDataGridViewTextBoxColumn.Width = 190;
            // 
            // остатокнатекущиймоментDataGridViewTextBoxColumn
            // 
            this.остатокнатекущиймоментDataGridViewTextBoxColumn.DataPropertyName = "Остаток_на_текущий_момент";
            this.остатокнатекущиймоментDataGridViewTextBoxColumn.HeaderText = "Остаток";
            this.остатокнатекущиймоментDataGridViewTextBoxColumn.Name = "остатокнатекущиймоментDataGridViewTextBoxColumn";
            this.остатокнатекущиймоментDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // признактехникиDataGridViewTextBoxColumn
            // 
            this.признактехникиDataGridViewTextBoxColumn.DataPropertyName = "Признак_техники";
            this.признактехникиDataGridViewTextBoxColumn.HeaderText = "Признак";
            this.признактехникиDataGridViewTextBoxColumn.Name = "признактехникиDataGridViewTextBoxColumn";
            this.признактехникиDataGridViewTextBoxColumn.ReadOnly = true;
            this.признактехникиDataGridViewTextBoxColumn.Width = 150;
            // 
            // ViewStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStore";
            this.Load += new System.EventHandler(this.ViewStore_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private testDataSet testDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDмоделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource складBindingSource1;
        private testDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпартииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапоступленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиемоделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn остатокнатекущиймоментDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn признактехникиDataGridViewTextBoxColumn;
    }
}