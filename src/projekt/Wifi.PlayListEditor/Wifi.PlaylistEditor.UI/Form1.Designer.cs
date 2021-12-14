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
            this.components = new System.ComponentModel.Container();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel_ControlLeft = new System.Windows.Forms.Panel();
            this.btn_Image = new FontAwesome.Sharp.IconButton();
            this.btn_Video = new FontAwesome.Sharp.IconButton();
            this.btn_Music = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_MenuBurger = new FontAwesome.Sharp.IconButton();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemItems = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_TopMenue = new System.Windows.Forms.Panel();
            this.btn_MinimizeApp = new FontAwesome.Sharp.IconButton();
            this.btn_MaximizeApp = new FontAwesome.Sharp.IconButton();
            this.btn_CloseApp = new FontAwesome.Sharp.IconButton();
            this.panel_SongDetails = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreatorInfo = new System.Windows.Forms.Label();
            this.lv_Center_AllItems = new System.Windows.Forms.ListView();
            this.lbl_RightPlaylistName = new System.Windows.Forms.Label();
            this.lbl_RightPlaylistDuration = new System.Windows.Forms.Label();
            this.lbl_RightPlaylistAuthor = new System.Windows.Forms.Label();
            this.lbl_RightPlaylistCreateDate = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_ControlLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.panel_TopMenue.SuspendLayout();
            this.panel_SongDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ControlLeft
            // 
            this.panel_ControlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(171)))));
            this.panel_ControlLeft.Controls.Add(this.btn_Image);
            this.panel_ControlLeft.Controls.Add(this.btn_Video);
            this.panel_ControlLeft.Controls.Add(this.btn_Music);
            this.panel_ControlLeft.Controls.Add(this.panel2);
            this.panel_ControlLeft.Controls.Add(this.menuStrip);
            this.panel_ControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ControlLeft.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ControlLeft.Name = "panel_ControlLeft";
            this.panel_ControlLeft.Size = new System.Drawing.Size(180, 689);
            this.panel_ControlLeft.TabIndex = 0;
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
            this.btn_Image.Location = new System.Drawing.Point(0, 291);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(180, 50);
            this.btn_Image.TabIndex = 6;
            this.btn_Image.Tag = "Image";
            this.btn_Image.Text = "Image";
            this.btn_Image.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Image.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Image.UseVisualStyleBackColor = false;
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
            this.btn_Video.Location = new System.Drawing.Point(0, 241);
            this.btn_Video.Name = "btn_Video";
            this.btn_Video.Size = new System.Drawing.Size(180, 50);
            this.btn_Video.TabIndex = 5;
            this.btn_Video.Tag = "Video";
            this.btn_Video.Text = "Video";
            this.btn_Video.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Video.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Video.UseVisualStyleBackColor = false;
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
            this.btn_Music.Location = new System.Drawing.Point(0, 191);
            this.btn_Music.Name = "btn_Music";
            this.btn_Music.Size = new System.Drawing.Size(180, 50);
            this.btn_Music.TabIndex = 4;
            this.btn_Music.Tag = "Music";
            this.btn_Music.Text = "Music";
            this.btn_Music.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Music.UseVisualStyleBackColor = false;
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemItems});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(180, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemLoad,
            this.menuItemSave,
            this.menuItemQuit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(180, 22);
            this.menuItemNew.Text = "New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemLoad
            // 
            this.menuItemLoad.Name = "menuItemLoad";
            this.menuItemLoad.Size = new System.Drawing.Size(180, 22);
            this.menuItemLoad.Text = "Load";
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(180, 22);
            this.menuItemSave.Text = "Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemQuit
            // 
            this.menuItemQuit.Name = "menuItemQuit";
            this.menuItemQuit.Size = new System.Drawing.Size(180, 22);
            this.menuItemQuit.Text = "Quit";
            // 
            // menuItemItems
            // 
            this.menuItemItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdd,
            this.menuItemRemove,
            this.menuItemClearAll});
            this.menuItemItems.Name = "menuItemItems";
            this.menuItemItems.Size = new System.Drawing.Size(48, 20);
            this.menuItemItems.Text = "Items";
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(180, 22);
            this.menuItemAdd.Text = "Add";
            this.menuItemAdd.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // menuItemRemove
            // 
            this.menuItemRemove.Name = "menuItemRemove";
            this.menuItemRemove.Size = new System.Drawing.Size(180, 22);
            this.menuItemRemove.Text = "Remove";
            this.menuItemRemove.Click += new System.EventHandler(this.menuItemRemove_Click);
            // 
            // menuItemClearAll
            // 
            this.menuItemClearAll.Name = "menuItemClearAll";
            this.menuItemClearAll.Size = new System.Drawing.Size(180, 22);
            this.menuItemClearAll.Text = "ClearAll";
            this.menuItemClearAll.Click += new System.EventHandler(this.menuItemClearAll_Click);
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
            // btn_CloseApp
            // 
            this.btn_CloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_CloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // panel_SongDetails
            // 
            this.panel_SongDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(171)))));
            this.panel_SongDetails.Controls.Add(this.lbl_RightPlaylistCreateDate);
            this.panel_SongDetails.Controls.Add(this.lbl_RightPlaylistAuthor);
            this.panel_SongDetails.Controls.Add(this.lbl_RightPlaylistDuration);
            this.panel_SongDetails.Controls.Add(this.lbl_RightPlaylistName);
            this.panel_SongDetails.Controls.Add(this.CreatorInfo);
            this.panel_SongDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_SongDetails.Location = new System.Drawing.Point(992, 37);
            this.panel_SongDetails.Margin = new System.Windows.Forms.Padding(0);
            this.panel_SongDetails.Name = "panel_SongDetails";
            this.panel_SongDetails.Size = new System.Drawing.Size(200, 652);
            this.panel_SongDetails.TabIndex = 2;
            this.panel_SongDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_SongDetails_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CreatorInfo
            // 
            this.CreatorInfo.AutoSize = true;
            this.CreatorInfo.BackColor = System.Drawing.Color.Transparent;
            this.CreatorInfo.Location = new System.Drawing.Point(68, 630);
            this.CreatorInfo.Name = "CreatorInfo";
            this.CreatorInfo.Size = new System.Drawing.Size(110, 13);
            this.CreatorInfo.TabIndex = 0;
            this.CreatorInfo.Text = "Autor: Damian Scherl ";
            // 
            // lv_Center_AllItems
            // 
            this.lv_Center_AllItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Center_AllItems.HideSelection = false;
            this.lv_Center_AllItems.Location = new System.Drawing.Point(180, 37);
            this.lv_Center_AllItems.Name = "lv_Center_AllItems";
            this.lv_Center_AllItems.Size = new System.Drawing.Size(812, 652);
            this.lv_Center_AllItems.TabIndex = 5;
            this.lv_Center_AllItems.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_RightPlaylistName
            // 
            this.lbl_RightPlaylistName.AutoSize = true;
            this.lbl_RightPlaylistName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RightPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RightPlaylistName.Location = new System.Drawing.Point(23, 21);
            this.lbl_RightPlaylistName.Name = "lbl_RightPlaylistName";
            this.lbl_RightPlaylistName.Size = new System.Drawing.Size(150, 18);
            this.lbl_RightPlaylistName.TabIndex = 5;
            this.lbl_RightPlaylistName.Text = "Das ist ein Platzhalter";
            // 
            // lbl_RightPlaylistDuration
            // 
            this.lbl_RightPlaylistDuration.AutoSize = true;
            this.lbl_RightPlaylistDuration.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RightPlaylistDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RightPlaylistDuration.Location = new System.Drawing.Point(23, 85);
            this.lbl_RightPlaylistDuration.Name = "lbl_RightPlaylistDuration";
            this.lbl_RightPlaylistDuration.Size = new System.Drawing.Size(125, 18);
            this.lbl_RightPlaylistDuration.TabIndex = 6;
            this.lbl_RightPlaylistDuration.Text = "Die Playlist dauert";
            // 
            // lbl_RightPlaylistAuthor
            // 
            this.lbl_RightPlaylistAuthor.AutoSize = true;
            this.lbl_RightPlaylistAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RightPlaylistAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RightPlaylistAuthor.Location = new System.Drawing.Point(23, 154);
            this.lbl_RightPlaylistAuthor.Name = "lbl_RightPlaylistAuthor";
            this.lbl_RightPlaylistAuthor.Size = new System.Drawing.Size(101, 18);
            this.lbl_RightPlaylistAuthor.TabIndex = 7;
            this.lbl_RightPlaylistAuthor.Text = "Playlist Author";
            this.lbl_RightPlaylistAuthor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_RightPlaylistCreateDate
            // 
            this.lbl_RightPlaylistCreateDate.AutoSize = true;
            this.lbl_RightPlaylistCreateDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RightPlaylistCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RightPlaylistCreateDate.Location = new System.Drawing.Point(23, 204);
            this.lbl_RightPlaylistCreateDate.Name = "lbl_RightPlaylistCreateDate";
            this.lbl_RightPlaylistCreateDate.Size = new System.Drawing.Size(110, 15);
            this.lbl_RightPlaylistCreateDate.TabIndex = 8;
            this.lbl_RightPlaylistCreateDate.Text = "Playlist CreateDate";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(128, 128);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1192, 689);
            this.Controls.Add(this.lv_Center_AllItems);
            this.Controls.Add(this.panel_SongDetails);
            this.Controls.Add(this.panel_TopMenue);
            this.Controls.Add(this.panel_ControlLeft);
            this.Name = "Form1";
            this.Text = "Playlist Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel_ControlLeft.ResumeLayout(false);
            this.panel_ControlLeft.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel_TopMenue.ResumeLayout(false);
            this.panel_SongDetails.ResumeLayout(false);
            this.panel_SongDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel_ControlLeft;
        private System.Windows.Forms.Panel panel_TopMenue;
        private System.Windows.Forms.Panel panel_SongDetails;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_MenuBurger;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private FontAwesome.Sharp.IconButton btn_Image;
        private FontAwesome.Sharp.IconButton btn_Video;
        private FontAwesome.Sharp.IconButton btn_Music;
        private FontAwesome.Sharp.IconButton btn_CloseApp;
        private FontAwesome.Sharp.IconButton btn_MinimizeApp;
        private FontAwesome.Sharp.IconButton btn_MaximizeApp;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoad;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem menuItemItems;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem menuItemRemove;
        private System.Windows.Forms.ToolStripMenuItem menuItemClearAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_RightPlaylistDuration;
        private System.Windows.Forms.Label lbl_RightPlaylistName;
        private System.Windows.Forms.Label CreatorInfo;
        private System.Windows.Forms.ListView lv_Center_AllItems;
        private System.Windows.Forms.Label lbl_RightPlaylistAuthor;
        private System.Windows.Forms.Label lbl_RightPlaylistCreateDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

