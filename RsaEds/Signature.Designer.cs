namespace RsaEds
{
    partial class Signature
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signature));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.digest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.decrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encrypt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.hash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.keys = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 23);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(200, 150);
            this.textBox.TabIndex = 1;
            this.textBox.Text = resources.GetString("textBox.Text");
            // 
            // digest
            // 
            this.digest.Location = new System.Drawing.Point(218, 23);
            this.digest.Multiline = true;
            this.digest.Name = "digest";
            this.digest.Size = new System.Drawing.Size(200, 150);
            this.digest.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дайджест";
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(218, 284);
            this.decrypt.Multiline = true;
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(200, 70);
            this.decrypt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Decrypt";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(12, 192);
            this.encrypt.Multiline = true;
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(200, 162);
            this.encrypt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Encrypt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Получить дайджест и хэш";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Шифрование";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(424, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Дешифрование";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hash
            // 
            this.hash.Location = new System.Drawing.Point(218, 192);
            this.hash.Multiline = true;
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(200, 70);
            this.hash.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Хэшкод";
            // 
            // keys
            // 
            this.keys.Location = new System.Drawing.Point(424, 23);
            this.keys.Multiline = true;
            this.keys.Name = "keys";
            this.keys.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.keys.Size = new System.Drawing.Size(200, 331);
            this.keys.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Keys";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 401);
            this.Controls.Add(this.keys);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.digest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Name = "Signature";
            this.Text = "Signature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox digest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox decrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox hash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox keys;
        private System.Windows.Forms.Label label6;
    }
}