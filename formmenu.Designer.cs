namespace caro222
{
    partial class formmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formmenu));
            this.btnp = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lblH1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnp
            // 
            this.btnp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnp.Location = new System.Drawing.Point(103, 215);
            this.btnp.Name = "btnp";
            this.btnp.Size = new System.Drawing.Size(147, 53);
            this.btnp.TabIndex = 2;
            this.btnp.Text = "PLAY";
            this.btnp.UseVisualStyleBackColor = false;
            this.btnp.Click += new System.EventHandler(this.btnp_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(73, 81);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(217, 20);
            this.txtPlayer1.TabIndex = 3;
            this.txtPlayer1.MouseLeave += new System.EventHandler(this.TxtPlayer_MouseLeave);
            this.txtPlayer1.MouseHover += new System.EventHandler(this.TxtPlayer_MouseHover);
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(73, 159);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(217, 20);
            this.txtPlayer2.TabIndex = 4;
            this.txtPlayer2.MouseLeave += new System.EventHandler(this.TxtPlayer_MouseLeave);
            this.txtPlayer2.MouseHover += new System.EventHandler(this.TxtPlayer_MouseHover);
            // 
            // lblH1
            // 
            this.lblH1.AutoSize = true;
            this.lblH1.Location = new System.Drawing.Point(79, 123);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(31, 13);
            this.lblH1.TabIndex = 5;
            this.lblH1.Text = "lblH1";
            this.lblH1.Visible = false;
            // 
            // formmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::caro222.Properties.Resources.screenshot_1729521129625;
            this.ClientSize = new System.Drawing.Size(358, 342);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.btnp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formmenu";
            this.Text = "MENU CARO 3x3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnp;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label lblH1;
    }
}