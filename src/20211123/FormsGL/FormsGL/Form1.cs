using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsGL
{
    public partial class Form1 : Form
    {
        private List<IBook> _myBooks;


        public Form1()
        {
            InitializeComponent();

            _myBooks = new List<IBook>();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClearFormContent(object sender, EventArgs e)
        {
            txt_Titel.Text = String.Empty;
            txt_Autor.Text = String.Empty;
            txt_Verlag.Text = String.Empty;
            
        }

        private void btt_Save_Click(object sender, EventArgs e)
        {
            var newBook = new Book(txt_Titel.Text, txt_Autor.Text, txt_Verlag.Text, dateTimePicker1.Value);

            _myBooks.Add(newBook);
            ClearFormContent(null, null);
        }
    }
}
