using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class List_Detail : BaseEntity
    {
        private Book_List idList;
        private Book idBook;

        public Book_List IdList { get => idList; set => idList = value; }
        public Book IdBook { get => idBook; set => idBook = value; }

        public override string ToString()
        {
            return $"List Name: {IdList.ListName}, Book Title: {IdBook}";
        }
    }
}
