﻿using System;
using System.Collections.Generic;

namespace AspNETMVCTest.Models
{
    public class BookRepository : IBookRepository
    {
        private static int _nextId = 0;

        private static readonly List<BookDetails> _book = new List<BookDetails>();

        public List<BookDetails> Books
        {
            get
            {
                return _book;
            }
        }

        public void Add(BookDetails newBook)
        {
            if (newBook == null)
            {
                throw new ArgumentNullException("Parameter newBook can't be null.");
            }

            newBook.Id = _nextId;
            _book.Add(newBook);

            _nextId++;
        }
    }
}
