using System;

namespace ClassBook
{
    class Book
    {
        Author author = new Author();
        Title title = new Title();
        Content content = new Content();
        public Book(){}
        public Book(string nameOfTitle, string nameOfAuthor, string nameOfContent)
        {
            this.title.nameOfTitle = nameOfTitle;
            this.author.nameOfAuthor = nameOfAuthor;
            this.content.nameOfContent = nameOfContent;
        }
        public void ShowBook()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            author.Show();
            Console.ForegroundColor = ConsoleColor.Blue;
            title.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            content.Show();
        }
    }
    class Title
    {
        public string nameOfTitle;
        public void Show()
        {
            Console.WriteLine($"Название книги: {nameOfTitle}");
        }
    }
    public class Author
    {
        public string nameOfAuthor;
        public void Show()
        {
            Console.WriteLine($"Автор книги: {nameOfAuthor}");
        }
    }
    class Content
    {
        public string nameOfContent;
        public void Show()
        {
            Console.WriteLine($"Жанр книги: {nameOfContent}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует класс Book!");
            string[] author = {"Марк Твен", "Джордж Оруелл", "Анна Тод", "Роберт Кийосаки"};
            string[] title = {"Том Сойер", "1984", "После", "Богатый папа, Бедный папа"};
            string[] content = {"Художественная литература", "Антиутопия", "Роман", "Бизнес и финансы"};
            for (int  i = 0; i < author.Length; i++)
            {
                Console.WriteLine($"Книга №{i+1}");
                Book book = new Book(author[i], title[i], content[i]);
                book.ShowBook();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
