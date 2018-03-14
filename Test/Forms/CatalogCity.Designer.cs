namespace Test
{
    partial class CatalogCity
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьНовыйГородToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDгородаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиегородаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.километраждогородаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Test.testDataSet();
            this.городTableAdapter = new Test.testDataSetTableAdapters.ГородTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовыйГородToolStripMenuItem,
            this.изменитьИнформациюToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьНовыйГородToolStripMenuItem
            // 
            this.добавитьНовыйГородToolStripMenuItem.Image = global::Test.Properties.Resources._1479950372_More;
            this.добавитьНовыйГородToolStripMenuItem.Name = "добавитьНовыйГородToolStripMenuItem";
            this.добавитьНовыйГородToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.добавитьНовыйГородToolStripMenuItem.Text = "Добавить город";
            this.добавитьНовыйГородToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовыйГородToolStripMenuItem_Click);
            // 
            // изменитьИнформациюToolStripMenuItem
            // 
            this.изменитьИнформациюToolStripMenuItem.Image = global::Test.Properties.Resources._1479950564_common_new_edit_compose_glyph;
            this.изменитьИнформациюToolStripMenuItem.Name = "изменитьИнформациюToolStripMenuItem";
            this.изменитьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.изменитьИнформациюToolStripMenuItem.Text = "Изменить информацию";
            this.изменитьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.изменитьИнформациюToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Image = global::Test.Properties.Resources._1479950367_Less;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDгородаDataGridViewTextBoxColumn,
            this.названиегородаDataGridViewTextBoxColumn,
            this.километраждогородаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.городBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(555, 301);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDгородаDataGridViewTextBoxColumn
            // 
            this.iDгородаDataGridViewTextBoxColumn.DataPropertyName = "ID_города";
            this.iDгородаDataGridViewTextBoxColumn.HeaderText = "ID_города";
            this.iDгородаDataGridViewTextBoxColumn.Name = "iDгородаDataGridViewTextBoxColumn";
            this.iDгородаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDгородаDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиегородаDataGridViewTextBoxColumn
            // 
            this.названиегородаDataGridViewTextBoxColumn.DataPropertyName = "Название_города";
            this.названиегородаDataGridViewTextBoxColumn.HeaderText = "Название города";
            this.названиегородаDataGridViewTextBoxColumn.Name = "названиегородаDataGridViewTextBoxColumn";
            this.названиегородаDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиегородаDataGridViewTextBoxColumn.Width = 300;
            // 
            // километраждогородаDataGridViewTextBoxColumn
            // 
            this.километраждогородаDataGridViewTextBoxColumn.DataPropertyName = "Километраж_до_города";
            this.километраждогородаDataGridViewTextBoxColumn.HeaderText = "Километраж до города";
            this.километраждогородаDataGridViewTextBoxColumn.Name = "километраждогородаDataGridViewTextBoxColumn";
            this.километраждогородаDataGridViewTextBoxColumn.ReadOnly = true;
            this.километраждогородаDataGridViewTextBoxColumn.Width = 250;
            // 
            // городBindingSource
            // 
            this.городBindingSource.DataMember = "Город";
            this.городBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // городTableAdapter
            // 
            this.городTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers_org_ua_18616;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Image = global::Test.Properties.Resources._1496547746_close21;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(415, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "    Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CatalogCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.ClientSize = new System.Drawing.Size(580, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CatalogCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalogCity";
            this.Load += new System.EventHandler(this.CatalogCity_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource городBindingSource;
        private testDataSetTableAdapters.ГородTableAdapter городTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовыйГородToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDгородаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиегородаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn километраждогородаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}