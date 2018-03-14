namespace Test
{
    partial class ViewRequisite
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
            this.iDзаводаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиебанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расчетныйсчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.корреспондентскийсчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бИКDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.банковскиереквизитыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Test.testDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.банковские_реквизитыTableAdapter = new Test.testDataSetTableAdapters.Банковские_реквизитыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.банковскиереквизитыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDзаводаDataGridViewTextBoxColumn,
            this.наименованиебанкаDataGridViewTextBoxColumn,
            this.расчетныйсчетDataGridViewTextBoxColumn,
            this.корреспондентскийсчетDataGridViewTextBoxColumn,
            this.бИКDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.банковскиереквизитыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDзаводаDataGridViewTextBoxColumn
            // 
            this.iDзаводаDataGridViewTextBoxColumn.DataPropertyName = "ID_завода";
            this.iDзаводаDataGridViewTextBoxColumn.HeaderText = "ID_завода";
            this.iDзаводаDataGridViewTextBoxColumn.Name = "iDзаводаDataGridViewTextBoxColumn";
            this.iDзаводаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDзаводаDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиебанкаDataGridViewTextBoxColumn
            // 
            this.наименованиебанкаDataGridViewTextBoxColumn.DataPropertyName = "Наименование_банка";
            this.наименованиебанкаDataGridViewTextBoxColumn.HeaderText = "Наименование банка";
            this.наименованиебанкаDataGridViewTextBoxColumn.Name = "наименованиебанкаDataGridViewTextBoxColumn";
            this.наименованиебанкаDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиебанкаDataGridViewTextBoxColumn.Width = 300;
            // 
            // расчетныйсчетDataGridViewTextBoxColumn
            // 
            this.расчетныйсчетDataGridViewTextBoxColumn.DataPropertyName = "Расчетный_счет";
            this.расчетныйсчетDataGridViewTextBoxColumn.HeaderText = "Расчетный счет";
            this.расчетныйсчетDataGridViewTextBoxColumn.Name = "расчетныйсчетDataGridViewTextBoxColumn";
            this.расчетныйсчетDataGridViewTextBoxColumn.ReadOnly = true;
            this.расчетныйсчетDataGridViewTextBoxColumn.Width = 200;
            // 
            // корреспондентскийсчетDataGridViewTextBoxColumn
            // 
            this.корреспондентскийсчетDataGridViewTextBoxColumn.DataPropertyName = "Корреспондентский_счет";
            this.корреспондентскийсчетDataGridViewTextBoxColumn.HeaderText = "Корреспондентский счет";
            this.корреспондентскийсчетDataGridViewTextBoxColumn.Name = "корреспондентскийсчетDataGridViewTextBoxColumn";
            this.корреспондентскийсчетDataGridViewTextBoxColumn.ReadOnly = true;
            this.корреспондентскийсчетDataGridViewTextBoxColumn.Width = 300;
            // 
            // бИКDataGridViewTextBoxColumn
            // 
            this.бИКDataGridViewTextBoxColumn.DataPropertyName = "БИК";
            this.бИКDataGridViewTextBoxColumn.HeaderText = "БИК";
            this.бИКDataGridViewTextBoxColumn.Name = "бИКDataGridViewTextBoxColumn";
            this.бИКDataGridViewTextBoxColumn.ReadOnly = true;
            this.бИКDataGridViewTextBoxColumn.Width = 200;
            // 
            // банковскиереквизитыBindingSource
            // 
            this.банковскиереквизитыBindingSource.DataMember = "Банковские_реквизиты";
            this.банковскиереквизитыBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Image = global::Test.Properties.Resources._1496547746_close21;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(860, 269);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "   Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Реквизиты завода-изготовителя:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Image = global::Test.Properties.Resources._1479950372_More;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Image = global::Test.Properties.Resources._1479950564_common_new_edit_compose_glyph;
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Image = global::Test.Properties.Resources._1479950367_Less;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // банковские_реквизитыTableAdapter
            // 
            this.банковские_реквизитыTableAdapter.ClearBeforeFill = true;
            // 
            // ViewRequisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewRequisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реквизиты";
            this.Load += new System.EventHandler(this.Реквизиты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.банковскиереквизитыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.BindingSource банковскиереквизитыBindingSource;
        private testDataSet testDataSet;
        private testDataSetTableAdapters.Банковские_реквизитыTableAdapter банковские_реквизитыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзаводаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиебанкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расчетныйсчетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn корреспондентскийсчетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бИКDataGridViewTextBoxColumn;
    }
}