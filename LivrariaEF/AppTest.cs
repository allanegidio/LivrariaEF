using LivrariaEF.Models;
using LivrariaEF.Repositories;
using LivrariaEF.UnitOfWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LivrariaEF
{
    [TestClass]
    public class AppTest
    {
        DatabaseContext _databaseContext;
        IUnitOfWork _uow;
        IBookRepository _bookRepository;
        IAuthorRepository _authorRepository;
        IShelfRepository _shelfRepository;

        List<Author> _authors;
        List<Book> _books;

        [TestInitialize]
        public void Initialize()
        {
            _databaseContext = new DatabaseContext();
            _uow = new UnitOfWork.UnitOfWork(_databaseContext);
            _bookRepository = new BookRepository(_databaseContext);
            _authorRepository = new AuthorRepository(_databaseContext);
            _shelfRepository = new ShelfRepository(_databaseContext);
            _authors = new List<Author>();
            _books = new List<Book>();
        }

        [TestMethod]
        public void AdicionandoLivro()
        {
            var shelf = new Shelf
            {
                Number = 500
            };
            

            _authors.Add(new Author() { Name = "Allan Boladao" });
            _authors.Add(new Author() { Name = "Ludwig Von Mises" });

            var book = new Book
            {
                Name = "Como nao destruir o pais",
                Shelf = shelf,
                Authors = _authors
            };

            var books = _bookRepository.Get();
            
            _bookRepository.Add(book);
            _uow.Commit();
        }

        [TestMethod]
        public void AdicionandoAuthor()
        {
            var shelf = new Shelf
            {
                Number = 5000
            };


            _books.Add(new Book() { Name = "Malditos Comunistas", Shelf = shelf });
            _books.Add(new Book() { Name = "Parasitas do Estado", Shelf = shelf });

            var author = new Author
            {
                Name = "Allan Egidio",
                Books = _books,
            };

            var authors = _authorRepository.Get();

            _authorRepository.Add(author);
            _uow.Commit();
        }

        [TestMethod]
        public void ExcluindoAutor()
        {
            var id = 1;
            var authors = _authorRepository.Get();
            _authorRepository.Delete(id);
            _uow.Commit();
            var result = _authorRepository.Get();
        }

        [TestMethod]
        public void AdicionandoEstante()
        {
            var shelf = new Shelf
            {
                Number = 100
            };

            _shelfRepository.Add(shelf);
            _uow.Commit();
        }

        [TestMethod]
        public void ExcluindoEstante()
        {
            var id = 10;
            var shelfs = _shelfRepository.Get();
            _shelfRepository.Delete(id);
            _uow.Commit();
            var result = _shelfRepository.Get();

        }
    }
}
