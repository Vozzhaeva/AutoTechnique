namespace Test.Forms
{
    partial class CatalogGroupTechnique
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDподгруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеподгруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDгруппыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKПодгруппаIDгр3B75D760BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группатехникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Test.testDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDгруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиегруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDотделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группа_техникиTableAdapter = new Test.testDataSetTableAdapters.Группа_техникиTableAdapter();
            this.подгруппаTableAdapter = new Test.testDataSetTableAdapters.ПодгруппаTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новуюГруппуТехникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новуюПодгруппуТехникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группуТехникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подгруппуТехникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбраннуюГруппуТехникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбраннуюПодгруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПодгруппаIDгр3B75D760BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группатехникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers21;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cправочник групп техники";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDподгруппыDataGridViewTextBoxColumn,
            this.названиеподгруппыDataGridViewTextBoxColumn,
            this.iDгруппыDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.fKПодгруппаIDгр3B75D760BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(563, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(504, 326);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDподгруппыDataGridViewTextBoxColumn
            // 
            this.iDподгруппыDataGridViewTextBoxColumn.DataPropertyName = "ID_подгруппы";
            this.iDподгруппыDataGridViewTextBoxColumn.HeaderText = "ID_подгруппы";
            this.iDподгруппыDataGridViewTextBoxColumn.Name = "iDподгруппыDataGridViewTextBoxColumn";
            this.iDподгруппыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDподгруппыDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеподгруппыDataGridViewTextBoxColumn
            // 
            this.названиеподгруппыDataGridViewTextBoxColumn.DataPropertyName = "Название_подгруппы";
            this.названиеподгруппыDataGridViewTextBoxColumn.HeaderText = "Название подгруппы";
            this.названиеподгруппыDataGridViewTextBoxColumn.Name = "названиеподгруппыDataGridViewTextBoxColumn";
            this.названиеподгруппыDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеподгруппыDataGridViewTextBoxColumn.Width = 500;
            // 
            // iDгруппыDataGridViewTextBoxColumn1
            // 
            this.iDгруппыDataGridViewTextBoxColumn1.DataPropertyName = "ID_группы";
            this.iDгруппыDataGridViewTextBoxColumn1.HeaderText = "ID_группы";
            this.iDгруппыDataGridViewTextBoxColumn1.Name = "iDгруппыDataGridViewTextBoxColumn1";
            this.iDгруппыDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDгруппыDataGridViewTextBoxColumn1.Visible = false;
            // 
            // fKПодгруппаIDгр3B75D760BindingSource
            // 
            this.fKПодгруппаIDгр3B75D760BindingSource.DataMember = "FK__Подгруппа__ID_гр__3B75D760";
            this.fKПодгруппаIDгр3B75D760BindingSource.DataSource = this.группатехникиBindingSource;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDгруппыDataGridViewTextBoxColumn,
            this.названиегруппыDataGridViewTextBoxColumn,
            this.iDотделаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.группатехникиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(531, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDгруппыDataGridViewTextBoxColumn
            // 
            this.iDгруппыDataGridViewTextBoxColumn.DataPropertyName = "ID_группы";
            this.iDгруппыDataGridViewTextBoxColumn.HeaderText = "ID_группы";
            this.iDгруппыDataGridViewTextBoxColumn.Name = "iDгруппыDataGridViewTextBoxColumn";
            this.iDгруппыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDгруппыDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиегруппыDataGridViewTextBoxColumn
            // 
            this.названиегруппыDataGridViewTextBoxColumn.DataPropertyName = "Название_группы";
            this.названиегруппыDataGridViewTextBoxColumn.HeaderText = "Название группы";
            this.названиегруппыDataGridViewTextBoxColumn.Name = "названиегруппыDataGridViewTextBoxColumn";
            this.названиегруппыDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиегруппыDataGridViewTextBoxColumn.Width = 500;
            // 
            // iDотделаDataGridViewTextBoxColumn
            // 
            this.iDотделаDataGridViewTextBoxColumn.DataPropertyName = "ID_отдела";
            this.iDотделаDataGridViewTextBoxColumn.HeaderText = "ID_отдела";
            this.iDотделаDataGridViewTextBoxColumn.Name = "iDотделаDataGridViewTextBoxColumn";
            this.iDотделаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDотделаDataGridViewTextBoxColumn.Visible = false;
            // 
            // группа_техникиTableAdapter
            // 
            this.группа_техникиTableAdapter.ClearBeforeFill = true;
            // 
            // подгруппаTableAdapter
            // 
            this.подгруппаTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers_org_ua_18616;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Image = global::Test.Properties.Resources._1496547746_close21;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(935, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "    Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новуюГруппуТехникиToolStripMenuItem,
            this.новуюПодгруппуТехникиToolStripMenuItem});
            this.добавитьToolStripMenuItem.Image = global::Test.Properties.Resources._1479950372_More;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // новуюГруппуТехникиToolStripMenuItem
            // 
            this.новуюГруппуТехникиToolStripMenuItem.Name = "новуюГруппуТехникиToolStripMenuItem";
            this.новуюГруппуТехникиToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.новуюГруппуТехникиToolStripMenuItem.Text = "Новую группу техники";
            this.новуюГруппуТехникиToolStripMenuItem.Click += new System.EventHandler(this.новуюГруппуТехникиToolStripMenuItem_Click);
            // 
            // новуюПодгруппуТехникиToolStripMenuItem
            // 
            this.новуюПодгруппуТехникиToolStripMenuItem.Name = "новуюПодгруппуТехникиToolStripMenuItem";
            this.новуюПодгруппуТехникиToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.новуюПодгруппуТехникиToolStripMenuItem.Text = "Новую подгруппу техники";
            this.новуюПодгруппуТехникиToolStripMenuItem.Click += new System.EventHandler(this.новуюПодгруппуТехникиToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.группуТехникиToolStripMenuItem,
            this.подгруппуТехникиToolStripMenuItem});
            this.изменитьToolStripMenuItem.Image = global::Test.Properties.Resources._1479950564_common_new_edit_compose_glyph;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // группуТехникиToolStripMenuItem
            // 
            this.группуТехникиToolStripMenuItem.Name = "группуТехникиToolStripMenuItem";
            this.группуТехникиToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.группуТехникиToolStripMenuItem.Text = "Группу техники";
            this.группуТехникиToolStripMenuItem.Click += new System.EventHandler(this.группуТехникиToolStripMenuItem_Click);
            // 
            // подгруппуТехникиToolStripMenuItem
            // 
            this.подгруппуТехникиToolStripMenuItem.Name = "подгруппуТехникиToolStripMenuItem";
            this.подгруппуТехникиToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.подгруппуТехникиToolStripMenuItem.Text = "Подгруппу техники";
            this.подгруппуТехникиToolStripMenuItem.Click += new System.EventHandler(this.подгруппуТехникиToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбраннуюГруппуТехникиToolStripMenuItem,
            this.выбраннуюПодгруппуToolStripMenuItem});
            this.удалитьToolStripMenuItem.Image = global::Test.Properties.Resources._1479950367_Less;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // выбраннуюГруппуТехникиToolStripMenuItem
            // 
            this.выбраннуюГруппуТехникиToolStripMenuItem.Name = "выбраннуюГруппуТехникиToolStripMenuItem";
            this.выбраннуюГруппуТехникиToolStripMenuItem.Size = new System.Drawing.Size(365, 26);
            this.выбраннуюГруппуТехникиToolStripMenuItem.Text = "Выбранную группу техники";
            this.выбраннуюГруппуТехникиToolStripMenuItem.Click += new System.EventHandler(this.выбраннуюГруппуТехникиToolStripMenuItem_Click);
            // 
            // выбраннуюПодгруппуToolStripMenuItem
            // 
            this.выбраннуюПодгруппуToolStripMenuItem.Name = "выбраннуюПодгруппуToolStripMenuItem";
            this.выбраннуюПодгруппуToolStripMenuItem.Size = new System.Drawing.Size(365, 26);
            this.выбраннуюПодгруппуToolStripMenuItem.Text = "Выбранную подгруппу техники";
            this.выбраннуюПодгруппуToolStripMenuItem.Click += new System.EventHandler(this.выбраннуюПодгруппуToolStripMenuItem_Click);
            // 
            // CatalogGroupTechnique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers_org_ua_18616;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 483);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CatalogGroupTechnique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalogGroupTechnique";
            this.Load += new System.EventHandler(this.CatalogGroupTechnique_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПодгруппаIDгр3B75D760BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группатехникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource группатехникиBindingSource;
        private testDataSetTableAdapters.Группа_техникиTableAdapter группа_техникиTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKПодгруппаIDгр3B75D760BindingSource;
        private testDataSetTableAdapters.ПодгруппаTableAdapter подгруппаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDподгруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеподгруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDгруппыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDгруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиегруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDотделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новуюГруппуТехникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новуюПодгруппуТехникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбраннуюГруппуТехникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбраннуюПодгруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группуТехникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подгруппуТехникиToolStripMenuItem;
    }
}