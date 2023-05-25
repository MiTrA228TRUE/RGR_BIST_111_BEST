namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_cols = new System.Windows.Forms.TextBox();
            this.tb_rows = new System.Windows.Forms.TextBox();
            this.tb_number_start = new System.Windows.Forms.TextBox();
            this.tb_number_end = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.tb_help = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.tb_run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.input_k = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.tb6 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_cols
            // 
            this.tb_cols.BackColor = System.Drawing.Color.LemonChiffon;
            this.tb_cols.Location = new System.Drawing.Point(360, 15);
            this.tb_cols.Name = "tb_cols";
            this.tb_cols.Size = new System.Drawing.Size(144, 27);
            this.tb_cols.TabIndex = 0;
            this.tb_cols.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cols_KeyPress);
            // 
            // tb_rows
            // 
            this.tb_rows.BackColor = System.Drawing.Color.LemonChiffon;
            this.tb_rows.Location = new System.Drawing.Point(360, 56);
            this.tb_rows.Name = "tb_rows";
            this.tb_rows.Size = new System.Drawing.Size(145, 27);
            this.tb_rows.TabIndex = 0;
            this.tb_rows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_rows_KeyPress);
            // 
            // tb_number_start
            // 
            this.tb_number_start.BackColor = System.Drawing.Color.LemonChiffon;
            this.tb_number_start.Location = new System.Drawing.Point(680, 60);
            this.tb_number_start.Name = "tb_number_start";
            this.tb_number_start.Size = new System.Drawing.Size(163, 27);
            this.tb_number_start.TabIndex = 1;
            this.tb_number_start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_number_start_KeyPress);
            // 
            // tb_number_end
            // 
            this.tb_number_end.BackColor = System.Drawing.Color.LemonChiffon;
            this.tb_number_end.Location = new System.Drawing.Point(938, 60);
            this.tb_number_end.Name = "tb_number_end";
            this.tb_number_end.Size = new System.Drawing.Size(163, 27);
            this.tb_number_end.TabIndex = 2;
            this.tb_number_end.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_number_end_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cakra Normal", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(510, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 105);
            this.button1.TabIndex = 3;
            this.button1.Text = "СОЗДАНИЕ МАССИВА";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(3, 6);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(611, 414);
            this.dgv1.TabIndex = 4;
            // 
            // tb_output
            // 
            this.tb_output.BackColor = System.Drawing.Color.LemonChiffon;
            this.tb_output.Location = new System.Drawing.Point(868, 126);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.Size = new System.Drawing.Size(368, 432);
            this.tb_output.TabIndex = 5;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Cakra Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb1.Location = new System.Drawing.Point(689, 358);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(145, 29);
            this.rb1.TabIndex = 6;
            this.rb1.TabStop = true;
            this.rb1.Text = "ЗАДАНИЕ 12";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Cakra Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb2.Location = new System.Drawing.Point(689, 428);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(154, 29);
            this.rb2.TabIndex = 7;
            this.rb2.TabStop = true;
            this.rb2.Text = "ЗАДАНИЕ 29 ";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Cakra Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb3.Location = new System.Drawing.Point(689, 288);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(140, 29);
            this.rb3.TabIndex = 8;
            this.rb3.TabStop = true;
            this.rb3.Text = "ЗАДАНИЕ 1 ";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Cakra Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb4.Location = new System.Drawing.Point(689, 393);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(145, 29);
            this.rb4.TabIndex = 9;
            this.rb4.TabStop = true;
            this.rb4.Text = "ЗАДАНИЕ 18";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Cakra Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb5.Location = new System.Drawing.Point(689, 463);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(147, 29);
            this.rb5.TabIndex = 10;
            this.rb5.TabStop = true;
            this.rb5.Text = "ЗАДАНИЕ 35";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // tb_help
            // 
            this.tb_help.Font = new System.Drawing.Font("Lucida Handwriting", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_help.Location = new System.Drawing.Point(1117, 15);
            this.tb_help.Name = "tb_help";
            this.tb_help.Size = new System.Drawing.Size(119, 68);
            this.tb_help.TabIndex = 11;
            this.tb_help.Text = "HELP";
            this.tb_help.UseVisualStyleBackColor = true;
            this.tb_help.Click += new System.EventHandler(this.tb_help_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Cakra Normal", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button_save.Location = new System.Drawing.Point(10, 578);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(283, 47);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "ЭКСПОРТ";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("Cakra Normal", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button_open.Location = new System.Drawing.Point(360, 578);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(283, 47);
            this.button_open.TabIndex = 13;
            this.button_open.Text = "ИМПОРТ";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // tb_run
            // 
            this.tb_run.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_run.FlatAppearance.BorderSize = 5;
            this.tb_run.Font = new System.Drawing.Font("Cakra Normal", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_run.Location = new System.Drawing.Point(689, 213);
            this.tb_run.Name = "tb_run";
            this.tb_run.Size = new System.Drawing.Size(163, 69);
            this.tb_run.TabIndex = 14;
            this.tb_run.Text = "ВЫПОЛНИТЬ ЗАДАНИЕ";
            this.tb_run.UseVisualStyleBackColor = true;
            this.tb_run.Click += new System.EventHandler(this.tb_run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cakra Normal", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "КОЛИЧЕСТВО СТРОК";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cakra Normal", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "КОЛИЧЕСТВО СТОЛБЦОВ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cakra Normal", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(677, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "ИНТЕРВАЛ ЗНАЧЕНИЕ РАНДОМА";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.input_k);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_run);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.button_save);
            this.groupBox1.Controls.Add(this.tb_help);
            this.groupBox1.Controls.Add(this.tb6);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.tb_output);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_number_end);
            this.groupBox1.Controls.Add(this.tb_number_start);
            this.groupBox1.Controls.Add(this.tb_rows);
            this.groupBox1.Controls.Add(this.tb_cols);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Cakra Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1242, 651);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // input_k
            // 
            this.input_k.ForeColor = System.Drawing.Color.OrangeRed;
            this.input_k.Location = new System.Drawing.Point(689, 519);
            this.input_k.Name = "input_k";
            this.input_k.Size = new System.Drawing.Size(140, 27);
            this.input_k.TabIndex = 18;
            this.input_k.Text = "Введите k";
            this.input_k.Visible = false;
            this.input_k.Enter += new System.EventHandler(this.input_k_Enter);
            this.input_k.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_k_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 464);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основной массив";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Измененный массив";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(4, 6);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowTemplate.Height = 25;
            this.dgv2.Size = new System.Drawing.Size(613, 414);
            this.dgv2.TabIndex = 0;
            // 
            // tb6
            // 
            this.tb6.AutoSize = true;
            this.tb6.Font = new System.Drawing.Font("Cakra Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb6.Location = new System.Drawing.Point(689, 323);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(137, 29);
            this.tb6.TabIndex = 10;
            this.tb6.TabStop = true;
            this.tb6.Text = "ЗАДАНИЕ 7";
            this.tb6.UseVisualStyleBackColor = true;
            this.tb6.Enter += new System.EventHandler(this.tb6_Enter);
            this.tb6.Leave += new System.EventHandler(this.tb6_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 675);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RGR-12";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_cols;
        private TextBox tb_rows;
        private TextBox tb_number_start;
        private TextBox tb_number_end;
        private Button button1;
        private TextBox tb_output;
        private RadioButton rb1;
        private RadioButton rb2;
        private RadioButton rb3;
        private RadioButton rb4;
        private RadioButton rb5;
        private Button tb_help;
        private Button button_save;
        private Button button_open;
        private Button tb_run;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        public DataGridView dgv1;
        private DataGridView dgv2;
        private RadioButton tb6;
        private TextBox input_k;
    }
}