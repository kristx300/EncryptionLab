namespace EncryptionLab.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alphabetBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.decodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // methodBox
            // 
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "Шифр Цезаря",
            "Метод многоалфавитной замены",
            "Метод блочной перестановки"});
            this.methodBox.Location = new System.Drawing.Point(12, 23);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(121, 21);
            this.methodBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Метод";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(12, 64);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(121, 20);
            this.valueBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Алфавит";
            // 
            // alphabetBox
            // 
            this.alphabetBox.FormattingEnabled = true;
            this.alphabetBox.Items.AddRange(new object[] {
            "Английский",
            "Русский"});
            this.alphabetBox.Location = new System.Drawing.Point(139, 23);
            this.alphabetBox.Name = "alphabetBox";
            this.alphabetBox.Size = new System.Drawing.Size(121, 21);
            this.alphabetBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ключ/смещение";
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(139, 64);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(121, 20);
            this.keyBox.TabIndex = 6;
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(12, 90);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(121, 40);
            this.encodeButton.TabIndex = 8;
            this.encodeButton.Text = "Зашифровать";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 149);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(248, 82);
            this.resultBox.TabIndex = 9;
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(139, 90);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(121, 40);
            this.decodeButton.TabIndex = 11;
            this.decodeButton.Text = "Расшифровать";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 243);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alphabetBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.methodBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox alphabetBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button decodeButton;
    }
}

