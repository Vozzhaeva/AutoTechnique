namespace Test
{
    partial class ViewContact
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testDataSet = new Test.testDataSet();
            this.контактBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.контактTableAdapter = new Test.testDataSetTableAdapters.КонтактTableAdapter();
            this.iDзаводаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпопорядкуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактноелицоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактныйemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Контакты завода-изготовителя:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Image = global::Test.Properties.Resources._1496547746_close21;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(860, 256);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "   Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.номерпопорядкуDataGridViewTextBoxColumn,
            this.контактноелицоDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn,
            this.контактныйemailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.контактBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 186);
            this.dataGridView1.TabIndex = 9;
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
            this.menuStrip1.Size = new System.Drawing.Size(1035, 30);
            this.menuStrip1.TabIndex = 12;
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
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // контактBindingSource
            // 
            this.контактBindingSource.DataMember = "Контакт";
            this.контактBindingSource.DataSource = this.testDataSet;
            // 
            // контактTableAdapter
            // 
            this.контактTableAdapter.ClearBeforeFill = true;
            // 
            // iDзаводаDataGridViewTextBoxColumn
            // 
            this.iDзаводаDataGridViewTextBoxColumn.DataPropertyName = "ID_завода";
            this.iDзаводаDataGridViewTextBoxColumn.HeaderText = "ID_завода";
            this.iDзаводаDataGridViewTextBoxColumn.Name = "iDзаводаDataGridViewTextBoxColumn";
            this.iDзаводаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDзаводаDataGridViewTextBoxColumn.Visible = false;
            // 
            // номерпопорядкуDataGridViewTextBoxColumn
            // 
            this.номерпопорядкуDataGridViewTextBoxColumn.DataPropertyName = "Номер_по_порядку";
            this.номерпопорядкуDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерпопорядкуDataGridViewTextBoxColumn.Name = "номерпопорядкуDataGridViewTextBoxColumn";
            this.номерпопорядкуDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // контактноелицоDataGridViewTextBoxColumn
            // 
            this.контактноелицоDataGridViewTextBoxColumn.DataPropertyName = "Контактное_лицо";
            this.контактноелицоDataGridViewTextBoxColumn.HeaderText = "Контактное лицо";
            this.контактноелицоDataGridViewTextBoxColumn.Name = "контактноелицоDataGridViewTextBoxColumn";
            this.контактноелицоDataGridViewTextBoxColumn.ReadOnly = true;
            this.контактноелицоDataGridViewTextBoxColumn.Width = 300;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.должностьDataGridViewTextBoxColumn.Width = 200;
            // 
            // номертелефонаDataGridViewTextBoxColumn
            // 
            this.номертелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.HeaderText = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.Name = "номертелефонаDataGridViewTextBoxColumn";
            this.номертелефонаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номертелефонаDataGridViewTextBoxColumn.Width = 200;
            // 
            // контактныйemailDataGridViewTextBoxColumn
            // 
            this.контактныйemailDataGridViewTextBoxColumn.DataPropertyName = "Контактный_email";
            this.контактныйemailDataGridViewTextBoxColumn.HeaderText = "Контактный email";
            this.контактныйemailDataGridViewTextBoxColumn.Name = "контактныйemailDataGridViewTextBoxColumn";
            this.контактныйemailDataGridViewTextBoxColumn.ReadOnly = true;
            this.контактныйemailDataGridViewTextBoxColumn.Width = 200;
            // 
            // ViewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewContact";
            this.Load += new System.EventHandler(this.ViewContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзаводаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпопорядкуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактноелицоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактныйemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource контактBindingSource;
        private testDataSet testDataSet;
        private testDataSetTableAdapters.КонтактTableAdapter контактTableAdapter;
    }
}