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
            this.buttonIniciSessio = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxContrasenya = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxNomCorreu = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabelRegistrat
            // 
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
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "No tens compte? Crean una";
            // 
            // materialLabel1
            // 
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
            // buttonIniciSessio
            // 
            this.buttonIniciSessio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIniciSessio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonIniciSessio.Depth = 0;
            this.buttonIniciSessio.HighEmphasis = true;
            this.buttonIniciSessio.Icon = null;
            this.buttonIniciSessio.Location = new System.Drawing.Point(177, 340);
            this.buttonIniciSessio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonIniciSessio.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonIniciSessio.Name = "buttonIniciSessio";
            this.buttonIniciSessio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonIniciSessio.Size = new System.Drawing.Size(117, 36);
            this.buttonIniciSessio.TabIndex = 17;
            this.buttonIniciSessio.Text = "Inicia Sessió";
            this.buttonIniciSessio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonIniciSessio.UseAccentColor = false;
            this.buttonIniciSessio.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
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
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.AnimateReadOnly = false;
            this.textBoxContrasenya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContrasenya.Depth = 0;
            this.textBoxContrasenya.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxContrasenya.LeadingIcon = null;
            this.textBoxContrasenya.Location = new System.Drawing.Point(70, 260);
            this.textBoxContrasenya.MaxLength = 50;
            this.textBoxContrasenya.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxContrasenya.Multiline = false;
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Password = true;
            this.textBoxContrasenya.Size = new System.Drawing.Size(331, 50);
            this.textBoxContrasenya.TabIndex = 19;
            this.textBoxContrasenya.Text = "";
            this.textBoxContrasenya.TrailingIcon = null;
            // 
            // textBoxNomCorreu
            // 
            this.textBoxNomCorreu.AnimateReadOnly = false;
            this.textBoxNomCorreu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomCorreu.Depth = 0;
            this.textBoxNomCorreu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxNomCorreu.LeadingIcon = null;
            this.textBoxNomCorreu.Location = new System.Drawing.Point(70, 150);
            this.textBoxNomCorreu.MaxLength = 50;
            this.textBoxNomCorreu.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxNomCorreu.Multiline = false;
            this.textBoxNomCorreu.Name = "textBoxNomCorreu";
            this.textBoxNomCorreu.Size = new System.Drawing.Size(331, 50);
            this.textBoxNomCorreu.TabIndex = 20;
            this.textBoxNomCorreu.Text = "";
            this.textBoxNomCorreu.TrailingIcon = null;
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonShowPassword.Location = new System.Drawing.Point(360, 276);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(25, 20);
            this.buttonShowPassword.TabIndex = 21;
            this.buttonShowPassword.Text = "👁";
            this.buttonShowPassword.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 527);
            this.Controls.Add(this.buttonShowPassword);
            this.Controls.Add(this.textBoxNomCorreu);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.buttonIniciSessio);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabelRegistrat);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.LinkLabel linkLabelRegistrat;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button buttonShowPassword;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialButton buttonIniciSessio;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialTextBox textBoxContrasenya;
        public MaterialSkin.Controls.MaterialTextBox textBoxNomCorreu;
    }
}