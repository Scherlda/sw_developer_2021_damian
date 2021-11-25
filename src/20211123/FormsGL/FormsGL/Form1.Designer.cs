namespace FormsGL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btt_Clear = new System.Windows.Forms.Button();
            this.btt_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Titel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btt_Load = new System.Windows.Forms.Button();
            this.btt_Exit = new System.Windows.Forms.Button();
            this.lbl_Show = new System.Windows.Forms.TextBox();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Verlag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btt_Clear
            // 
            this.btt_Clear.Location = new System.Drawing.Point(177, 220);
            this.btt_Clear.Name = "btt_Clear";
            this.btt_Clear.Size = new System.Drawing.Size(100, 40);
            this.btt_Clear.TabIndex = 0;
            this.btt_Clear.Text = "Leeren";
            this.btt_Clear.UseVisualStyleBackColor = true;
            this.btt_Clear.Click += new System.EventHandler(this.ClearFormContent);
            // 
            // btt_Save
            // 
            this.btt_Save.Location = new System.Drawing.Point(33, 220);
            this.btt_Save.Name = "btt_Save";
            this.btt_Save.Size = new System.Drawing.Size(100, 40);
            this.btt_Save.TabIndex = 1;
            this.btt_Save.Text = "Speichern";
            this.btt_Save.UseVisualStyleBackColor = true;
            this.btt_Save.Click += new System.EventHandler(this.btt_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titel";
            // 
            // txt_Titel
            // 
            this.txt_Titel.Location = new System.Drawing.Point(122, 30);
            this.txt_Titel.Name = "txt_Titel";
            this.txt_Titel.Size = new System.Drawing.Size(268, 20);
            this.txt_Titel.TabIndex = 3;
            this.txt_Titel.Text = "Hier!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buchverwaltung";
            // 
            // btt_Load
            // 
            this.btt_Load.Location = new System.Drawing.Point(323, 220);
            this.btt_Load.Name = "btt_Load";
            this.btt_Load.Size = new System.Drawing.Size(100, 40);
            this.btt_Load.TabIndex = 5;
            this.btt_Load.Text = "Alles Laden";
            this.btt_Load.UseVisualStyleBackColor = true;
            // 
            // btt_Exit
            // 
            this.btt_Exit.Location = new System.Drawing.Point(323, 496);
            this.btt_Exit.Name = "btt_Exit";
            this.btt_Exit.Size = new System.Drawing.Size(100, 40);
            this.btt_Exit.TabIndex = 6;
            this.btt_Exit.Text = "Verlassen";
            this.btt_Exit.UseVisualStyleBackColor = true;
            // 
            // lbl_Show
            // 
            this.lbl_Show.Location = new System.Drawing.Point(33, 276);
            this.lbl_Show.Multiline = true;
            this.lbl_Show.Name = "lbl_Show";
            this.lbl_Show.Size = new System.Drawing.Size(390, 200);
            this.lbl_Show.TabIndex = 7;
            // 
            // txt_Autor
            // 
            this.txt_Autor.Location = new System.Drawing.Point(122, 56);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(268, 20);
            this.txt_Autor.TabIndex = 9;
            this.txt_Autor.Text = "Hier!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Autor";
            // 
            // txt_Verlag
            // 
            this.txt_Verlag.Location = new System.Drawing.Point(122, 82);
            this.txt_Verlag.Name = "txt_Verlag";
            this.txt_Verlag.Size = new System.Drawing.Size(268, 20);
            this.txt_Verlag.TabIndex = 11;
            this.txt_Verlag.Text = "Hier!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Verlag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Erscheinungsjahr";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(78, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Titel);
            this.groupBox1.Controls.Add(this.txt_Verlag);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Autor);
            this.groupBox1.Location = new System.Drawing.Point(33, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 148);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neue Buchdaten";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(476, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Show);
            this.Controls.Add(this.btt_Exit);
            this.Controls.Add(this.btt_Load);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btt_Save);
            this.Controls.Add(this.btt_Clear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NetPro BookManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_Clear;
        private System.Windows.Forms.Button btt_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Titel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btt_Load;
        private System.Windows.Forms.Button btt_Exit;
        private System.Windows.Forms.TextBox lbl_Show;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Verlag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

