﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Library
{
    class Book
    {
        private String isbn;
        private string title;
        private Boolean onloan;

        public Book(string isbn, string title)
        {
            this.isbn = isbn;
            this.title = title;
        }
        public string ISBN
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public Boolean Onloan
        {
            get { return this.onloan; }
            set { this.onloan = value; }
        }

    }
}
