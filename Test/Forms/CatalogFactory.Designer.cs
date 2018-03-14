namespace Test
{
    partial class CatalogFactory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogFactory));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDзаводаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиезаводаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресзаводаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактныйтелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактныйemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кППDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заводизготовительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Test.testDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьРеквизитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьКонтактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.завод_изготовительTableAdapter = new Test.testDataSetTableAdapters.Завод_изготовительTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заводизготовительBindingSource)).BeginInit();
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
            this.наименованиезаводаDataGridViewTextBoxColumn,
            this.адресзаводаDataGridViewTextBoxColumn,
            this.контактныйтелефонDataGridViewTextBoxColumn,
            this.контактныйemailDataGridViewTextBoxColumn,
            this.iDсотрудникаDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.кППDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заводизготовительBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1356, 373);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // iDзаводаDataGridViewTextBoxColumn
            // 
            this.iDзаводаDataGridViewTextBoxColumn.DataPropertyName = "ID_завода";
            this.iDзаводаDataGridViewTextBoxColumn.HeaderText = "ID_завода";
            this.iDзаводаDataGridViewTextBoxColumn.Name = "iDзаводаDataGridViewTextBoxColumn";
            this.iDзаводаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDзаводаDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиезаводаDataGridViewTextBoxColumn
            // 
            this.наименованиезаводаDataGridViewTextBoxColumn.DataPropertyName = "Наименование_завода";
            this.наименованиезаводаDataGridViewTextBoxColumn.HeaderText = "Наименование завода";
            this.наименованиезаводаDataGridViewTextBoxColumn.Name = "наименованиезаводаDataGridViewTextBoxColumn";
            this.наименованиезаводаDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиезаводаDataGridViewTextBoxColumn.Width = 300;
            // 
            // адресзаводаDataGridViewTextBoxColumn
            // 
            this.адресзаводаDataGridViewTextBoxColumn.DataPropertyName = "Адрес_завода";
            this.адресзаводаDataGridViewTextBoxColumn.HeaderText = "Адрес завода";
            this.адресзаводаDataGridViewTextBoxColumn.Name = "адресзаводаDataGridViewTextBoxColumn";
            this.адресзаводаDataGridViewTextBoxColumn.ReadOnly = true;
            this.адресзаводаDataGridViewTextBoxColumn.Width = 300;
            // 
            // контактныйтелефонDataGridViewTextBoxColumn
            // 
            this.контактныйтелефонDataGridViewTextBoxColumn.DataPropertyName = "Контактный_телефон";
            this.контактныйтелефонDataGridViewTextBoxColumn.HeaderText = "Контактный телефон";
            this.контактныйтелефонDataGridViewTextBoxColumn.Name = "контактныйтелефонDataGridViewTextBoxColumn";
            this.контактныйтелефонDataGridViewTextBoxColumn.ReadOnly = true;
            this.контактныйтелефонDataGridViewTextBoxColumn.Width = 200;
            // 
            // контактныйemailDataGridViewTextBoxColumn
            // 
            this.контактныйemailDataGridViewTextBoxColumn.DataPropertyName = "Контактный_email";
            this.контактныйemailDataGridViewTextBoxColumn.HeaderText = "Контактный email";
            this.контактныйemailDataGridViewTextBoxColumn.Name = "контактныйemailDataGridViewTextBoxColumn";
            this.контактныйemailDataGridViewTextBoxColumn.ReadOnly = true;
            this.контактныйemailDataGridViewTextBoxColumn.Width = 200;
            // 
            // iDсотрудникаDataGridViewTextBoxColumn
            // 
            this.iDсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ID_сотрудника";
            this.iDсотрудникаDataGridViewTextBoxColumn.HeaderText = "ID_сотрудника";
            this.iDсотрудникаDataGridViewTextBoxColumn.Name = "iDсотрудникаDataGridViewTextBoxColumn";
            this.iDсотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDсотрудникаDataGridViewTextBoxColumn.Visible = false;
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            this.иННDataGridViewTextBoxColumn.ReadOnly = true;
            this.иННDataGridViewTextBoxColumn.Width = 150;
            // 
            // кППDataGridViewTextBoxColumn
            // 
            this.кППDataGridViewTextBoxColumn.DataPropertyName = "КПП";
            this.кППDataGridViewTextBoxColumn.HeaderText = "КПП";
            this.кППDataGridViewTextBoxColumn.Name = "кППDataGridViewTextBoxColumn";
            this.кППDataGridViewTextBoxColumn.ReadOnly = true;
            this.кППDataGridViewTextBoxColumn.Width = 150;
            // 
            // заводизготовительBindingSource
            // 
            this.заводизготовительBindingSource.DataMember = "Завод_изготовитель";
            this.заводизготовительBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.просмотретьРеквизитыToolStripMenuItem,
            this.просмотретьКонтактыToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1381, 30);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавитьToolStripMenuItem.Image")));
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Image = global::Test.Properties.Resources._1496547691_pen;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьToolStripMenuItem.Image")));
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // просмотретьРеквизитыToolStripMenuItem
            // 
            this.просмотретьРеквизитыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("просмотретьРеквизитыToolStripMenuItem.Image")));
            this.просмотретьРеквизитыToolStripMenuItem.Name = "просмотретьРеквизитыToolStripMenuItem";
            this.просмотретьРеквизитыToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.просмотретьРеквизитыToolStripMenuItem.Text = "Просмотреть реквизиты";
            this.просмотретьРеквизитыToolStripMenuItem.Click += new System.EventHandler(this.просмотретьРеквизитыToolStripMenuItem_Click);
            // 
            // просмотретьКонтактыToolStripMenuItem
            // 
            this.просмотретьКонтактыToolStripMenuItem.Image = global::Test.Properties.Resources._1496547728_finger1;
            this.просмотретьКонтактыToolStripMenuItem.Name = "просмотретьКонтактыToolStripMenuItem";
            this.просмотретьКонтактыToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.просмотретьКонтактыToolStripMenuItem.Text = "Просмотреть контакты";
            this.просмотретьКонтактыToolStripMenuItem.Click += new System.EventHandler(this.просмотретьКонтактыToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers2;
            this.button2.Image = global::Test.Properties.Resources._1496547746_close2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1198, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "   Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers2;
            this.button1.Image = global::Test.Properties.Resources._1496547760_check;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1008, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "    Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // завод_изготовительTableAdapter
            // 
            this.завод_изготовительTableAdapter.ClearBeforeFill = true;
            // 
            // CatalogFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1381, 478);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CatalogFactory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заводы";
            this.Load += new System.EventHandler(this.Заводы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заводизготовительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem просмотретьРеквизитыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьКонтактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource заводизготовительBindingSource;
        private testDataSetTableAdapters.Завод_изготовительTableAdapter завод_изготовительTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзаводаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиезаводаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресзаводаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактныйтелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактныйemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кППDataGridViewTextBoxColumn;
    }
}