namespace Wifi.PlaylistEditor.UI
{
    partial class frmNewPlaylist
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
            this.btn_NewPlaylistCreate = new System.Windows.Forms.Button();
            this.btn_NewPlaylistCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NPLTitle = new System.Windows.Forms.TextBox();
            this.textBox_NPLAuthor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CloseApp = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_NewPlaylistCreate
            // 
            this.btn_NewPlaylistCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(171)))));
            this.btn_NewPlaylistCreate.Location = new System.Drawing.Point(88, 125);
            this.btn_NewPlaylistCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NewPlaylistCreate.Name = "btn_NewPlaylistCreate";
            this.btn_NewPlaylistCreate.Size = new System.Drawing.Size(75, 23);
            this.btn_NewPlaylistCreate.TabIndex = 0;
            this.btn_NewPlaylistCreate.Text = "Create";
            this.btn_NewPlaylistCreate.UseVisualStyleBackColor = false;
            this.btn_NewPlaylistCreate.Click += new System.EventHandler(this.btn_NewPlaylistCreate_Click);
            // 
            // btn_NewPlaylistCancel
            // 
            this.btn_NewPlaylistCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(193)))), ((int)(((byte)(176)))));
            this.btn_NewPlaylistCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_NewPlaylistCancel.Location = new System.Drawing.Point(248, 125);
            this.btn_NewPlaylistCancel.Name = "btn_NewPlaylistCancel";
            this.btn_NewPlaylistCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_NewPlaylistCancel.TabIndex = 1;
            this.btn_NewPlaylistCancel.Text = "Cancel";
            this.btn_NewPlaylistCancel.UseVisualStyleBackColor = false;
            this.btn_NewPlaylistCancel.Click += new System.EventHandler(this.btn_NewPlaylistCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author";
            // 
            // textBox_NPLTitle
            // 
            this.textBox_NPLTitle.Location = new System.Drawing.Point(88, 24);
            this.textBox_NPLTitle.Name = "textBox_NPLTitle";
            this.textBox_NPLTitle.Size = new System.Drawing.Size(235, 20);
            this.textBox_NPLTitle.TabIndex = 4;
            this.textBox_NPLTitle.TextChanged += new System.EventHandler(this.textBox_NPLTitle_TextChanged);
            // 
            // textBox_NPLAuthor
            // 
            this.textBox_NPLAuthor.Location = new System.Drawing.Point(88, 77);
            this.textBox_NPLAuthor.Name = "textBox_NPLAuthor";
            this.textBox_NPLAuthor.Size = new System.Drawing.Size(235, 20);
            this.textBox_NPLAuthor.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.btn_CloseApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 23);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TopMenue_MouseDown);
            // 
            // btn_CloseApp
            // 
            this.btn_CloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_CloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CloseApp.FlatAppearance.BorderSize = 0;
            this.btn_CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseApp.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_CloseApp.IconColor = System.Drawing.Color.White;
            this.btn_CloseApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CloseApp.IconSize = 20;
            this.btn_CloseApp.Location = new System.Drawing.Point(344, 0);
            this.btn_CloseApp.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CloseApp.Name = "btn_CloseApp";
            this.btn_CloseApp.Size = new System.Drawing.Size(40, 23);
            this.btn_CloseApp.TabIndex = 3;
            this.btn_CloseApp.UseVisualStyleBackColor = false;
            this.btn_CloseApp.Click += new System.EventHandler(this.btn_CloseApp_Click);
            // 
            // frmNewPlaylist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btn_NewPlaylistCancel;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_NPLAuthor);
            this.Controls.Add(this.textBox_NPLTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NewPlaylistCancel);
            this.Controls.Add(this.btn_NewPlaylistCreate);
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "frmNewPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neue Playlist erzeugen";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewPlaylistCreate;
        private System.Windows.Forms.Button btn_NewPlaylistCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NPLTitle;
        private System.Windows.Forms.TextBox textBox_NPLAuthor;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_CloseApp;
    }
}