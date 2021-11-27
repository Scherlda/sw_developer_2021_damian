namespace BookManager
{
    partial class BookManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManager));
            this.list_BookOverview = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.txt_YearOfPublication = new System.Windows.Forms.TextBox();
            this.lbl_YearOfPublication = new System.Windows.Forms.Label();
            this.txt_Language = new System.Windows.Forms.TextBox();
            this.lbl_Language = new System.Windows.Forms.Label();
            this.txt_AgeRecommendation = new System.Windows.Forms.TextBox();
            this.txt_Publisher = new System.Windows.Forms.TextBox();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.pic_BookCover = new System.Windows.Forms.PictureBox();
            this.lbl_AgeRecommendation = new System.Windows.Forms.Label();
            this.lbl_Publisher = new System.Windows.Forms.Label();
            this.lbl_Autor = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // list_BookOverview
            // 
            this.list_BookOverview.HideSelection = false;
            this.list_BookOverview.Location = new System.Drawing.Point(719, 82);
            this.list_BookOverview.Name = "list_BookOverview";
            this.list_BookOverview.Size = new System.Drawing.Size(516, 529);
            this.list_BookOverview.TabIndex = 0;
            this.list_BookOverview.UseCompatibleStateImageBehavior = false;
            this.list_BookOverview.SelectedIndexChanged += new System.EventHandler(this.list_BookOverview_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_ClearAll);
            this.panel1.Controls.Add(this.txt_YearOfPublication);
            this.panel1.Controls.Add(this.lbl_YearOfPublication);
            this.panel1.Controls.Add(this.txt_Language);
            this.panel1.Controls.Add(this.lbl_Language);
            this.panel1.Controls.Add(this.txt_AgeRecommendation);
            this.panel1.Controls.Add(this.txt_Publisher);
            this.panel1.Controls.Add(this.txt_Autor);
            this.panel1.Controls.Add(this.txt_Title);
            this.panel1.Controls.Add(this.pic_BookCover);
            this.panel1.Controls.Add(this.lbl_AgeRecommendation);
            this.panel1.Controls.Add(this.lbl_Publisher);
            this.panel1.Controls.Add(this.lbl_Autor);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 529);
            this.panel1.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(564, 486);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 40);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(379, 486);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(114, 40);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(186, 486);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(114, 40);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.Location = new System.Drawing.Point(13, 486);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(114, 40);
            this.btn_ClearAll.TabIndex = 12;
            this.btn_ClearAll.Text = "Clear all";
            this.btn_ClearAll.UseVisualStyleBackColor = true;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // txt_YearOfPublication
            // 
            this.txt_YearOfPublication.Location = new System.Drawing.Point(141, 289);
            this.txt_YearOfPublication.Name = "txt_YearOfPublication";
            this.txt_YearOfPublication.Size = new System.Drawing.Size(321, 20);
            this.txt_YearOfPublication.TabIndex = 11;
            // 
            // lbl_YearOfPublication
            // 
            this.lbl_YearOfPublication.AutoSize = true;
            this.lbl_YearOfPublication.Location = new System.Drawing.Point(10, 292);
            this.lbl_YearOfPublication.Name = "lbl_YearOfPublication";
            this.lbl_YearOfPublication.Size = new System.Drawing.Size(95, 13);
            this.lbl_YearOfPublication.TabIndex = 10;
            this.lbl_YearOfPublication.Text = "Year of publication";
            // 
            // txt_Language
            // 
            this.txt_Language.Location = new System.Drawing.Point(141, 236);
            this.txt_Language.Name = "txt_Language";
            this.txt_Language.Size = new System.Drawing.Size(321, 20);
            this.txt_Language.TabIndex = 9;
            // 
            // lbl_Language
            // 
            this.lbl_Language.AutoSize = true;
            this.lbl_Language.Location = new System.Drawing.Point(10, 239);
            this.lbl_Language.Name = "lbl_Language";
            this.lbl_Language.Size = new System.Drawing.Size(55, 13);
            this.lbl_Language.TabIndex = 8;
            this.lbl_Language.Text = "Language";
            // 
            // txt_AgeRecommendation
            // 
            this.txt_AgeRecommendation.Location = new System.Drawing.Point(141, 178);
            this.txt_AgeRecommendation.Name = "txt_AgeRecommendation";
            this.txt_AgeRecommendation.Size = new System.Drawing.Size(321, 20);
            this.txt_AgeRecommendation.TabIndex = 7;
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.Location = new System.Drawing.Point(141, 122);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(321, 20);
            this.txt_Publisher.TabIndex = 6;
            // 
            // txt_Autor
            // 
            this.txt_Autor.Location = new System.Drawing.Point(141, 71);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(321, 20);
            this.txt_Autor.TabIndex = 5;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(141, 24);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(321, 20);
            this.txt_Title.TabIndex = 4;
            // 
            // pic_BookCover
            // 
            this.pic_BookCover.Location = new System.Drawing.Point(483, 15);
            this.pic_BookCover.Name = "pic_BookCover";
            this.pic_BookCover.Size = new System.Drawing.Size(151, 202);
            this.pic_BookCover.TabIndex = 3;
            this.pic_BookCover.TabStop = false;
            // 
            // lbl_AgeRecommendation
            // 
            this.lbl_AgeRecommendation.AutoSize = true;
            this.lbl_AgeRecommendation.Location = new System.Drawing.Point(10, 181);
            this.lbl_AgeRecommendation.Name = "lbl_AgeRecommendation";
            this.lbl_AgeRecommendation.Size = new System.Drawing.Size(107, 13);
            this.lbl_AgeRecommendation.TabIndex = 3;
            this.lbl_AgeRecommendation.Text = "Age recommendation";
            // 
            // lbl_Publisher
            // 
            this.lbl_Publisher.AutoSize = true;
            this.lbl_Publisher.Location = new System.Drawing.Point(10, 125);
            this.lbl_Publisher.Name = "lbl_Publisher";
            this.lbl_Publisher.Size = new System.Drawing.Size(50, 13);
            this.lbl_Publisher.TabIndex = 2;
            this.lbl_Publisher.Text = "Publisher";
            // 
            // lbl_Autor
            // 
            this.lbl_Autor.AutoSize = true;
            this.lbl_Autor.Location = new System.Drawing.Point(10, 74);
            this.lbl_Autor.Name = "lbl_Autor";
            this.lbl_Autor.Size = new System.Drawing.Size(32, 13);
            this.lbl_Autor.TabIndex = 1;
            this.lbl_Autor.Text = "Autor";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(10, 27);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(27, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Title";
            this.lbl_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // BookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 623);
            this.Controls.Add(this.list_BookOverview);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookManager";
            this.Text = "Book Manager";
            this.Load += new System.EventHandler(this.BookManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_BookOverview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_AgeRecommendation;
        private System.Windows.Forms.TextBox txt_Publisher;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.PictureBox pic_BookCover;
        private System.Windows.Forms.Label lbl_AgeRecommendation;
        private System.Windows.Forms.Label lbl_Publisher;
        private System.Windows.Forms.Label lbl_Autor;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_YearOfPublication;
        private System.Windows.Forms.Label lbl_YearOfPublication;
        private System.Windows.Forms.TextBox txt_Language;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_ClearAll;
    }
}

