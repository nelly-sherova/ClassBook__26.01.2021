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
            author.Show();
            title.Show();
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
            Console.WriteLine("Hello World!");
        }
    }
}
