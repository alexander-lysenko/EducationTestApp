﻿namespace TESTER
{
    partial class RegisterForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(){
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Test_CB = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Subject_CB = new System.Windows.Forms.ComboBox();
            this.EI_CB = new System.Windows.Forms.ComboBox();
            this.FIO_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.God_mode = new System.Windows.Forms.Label();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(489, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "© 2015 Компания Физмата. Все авторские права пока отсутствуют.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Название теста";
            // 
            // Test_CB
            // 
            this.Test_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Test_CB.FormattingEnabled = true;
            this.Test_CB.Items.AddRange(new object[] {
            "(Сначала выберите предмет)"});
            this.Test_CB.Location = new System.Drawing.Point(143, 200);
            this.Test_CB.Name = "Test_CB";
            this.Test_CB.Size = new System.Drawing.Size(357, 21);
            this.Test_CB.TabIndex = 5;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(64, 238);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(389, 61);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Начать тест!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Subject_CB
            // 
            this.Subject_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject_CB.FormattingEnabled = true;
            this.Subject_CB.Location = new System.Drawing.Point(143, 172);
            this.Subject_CB.Name = "Subject_CB";
            this.Subject_CB.Size = new System.Drawing.Size(357, 21);
            this.Subject_CB.TabIndex = 4;
            this.Subject_CB.Tag = "";
            this.Subject_CB.SelectedIndexChanged += new System.EventHandler(this.Subject_CB_SelectedIndexChanged);
            // 
            // EI_CB
            // 
            this.EI_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EI_CB.FormattingEnabled = true;
            this.EI_CB.Items.AddRange(new object[] {
            "ГОУ \"ВИМО ПМР им. А.И. Лебедя\"",
            "ГОУ \"ПГУ им. Т.Г. Шевченко\"",
            "ГОУ \"ТМУ\"",
            "ГОУ \"ТЮИ МВД ПМР\"",
            "МОУ \"Бендерская гимназия №2\"",
            "МОУ \"Бендерский теоретический лицей №1\"",
            "МОУ \"Краснянская СОШ\""});
            this.EI_CB.Location = new System.Drawing.Point(143, 145);
            this.EI_CB.Name = "EI_CB";
            this.EI_CB.Size = new System.Drawing.Size(357, 21);
            this.EI_CB.Sorted = true;
            this.EI_CB.TabIndex = 3;
            // 
            // FIO_TextBox
            // 
            this.FIO_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIO_TextBox.Location = new System.Drawing.Point(143, 93);
            this.FIO_TextBox.Name = "FIO_TextBox";
            this.FIO_TextBox.Size = new System.Drawing.Size(357, 20);
            this.FIO_TextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Сдаваемый предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Учебное заведение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ваши ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Добро пожаловать в EduQual Test!";
            // 
            // God_mode
            // 
            this.God_mode.AutoSize = true;
            this.God_mode.BackColor = System.Drawing.Color.Transparent;
            this.God_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.God_mode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.God_mode.Location = new System.Drawing.Point(437, 308);
            this.God_mode.Name = "God_mode";
            this.God_mode.Size = new System.Drawing.Size(67, 13);
            this.God_mode.TabIndex = 22;
            this.God_mode.Text = "God\' mode";
            this.God_mode.Click += new System.EventHandler(this.God_mode_Click);
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_TextBox.Location = new System.Drawing.Point(143, 119);
            this.ID_TextBox.MaxLength = 16;
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(357, 20);
            this.ID_TextBox.TabIndex = 2;
            this.ID_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_TextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Идентификационный\r\nномер";
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TESTER.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(513, 336);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.God_mode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Test_CB);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Subject_CB);
            this.Controls.Add(this.EI_CB);
            this.Controls.Add(this.FIO_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа тестирования учащихся EduQual Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label God_mode;
        public System.Windows.Forms.ComboBox Test_CB;
        public System.Windows.Forms.ComboBox Subject_CB;
        public System.Windows.Forms.ComboBox EI_CB;
        public System.Windows.Forms.TextBox FIO_TextBox;
        public System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.Label label7;
    }
}