
namespace GenToken
{
    partial class Form1
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
            this.btn_Gen = new System.Windows.Forms.Button();
            this.tb_prjCode = new System.Windows.Forms.TextBox();
            this.tb_token = new System.Windows.Forms.TextBox();
            this.tb_URL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CPToken = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CopyURL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Gen
            // 
            this.btn_Gen.Location = new System.Drawing.Point(141, 70);
            this.btn_Gen.Name = "btn_Gen";
            this.btn_Gen.Size = new System.Drawing.Size(122, 38);
            this.btn_Gen.TabIndex = 0;
            this.btn_Gen.Text = "Generate Token";
            this.btn_Gen.UseVisualStyleBackColor = true;
            this.btn_Gen.Click += new System.EventHandler(this.btn_Gen_Click);
            // 
            // tb_prjCode
            // 
            this.tb_prjCode.Location = new System.Drawing.Point(126, 43);
            this.tb_prjCode.Name = "tb_prjCode";
            this.tb_prjCode.Size = new System.Drawing.Size(153, 20);
            this.tb_prjCode.TabIndex = 1;
            // 
            // tb_token
            // 
            this.tb_token.Location = new System.Drawing.Point(12, 161);
            this.tb_token.Name = "tb_token";
            this.tb_token.ReadOnly = true;
            this.tb_token.Size = new System.Drawing.Size(336, 20);
            this.tb_token.TabIndex = 2;
            // 
            // tb_URL
            // 
            this.tb_URL.Location = new System.Drawing.Point(12, 210);
            this.tb_URL.Name = "tb_URL";
            this.tb_URL.ReadOnly = true;
            this.tb_URL.Size = new System.Drawing.Size(336, 20);
            this.tb_URL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project Token: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "URL: ";
            // 
            // btn_CPToken
            // 
            this.btn_CPToken.Location = new System.Drawing.Point(354, 158);
            this.btn_CPToken.Name = "btn_CPToken";
            this.btn_CPToken.Size = new System.Drawing.Size(48, 23);
            this.btn_CPToken.TabIndex = 6;
            this.btn_CPToken.Text = "Copy";
            this.btn_CPToken.UseVisualStyleBackColor = true;
            this.btn_CPToken.Click += new System.EventHandler(this.btn_CPToken_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "___________________________________________________________________";
            // 
            // btn_CopyURL
            // 
            this.btn_CopyURL.Location = new System.Drawing.Point(354, 208);
            this.btn_CopyURL.Name = "btn_CopyURL";
            this.btn_CopyURL.Size = new System.Drawing.Size(48, 23);
            this.btn_CopyURL.TabIndex = 8;
            this.btn_CopyURL.Text = "Copy";
            this.btn_CopyURL.UseVisualStyleBackColor = true;
            this.btn_CopyURL.Click += new System.EventHandler(this.btn_CopyURL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Project Code:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Gen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 266);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CopyURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_CPToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_URL);
            this.Controls.Add(this.tb_token);
            this.Controls.Add(this.tb_prjCode);
            this.Controls.Add(this.btn_Gen);
            this.Name = "Form1";
            this.Text = "Gen Token";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Gen;
        private System.Windows.Forms.TextBox tb_prjCode;
        private System.Windows.Forms.TextBox tb_token;
        private System.Windows.Forms.TextBox tb_URL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CPToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CopyURL;
        private System.Windows.Forms.Label label4;
    }
}

