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
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonActualitzar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonResultats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.monthCalendarEvents = new Pabo.Calendar.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(48, 99);
            this.dataGridViewEvents.MultiSelect = false;
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.ReadOnly = true;
            this.dataGridViewEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvents.Size = new System.Drawing.Size(722, 390);
            this.dataGridViewEvents.TabIndex = 0;
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAfegir.Location = new System.Drawing.Point(874, 171);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(91, 35);
            this.buttonAfegir.TabIndex = 1;
            this.buttonAfegir.Text = "AFEGIR";
            this.buttonAfegir.UseVisualStyleBackColor = true;
            // 
            // buttonActualitzar
            // 
            this.buttonActualitzar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonActualitzar.Location = new System.Drawing.Point(874, 251);
            this.buttonActualitzar.Name = "buttonActualitzar";
            this.buttonActualitzar.Size = new System.Drawing.Size(91, 33);
            this.buttonActualitzar.TabIndex = 2;
            this.buttonActualitzar.Text = "ACTUALITZAR";
            this.buttonActualitzar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEliminar.Location = new System.Drawing.Point(874, 335);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(91, 33);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonResultats
            // 
            this.buttonResultats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResultats.Location = new System.Drawing.Point(1283, 455);
            this.buttonResultats.Name = "buttonResultats";
            this.buttonResultats.Size = new System.Drawing.Size(90, 34);
            this.buttonResultats.TabIndex = 4;
            this.buttonResultats.Text = "AFEGIR RESULTATS";
            this.buttonResultats.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "SportXperience";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Location = new System.Drawing.Point(1283, 24);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
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
            this.monthCalendarEvents.Location = new System.Drawing.Point(1051, 158);
            this.monthCalendarEvents.MaxDate = new System.DateTime(2035, 3, 27, 15, 46, 19, 762);
            this.monthCalendarEvents.MinDate = new System.DateTime(2015, 3, 27, 15, 46, 19, 762);
            this.monthCalendarEvents.Month.BackgroundImage = null;
            this.monthCalendarEvents.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Name = "monthCalendarEvents";
            this.monthCalendarEvents.Size = new System.Drawing.Size(348, 213);
            this.monthCalendarEvents.TabIndex = 7;
            this.monthCalendarEvents.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 532);
            this.Controls.Add(this.monthCalendarEvents);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonResultats);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualitzar);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.dataGridViewEvents);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewEvents;
        public System.Windows.Forms.Button buttonAfegir;
        public System.Windows.Forms.Button buttonActualitzar;
        public System.Windows.Forms.Button buttonEliminar;
        public System.Windows.Forms.Button buttonResultats;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBoxLogo;
        public Pabo.Calendar.MonthCalendar monthCalendarEvents;
    }
}

