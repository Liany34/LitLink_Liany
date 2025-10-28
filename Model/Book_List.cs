using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book_List : BaseEntity
    {
        private Reader idReader;
        private string listName;
        private bool isPublic;

        public Reader IdReader { get => idReader; set => idReader = value; }
        public string ListName { get => listName; set => listName = value; }
        public bool IsPublic { get => isPublic; set => isPublic = value; }

        public override string ToString()
        {
            return $"List Name: {ListName}, Reader: {IdReader.Username}, Is Public?: {IsPublic}";
        }
    }
}
