namespace SportXperience.View
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
            this.linkLabelRegistrat = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonIniciSessio = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxContrasenya = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.textBoxNomCorreu = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // linkLabelRegistrat
            // 
            this.linkLabelRegistrat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelRegistrat.AutoSize = true;
            this.linkLabelRegistrat.Location = new System.Drawing.Point(278, 398);
            this.linkLabelRegistrat.Name = "linkLabelRegistrat";
            this.linkLabelRegistrat.Size = new System.Drawing.Size(51, 13);
            this.linkLabelRegistrat.TabIndex = 13;
            this.linkLabelRegistrat.TabStop = true;
            this.linkLabelRegistrat.Text = "Registra\'t";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "No tens compte? Crean una";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(67, 128);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(227, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Correu electrónic i nom d\'usuari:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(67, 238);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "Contrasenya:";
            // 
            // buttonIniciSessio
            // 
            this.buttonIniciSessio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIniciSessio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonIniciSessio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonIniciSessio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonIniciSessio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonIniciSessio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonIniciSessio.ForeColor = System.Drawing.Color.White;
            this.buttonIniciSessio.Location = new System.Drawing.Point(141, 336);
            this.buttonIniciSessio.Name = "buttonIniciSessio";
            this.buttonIniciSessio.Size = new System.Drawing.Size(188, 45);
            this.buttonIniciSessio.TabIndex = 22;
            this.buttonIniciSessio.Text = "INICIA SESSIÓ";
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContrasenya.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxContrasenya.DefaultText = "";
            this.textBoxContrasenya.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxContrasenya.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxContrasenya.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxContrasenya.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxContrasenya.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxContrasenya.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxContrasenya.ForeColor = System.Drawing.Color.Black;
            this.textBoxContrasenya.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxContrasenya.Location = new System.Drawing.Point(70, 260);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.PlaceholderText = "";
            this.textBoxContrasenya.SelectedText = "";
            this.textBoxContrasenya.Size = new System.Drawing.Size(331, 50);
            this.textBoxContrasenya.TabIndex = 23;
            this.textBoxContrasenya.UseSystemPasswordChar = true;
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonShowPassword.Location = new System.Drawing.Point(352, 276);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(34, 20);
            this.buttonShowPassword.TabIndex = 24;
            this.buttonShowPassword.Text = "👁";
            this.buttonShowPassword.UseVisualStyleBackColor = false;
            // 
            // textBoxNomCorreu
            // 
            this.textBoxNomCorreu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNomCorreu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNomCorreu.DefaultText = "";
            this.textBoxNomCorreu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNomCorreu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNomCorreu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNomCorreu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNomCorreu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNomCorreu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxNomCorreu.ForeColor = System.Drawing.Color.Black;
            this.textBoxNomCorreu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNomCorreu.Location = new System.Drawing.Point(70, 150);
            this.textBoxNomCorreu.Name = "textBoxNomCorreu";
            this.textBoxNomCorreu.PlaceholderText = "";
            this.textBoxNomCorreu.SelectedText = "";
            this.textBoxNomCorreu.Size = new System.Drawing.Size(331, 50);
            this.textBoxNomCorreu.TabIndex = 25;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 527);
            this.Controls.Add(this.textBoxNomCorreu);
            this.Controls.Add(this.buttonShowPassword);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.buttonIniciSessio);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabelRegistrat);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.LinkLabel linkLabelRegistrat;
        public System.Windows.Forms.Label label4;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public Guna.UI2.WinForms.Guna2Button buttonIniciSessio;
        public Guna.UI2.WinForms.Guna2TextBox textBoxContrasenya;
        public System.Windows.Forms.Button buttonShowPassword;
        public Guna.UI2.WinForms.Guna2TextBox textBoxNomCorreu;
    }
}