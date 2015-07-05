using System.Collections.Generic;

namespace AspNETMVCTest.Models
{
    internal interface IBookRepository
    {
        List<BookDetails> Books { get; }

        void Add(BookDetails newBook);
    }
}
