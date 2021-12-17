namespace lift
{
    partial class loginform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closebutton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.enterbutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.closebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 107);
            this.panel1.TabIndex = 0;
            // 
            // closebutton
            // 
            this.closebutton.AutoSize = true;
            this.closebutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(21)))), ((int)(((byte)(50)))));
            this.closebutton.Location = new System.Drawing.Point(618, 0);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(22, 25);
            this.closebutton.TabIndex = 1;
            this.closebutton.Text = "x";
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            this.closebutton.MouseEnter += new System.EventHandler(this.closebutton_MouseEnter);
            this.closebutton.MouseLeave += new System.EventHandler(this.closebutton_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // textlogin
            // 
            this.textlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textlogin.Location = new System.Drawing.Point(192, 134);
            this.textlogin.Multiline = true;
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(379, 82);
            this.textlogin.TabIndex = 2;
            this.textlogin.Enter += new System.EventHandler(this.textlogin_Enter);
            this.textlogin.Leave += new System.EventHandler(this.textlogin_Leave);
            // 
            // textpassword
            // 
            this.textpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textpassword.Location = new System.Drawing.Point(192, 238);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(379, 56);
            this.textpassword.TabIndex = 4;
            this.textpassword.Enter += new System.EventHandler(this.textpassword_Enter);
            this.textpassword.Leave += new System.EventHandler(this.textpassword_Leave);
            // 
            // enterbutton
            // 
            this.enterbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(21)))), ((int)(((byte)(50)))));
            this.enterbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.enterbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.enterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterbutton.Location = new System.Drawing.Point(274, 349);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(117, 42);
            this.enterbutton.TabIndex = 5;
            this.enterbutton.Text = "войти";
            this.enterbutton.UseVisualStyleBackColor = false;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::lift.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(80, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lift.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(80, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(640, 418);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.Text = "loginform";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginform_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginform_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button enterbutton;
    }
}