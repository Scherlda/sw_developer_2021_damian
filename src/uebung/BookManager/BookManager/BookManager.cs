using BookManager.StorageTypes;
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
        private List<IBook> _myBookList;
        private IStorage _storage;
        public BookManager()
        {
            InitializeComponent();
            _myBookList = new List<IBook>();
            //_storage = new JsonStorage();
            _storage = new XmlStorage();


            //dGV_BookOverview.Columns.Add("Title", "Title");
            //dGV_BookOverview.Columns.Add("Autor", "Autor");
            //dGV_BookOverview.Columns.Add("Publisher", "Publisher");
            //dGV_BookOverview.Columns.Add("Age Recommendation", "Age Recommendation");
            //dGV_BookOverview.Columns.Add("Language", "Language");
            //dGV_BookOverview.Columns.Add("Year Of Publication", "Year Of Publication");
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
            txt_Title.Focus();
        }

        

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var newBook = new Book(txt_Title.Text, txt_Autor.Text, txt_Publisher.Text, Convert.ToInt32(txt_AgeRecommendation.Text), txt_Language.Text, Convert.ToInt32(txt_YearOfPublication.Text));
            _myBookList.Add(newBook);
    
            DisplayBookList(_myBookList);
            btn_ClearAll_Click(null, null);
        }

        private void DisplayBookList(IEnumerable<IBook> booksToDisplay)
        {
            dGV_BookOverview.DataSource = null;
            dGV_BookOverview.DataSource = booksToDisplay;
            //foreach (var book in booksToDisplay)
            //{
            //    txt_bookListView.Text += book.Title + Environment.NewLine;
            //    txt_bookListView.Show();
            //}
        }

        private void list_BookOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Sauberer Weg ein program zu beenden
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_myBookList == null || _myBookList.Count == 0)
            {
                return;
            }

            var erg = _storage.Save(_myBookList, "MyBookList.dat");
            if (erg)
            {
                MessageBox.Show("Bücherliste wurde  erfolgreich gespeichert",
                    "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _myBookList.Clear();

            _myBookList.AddRange(_storage.Load("MyBookList.dat")); //Load liefert eine Liste

            DisplayBookList(_myBookList);
        }


        private void txt_bookListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}

