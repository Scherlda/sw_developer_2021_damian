namespace UI_Buchverwaltung
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureOfBook = new System.Windows.Forms.PictureBox();
            this.tab_overview = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfBook)).BeginInit();
            this.tab_overview.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(25, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 193);
            this.panel1.TabIndex = 0;
            // 
            // pictureOfBook
            // 
            this.pictureOfBook.Location = new System.Drawing.Point(647, 62);
            this.pictureOfBook.Name = "pictureOfBook";
            this.pictureOfBook.Size = new System.Drawing.Size(148, 193);
            this.pictureOfBook.TabIndex = 1;
            this.pictureOfBook.TabStop = false;
            // 
            // tab_overview
            // 
            this.tab_overview.Controls.Add(this.tabPage1);
            this.tab_overview.Controls.Add(this.tabPage2);
            this.tab_overview.Location = new System.Drawing.Point(0, 35);
            this.tab_overview.Name = "tab_overview";
            this.tab_overview.SelectedIndex = 0;
            this.tab_overview.Size = new System.Drawing.Size(1022, 526);
            this.tab_overview.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.pictureOfBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 561);
            this.Controls.Add(this.tab_overview);
            this.Name = "Form1";
            this.Text = "NetPro BookManager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfBook)).EndInit();
            this.tab_overview.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureOfBook;
        private System.Windows.Forms.TabControl tab_overview;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

