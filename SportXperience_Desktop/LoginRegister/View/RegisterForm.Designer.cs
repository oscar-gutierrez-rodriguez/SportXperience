namespace LoginRegister.View
{
    partial class RegisterForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNaixement = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGenere = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.textBoxDNI = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxNom = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxContrasenyaReg = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxCognoms = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxNomUsuari = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxCorreu = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonShowPasswordRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nom usuari: ";
            // 
            // dateTimePickerNaixement
            // 
            this.dateTimePickerNaixement.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNaixement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNaixement.Location = new System.Drawing.Point(297, 318);
            this.dateTimePickerNaixement.Name = "dateTimePickerNaixement";
            this.dateTimePickerNaixement.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerNaixement.TabIndex = 33;
            // 
            // comboBoxGenere
            // 
            this.comboBoxGenere.FormattingEnabled = true;
            this.comboBoxGenere.Location = new System.Drawing.Point(75, 317);
            this.comboBoxGenere.Name = "comboBoxGenere";
            this.comboBoxGenere.Size = new System.Drawing.Size(112, 21);
            this.comboBoxGenere.TabIndex = 34;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(72, 121);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(31, 19);
            this.materialLabel1.TabIndex = 37;
            this.materialLabel1.Text = "DNI:";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(72, 209);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 38;
            this.materialLabel2.Text = "Nom:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(72, 296);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 39;
            this.materialLabel3.Text = "Génere:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(72, 443);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(88, 19);
            this.materialLabel4.TabIndex = 40;
            this.materialLabel4.Text = "Nom Usuari:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(72, 353);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(123, 19);
            this.materialLabel5.TabIndex = 41;
            this.materialLabel5.Text = "Correu electrónic:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(72, 527);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(94, 19);
            this.materialLabel6.TabIndex = 42;
            this.materialLabel6.Text = "Contrasenya:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(234, 209);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(73, 19);
            this.materialLabel7.TabIndex = 43;
            this.materialLabel7.Text = "Cognoms:";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(294, 296);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(138, 19);
            this.materialLabel8.TabIndex = 44;
            this.materialLabel8.Text = "Data de naixement:";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonRegistrar.Depth = 0;
            this.buttonRegistrar.HighEmphasis = true;
            this.buttonRegistrar.Icon = null;
            this.buttonRegistrar.Location = new System.Drawing.Point(202, 606);
            this.buttonRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonRegistrar.Size = new System.Drawing.Size(101, 36);
            this.buttonRegistrar.TabIndex = 45;
            this.buttonRegistrar.Text = "Registra\'t";
            this.buttonRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonRegistrar.UseAccentColor = false;
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.AnimateReadOnly = false;
            this.textBoxDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDNI.Depth = 0;
            this.textBoxDNI.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxDNI.LeadingIcon = null;
            this.textBoxDNI.Location = new System.Drawing.Point(75, 143);
            this.textBoxDNI.MaxLength = 50;
            this.textBoxDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxDNI.Multiline = false;
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(120, 50);
            this.textBoxDNI.TabIndex = 46;
            this.textBoxDNI.Text = "";
            this.textBoxDNI.TrailingIcon = null;
            // 
            // textBoxNom
            // 
            this.textBoxNom.AnimateReadOnly = false;
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNom.Depth = 0;
            this.textBoxNom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxNom.LeadingIcon = null;
            this.textBoxNom.Location = new System.Drawing.Point(75, 231);
            this.textBoxNom.MaxLength = 50;
            this.textBoxNom.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxNom.Multiline = false;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(120, 50);
            this.textBoxNom.TabIndex = 47;
            this.textBoxNom.Text = "";
            this.textBoxNom.TrailingIcon = null;
            // 
            // textBoxContrasenyaReg
            // 
            this.textBoxContrasenyaReg.AnimateReadOnly = false;
            this.textBoxContrasenyaReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContrasenyaReg.Depth = 0;
            this.textBoxContrasenyaReg.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxContrasenyaReg.LeadingIcon = null;
            this.textBoxContrasenyaReg.Location = new System.Drawing.Point(75, 549);
            this.textBoxContrasenyaReg.MaxLength = 50;
            this.textBoxContrasenyaReg.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxContrasenyaReg.Multiline = false;
            this.textBoxContrasenyaReg.Name = "textBoxContrasenyaReg";
            this.textBoxContrasenyaReg.Password = true;
            this.textBoxContrasenyaReg.Size = new System.Drawing.Size(322, 50);
            this.textBoxContrasenyaReg.TabIndex = 49;
            this.textBoxContrasenyaReg.Text = "";
            this.textBoxContrasenyaReg.TrailingIcon = null;
            // 
            // textBoxCognoms
            // 
            this.textBoxCognoms.AnimateReadOnly = false;
            this.textBoxCognoms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCognoms.Depth = 0;
            this.textBoxCognoms.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCognoms.LeadingIcon = null;
            this.textBoxCognoms.Location = new System.Drawing.Point(237, 231);
            this.textBoxCognoms.MaxLength = 50;
            this.textBoxCognoms.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCognoms.Multiline = false;
            this.textBoxCognoms.Name = "textBoxCognoms";
            this.textBoxCognoms.Size = new System.Drawing.Size(220, 50);
            this.textBoxCognoms.TabIndex = 50;
            this.textBoxCognoms.Text = "";
            this.textBoxCognoms.TrailingIcon = null;
            // 
            // textBoxNomUsuari
            // 
            this.textBoxNomUsuari.AnimateReadOnly = false;
            this.textBoxNomUsuari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomUsuari.Depth = 0;
            this.textBoxNomUsuari.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxNomUsuari.LeadingIcon = null;
            this.textBoxNomUsuari.Location = new System.Drawing.Point(75, 465);
            this.textBoxNomUsuari.MaxLength = 50;
            this.textBoxNomUsuari.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxNomUsuari.Multiline = false;
            this.textBoxNomUsuari.Name = "textBoxNomUsuari";
            this.textBoxNomUsuari.Size = new System.Drawing.Size(322, 50);
            this.textBoxNomUsuari.TabIndex = 51;
            this.textBoxNomUsuari.Text = "";
            this.textBoxNomUsuari.TrailingIcon = null;
            // 
            // textBoxCorreu
            // 
            this.textBoxCorreu.AnimateReadOnly = false;
            this.textBoxCorreu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorreu.Depth = 0;
            this.textBoxCorreu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCorreu.LeadingIcon = null;
            this.textBoxCorreu.Location = new System.Drawing.Point(75, 375);
            this.textBoxCorreu.MaxLength = 50;
            this.textBoxCorreu.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCorreu.Multiline = false;
            this.textBoxCorreu.Name = "textBoxCorreu";
            this.textBoxCorreu.Size = new System.Drawing.Size(322, 50);
            this.textBoxCorreu.TabIndex = 52;
            this.textBoxCorreu.Text = "";
            this.textBoxCorreu.TrailingIcon = null;
            this.textBoxCorreu.TextChanged += new System.EventHandler(this.textBoxCorreu_TextChanged);
            // 
            // buttonShowPasswordRegistrar
            // 
            this.buttonShowPasswordRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowPasswordRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonShowPasswordRegistrar.Location = new System.Drawing.Point(360, 562);
            this.buttonShowPasswordRegistrar.Name = "buttonShowPasswordRegistrar";
            this.buttonShowPasswordRegistrar.Size = new System.Drawing.Size(25, 20);
            this.buttonShowPasswordRegistrar.TabIndex = 53;
            this.buttonShowPasswordRegistrar.Text = "👁";
            this.buttonShowPasswordRegistrar.UseVisualStyleBackColor = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 672);
            this.Controls.Add(this.buttonShowPasswordRegistrar);
            this.Controls.Add(this.textBoxCorreu);
            this.Controls.Add(this.textBoxNomUsuari);
            this.Controls.Add(this.textBoxCognoms);
            this.Controls.Add(this.textBoxContrasenyaReg);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.comboBoxGenere);
            this.Controls.Add(this.dateTimePickerNaixement);
            this.Controls.Add(this.label4);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateTimePickerNaixement;
        public System.Windows.Forms.ComboBox comboBoxGenere;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialLabel materialLabel4;
        public MaterialSkin.Controls.MaterialLabel materialLabel5;
        public MaterialSkin.Controls.MaterialLabel materialLabel6;
        public MaterialSkin.Controls.MaterialLabel materialLabel7;
        public MaterialSkin.Controls.MaterialLabel materialLabel8;
        public MaterialSkin.Controls.MaterialButton buttonRegistrar;
        public MaterialSkin.Controls.MaterialTextBox textBoxDNI;
        public MaterialSkin.Controls.MaterialTextBox textBoxNom;
        public MaterialSkin.Controls.MaterialTextBox textBoxContrasenyaReg;
        public MaterialSkin.Controls.MaterialTextBox textBoxCognoms;
        public MaterialSkin.Controls.MaterialTextBox textBoxNomUsuari;
        public MaterialSkin.Controls.MaterialTextBox textBoxCorreu;
        public System.Windows.Forms.Button buttonShowPasswordRegistrar;
    }
}