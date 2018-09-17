namespace CodingXORWinForms
{
    partial class FormXor
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
            this.txbWay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bthCode = new System.Windows.Forms.Button();
            this.btnUncode = new System.Windows.Forms.Button();
            this.progrBar = new System.Windows.Forms.ProgressBar();
            this.txbByte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbWay
            // 
            this.txbWay.Location = new System.Drawing.Point(107, 18);
            this.txbWay.Name = "txbWay";
            this.txbWay.Size = new System.Drawing.Size(303, 20);
            this.txbWay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к файлу";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(107, 55);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(303, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Выбрать файл";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txbKey
            // 
            this.txbKey.Location = new System.Drawing.Point(107, 94);
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(303, 20);
            this.txbKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ключ шифра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "min 6 символов";
            // 
            // bthCode
            // 
            this.bthCode.Location = new System.Drawing.Point(191, 138);
            this.bthCode.Name = "bthCode";
            this.bthCode.Size = new System.Drawing.Size(219, 23);
            this.bthCode.TabIndex = 6;
            this.bthCode.Text = "Зашифровать";
            this.bthCode.UseVisualStyleBackColor = true;
            this.bthCode.Click += new System.EventHandler(this.bthCode_Click);
            // 
            // btnUncode
            // 
            this.btnUncode.Location = new System.Drawing.Point(107, 188);
            this.btnUncode.Name = "btnUncode";
            this.btnUncode.Size = new System.Drawing.Size(303, 23);
            this.btnUncode.TabIndex = 7;
            this.btnUncode.Text = "Расшифровать";
            this.btnUncode.UseVisualStyleBackColor = true;
            this.btnUncode.Click += new System.EventHandler(this.btnUncode_Click);
            // 
            // progrBar
            // 
            this.progrBar.Location = new System.Drawing.Point(107, 239);
            this.progrBar.Name = "progrBar";
            this.progrBar.Size = new System.Drawing.Size(303, 23);
            this.progrBar.TabIndex = 8;
            // 
            // txbByte
            // 
            this.txbByte.Location = new System.Drawing.Point(107, 138);
            this.txbByte.Name = "txbByte";
            this.txbByte.Size = new System.Drawing.Size(60, 20);
            this.txbByte.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Размер ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "шифрования";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "байт";
            // 
            // FormXor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 274);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbByte);
            this.Controls.Add(this.progrBar);
            this.Controls.Add(this.btnUncode);
            this.Controls.Add(this.bthCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbWay);
            this.Name = "FormXor";
            this.Text = "Шифрование файлов XOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbWay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bthCode;
        private System.Windows.Forms.Button btnUncode;
        private System.Windows.Forms.ProgressBar progrBar;
        private System.Windows.Forms.TextBox txbByte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

