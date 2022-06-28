namespace PPAI_DSI.Formularios
{
    partial class FormEscritorio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscritorio));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_cerrar = new FontAwesome.Sharp.IconButton();
            this.btn_abm = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_salir = new FontAwesome.Sharp.IconPictureBox();
            this.btn_min = new FontAwesome.Sharp.IconPictureBox();
            this.btn_max = new FontAwesome.Sharp.IconPictureBox();
            this.l_icnActual = new System.Windows.Forms.Label();
            this.icn_actual = new FontAwesome.Sharp.IconPictureBox();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.txt_hora = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_actual)).BeginInit();
            this.panelEscritorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.btn_cerrar);
            this.panelMenu.Controls.Add(this.btn_abm);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(219, 614);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_cerrar.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_cerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cerrar.IconSize = 30;
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(0, 556);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btn_cerrar.Size = new System.Drawing.Size(219, 58);
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.Text = "Cerrar sesion";
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_abm
            // 
            this.btn_abm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_abm.FlatAppearance.BorderSize = 0;
            this.btn_abm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_abm.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btn_abm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_abm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_abm.IconSize = 30;
            this.btn_abm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abm.Location = new System.Drawing.Point(0, 173);
            this.btn_abm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_abm.Name = "btn_abm";
            this.btn_abm.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btn_abm.Size = new System.Drawing.Size(219, 58);
            this.btn_abm.TabIndex = 2;
            this.btn_abm.Text = "Registrar ingreso de RT en mantenimiento correctivo";
            this.btn_abm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_abm.UseVisualStyleBackColor = true;
            this.btn_abm.Click += new System.EventHandler(this.btn_abm_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 30;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 115);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnDashboard.Size = new System.Drawing.Size(219, 58);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Escritorio";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btn_home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(219, 115);
            this.panelLogo.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(51, 33);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(112, 54);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_home.TabIndex = 1;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.panelTitleBar.Controls.Add(this.btn_salir);
            this.panelTitleBar.Controls.Add(this.btn_min);
            this.panelTitleBar.Controls.Add(this.btn_max);
            this.panelTitleBar.Controls.Add(this.l_icnActual);
            this.panelTitleBar.Controls.Add(this.icn_actual);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(219, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(694, 60);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_salir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_salir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_salir.IconSize = 24;
            this.btn_salir.Location = new System.Drawing.Point(665, 3);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(26, 24);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 1;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.btn_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_min.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_min.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_min.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_min.IconSize = 21;
            this.btn_min.Location = new System.Drawing.Point(604, 3);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(21, 24);
            this.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_min.TabIndex = 3;
            this.btn_min.TabStop = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.btn_max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_max.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_max.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_max.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_max.IconSize = 24;
            this.btn_max.Location = new System.Drawing.Point(632, 3);
            this.btn_max.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(26, 24);
            this.btn_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_max.TabIndex = 0;
            this.btn_max.TabStop = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // l_icnActual
            // 
            this.l_icnActual.AutoSize = true;
            this.l_icnActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.l_icnActual.Location = new System.Drawing.Point(60, 23);
            this.l_icnActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_icnActual.Name = "l_icnActual";
            this.l_icnActual.Size = new System.Drawing.Size(56, 15);
            this.l_icnActual.TabIndex = 2;
            this.l_icnActual.Text = "Escritorio";
            // 
            // icn_actual
            // 
            this.icn_actual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.icn_actual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.icn_actual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icn_actual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.icn_actual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icn_actual.IconSize = 33;
            this.icn_actual.Location = new System.Drawing.Point(18, 14);
            this.icn_actual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.icn_actual.Name = "icn_actual";
            this.icn_actual.Size = new System.Drawing.Size(34, 33);
            this.icn_actual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icn_actual.TabIndex = 0;
            this.icn_actual.TabStop = false;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.SystemColors.Control;
            this.panelEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelEscritorio.Controls.Add(this.txt_hora);
            this.panelEscritorio.Controls.Add(this.txt_fecha);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(219, 60);
            this.panelEscritorio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(694, 554);
            this.panelEscritorio.TabIndex = 2;
            // 
            // txt_hora
            // 
            this.txt_hora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_hora.AutoSize = true;
            this.txt_hora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txt_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.txt_hora.Location = new System.Drawing.Point(279, 482);
            this.txt_hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(69, 29);
            this.txt_hora.TabIndex = 2;
            this.txt_hora.Text = "Hora";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_fecha.AutoSize = true;
            this.txt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.txt_fecha.Location = new System.Drawing.Point(181, 433);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(257, 29);
            this.txt_fecha.TabIndex = 1;
            this.txt_fecha.Text = "Fecha del dia de hoy";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // FormEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(913, 614);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormEscritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop";
            this.Load += new System.EventHandler(this.Frm_Escritorio_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_actual)).EndInit();
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btn_home;
        private FontAwesome.Sharp.IconButton btn_abm;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label l_icnActual;
        private FontAwesome.Sharp.IconPictureBox icn_actual;
        private System.Windows.Forms.Panel panelEscritorio;
        private FontAwesome.Sharp.IconPictureBox btn_salir;
        private FontAwesome.Sharp.IconPictureBox btn_min;
        private FontAwesome.Sharp.IconPictureBox btn_max;
        private System.Windows.Forms.Label txt_fecha;
        private System.Windows.Forms.Label txt_hora;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btn_cerrar;
    }
}