namespace WindowsFormsApplication1
{
    partial class Hotels
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.продажиDataGridView = new System.Windows.Forms.DataGridView();
            this.turDataSet = new WindowsFormsApplication1.TurDataSet();
            this.гостиницыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.гостиницыTableAdapter = new WindowsFormsApplication1.TurDataSetTableAdapters.ГостиницыTableAdapter();
            this.кодгостиницыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колзвездDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продажиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гостиницыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(631, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 265);
            this.panel1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "ФИО";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(195, 76);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(263, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 116);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тур";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "След.";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(195, 174);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(264, 28);
            this.button5.TabIndex = 6;
            this.button5.Text = "Сохранить изменения";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Пред.";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(359, 209);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 209);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Новая";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // продажиDataGridView
            // 
            this.продажиDataGridView.AutoGenerateColumns = false;
            this.продажиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.продажиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодгостиницыDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.колзвездDataGridViewTextBoxColumn});
            this.продажиDataGridView.DataSource = this.гостиницыBindingSource;
            this.продажиDataGridView.Location = new System.Drawing.Point(13, 36);
            this.продажиDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.продажиDataGridView.Name = "продажиDataGridView";
            this.продажиDataGridView.RowHeadersWidth = 51;
            this.продажиDataGridView.Size = new System.Drawing.Size(556, 269);
            this.продажиDataGridView.TabIndex = 10;
            // 
            // turDataSet
            // 
            this.turDataSet.DataSetName = "TurDataSet";
            this.turDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // гостиницыBindingSource
            // 
            this.гостиницыBindingSource.DataMember = "Гостиницы";
            this.гостиницыBindingSource.DataSource = this.turDataSet;
            // 
            // гостиницыTableAdapter
            // 
            this.гостиницыTableAdapter.ClearBeforeFill = true;
            // 
            // кодгостиницыDataGridViewTextBoxColumn
            // 
            this.кодгостиницыDataGridViewTextBoxColumn.DataPropertyName = "Код_гостиницы";
            this.кодгостиницыDataGridViewTextBoxColumn.HeaderText = "Код_гостиницы";
            this.кодгостиницыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодгостиницыDataGridViewTextBoxColumn.Name = "кодгостиницыDataGridViewTextBoxColumn";
            this.кодгостиницыDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодгостиницыDataGridViewTextBoxColumn.Width = 125;
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            this.странаDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // колзвездDataGridViewTextBoxColumn
            // 
            this.колзвездDataGridViewTextBoxColumn.DataPropertyName = "Кол_звезд";
            this.колзвездDataGridViewTextBoxColumn.HeaderText = "Кол_звезд";
            this.колзвездDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.колзвездDataGridViewTextBoxColumn.Name = "колзвездDataGridViewTextBoxColumn";
            this.колзвездDataGridViewTextBoxColumn.Width = 125;
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 337);
            this.Controls.Add(this.продажиDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Hotels";
            this.Text = "Hotels";
            this.Load += new System.EventHandler(this.Hotels_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продажиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гостиницыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView продажиDataGridView;
        private TurDataSet turDataSet;
        private System.Windows.Forms.BindingSource гостиницыBindingSource;
        private TurDataSetTableAdapters.ГостиницыTableAdapter гостиницыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодгостиницыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колзвездDataGridViewTextBoxColumn;
    }
}