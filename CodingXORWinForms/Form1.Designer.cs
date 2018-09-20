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
            this.components = new System.ComponentModel.Container();
            this.txbWay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bthCode = new System.Windows.Forms.Button();
            this.btnUncode = new System.Windows.Forms.Button();
            this.progrBar = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txbWay
            // 
            this.txbWay.Location = new System.Drawing.Point(107, 18);
            this.txbWay.Name = "txbWay";
            this.txbWay.Size = new System.Drawing.Size(303, 20);
            this.txbWay.TabIndex = 0;
            this.txbWay.TextChanged += new System.EventHandler(this.txbWay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path to file";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(107, 55);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(303, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Select File";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txbKey
            // 
            this.txbKey.Location = new System.Drawing.Point(107, 94);
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(303, 20);
            this.txbKey.TabIndex = 3;
            this.txbKey.TextChanged += new System.EventHandler(this.txbKey_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cipher Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "min 6 symbols";
            // 
            // bthCode
            // 
            this.bthCode.Location = new System.Drawing.Point(107, 138);
            this.bthCode.Name = "bthCode";
            this.bthCode.Size = new System.Drawing.Size(151, 23);
            this.bthCode.TabIndex = 6;
            this.bthCode.Text = "Encrypt File";
            this.bthCode.UseVisualStyleBackColor = true;
            this.bthCode.Click += new System.EventHandler(this.bthCode_Click);
            // 
            // btnUncode
            // 
            this.btnUncode.Location = new System.Drawing.Point(276, 138);
            this.btnUncode.Name = "btnUncode";
            this.btnUncode.Size = new System.Drawing.Size(134, 23);
            this.btnUncode.TabIndex = 7;
            this.btnUncode.Text = "Decrypt File";
            this.btnUncode.UseVisualStyleBackColor = true;
            this.btnUncode.Click += new System.EventHandler(this.btnUncode_Click);
            // 
            // progrBar
            // 
            this.progrBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progrBar.Location = new System.Drawing.Point(0, 224);
            this.progrBar.Name = "progrBar";
            this.progrBar.Size = new System.Drawing.Size(434, 27);
            this.progrBar.TabIndex = 8;
            this.progrBar.Click += new System.EventHandler(this.progrBar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(303, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormXor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 251);
            this.Controls.Add(this.btnCancel);
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
            this.Text = "XOR File Encryption ";
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

