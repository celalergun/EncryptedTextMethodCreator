namespace EncryptedTextMethodCreator
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textKey = new System.Windows.Forms.TextBox();
            this.textText = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMethod = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbXOR = new System.Windows.Forms.RadioButton();
            this.rbAES = new System.Windows.Forms.RadioButton();
            this.rbHede = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(68, 6);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(271, 20);
            this.textKey.TabIndex = 3;
            // 
            // textText
            // 
            this.textText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textText.Location = new System.Drawing.Point(68, 41);
            this.textText.Name = "textText";
            this.textText.Size = new System.Drawing.Size(524, 20);
            this.textText.TabIndex = 4;
            this.textText.Text = "The quick brown fox jumps over the lazy dog";
            this.textText.TextChanged += new System.EventHandler(this.textText_TextChanged);
            // 
            // textResult
            // 
            this.textResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResult.Location = new System.Drawing.Point(68, 78);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(524, 20);
            this.textResult.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Method";
            // 
            // textMethod
            // 
            this.textMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMethod.Location = new System.Drawing.Point(68, 127);
            this.textMethod.Multiline = true;
            this.textMethod.Name = "textMethod";
            this.textMethod.Size = new System.Drawing.Size(524, 307);
            this.textMethod.TabIndex = 7;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(345, 6);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 20);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Algorithm";
            // 
            // rbXOR
            // 
            this.rbXOR.AutoSize = true;
            this.rbXOR.Checked = true;
            this.rbXOR.Location = new System.Drawing.Point(68, 104);
            this.rbXOR.Name = "rbXOR";
            this.rbXOR.Size = new System.Drawing.Size(48, 17);
            this.rbXOR.TabIndex = 10;
            this.rbXOR.TabStop = true;
            this.rbXOR.Text = "XOR";
            this.rbXOR.UseVisualStyleBackColor = true;
            // 
            // rbAES
            // 
            this.rbAES.AutoSize = true;
            this.rbAES.Location = new System.Drawing.Point(169, 104);
            this.rbAES.Name = "rbAES";
            this.rbAES.Size = new System.Drawing.Size(46, 17);
            this.rbAES.TabIndex = 11;
            this.rbAES.Text = "AES";
            this.rbAES.UseVisualStyleBackColor = true;
            // 
            // rbHede
            // 
            this.rbHede.AutoSize = true;
            this.rbHede.Location = new System.Drawing.Point(260, 104);
            this.rbHede.Name = "rbHede";
            this.rbHede.Size = new System.Drawing.Size(55, 17);
            this.rbHede.TabIndex = 12;
            this.rbHede.Text = "HEDE";
            this.rbHede.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 446);
            this.Controls.Add(this.rbHede);
            this.Controls.Add(this.rbAES);
            this.Controls.Add(this.rbXOR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.textMethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textText);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "C# Method Creator ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.TextBox textText;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMethod;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbXOR;
        private System.Windows.Forms.RadioButton rbAES;
        private System.Windows.Forms.RadioButton rbHede;
    }
}

