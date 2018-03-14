namespace Test
{
    partial class PriceList
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиемоделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cрокпоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прайслистBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Test.testDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьМодельВПрайслистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьМодельИзПрайслистаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайс_листTableAdapter = new Test.testDataSetTableAdapters.Прайс_листTableAdapter();
            this.изменитьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайслистBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers2;
            this.button2.Image = global::Test.Properties.Resources._1496547746_close21;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(708, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "   Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers21;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(9, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(860, 516);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Прайс-лист";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаDataGridViewTextBoxColumn,
            this.наименованиемоделиDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.cтоимостьDataGridViewTextBoxColumn,
            this.cрокпоставкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.прайслистBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(825, 476);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаDataGridViewTextBoxColumn.Width = 150;
            // 
            // наименованиемоделиDataGridViewTextBoxColumn
            // 
            this.наименованиемоделиDataGridViewTextBoxColumn.DataPropertyName = "Наименование_модели";
            this.наименованиемоделиDataGridViewTextBoxColumn.HeaderText = "Наименование модели";
            this.наименованиемоделиDataGridViewTextBoxColumn.Name = "наименованиемоделиDataGridViewTextBoxColumn";
            this.наименованиемоделиDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиемоделиDataGridViewTextBoxColumn.Width = 300;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_модели";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_модели";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // cтоимостьDataGridViewTextBoxColumn
            // 
            this.cтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Cтоимость";
            this.cтоимостьDataGridViewTextBoxColumn.HeaderText = "Cтоимость, руб.";
            this.cтоимостьDataGridViewTextBoxColumn.Name = "cтоимостьDataGridViewTextBoxColumn";
            this.cтоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.cтоимостьDataGridViewTextBoxColumn.Width = 180;
            // 
            // cрокпоставкиDataGridViewTextBoxColumn
            // 
            this.cрокпоставкиDataGridViewTextBoxColumn.DataPropertyName = "Cрок_поставки";
            this.cрокпоставкиDataGridViewTextBoxColumn.HeaderText = "Cрок поставки, дней";
            this.cрокпоставкиDataGridViewTextBoxColumn.Name = "cрокпоставкиDataGridViewTextBoxColumn";
            this.cрокпоставкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.cрокпоставкиDataGridViewTextBoxColumn.Width = 180;
            // 
            // прайслистBindingSource
            // 
            this.прайслистBindingSource.DataMember = "Прайс_лист";
            this.прайслистBindingSource.DataSource = this.testDataSet;
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
            this.добавитьМодельВПрайслистToolStripMenuItem,
            this.изменитьИнформациюToolStripMenuItem,
            this.удалитьМодельИзПрайслистаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьМодельВПрайслистToolStripMenuItem
            // 
            this.добавитьМодельВПрайслистToolStripMenuItem.Image = global::Test.Properties.Resources._1479950372_More;
            this.добавитьМодельВПрайслистToolStripMenuItem.Name = "добавитьМодельВПрайслистToolStripMenuItem";
            this.добавитьМодельВПрайслистToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.добавитьМодельВПрайслистToolStripMenuItem.Text = "Добавить модель в прайс-лист";
            this.добавитьМодельВПрайслистToolStripMenuItem.Click += new System.EventHandler(this.добавитьМодельВПрайслистToolStripMenuItem_Click);
            // 
            // удалитьМодельИзПрайслистаToolStripMenuItem
            // 
            this.удалитьМодельИзПрайслистаToolStripMenuItem.Image = global::Test.Properties.Resources._1479950367_Less;
            this.удалитьМодельИзПрайслистаToolStripMenuItem.Name = "удалитьМодельИзПрайслистаToolStripMenuItem";
            this.удалитьМодельИзПрайслистаToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.удалитьМодельИзПрайслистаToolStripMenuItem.Text = "Удалить модель";
            this.удалитьМодельИзПрайслистаToolStripMenuItem.Click += new System.EventHandler(this.удалитьМодельИзПрайслистаToolStripMenuItem_Click);
            // 
            // прайс_листTableAdapter
            // 
            this.прайс_листTableAdapter.ClearBeforeFill = true;
            // 
            // изменитьИнформациюToolStripMenuItem
            // 
            this.изменитьИнформациюToolStripMenuItem.Image = global::Test.Properties.Resources._1479950564_common_new_edit_compose_glyph;
            this.изменитьИнформациюToolStripMenuItem.Name = "изменитьИнформациюToolStripMenuItem";
            this.изменитьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.изменитьИнформациюToolStripMenuItem.Text = "Изменить информацию";
            this.изменитьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.изменитьИнформациюToolStripMenuItem_Click);
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PriceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПрайсЛистcs";
            this.Load += new System.EventHandler(this.ПрайсЛистcs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайслистBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDмоделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьМодельВПрайслистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьМодельИзПрайслистаToolStripMenuItem;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource прайслистBindingSource;
        private testDataSetTableAdapters.Прайс_листTableAdapter прайс_листTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиемоделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cрокпоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem изменитьИнформациюToolStripMenuItem;
    }
}