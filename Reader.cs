using generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Читатель(Reader):
//Свойства: Имя, Номер читательского билета, Список взятых книг.
//Методы: Взять книгу, Вернуть книгу.
book book1 = new book("tven ", "jony","Horror ", 3456);
Reader reader = new Reader("joe", 356765);


//reader.AddBook(book1);
//reader.Info();
//reader.DeletBook(book1);
//reader.Info();


namespace generic
{
    internal class Reader
    {
        public string Name { get; set; }
        public int NumBilet { get; set; }
        List<book> books = new List<book>();

        public Reader(string name, int num)
        {
            Name = name;
            NumBilet = num;
            
        }

        public void AddBook(book book) {  books.Add(book); Console.WriteLine($"{book.Title} ADD"); }

        public void DeletBook(book book) { books.Remove(book); Console.WriteLine($"{book.Title} dell"); }

        public void Info() 
        {
            foreach (var i in books)
            {
                Console.WriteLine(i.Title);
            }
        }
        
    }
}
