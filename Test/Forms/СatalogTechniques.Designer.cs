namespace Test
{
    partial class СatalogTechniques
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
            this.названиегруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группатехникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Test.testDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.названиеподгруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKПодгруппаIDгр3B75D760BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDмоделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиемоделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDподгруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDзаводаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKТехникаIDподг0880433FBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Обновить = new System.Windows.Forms.Button();
            this.Выйти = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.группа_техникиTableAdapter = new Test.testDataSetTableAdapters.Группа_техникиTableAdapter();
            this.подгруппаTableAdapter = new Test.testDataSetTableAdapters.ПодгруппаTableAdapter();
            this.техникаTableAdapter = new Test.testDataSetTableAdapters.ТехникаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группатехникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПодгруппаIDгр3B75D760BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKТехникаIDподг0880433FBindingSource)).BeginInit();
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
            this.названиегруппыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.группатехникиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 399);
            this.dataGridView1.TabIndex = 1;
            // 
            // названиегруппыDataGridViewTextBoxColumn
            // 
            this.названиегруппыDataGridViewTextBoxColumn.DataPropertyName = "Название_группы";
            this.названиегруппыDataGridViewTextBoxColumn.HeaderText = "Название группы";
            this.названиегруппыDataGridViewTextBoxColumn.Name = "названиегруппыDataGridViewTextBoxColumn";
            this.названиегруппыDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиегруппыDataGridViewTextBoxColumn.Width = 400;
            // 
            // группатехникиBindingSource
            // 
            this.группатехникиBindingSource.DataMember = "Группа_техники";
            this.группатехникиBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеподгруппыDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKПодгруппаIDгр3B75D760BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(434, 41);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(413, 399);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // названиеподгруппыDataGridViewTextBoxColumn
            // 
            this.названиеподгруппыDataGridViewTextBoxColumn.DataPropertyName = "Название_подгруппы";
            this.названиеподгруппыDataGridViewTextBoxColumn.HeaderText = "Название подгруппы";
            this.названиеподгруппыDataGridViewTextBoxColumn.Name = "названиеподгруппыDataGridViewTextBoxColumn";
            this.названиеподгруппыDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеподгруппыDataGridViewTextBoxColumn.Width = 400;
            // 
            // fKПодгруппаIDгр3B75D760BindingSource
            // 
            this.fKПодгруппаIDгр3B75D760BindingSource.DataMember = "FK__Подгруппа__ID_гр__3B75D760";
            this.fKПодгруппаIDгр3B75D760BindingSource.DataSource = this.группатехникиBindingSource;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDмоделиDataGridViewTextBoxColumn,
            this.наименованиемоделиDataGridViewTextBoxColumn,
            this.iDподгруппыDataGridViewTextBoxColumn,
            this.iDзаводаDataGridViewTextBoxColumn,
            this.iDсотрудникаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.fKТехникаIDподг0880433FBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(855, 41);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(413, 399);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // iDмоделиDataGridViewTextBoxColumn
            // 
            this.iDмоделиDataGridViewTextBoxColumn.DataPropertyName = "ID_модели";
            this.iDмоделиDataGridViewTextBoxColumn.HeaderText = "ID_модели";
            this.iDмоделиDataGridViewTextBoxColumn.Name = "iDмоделиDataGridViewTextBoxColumn";
            this.iDмоделиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDмоделиDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиемоделиDataGridViewTextBoxColumn
            // 
            this.наименованиемоделиDataGridViewTextBoxColumn.DataPropertyName = "Наименование_модели";
            this.наименованиемоделиDataGridViewTextBoxColumn.HeaderText = "Наименование модели";
            this.наименованиемоделиDataGridViewTextBoxColumn.Name = "наименованиемоделиDataGridViewTextBoxColumn";
            this.наименованиемоделиDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиемоделиDataGridViewTextBoxColumn.Width = 400;
            // 
            // iDподгруппыDataGridViewTextBoxColumn
            // 
            this.iDподгруппыDataGridViewTextBoxColumn.DataPropertyName = "ID_подгруппы";
            this.iDподгруппыDataGridViewTextBoxColumn.HeaderText = "ID_подгруппы";
            this.iDподгруппыDataGridViewTextBoxColumn.Name = "iDподгруппыDataGridViewTextBoxColumn";
            this.iDподгруппыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDподгруппыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDзаводаDataGridViewTextBoxColumn
            // 
            this.iDзаводаDataGridViewTextBoxColumn.DataPropertyName = "ID_завода";
            this.iDзаводаDataGridViewTextBoxColumn.HeaderText = "ID_завода";
            this.iDзаводаDataGridViewTextBoxColumn.Name = "iDзаводаDataGridViewTextBoxColumn";
            this.iDзаводаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDзаводаDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDсотрудникаDataGridViewTextBoxColumn
            // 
            this.iDсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ID_сотрудника";
            this.iDсотрудникаDataGridViewTextBoxColumn.HeaderText = "ID_сотрудника";
            this.iDсотрудникаDataGridViewTextBoxColumn.Name = "iDсотрудникаDataGridViewTextBoxColumn";
            this.iDсотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDсотрудникаDataGridViewTextBoxColumn.Visible = false;
            // 
            // fKТехникаIDподг0880433FBindingSource
            // 
            this.fKТехникаIDподг0880433FBindingSource.DataMember = "FK__Техника__ID_подг__0880433F";
            this.fKТехникаIDподг0880433FBindingSource.DataSource = this.fKПодгруппаIDгр3B75D760BindingSource;
            // 
            // Обновить
            // 
            this.Обновить.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers21;
            this.Обновить.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Обновить.Image = global::Test.Properties.Resources._1496547806_download;
            this.Обновить.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Обновить.Location = new System.Drawing.Point(923, 496);
            this.Обновить.Name = "Обновить";
            this.Обновить.Size = new System.Drawing.Size(177, 45);
            this.Обновить.TabIndex = 4;
            this.Обновить.Text = "   Обновить";
            this.Обновить.UseVisualStyleBackColor = true;
            this.Обновить.Click += new System.EventHandler(this.Обновить_Click);
            // 
            // Выйти
            // 
            this.Выйти.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers21;
            this.Выйти.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Выйти.Image = global::Test.Properties.Resources._1496547746_close2;
            this.Выйти.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Выйти.Location = new System.Drawing.Point(1116, 496);
            this.Выйти.Name = "Выйти";
            this.Выйти.Size = new System.Drawing.Size(152, 45);
            this.Выйти.TabIndex = 5;
            this.Выйти.Text = "   Выйти";
            this.Выйти.UseVisualStyleBackColor = true;
            this.Выйти.Click += new System.EventHandler(this.Выйти_Click);
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
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1285, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавитьToolStripMenuItem.Image = global::Test.Properties.Resources._1479950372_More;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить модель техники";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.удалитьToolStripMenuItem.Image = global::Test.Properties.Resources._1479950367_Less;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить выбранную модель";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(969, 455);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(299, 18);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Дополнительная информация о модели";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // группа_техникиTableAdapter
            // 
            this.группа_техникиTableAdapter.ClearBeforeFill = true;
            // 
            // подгруппаTableAdapter
            // 
            this.подгруппаTableAdapter.ClearBeforeFill = true;
            // 
            // техникаTableAdapter
            // 
            this.техникаTableAdapter.ClearBeforeFill = true;
            // 
            // СatalogTechniques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 560);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Выйти);
            this.Controls.Add(this.Обновить);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "СatalogTechniques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Техника";
            this.Load += new System.EventHandler(this.Техника_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группатехникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПодгруппаIDгр3B75D760BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKТехникаIDподг0880433FBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button Обновить;
        private System.Windows.Forms.Button Выйти;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource группатехникиBindingSource;
        private testDataSetTableAdapters.Группа_техникиTableAdapter группа_техникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиегруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKПодгруппаIDгр3B75D760BindingSource;
        private testDataSetTableAdapters.ПодгруппаTableAdapter подгруппаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеподгруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKТехникаIDподг0880433FBindingSource;
        private testDataSetTableAdapters.ТехникаTableAdapter техникаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDмоделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиемоделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDподгруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзаводаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDсотрудникаDataGridViewTextBoxColumn;
    }
}