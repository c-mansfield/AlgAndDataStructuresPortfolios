using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Library
{
    public partial class Form1 : Form
    {

        Dictionary<string, Book> librarydic = new Dictionary<string, Book>();
        //Book[] books = new Book[100];
        String isbn_Input;
        String title_Input;

        public Form1()
        {
            InitializeComponent();

            returnListItems();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            isbn_Input = txt_Isbn.Text;
            title_Input = txt_Title.Text;
            Book book = new Book(isbn_Input, title_Input.ToLower());

            if (!librarydic.ContainsKey(isbn_Input))
            {
                librarydic.Add(book.ISBN, book);
                returnListItems();
            }

            else
            {
                lbl_Outputs.Text = "ISBN already in use!";
            }
            

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            isbn_Input = txt_Isbn.Text;
            librarydic.Remove(isbn_Input);

            returnListItems();
        }

        private void returnListItems()
        {
            listBox1.Items.Clear();

            foreach (var item in librarydic)
            {
                //add to the ListBox
                listBox1.Items.Add(item.Value.ISBN);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbl_Outputs.Text = "ISBN = " +;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            foreach (KeyValuePair<string, Book> item in librarydic)
            {
                if (txt_Search.Text == item.Key || item.Value.Title.Contains(txt_Search.Text))
                {
                    lbl_Outputs.Text = "ISBN = " + item.Value.ISBN
                        + "\nTitle = " + item.Value.Title
                        + "\nOn loan = " + item.Value.Onloan;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Book> item in librarydic)
            {
                if ((txt_Search.Text == item.Key || item.Value.Title.Contains(txt_Search.Text)) && item.Value.Onloan.Equals(true))
                {
                    item.Value.Onloan = false;
                    lbl_Outputs.Text = "Loan value changed to false!";

                }

                else if ((txt_Search.Text == item.Key || item.Value.Title.Contains(txt_Search.Text)) && item.Value.Onloan.Equals(false))
                {
                    item.Value.Onloan = true;
                    lbl_Outputs.Text = "Loan value changed to true!";
                }
            }
        }
    }
}
