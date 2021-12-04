namespace Wifi.PlaylistEditor.UI
{
    partial class Form1
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel_ControlLeft = new System.Windows.Forms.Panel();
            this.panel_TopMenue = new System.Windows.Forms.Panel();
            this.panel_SongDetails = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_MenuBurger = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel_ControlLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ControlLeft
            // 
            this.panel_ControlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(171)))));
            this.panel_ControlLeft.Controls.Add(this.iconButton1);
            this.panel_ControlLeft.Controls.Add(this.panel2);
            this.panel_ControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ControlLeft.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ControlLeft.Name = "panel_ControlLeft";
            this.panel_ControlLeft.Size = new System.Drawing.Size(212, 689);
            this.panel_ControlLeft.TabIndex = 0;
            // 
            // panel_TopMenue
            // 
            this.panel_TopMenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(171)))));
            this.panel_TopMenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TopMenue.Location = new System.Drawing.Point(212, 0);
            this.panel_TopMenue.Margin = new System.Windows.Forms.Padding(0);
            this.panel_TopMenue.Name = "panel_TopMenue";
            this.panel_TopMenue.Size = new System.Drawing.Size(980, 32);
            this.panel_TopMenue.TabIndex = 1;
            // 
            // panel_SongDetails
            // 
            this.panel_SongDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(171)))));
            this.panel_SongDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_SongDetails.Location = new System.Drawing.Point(992, 32);
            this.panel_SongDetails.Margin = new System.Windows.Forms.Padding(0);
            this.panel_SongDetails.Name = "panel_SongDetails";
            this.panel_SongDetails.Size = new System.Drawing.Size(200, 657);
            this.panel_SongDetails.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(212, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 657);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_MenuBurger);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 167);
            this.panel2.TabIndex = 0;
            // 
            // btn_MenuBurger
            // 
            this.btn_MenuBurger.BackColor = System.Drawing.Color.Transparent;
            this.btn_MenuBurger.FlatAppearance.BorderSize = 0;
            this.btn_MenuBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuBurger.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btn_MenuBurger.IconColor = System.Drawing.Color.White;
            this.btn_MenuBurger.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MenuBurger.IconSize = 30;
            this.btn_MenuBurger.Location = new System.Drawing.Point(168, 3);
            this.btn_MenuBurger.Name = "btn_MenuBurger";
            this.btn_MenuBurger.Size = new System.Drawing.Size(38, 34);
            this.btn_MenuBurger.TabIndex = 1;
            this.btn_MenuBurger.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Wifi.PlaylistEditor.UI.Properties.Resources.NetPro_Logo;
            this.pictureBox1.InitialImage = global::Wifi.PlaylistEditor.UI.Properties.Resources.NetPro_Logo_freigestellt;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(42, 191);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(38, 34);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1192, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_SongDetails);
            this.Controls.Add(this.panel_TopMenue);
            this.Controls.Add(this.panel_ControlLeft);
            this.Name = "Form1";
            this.Text = "Playlist Manager";
            this.panel_ControlLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel_ControlLeft;
        private System.Windows.Forms.Panel panel_TopMenue;
        private System.Windows.Forms.Panel panel_SongDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_MenuBurger;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

