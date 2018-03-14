namespace Test.Forms
{
    partial class ViewStoreAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDпартииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDмоделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапоступленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остатокнатекущиймоментDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.признактехникиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Test.testDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьТехникуНаСкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТехникуСоСкладаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складTableAdapter = new Test.testDataSetTableAdapters.СкладTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = global::Test.Properties.Resources._1496547746_close2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(984, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "   Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers21;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(27, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 431);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Техника на складе";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDпартииDataGridViewTextBoxColumn,
            this.iDмоделиDataGridViewTextBoxColumn,
            this.датапоступленияDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.количествоDataGridViewTextBoxColumn,
            this.cтоимостьDataGridViewTextBoxColumn,
            this.остатокнатекущиймоментDataGridViewTextBoxColumn,
            this.признактехникиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.складBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDпартииDataGridViewTextBoxColumn
            // 
            this.iDпартииDataGridViewTextBoxColumn.DataPropertyName = "ID_партии";
            this.iDпартииDataGridViewTextBoxColumn.HeaderText = "ID_партии";
            this.iDпартииDataGridViewTextBoxColumn.Name = "iDпартииDataGridViewTextBoxColumn";
            this.iDпартииDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDпартииDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDмоделиDataGridViewTextBoxColumn
            // 
            this.iDмоделиDataGridViewTextBoxColumn.DataPropertyName = "ID_модели";
            this.iDмоделиDataGridViewTextBoxColumn.HeaderText = "ID_модели";
            this.iDмоделиDataGridViewTextBoxColumn.Name = "iDмоделиDataGridViewTextBoxColumn";
            this.iDмоделиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDмоделиDataGridViewTextBoxColumn.Visible = false;
            // 
            // датапоступленияDataGridViewTextBoxColumn
            // 
            this.датапоступленияDataGridViewTextBoxColumn.DataPropertyName = "Дата_поступления";
            this.датапоступленияDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.датапоступленияDataGridViewTextBoxColumn.Name = "датапоступленияDataGridViewTextBoxColumn";
            this.датапоступленияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датапоступленияDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Наименование_модели";
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование модели";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
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
            this.cтоимостьDataGridViewTextBoxColumn.HeaderText = "Cтоимость";
            this.cтоимостьDataGridViewTextBoxColumn.Name = "cтоимостьDataGridViewTextBoxColumn";
            this.cтоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.cтоимостьDataGridViewTextBoxColumn.Width = 130;
            // 
            // остатокнатекущиймоментDataGridViewTextBoxColumn
            // 
            this.остатокнатекущиймоментDataGridViewTextBoxColumn.DataPropertyName = "Остаток_на_текущий_момент";
            this.остатокнатекущиймоментDataGridViewTextBoxColumn.HeaderText = "Остаток";
            this.остатокнатекущиймоментDataGridViewTextBoxColumn.Name = "остатокнатекущиймоментDataGridViewTextBoxColumn";
            this.остатокнатекущиймоментDataGridViewTextBoxColumn.ReadOnly = true;
            this.остатокнатекущиймоментDataGridViewTextBoxColumn.Width = 130;
            // 
            // признактехникиDataGridViewTextBoxColumn
            // 
            this.признактехникиDataGridViewTextBoxColumn.DataPropertyName = "Признак_техники";
            this.признактехникиDataGridViewTextBoxColumn.HeaderText = "Признак";
            this.признактехникиDataGridViewTextBoxColumn.Name = "признактехникиDataGridViewTextBoxColumn";
            this.признактехникиDataGridViewTextBoxColumn.ReadOnly = true;
            this.признактехникиDataGridViewTextBoxColumn.Width = 200;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers_org_ua_18616;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТехникуНаСкладToolStripMenuItem,
            this.изменитьИнформациюToolStripMenuItem,
            this.удалитьТехникуСоСкладаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1151, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьТехникуНаСкладToolStripMenuItem
            // 
            this.добавитьТехникуНаСкладToolStripMenuItem.Image = global::Test.Properties.Resources._1479950372_More;
            this.добавитьТехникуНаСкладToolStripMenuItem.Name = "добавитьТехникуНаСкладToolStripMenuItem";
            this.добавитьТехникуНаСкладToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.добавитьТехникуНаСкладToolStripMenuItem.Text = "Добавить технику на склад";
            this.добавитьТехникуНаСкладToolStripMenuItem.Click += new System.EventHandler(this.добавитьТехникуНаСкладToolStripMenuItem_Click);
            // 
            // изменитьИнформациюToolStripMenuItem
            // 
            this.изменитьИнформациюToolStripMenuItem.Image = global::Test.Properties.Resources._1479950564_common_new_edit_compose_glyph;
            this.изменитьИнформациюToolStripMenuItem.Name = "изменитьИнформациюToolStripMenuItem";
            this.изменитьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.изменитьИнформациюToolStripMenuItem.Text = "Изменить информацию";
            this.изменитьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.изменитьИнформациюToolStripMenuItem_Click);
            // 
            // удалитьТехникуСоСкладаToolStripMenuItem
            // 
            this.удалитьТехникуСоСкладаToolStripMenuItem.Image = global::Test.Properties.Resources._1479950367_Less;
            this.удалитьТехникуСоСкладаToolStripMenuItem.Name = "удалитьТехникуСоСкладаToolStripMenuItem";
            this.удалитьТехникуСоСкладаToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.удалитьТехникуСоСкладаToolStripMenuItem.Text = "Удалить технику со склада";
            this.удалитьТехникуСоСкладаToolStripMenuItem.Click += new System.EventHandler(this.удалитьТехникуСоСкладаToolStripMenuItem_Click);
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // ViewStoreAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers_org_ua_18616;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewStoreAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStoreAdmin";
            this.Load += new System.EventHandler(this.ViewStoreAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьТехникуНаСкладToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТехникуСоСкладаToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиемоделиDataGridViewTextBoxColumn;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource складBindingSource;
        private testDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпартииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDмоделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапоступленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn остатокнатекущиймоментDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn признактехникиDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem изменитьИнформациюToolStripMenuItem;
    }
}