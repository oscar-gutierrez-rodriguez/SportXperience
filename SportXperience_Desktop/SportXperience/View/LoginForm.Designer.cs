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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomCorreu = new System.Windows.Forms.TextBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.buttonIniciSessio = new System.Windows.Forms.Button();
            this.linkLabelRegistrat = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "SportXperience";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Correu electrónic o nom d\'usuari:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contrasenya: ";
            // 
            // textBoxNomCorreu
            // 
            this.textBoxNomCorreu.Location = new System.Drawing.Point(79, 183);
            this.textBoxNomCorreu.Name = "textBoxNomCorreu";
            this.textBoxNomCorreu.Size = new System.Drawing.Size(362, 20);
            this.textBoxNomCorreu.TabIndex = 9;
            this.textBoxNomCorreu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Location = new System.Drawing.Point(79, 260);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(362, 20);
            this.textBoxContrasenya.TabIndex = 10;
            // 
            // buttonIniciSessio
            // 
            this.buttonIniciSessio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonIniciSessio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciSessio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciSessio.Location = new System.Drawing.Point(160, 307);
            this.buttonIniciSessio.Name = "buttonIniciSessio";
            this.buttonIniciSessio.Size = new System.Drawing.Size(173, 29);
            this.buttonIniciSessio.TabIndex = 12;
            this.buttonIniciSessio.Text = "Inicia Sessió";
            this.buttonIniciSessio.UseVisualStyleBackColor = false;
            // 
            // linkLabelRegistrat
            // 
            this.linkLabelRegistrat.AutoSize = true;
            this.linkLabelRegistrat.Location = new System.Drawing.Point(297, 362);
            this.linkLabelRegistrat.Name = "linkLabelRegistrat";
            this.linkLabelRegistrat.Size = new System.Drawing.Size(51, 13);
            this.linkLabelRegistrat.TabIndex = 13;
            this.linkLabelRegistrat.TabStop = true;
            this.linkLabelRegistrat.Text = "Registra\'t";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "No tens compte? Crean un";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 527);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabelRegistrat);
            this.Controls.Add(this.buttonIniciSessio);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.textBoxNomCorreu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxNomCorreu;
        public System.Windows.Forms.TextBox textBoxContrasenya;
        public System.Windows.Forms.Button buttonIniciSessio;
        public System.Windows.Forms.LinkLabel linkLabelRegistrat;
        public System.Windows.Forms.Label label4;
    }
}