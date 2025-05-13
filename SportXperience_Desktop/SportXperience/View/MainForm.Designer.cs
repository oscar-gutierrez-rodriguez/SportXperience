namespace SportXperience
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendarEvents = new Pabo.Calendar.MonthCalendar();
            this.buttonResultats = new Guna.UI2.WinForms.Guna2Button();
            this.materialButtonProdPart = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.buttonActualitzar = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAfegir = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewEvents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.monthCalendarEvents);
            this.panel1.Controls.Add(this.buttonResultats);
            this.panel1.Controls.Add(this.materialButtonProdPart);
            this.panel1.Controls.Add(this.buttonEliminar);
            this.panel1.Controls.Add(this.buttonActualitzar);
            this.panel1.Controls.Add(this.buttonAfegir);
            this.panel1.Controls.Add(this.dataGridViewEvents);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Location = new System.Drawing.Point(-3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1927, 875);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // monthCalendarEvents
            // 
            this.monthCalendarEvents.ActiveMonth.Month = 3;
            this.monthCalendarEvents.ActiveMonth.Year = 2025;
            this.monthCalendarEvents.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.monthCalendarEvents.Culture = new System.Globalization.CultureInfo("es");
            this.monthCalendarEvents.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendarEvents.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendarEvents.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendarEvents.ImageList = null;
            this.monthCalendarEvents.Location = new System.Drawing.Point(1421, 334);
            this.monthCalendarEvents.MaxDate = new System.DateTime(2035, 3, 27, 15, 46, 19, 762);
            this.monthCalendarEvents.MinDate = new System.DateTime(2015, 3, 27, 15, 46, 19, 762);
            this.monthCalendarEvents.Month.BackgroundImage = null;
            this.monthCalendarEvents.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Name = "monthCalendarEvents";
            this.monthCalendarEvents.Size = new System.Drawing.Size(348, 213);
            this.monthCalendarEvents.TabIndex = 15;
            this.monthCalendarEvents.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // buttonResultats
            // 
            this.buttonResultats.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonResultats.BorderRadius = 10;
            this.buttonResultats.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonResultats.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonResultats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonResultats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonResultats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonResultats.ForeColor = System.Drawing.Color.White;
            this.buttonResultats.Location = new System.Drawing.Point(1627, 682);
            this.buttonResultats.Name = "buttonResultats";
            this.buttonResultats.Size = new System.Drawing.Size(189, 45);
            this.buttonResultats.TabIndex = 145;
            this.buttonResultats.Text = "AFEGIR RESULTATS";
            // 
            // materialButtonProdPart
            // 
            this.materialButtonProdPart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialButtonProdPart.BorderRadius = 10;
            this.materialButtonProdPart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.materialButtonProdPart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.materialButtonProdPart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.materialButtonProdPart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.materialButtonProdPart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialButtonProdPart.ForeColor = System.Drawing.Color.White;
            this.materialButtonProdPart.Location = new System.Drawing.Point(1421, 682);
            this.materialButtonProdPart.Name = "materialButtonProdPart";
            this.materialButtonProdPart.Size = new System.Drawing.Size(189, 45);
            this.materialButtonProdPart.TabIndex = 144;
            this.materialButtonProdPart.Text = "PRODUCTES PER PARTICIPANT";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonEliminar.BorderRadius = 10;
            this.buttonEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(1226, 511);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(118, 45);
            this.buttonEliminar.TabIndex = 143;
            this.buttonEliminar.Text = "ELIMINAR";
            // 
            // buttonActualitzar
            // 
            this.buttonActualitzar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonActualitzar.BorderRadius = 10;
            this.buttonActualitzar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonActualitzar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonActualitzar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonActualitzar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonActualitzar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonActualitzar.ForeColor = System.Drawing.Color.White;
            this.buttonActualitzar.Location = new System.Drawing.Point(1226, 419);
            this.buttonActualitzar.Name = "buttonActualitzar";
            this.buttonActualitzar.Size = new System.Drawing.Size(118, 45);
            this.buttonActualitzar.TabIndex = 142;
            this.buttonActualitzar.Text = "ACTUALITZAR";
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAfegir.BorderRadius = 10;
            this.buttonAfegir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAfegir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAfegir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAfegir.ForeColor = System.Drawing.Color.White;
            this.buttonAfegir.Location = new System.Drawing.Point(1226, 332);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(118, 45);
            this.buttonAfegir.TabIndex = 141;
            this.buttonAfegir.Text = "AFEGIR";
            // 
            // dataGridViewEvents
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEvents.ColumnHeadersHeight = 20;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEvents.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewEvents.GridColor = System.Drawing.Color.Black;
            this.dataGridViewEvents.Location = new System.Drawing.Point(43, 116);
            this.dataGridViewEvents.MultiSelect = false;
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.ReadOnly = true;
            this.dataGridViewEvents.RowHeadersVisible = false;
            this.dataGridViewEvents.Size = new System.Drawing.Size(1135, 611);
            this.dataGridViewEvents.TabIndex = 27;
            this.dataGridViewEvents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEvents.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewEvents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewEvents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewEvents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewEvents.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEvents.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dataGridViewEvents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewEvents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewEvents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEvents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewEvents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewEvents.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridViewEvents.ThemeStyle.ReadOnly = true;
            this.dataGridViewEvents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEvents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEvents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEvents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewEvents.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewEvents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewEvents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Location = new System.Drawing.Point(1625, 37);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(144, 139);
            this.pictureBoxLogo.TabIndex = 14;
            this.pictureBoxLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 886);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SportXperience";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBoxLogo;
        public Pabo.Calendar.MonthCalendar monthCalendarEvents;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridViewEvents;
        public Guna.UI2.WinForms.Guna2Button buttonAfegir;
        public Guna.UI2.WinForms.Guna2Button buttonActualitzar;
        public Guna.UI2.WinForms.Guna2Button buttonEliminar;
        public Guna.UI2.WinForms.Guna2Button materialButtonProdPart;
        public Guna.UI2.WinForms.Guna2Button buttonResultats;
    }
}

