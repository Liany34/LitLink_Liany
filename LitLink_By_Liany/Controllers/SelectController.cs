using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace LitLink_By_Liany.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class SelectController : ControllerBase
    {
        [HttpGet]
        [ActionName("GenreSelector")]
        public ListGenre SelectAllGenres()
        {
            GenreDB db = new GenreDB();
            ListGenre genres = db.SelectAll();
            return genres;
        }

        [HttpGet]
        [ActionName("LanguageSelector")]
        public ListLanguage SelectAllLanguages()
        {
            LanguageDB db = new LanguageDB();
            ListLanguage languages = db.SelectAll();
            return languages;
        }

        [HttpGet]
        [ActionName("IntrestSelector")]
        public ListIntrest SelectAllIntrests()
        {
            IntrestDB db = new IntrestDB();
            ListIntrest intrests = db.SelectAll();
            return intrests;
        }

        [HttpGet]
        [ActionName("DiscountCodesSelector")]
        public ListDiscountCodes SelectAllDiscountCodes()
        {
            DiscountCodesDB db = new DiscountCodesDB();
            ListDiscountCodes discountCodes = db.SelectAll();
            return discountCodes;
        }

        [HttpGet]
        [ActionName("UserSelector")]
        public ListUser SelectAllUsers()
        {
            UserDB db = new UserDB();
            ListUser users = db.SelectAll();
            return users;
        }

        [HttpGet]
        [ActionName("AuthorSelector")]
        public ListAuthor SelectAllAuthors()
        {
            AuthorDB db = new AuthorDB();
            ListAuthor authors = db.SelectAll();
            return authors;
        }

        [HttpGet]
        [ActionName("ReaderSelector")]
        public ListReader SelectAllReaders()
        {
            ReaderDB db = new ReaderDB();
            ListReader readers = db.SelectAll();
            return readers;
        }

        [HttpGet]
        [ActionName("AdminSelector")]
        public ListAdmin SelectAllAdmins()
        {
            AdminDB db = new AdminDB();
            ListAdmin admins = db.SelectAll();
            return admins;
        }

        [HttpGet]
        [ActionName("BookSelector")]
        public ListBook SelectAllBooks()
        {
            BookDB db = new BookDB();
            ListBook books = db.SelectAll();
            return books;
        }

        [HttpGet]
        [ActionName("BookSeriesSelector")]
        public ListBook_Series SelectAllBookSeries()
        {
            Book_SeriesDB db = new Book_SeriesDB();
            ListBook_Series bookSeries = db.SelectAll();
            return bookSeries;
        }

        [HttpGet]
        [ActionName("SeriesDetailSelector")]
        public ListSeries_Detail SelectAllSeriesDetails()
        {
            Series_DetailDB db = new Series_DetailDB();
            ListSeries_Detail seriesDetails = db.SelectAll();
            return seriesDetails;
        }

        [HttpGet]
        [ActionName("BookGenreSelector")]
        public ListBook_Genre SelectAllBookGenres()
        {
            Book_GenreDB db = new Book_GenreDB();
            ListBook_Genre bookGenres = db.SelectAll();
            return bookGenres;
        }

        [HttpGet]
        [ActionName("IntrestReaderSelector")]
        public ListIntrest_Reader SelectAllIntrestReaders()
        {
            Intrest_ReaderDB db = new Intrest_ReaderDB();
            ListIntrest_Reader intrestReaders = db.SelectAll();
            return intrestReaders;
        }

        [HttpGet]
        [ActionName("BookListSelector")]
        public ListBook_List SelectAllBookLists()
        {
            Book_ListDB db = new Book_ListDB();
            ListBook_List bookLists = db.SelectAll();
            return bookLists;
        }

        [HttpGet]
        [ActionName("ListDetailSelector")]
        public ListList_Detail SelectAllListDitails()
        {
            List_DetailDB db = new List_DetailDB();
            ListList_Detail listDetails = db.SelectAll();
            return listDetails;
        }

        [HttpGet]
        [ActionName("CartSelector")]
        public ListCart SelectAllCarts()
        {
            CartDB db = new CartDB();
            ListCart carts = db.SelectAll();
            return carts;
        }

        [HttpGet]
        [ActionName("CartDetailSelector")]
        public ListCart_Detail SelectAllCartDetails()
        {
            Cart_DetailDB db = new Cart_DetailDB();
            ListCart_Detail cartDetails = db.SelectAll();
            return cartDetails;
        }

        [HttpGet]
        [ActionName("NewsSelector")]
        public ListNews SelectAllNews()
        {
            NewsDB db = new NewsDB();
            ListNews news = db.SelectAll();
            return news;
        }

        [HttpGet]
        [ActionName("ReviewsSelector")]
        public ListReviews SelectAllReviews()
        {
            ReviewsDB db = new ReviewsDB();
            ListReviews reviews = db.SelectAll();
            return reviews;
        }

        [HttpGet]
        [ActionName("FollowingSelector")]
        public ListFollowing SelectAllFollowings()
        {
            FollowingDB db = new FollowingDB();
            ListFollowing followings = db.SelectAll();
            return followings;
        }
    }
}
