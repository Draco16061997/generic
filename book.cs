using generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Книга (Book):
//Свойства: Название, Автор, Год издания, Жанр, Уникальный идентификатор (ISBN).
//Методы: Конструктор для инициализации книги.





namespace generic
{
    internal class book
    {
        public string Title { get; }
        public string Autor { get; }
        public string Janr { get; }
        public double ISBN { get; }

        public book(string title, string autor, string janr, double iSBN)
        {
            Title = title;
            Autor = autor;
            Janr = janr;
            ISBN = iSBN;
        }   
    }
}



