
namespace AppAirport.UserControls
{
    partial class AddFlights
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtDateSchedule = new System.Windows.Forms.DateTimePicker();
            this.txtTypeFlights = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtActualyTime = new System.Windows.Forms.DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtAviacompany = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDirection = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumberFlights = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtDateSchedule);
            this.guna2Panel1.Controls.Add(this.txtTypeFlights);
            this.guna2Panel1.Controls.Add(this.txtActualyTime);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.txtAviacompany);
            this.guna2Panel1.Controls.Add(this.txtDirection);
            this.guna2Panel1.Controls.Add(this.txtStatus);
            this.guna2Panel1.Controls.Add(this.txtNumberFlights);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(841, 517);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // txtDateSchedule
            // 
            this.txtDateSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateSchedule.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateSchedule.CustomFormat = "yyyy/MM/dd HH:mm";
            this.txtDateSchedule.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateSchedule.Location = new System.Drawing.Point(166, 32);
            this.txtDateSchedule.Name = "txtDateSchedule";
            this.txtDateSchedule.Size = new System.Drawing.Size(509, 31);
            this.txtDateSchedule.TabIndex = 33;
            // 
            // txtTypeFlights
            // 
            this.txtTypeFlights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeFlights.BorderRadius = 9;
            this.txtTypeFlights.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTypeFlights.DefaultText = "";
            this.txtTypeFlights.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTypeFlights.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTypeFlights.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTypeFlights.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTypeFlights.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTypeFlights.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtTypeFlights.ForeColor = System.Drawing.Color.Black;
            this.txtTypeFlights.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTypeFlights.Location = new System.Drawing.Point(166, 344);
            this.txtTypeFlights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTypeFlights.Name = "txtTypeFlights";
            this.txtTypeFlights.PasswordChar = '\0';
            this.txtTypeFlights.PlaceholderText = "Тип полёт";
            this.txtTypeFlights.SelectedText = "";
            this.txtTypeFlights.Size = new System.Drawing.Size(509, 38);
            this.txtTypeFlights.TabIndex = 32;
            // 
            // txtActualyTime
            // 
            this.txtActualyTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualyTime.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualyTime.CustomFormat = "yyyy/MM/dd HH:mm";
            this.txtActualyTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualyTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtActualyTime.Location = new System.Drawing.Point(166, 407);
            this.txtActualyTime.Name = "txtActualyTime";
            this.txtActualyTime.Size = new System.Drawing.Size(509, 31);
            this.txtActualyTime.TabIndex = 30;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderRadius = 9;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(303, 454);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(236, 45);
            this.guna2Button1.TabIndex = 28;
            this.guna2Button1.Text = "Добавить";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtAviacompany
            // 
            this.txtAviacompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAviacompany.BorderRadius = 9;
            this.txtAviacompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAviacompany.DefaultText = "";
            this.txtAviacompany.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAviacompany.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAviacompany.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAviacompany.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAviacompany.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAviacompany.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAviacompany.ForeColor = System.Drawing.Color.Black;
            this.txtAviacompany.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAviacompany.Location = new System.Drawing.Point(166, 152);
            this.txtAviacompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAviacompany.Name = "txtAviacompany";
            this.txtAviacompany.PasswordChar = '\0';
            this.txtAviacompany.PlaceholderText = "Авиакомпания";
            this.txtAviacompany.SelectedText = "";
            this.txtAviacompany.Size = new System.Drawing.Size(509, 38);
            this.txtAviacompany.TabIndex = 26;
            // 
            // txtDirection
            // 
            this.txtDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirection.BorderRadius = 9;
            this.txtDirection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirection.DefaultText = "";
            this.txtDirection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDirection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDirection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDirection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDirection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDirection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirection.ForeColor = System.Drawing.Color.Black;
            this.txtDirection.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDirection.Location = new System.Drawing.Point(166, 219);
            this.txtDirection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.PasswordChar = '\0';
            this.txtDirection.PlaceholderText = "Направление";
            this.txtDirection.SelectedText = "";
            this.txtDirection.Size = new System.Drawing.Size(509, 38);
            this.txtDirection.TabIndex = 25;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.BorderRadius = 9;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.DefaultText = "";
            this.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Location = new System.Drawing.Point(166, 280);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.PlaceholderText = "Статус";
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(509, 38);
            this.txtStatus.TabIndex = 24;
            // 
            // txtNumberFlights
            // 
            this.txtNumberFlights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberFlights.BorderRadius = 9;
            this.txtNumberFlights.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberFlights.DefaultText = "";
            this.txtNumberFlights.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberFlights.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberFlights.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberFlights.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberFlights.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberFlights.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberFlights.ForeColor = System.Drawing.Color.Black;
            this.txtNumberFlights.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberFlights.Location = new System.Drawing.Point(166, 88);
            this.txtNumberFlights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumberFlights.Name = "txtNumberFlights";
            this.txtNumberFlights.PasswordChar = '\0';
            this.txtNumberFlights.PlaceholderText = "№ рейса";
            this.txtNumberFlights.SelectedText = "";
            this.txtNumberFlights.Size = new System.Drawing.Size(509, 38);
            this.txtNumberFlights.TabIndex = 27;
            // 
            // AddFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "AddFlights";
            this.Size = new System.Drawing.Size(841, 517);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtAviacompany;
        private Guna.UI2.WinForms.Guna2TextBox txtDirection;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberFlights;
        private System.Windows.Forms.DateTimePicker txtActualyTime;
        private Guna.UI2.WinForms.Guna2TextBox txtTypeFlights;
        private System.Windows.Forms.DateTimePicker txtDateSchedule;
    }
}
