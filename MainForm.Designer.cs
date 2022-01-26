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
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbClearText = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMethod = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbXOR = new System.Windows.Forms.RadioButton();
            this.rbAES = new System.Windows.Forms.RadioButton();
            this.rbXtea = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(113, 12);
            this.tbKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(449, 31);
            this.tbKey.TabIndex = 3;
            // 
            // tbClearText
            // 
            this.tbClearText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClearText.Location = new System.Drawing.Point(113, 79);
            this.tbClearText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbClearText.Name = "tbClearText";
            this.tbClearText.Size = new System.Drawing.Size(871, 31);
            this.tbClearText.TabIndex = 4;
            this.tbClearText.Text = "The quick brown fox jumps over the lazy dog";
            this.tbClearText.TextChanged += new System.EventHandler(this.textText_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Location = new System.Drawing.Point(113, 150);
            this.tbResult.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(871, 31);
            this.tbResult.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 525);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Method";
            // 
            // tbMethod
            // 
            this.tbMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMethod.Location = new System.Drawing.Point(113, 244);
            this.tbMethod.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbMethod.Multiline = true;
            this.tbMethod.Name = "tbMethod";
            this.tbMethod.Size = new System.Drawing.Size(871, 587);
            this.tbMethod.TabIndex = 7;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(575, 12);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(125, 38);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Algorithm";
            // 
            // rbXOR
            // 
            this.rbXOR.AutoSize = true;
            this.rbXOR.Checked = true;
            this.rbXOR.Location = new System.Drawing.Point(113, 200);
            this.rbXOR.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbXOR.Name = "rbXOR";
            this.rbXOR.Size = new System.Drawing.Size(73, 29);
            this.rbXOR.TabIndex = 10;
            this.rbXOR.TabStop = true;
            this.rbXOR.Text = "XOR";
            this.rbXOR.UseVisualStyleBackColor = true;
            this.rbXOR.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbAES
            // 
            this.rbAES.AutoSize = true;
            this.rbAES.Location = new System.Drawing.Point(282, 200);
            this.rbAES.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbAES.Name = "rbAES";
            this.rbAES.Size = new System.Drawing.Size(68, 29);
            this.rbAES.TabIndex = 11;
            this.rbAES.Text = "AES";
            this.rbAES.UseVisualStyleBackColor = true;
            this.rbAES.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbXtea
            // 
            this.rbXtea.AutoSize = true;
            this.rbXtea.Location = new System.Drawing.Point(433, 200);
            this.rbXtea.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbXtea.Name = "rbXtea";
            this.rbXtea.Size = new System.Drawing.Size(78, 29);
            this.rbXtea.TabIndex = 12;
            this.rbXtea.Text = "XTEA";
            this.rbXtea.UseVisualStyleBackColor = true;
            this.rbXtea.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 858);
            this.Controls.Add(this.rbXtea);
            this.Controls.Add(this.rbAES);
            this.Controls.Add(this.rbXOR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.tbMethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbClearText);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbClearText;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMethod;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbXOR;
        private System.Windows.Forms.RadioButton rbAES;
        private System.Windows.Forms.RadioButton rbXtea;
    }
}

