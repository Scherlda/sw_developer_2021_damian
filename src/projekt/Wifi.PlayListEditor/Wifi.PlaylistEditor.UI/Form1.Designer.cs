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
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.btn_File = new FontAwesome.Sharp.IconButton();
            this.btn_Items = new FontAwesome.Sharp.IconButton();
            this.btn_Music = new FontAwesome.Sharp.IconButton();
            this.btn_Video = new FontAwesome.Sharp.IconButton();
            this.btn_Image = new FontAwesome.Sharp.IconButton();
            this.btn_CloseApp = new FontAwesome.Sharp.IconButton();
            this.btn_MaximizeApp = new FontAwesome.Sharp.IconButton();
            this.btn_MinimizeApp = new FontAwesome.Sharp.IconButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel_ControlLeft.SuspendLayout();
            this.panel_TopMenue.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ControlLeft
            // 
            this.panel_ControlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(171)))));
            this.panel_ControlLeft.Controls.Add(this.btn_Image);
            this.panel_ControlLeft.Controls.Add(this.btn_Video);
            this.panel_ControlLeft.Controls.Add(this.btn_Music);
            this.panel_ControlLeft.Controls.Add(this.btn_Items);
            this.panel_ControlLeft.Controls.Add(this.btn_File);
            this.panel_ControlLeft.Controls.Add(this.panel2);
            this.panel_ControlLeft.Controls.Add(this.menuStrip1);
            this.panel_ControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ControlLeft.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ControlLeft.Name = "panel_ControlLeft";
            this.panel_ControlLeft.Size = new System.Drawing.Size(180, 689);
            this.panel_ControlLeft.TabIndex = 0;
            // 
            // panel_TopMenue
            // 
            this.panel_TopMenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(171)))));
            this.panel_TopMenue.Controls.Add(this.btn_MinimizeApp);
            this.panel_TopMenue.Controls.Add(this.btn_MaximizeApp);
            this.panel_TopMenue.Controls.Add(this.btn_CloseApp);
            this.panel_TopMenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TopMenue.Location = new System.Drawing.Point(180, 0);
            this.panel_TopMenue.Margin = new System.Windows.Forms.Padding(0);
            this.panel_TopMenue.Name = "panel_TopMenue";
            this.panel_TopMenue.Size = new System.Drawing.Size(1012, 37);
            this.panel_TopMenue.TabIndex = 1;
            this.panel_TopMenue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TopMenue_MouseDown);
            // 
            // panel_SongDetails
            // 
            this.panel_SongDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(171)))));
            this.panel_SongDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_SongDetails.Location = new System.Drawing.Point(992, 37);
            this.panel_SongDetails.Margin = new System.Windows.Forms.Padding(0);
            this.panel_SongDetails.Name = "panel_SongDetails";
            this.panel_SongDetails.Size = new System.Drawing.Size(200, 652);
            this.panel_SongDetails.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(180, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 652);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_MenuBurger);
            this.panel2.Controls.Add(this.pictureBox_Logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 167);
            this.panel2.TabIndex = 0;
            // 
            // btn_MenuBurger
            // 
            this.btn_MenuBurger.BackColor = System.Drawing.Color.Transparent;
            this.btn_MenuBurger.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_MenuBurger.FlatAppearance.BorderSize = 0;
            this.btn_MenuBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuBurger.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btn_MenuBurger.IconColor = System.Drawing.Color.White;
            this.btn_MenuBurger.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MenuBurger.IconSize = 30;
            this.btn_MenuBurger.Location = new System.Drawing.Point(142, 0);
            this.btn_MenuBurger.Name = "btn_MenuBurger";
            this.btn_MenuBurger.Size = new System.Drawing.Size(38, 167);
            this.btn_MenuBurger.TabIndex = 1;
            this.btn_MenuBurger.Tag = "menuBurger";
            this.btn_MenuBurger.UseVisualStyleBackColor = false;
            this.btn_MenuBurger.Click += new System.EventHandler(this.btn_MenuBurger_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logo.Image = global::Wifi.PlaylistEditor.UI.Properties.Resources.NetPro_Logo;
            this.pictureBox_Logo.InitialImage = global::Wifi.PlaylistEditor.UI.Properties.Resources.NetPro_Logo_freigestellt;
            this.pictureBox_Logo.Location = new System.Drawing.Point(24, 12);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(122, 104);
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // btn_File
            // 
            this.btn_File.BackColor = System.Drawing.Color.Transparent;
            this.btn_File.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_File.FlatAppearance.BorderSize = 0;
            this.btn_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_File.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_File.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_File.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btn_File.IconColor = System.Drawing.Color.White;
            this.btn_File.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_File.IconSize = 30;
            this.btn_File.Location = new System.Drawing.Point(0, 191);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(180, 50);
            this.btn_File.TabIndex = 2;
            this.btn_File.Tag = "File";
            this.btn_File.Text = "File";
            this.btn_File.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_File.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_File.UseVisualStyleBackColor = false;
            // 
            // btn_Items
            // 
            this.btn_Items.BackColor = System.Drawing.Color.Transparent;
            this.btn_Items.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Items.FlatAppearance.BorderSize = 0;
            this.btn_Items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Items.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Items.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Items.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.btn_Items.IconColor = System.Drawing.Color.White;
            this.btn_Items.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Items.IconSize = 30;
            this.btn_Items.Location = new System.Drawing.Point(0, 241);
            this.btn_Items.Name = "btn_Items";
            this.btn_Items.Size = new System.Drawing.Size(180, 50);
            this.btn_Items.TabIndex = 3;
            this.btn_Items.Tag = "Items";
            this.btn_Items.Text = "Items";
            this.btn_Items.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Items.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Items.UseVisualStyleBackColor = false;
            // 
            // btn_Music
            // 
            this.btn_Music.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Music.FlatAppearance.BorderSize = 0;
            this.btn_Music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Music.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Music.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Music.IconChar = FontAwesome.Sharp.IconChar.Headphones;
            this.btn_Music.IconColor = System.Drawing.Color.White;
            this.btn_Music.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Music.IconSize = 30;
            this.btn_Music.Location = new System.Drawing.Point(0, 291);
            this.btn_Music.Name = "btn_Music";
            this.btn_Music.Size = new System.Drawing.Size(180, 50);
            this.btn_Music.TabIndex = 4;
            this.btn_Music.Tag = "Music";
            this.btn_Music.Text = "Music";
            this.btn_Music.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Music.UseVisualStyleBackColor = false;
            // 
            // btn_Video
            // 
            this.btn_Video.BackColor = System.Drawing.Color.Transparent;
            this.btn_Video.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Video.FlatAppearance.BorderSize = 0;
            this.btn_Video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Video.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Video.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Video.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.btn_Video.IconColor = System.Drawing.Color.White;
            this.btn_Video.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Video.IconSize = 30;
            this.btn_Video.Location = new System.Drawing.Point(0, 341);
            this.btn_Video.Name = "btn_Video";
            this.btn_Video.Size = new System.Drawing.Size(180, 50);
            this.btn_Video.TabIndex = 5;
            this.btn_Video.Tag = "Video";
            this.btn_Video.Text = "Video";
            this.btn_Video.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Video.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Video.UseVisualStyleBackColor = false;
            // 
            // btn_Image
            // 
            this.btn_Image.BackColor = System.Drawing.Color.Transparent;
            this.btn_Image.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Image.FlatAppearance.BorderSize = 0;
            this.btn_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Image.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Image.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Image.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btn_Image.IconColor = System.Drawing.Color.White;
            this.btn_Image.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Image.IconSize = 30;
            this.btn_Image.Location = new System.Drawing.Point(0, 391);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(180, 50);
            this.btn_Image.TabIndex = 6;
            this.btn_Image.Tag = "Image";
            this.btn_Image.Text = "Image";
            this.btn_Image.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Image.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Image.UseVisualStyleBackColor = false;
            // 
            // btn_CloseApp
            // 
            this.btn_CloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_CloseApp.FlatAppearance.BorderSize = 0;
            this.btn_CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseApp.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_CloseApp.IconColor = System.Drawing.Color.White;
            this.btn_CloseApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CloseApp.IconSize = 20;
            this.btn_CloseApp.Location = new System.Drawing.Point(973, 1);
            this.btn_CloseApp.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CloseApp.Name = "btn_CloseApp";
            this.btn_CloseApp.Size = new System.Drawing.Size(40, 25);
            this.btn_CloseApp.TabIndex = 2;
            this.btn_CloseApp.UseVisualStyleBackColor = false;
            this.btn_CloseApp.Click += new System.EventHandler(this.btn_CloseApp_Click);
            // 
            // btn_MaximizeApp
            // 
            this.btn_MaximizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MaximizeApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
            this.btn_MaximizeApp.FlatAppearance.BorderSize = 0;
            this.btn_MaximizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MaximizeApp.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
            this.btn_MaximizeApp.IconColor = System.Drawing.Color.White;
            this.btn_MaximizeApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MaximizeApp.IconSize = 20;
            this.btn_MaximizeApp.Location = new System.Drawing.Point(933, 1);
            this.btn_MaximizeApp.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MaximizeApp.Name = "btn_MaximizeApp";
            this.btn_MaximizeApp.Size = new System.Drawing.Size(40, 25);
            this.btn_MaximizeApp.TabIndex = 3;
            this.btn_MaximizeApp.UseVisualStyleBackColor = false;
            this.btn_MaximizeApp.Click += new System.EventHandler(this.btn_MaximizeApp_Click);
            // 
            // btn_MinimizeApp
            // 
            this.btn_MinimizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinimizeApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(171)))));
            this.btn_MinimizeApp.FlatAppearance.BorderSize = 0;
            this.btn_MinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MinimizeApp.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_MinimizeApp.IconColor = System.Drawing.Color.White;
            this.btn_MinimizeApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MinimizeApp.IconSize = 20;
            this.btn_MinimizeApp.Location = new System.Drawing.Point(893, 1);
            this.btn_MinimizeApp.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MinimizeApp.Name = "btn_MinimizeApp";
            this.btn_MinimizeApp.Size = new System.Drawing.Size(40, 25);
            this.btn_MinimizeApp.TabIndex = 4;
            this.btn_MinimizeApp.UseVisualStyleBackColor = false;
            this.btn_MinimizeApp.Click += new System.EventHandler(this.btn_MinimizeApp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(180, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
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
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel_ControlLeft.ResumeLayout(false);
            this.panel_ControlLeft.PerformLayout();
            this.panel_TopMenue.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private FontAwesome.Sharp.IconButton btn_File;
        private FontAwesome.Sharp.IconButton btn_Items;
        private FontAwesome.Sharp.IconButton btn_Image;
        private FontAwesome.Sharp.IconButton btn_Video;
        private FontAwesome.Sharp.IconButton btn_Music;
        private FontAwesome.Sharp.IconButton btn_CloseApp;
        private FontAwesome.Sharp.IconButton btn_MinimizeApp;
        private FontAwesome.Sharp.IconButton btn_MaximizeApp;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

