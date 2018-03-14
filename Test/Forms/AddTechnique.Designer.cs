namespace Test
{
    partial class AddTechnique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTechnique));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.подгруппаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Test.testDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.подгруппаTableAdapter = new Test.testDataSetTableAdapters.ПодгруппаTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.заводизготовительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.завод_изготовительTableAdapter = new Test.testDataSetTableAdapters.Завод_изготовительTableAdapter();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new Test.testDataSetTableAdapters.СотрудникTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Характеристика = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.техническаяхарактеристикаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Значение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.техническая_характеристикаTableAdapter = new Test.testDataSetTableAdapters.Техническая_характеристикаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.подгруппаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заводизготовительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.техническаяхарактеристикаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.подгруппаBindingSource;
            this.comboBox1.DisplayMember = "Название_подгруппы";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(297, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(468, 26);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "ID_подгруппы";
            // 
            // подгруппаBindingSource
            // 
            this.подгруппаBindingSource.DataMember = "Подгруппа";
            this.подгруппаBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 44);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 24);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Выберете подгруппу техники:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите название модели:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = global::Test.Properties.Resources._1496547760_check;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(475, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "    Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // подгруппаTableAdapter
            // 
            this.подгруппаTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Выберете завод-изготовитель:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.заводизготовительBindingSource;
            this.comboBox2.DisplayMember = "Наименование_завода";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(297, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(468, 26);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "ID_завода";
            // 
            // заводизготовительBindingSource
            // 
            this.заводизготовительBindingSource.DataMember = "Завод_изготовитель";
            this.заводизготовительBindingSource.DataSource = this.testDataSet;
            // 
            // завод_изготовительTableAdapter
            // 
            this.завод_изготовительTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.testDataSet;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers21;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 396);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить модель техники";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Задайте технические характеристики модели:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Характеристика,
            this.Значение});
            this.dataGridView1.Location = new System.Drawing.Point(16, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 203);
            this.dataGridView1.TabIndex = 18;
            // 
            // Характеристика
            // 
            this.Характеристика.DataSource = this.техническаяхарактеристикаBindingSource;
            this.Характеристика.DisplayMember = "Название_характеристики";
            this.Характеристика.HeaderText = "Характеристика";
            this.Характеристика.Name = "Характеристика";
            this.Характеристика.ValueMember = "ID_характеристики";
            this.Характеристика.Width = 500;
            // 
            // техническаяхарактеристикаBindingSource
            // 
            this.техническаяхарактеристикаBindingSource.DataMember = "Техническая_характеристика";
            this.техническаяхарактеристикаBindingSource.DataSource = this.testDataSet;
            // 
            // Значение
            // 
            this.Значение.HeaderText = "Значение";
            this.Значение.MaxInputLength = 300;
            this.Значение.Name = "Значение";
            this.Значение.Width = 200;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Image = global::Test.Properties.Resources._1496547746_close2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(636, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "    Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // техническая_характеристикаTableAdapter
            // 
            this.техническая_характеристикаTableAdapter.ClearBeforeFill = true;
            // 
            // AddTechnique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Test.Properties.Resources.desktopwallpapers1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 476);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTechnique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить модель техники";
            this.Load += new System.EventHandler(this.ДобавитьМодель_Load);
            ((System.ComponentModel.ISupportInitialize)(this.подгруппаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заводизготовительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.техническаяхарактеристикаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource подгруппаBindingSource;
        private testDataSetTableAdapters.ПодгруппаTableAdapter подгруппаTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource заводизготовительBindingSource;
        private testDataSetTableAdapters.Завод_изготовительTableAdapter завод_изготовительTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private testDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource техническаяхарактеристикаBindingSource;
        private testDataSetTableAdapters.Техническая_характеристикаTableAdapter техническая_характеристикаTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn Характеристика;
        private System.Windows.Forms.DataGridViewTextBoxColumn Значение;
        private System.Windows.Forms.Label label4;
    }
}