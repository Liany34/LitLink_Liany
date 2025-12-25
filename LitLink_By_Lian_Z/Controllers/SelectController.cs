using Microsoft.AspNetCore.Mvc;
using Model;
using System.Reflection;
using ViewModel;

namespace LitLink_By_Lian_Z_.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectController : Controller
    {
        // Author
        [HttpGet]
        [ActionName("AuthorSelector")]
        public ListAuthor SelectAllAuthors()
        {
            AuthorDB db = new AuthorDB();
            ListAuthor authors = db.SelectAll();
            return authors;
        }

        [HttpPost]
        public int InsertAnAuthor([FromBody] Author author)
        {
            AuthorDB db = new AuthorDB();
            db.Insert(author);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAnAuthor([FromBody] Author author)
        {
            AuthorDB db = new AuthorDB();
            db.Update(author);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteAnAuthor(int id)
        {
            Author author = AuthorDB.SelectById(id);
            AuthorDB db = new AuthorDB();
            db.Delete(author);
            int x = db.SaveChanges();
            return x;
        }


        // Book
        [HttpGet]
        [ActionName("BookSelector")]
        public ListBook SelectAllBooks()
        {
            BookDB db = new BookDB();
            ListBook books = db.SelectAll();
            return books;
        }

        [HttpPost]
        public int InsertABook([FromBody] Book book)
        {
            BookDB db = new BookDB();
            db.Insert(book);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateABook([FromBody] Book book)
        {
            BookDB db = new BookDB();
            db.Update(book);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteABook(int id)
        {
            Book book = BookDB.SelectById(id);
            BookDB db = new BookDB();
            db.Delete(book);
            int x = db.SaveChanges();
            return x;
        }


        // Book_List
        [HttpGet]
        [ActionName("BookListSelector")]
        public ListBook_List SelectAllBookLists()
        {
            Book_ListDB db = new Book_ListDB();
            ListBook_List bookLists = db.SelectAll();
            return bookLists;
        }

        [HttpPost]
        public int InsertABookList([FromBody] Book_List bookList)
        {
            Book_ListDB db = new Book_ListDB();
            db.Insert(bookList);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateABookList([FromBody] Book_List bookList)
        {
            Book_ListDB db = new Book_ListDB();
            db.Update(bookList);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteABookList(int id)
        {
            Book_List bookList = Book_ListDB.SelectById(id);
            Book_ListDB db = new Book_ListDB();
            db.Delete(bookList);
            int x = db.SaveChanges();
            return x;
        }


        // Book_Series
        [HttpGet]
        [ActionName("BookSeriesSelector")]
        public ListBook_Series SelectAllBookSeries()
        {
            Book_SeriesDB db = new Book_SeriesDB();
            ListBook_Series bookSeries = db.SelectAll();
            return bookSeries;
        }

        [HttpPost]
        public int InsertABookSeries([FromBody] Book_Series bookSeries)
        {
            Book_SeriesDB db = new Book_SeriesDB();
            db.Insert(bookSeries);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateABookSeries([FromBody] Book_Series bookSeries)
        {
            Book_SeriesDB db = new Book_SeriesDB();
            db.Update(bookSeries);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteABookSeries(int id)
        {
            Book_Series bookSeries = Book_SeriesDB.SelectById(id);
            Book_SeriesDB db = new Book_SeriesDB();
            db.Delete(bookSeries);
            int x = db.SaveChanges();
            return x;
        }


        // Genre
        [HttpGet]
        [ActionName("GenreSelector")]
        public ListGenre SelectAllGenres()
        {
            GenreDB db = new GenreDB();
            ListGenre genres = db.SelectAll();
            return genres;
        }

        [HttpPost]
        public int InsertAGenre([FromBody] Genre genre)
        {
            GenreDB db = new GenreDB();
            db.Insert(genre);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAGenre([FromBody] Genre genre)
        {
            GenreDB db = new GenreDB();
            db.Update(genre);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteAGenre(int id)
        {
            Genre genre = GenreDB.SelectById(id);
            GenreDB db = new GenreDB();
            db.Delete(genre);
            int x = db.SaveChanges();
            return x;
        }


        // Intrest
        [HttpGet]
        [ActionName("IntrestSelector")]
        public ListIntrest SelectAllIntrests()
        {
            IntrestDB db = new IntrestDB();
            ListIntrest intrests = db.SelectAll();
            return intrests;
        }

        [HttpPost]
        public int InsertAnIntrest([FromBody] Intrest intrest)
        {
            IntrestDB db = new IntrestDB();
            db.Insert(intrest);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAnIntrest([FromBody] Intrest intrest)
        {
            IntrestDB db = new IntrestDB();
            db.Update(intrest);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteAnIntrest(int id)
        {
            Intrest intrest = IntrestDB.SelectById(id);
            IntrestDB db = new IntrestDB();
            db.Delete(intrest);
            int x = db.SaveChanges();
            return x;
        }


        // Intrest_Reader
        [HttpGet]
        [ActionName("IntrestReaderSelector")]
        public ListIntrest_Reader SelectAllIntrestReader()
        {
            Intrest_ReaderDB db = new Intrest_ReaderDB();
            ListIntrest_Reader intrestReader = db.SelectAll();
            return intrestReader;
        }

        [HttpPost]
        public int InsertAnIntrestReader([FromBody] Intrest_Reader intrestReader)
        {
            Intrest_ReaderDB db = new Intrest_ReaderDB();
            db.Insert(intrestReader);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAnIntrestReader([FromBody] Intrest_Reader intrestReader)
        {
            Intrest_ReaderDB db = new Intrest_ReaderDB();
            db.Update(intrestReader);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteAnIntrestReader(int id)
        {
            Intrest_Reader intrestReader = Intrest_ReaderDB.SelectById(id);
            Intrest_ReaderDB db = new Intrest_ReaderDB();
            db.Delete(intrestReader);
            int x = db.SaveChanges();
            return x;
        }


        // Language
        [HttpGet]
        [ActionName("LanguageSelector")]
        public ListLanguage SelectAllLanguages()
        {
            LanguageDB db = new LanguageDB();
            ListLanguage languages = db.SelectAll();
            return languages;
        }

        [HttpPost]
        public int InsertALanguage([FromBody] Language language)
        {
            LanguageDB db = new LanguageDB();
            db.Insert(language);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateALanguae([FromBody] Language language)
        {
            LanguageDB db = new LanguageDB();
            db.Update(language);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteALanguage(int id)
        {
            Language language = LanguageDB.SelectById(id);
            LanguageDB db = new LanguageDB();
            db.Delete(language);
            int x = db.SaveChanges();
            return x;
        }


        // List_Detail
        [HttpGet]
        [ActionName("ListDetailSelector")]
        public ListList_Detail SelectAllListDetails()
        {
            List_DetailDB db = new List_DetailDB();
            ListList_Detail listDetails = db.SelectAll();
            return listDetails;
        }

        [HttpPost]
        public int InsertAListDetail([FromBody] List_Detail listDetail)
        {
            List_DetailDB db = new List_DetailDB();
            db.Insert(listDetail);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAListDetail([FromBody] List_Detail listDetail)
        {
            List_DetailDB db = new List_DetailDB();
            db.Update(listDetail);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteAListDetail(int id)
        {
            List_Detail listDetail = List_DetailDB.SelectById(id);
            List_DetailDB db = new List_DetailDB();
            db.Delete(listDetail);
            int x = db.SaveChanges();
            return x;
        }


        // Permission
        [HttpGet]
        [ActionName("PermissionSelector")]
        public ListPermission SelectAllPermissions()
        {
            PermissionDB db = new PermissionDB();
            ListPermission permissions = db.SelectAll();
            return permissions;
        }

        [HttpPost]
        public int InsertAPermission([FromBody] Permission permission)
        {
            PermissionDB db = new PermissionDB();
            db.Insert(permission);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAPermission([FromBody] Permission permission)
        {
            PermissionDB db = new PermissionDB();
            db.Update(permission);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteAPermission(int id)
        {
            Permission permission = PermissionDB.SelectById(id);
            PermissionDB db = new PermissionDB();
            db.Delete(permission);
            int x = db.SaveChanges();
            return x;
        }


        // Permission_for_Administrator
        [HttpGet]
        [ActionName("PermissionforAdministratorSelector")]
        public ListPermissions_for_Administrator SelectAllPermissionsforAdministrators()
        {
            Permissions_for_AdministratorDB db = new Permissions_for_AdministratorDB();
            ListPermissions_for_Administrator permissionsforAdministrators = db.SelectAll();
            return permissionsforAdministrators;
        }

        [HttpPost]
        public int InsertAPermissions_for_Administrator([FromBody] Permissions_for_Administrator permissionsforAdministrator)
        {
            Permissions_for_AdministratorDB db = new Permissions_for_AdministratorDB();
            db.Insert(permissionsforAdministrator);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAPermissions_for_Administrator([FromBody] Permissions_for_Administrator permissionsforAdministrator)
        {
            Permissions_for_AdministratorDB db = new Permissions_for_AdministratorDB();
            db.Update(permissionsforAdministrator);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteAPermissions_for_Administrator(int id)
        {
            Permissions_for_Administrator permissionsforAdministrator = Permissions_for_AdministratorDB.SelectById(id);
            Permissions_for_AdministratorDB db = new Permissions_for_AdministratorDB();
            db.Delete(permissionsforAdministrator);
            int x = db.SaveChanges();
            return x;
        }


        // Reader
        [HttpGet]
        [ActionName("ReaderSelector")]
        public ListReader SelectAllReaders()
        {
           ReaderDB db = new ReaderDB();
            ListReader readers = db.SelectAll();
            return readers;
        }

        [HttpPost]
        public int InsertAReader([FromBody] Reader reader)
        {
            ReaderDB db = new ReaderDB();
            db.Insert(reader);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAReader([FromBody] Reader reader)
        {
            ReaderDB db = new ReaderDB();
            db.Update(reader);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteAReader(int id)
        {
            Reader reader = ReaderDB.SelectById(id);
            ReaderDB db = new ReaderDB();
            db.Delete(reader);
            int x = db.SaveChanges();
            return x;
        }


        // Series_Detail
        [HttpGet]
        [ActionName("SeriesDetailSelector")]
        public ListSeries_Detail SelectAllSeriesDetails()
        {
            Series_DetailDB db = new Series_DetailDB();
            ListSeries_Detail seriesDetais = db.SelectAll();
            return seriesDetais;
        }

        [HttpPost]
        public int InsertASeriesDetail([FromBody] Series_Detail seriesDetail)
        {
            Series_DetailDB db = new Series_DetailDB();
            db.Insert(seriesDetail);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateASeriesDetail([FromBody] Series_Detail seriesDetail)
        {
            Series_DetailDB db = new Series_DetailDB();
            db.Update(seriesDetail);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteASeriesDetail(int id)
        {
            Series_Detail seriesDetail = Series_DetailDB.SelectById(id);
            Series_DetailDB db = new Series_DetailDB();
            db.Delete(seriesDetail);
            int x = db.SaveChanges();
            return x;
        }


        // User
        [HttpGet]
        [ActionName("UserSelector")]
        public ListUser SelectAllUsers()
        {
            UserDB db = new UserDB();
            ListUser users = db.SelectAll();
            return users;
        }

        [HttpPost]
        public int InsertAUser([FromBody] User user)
        {
            UserDB db = new UserDB();
            db.Insert(user);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateAUser([FromBody] User user)
        {
            UserDB db = new UserDB();
            db.Update(user);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteAUser(int id)
        {
            User user = UserDB.SelectById(id);
            UserDB db = new UserDB();
            db.Delete(user);
            int x = db.SaveChanges();
            return x;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}

