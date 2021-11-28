using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class BookManager : Form
    {

        DataTable BookDB = new DataTable();

        public BookManager()
        {
            InitializeComponent();
            BookDB.Columns.Add("Title", typeof(string));
            BookDB.Columns.Add("Autor", typeof(string));
            BookDB.Columns.Add("Publisher", typeof(string));
            BookDB.Columns.Add("Age Recommendation", typeof(string));
            BookDB.Columns.Add("Language", typeof(string));
            BookDB.Columns.Add("Year Of Publication", typeof(string));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookManager_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            txt_Title.Text = string.Empty;
            txt_Autor.Text = string.Empty;
            txt_Publisher.Text = string.Empty;
            txt_AgeRecommendation.Text = string.Empty;
            txt_Language.Text = string.Empty;
            txt_YearOfPublication.Text = string.Empty;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var newBook = new Book(txt_Title.Text, txt_Autor.Text, txt_Publisher.Text, txt_AgeRecommendation.Text, txt_Language.Text, txt_YearOfPublication.Text);

            BookDB.Rows.Add(new object[]{ newBook });

            dGV_BookOverview.DataSource = BookDB;

            btn_ClearAll_Click(null, null);
        }

        private void list_BookOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

