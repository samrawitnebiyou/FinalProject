namespace Stadium
{
    partial class LoginForm
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
            this.pbox_auth = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_signin = new System.Windows.Forms.Button();
            this.lbl_dont = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_auth)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_auth
            // 
            this.pbox_auth.Image = global::Stadium.Properties.Resources.authentication;
            this.pbox_auth.Location = new System.Drawing.Point(330, 12);
            this.pbox_auth.Name = "pbox_auth";
            this.pbox_auth.Size = new System.Drawing.Size(100, 101);
            this.pbox_auth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_auth.TabIndex = 0;
            this.pbox_auth.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(166, 170);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(105, 24);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(166, 212);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(100, 24);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_username.Location = new System.Drawing.Point(330, 173);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(181, 20);
            this.txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_password.Location = new System.Drawing.Point(330, 217);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(181, 20);
            this.txt_password.TabIndex = 4;
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.Location = new System.Drawing.Point(208, 294);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(385, 36);
            this.btn_signin.TabIndex = 5;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.UseVisualStyleBackColor = false;
            // 
            // lbl_dont
            // 
            this.lbl_dont.AutoSize = true;
            this.lbl_dont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dont.Location = new System.Drawing.Point(141, 376);
            this.lbl_dont.Name = "lbl_dont";
            this.lbl_dont.Size = new System.Drawing.Size(163, 18);
            this.lbl_dont.TabIndex = 6;
            this.lbl_dont.Text = "Don\'t have an account?";
            // 
            // btn_register
            // 
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(310, 376);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(104, 29);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lbl_dont);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pbox_auth);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_auth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_auth;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Label lbl_dont;
        private System.Windows.Forms.Button btn_register;
    }
}