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
Reader<long> reader = new Reader<long>("joe", 356765);


reader.AddBook(book1);
reader.Info();
reader.DeletBook(book1);
reader.Info();


namespace generic
{
    internal class Reader<T>
    {
        public string Name { get; set; }
        public T NumBilet { get; set; }
        List<book> books { get; set; }

        public Reader(string name, T num)
        {
            Name = name;
            NumBilet = num;
            books = new List<book>();
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
