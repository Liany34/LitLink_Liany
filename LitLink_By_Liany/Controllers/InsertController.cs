using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace LitLink_By_Liany.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class InsertController : ControllerBase
    {
        [HttpPost]
        [ActionName("GenreInsert")]
        public int InsertGenre([FromBody] Genre genre)
        {
            GenreDB db = new GenreDB();
            db.Insert(genre);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("LanguageInsert")]
        public int InsertLanguage([FromBody] Language language)
        {
            LanguageDB db = new LanguageDB();
            db.Insert(language);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("DiscountCodesInsert")]
        public int InsertDiscountCodes([FromBody] DiscountCodes discountCodes)
        {
            DiscountCodesDB db = new DiscountCodesDB();
            db.Insert(discountCodes);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("UserInsert")]
        public int InsertUser([FromBody] User user)
        {
            UserDB db = new UserDB();
            db.Insert(user);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("AuthorInsert")]
        public int InsertAuthor([FromBody] Author author)
        {
            AuthorDB db = new AuthorDB();
            db.Insert(author);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("ReaderInsert")]
        public int InsertReader([FromBody] Reader reader)
        {
            ReaderDB db = new ReaderDB();
            db.Insert(reader);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("AdminInsert")]
        public int InsertAdmin([FromBody] Admin admin)
        {
            AdminDB db = new AdminDB();
            db.Insert(admin);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("BookInsert")]
        public int InsertBook([FromBody] Book book)
        {
            BookDB db = new BookDB();
            db.Insert(book);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("BookSeriesInsert")]
        public int InsertBookSeries([FromBody] Book_Series bookSeries)
        {
            Book_SeriesDB db = new Book_SeriesDB();
            db.Insert(bookSeries);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("SeriesDetailInsert")]
        public int InsertSeriesDetail([FromBody] Series_Detail seriesDetail)
        {
            Series_DetailDB db = new Series_DetailDB();
            db.Insert(seriesDetail);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("BookGenreInsert")]
        public int InsertBookGenre([FromBody] Book_Genre bookGenre)
        {
            Book_GenreDB db = new Book_GenreDB();
            db.Insert(bookGenre);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("GenreReaderInsert")]
        public int InsertGenreReader([FromBody] Genre_Reader genreReader)
        {
            Genre_ReaderDB db = new Genre_ReaderDB();
            db.Insert(genreReader);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("CartInsert")]
        public int InsertCart([FromBody] Cart cart)
        {
            CartDB db = new CartDB();
            db.Insert(cart);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("CartDetailInsert")]
        public int InsertCartDetail([FromBody] Cart_Detail cartDetail)
        {
            Cart_DetailDB db = new Cart_DetailDB();
            db.Insert(cartDetail);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("NewsInsert")]
        public int InsertNews([FromBody] News news)
        {
            NewsDB db = new NewsDB();
            db.Insert(news);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("ReviewsInsert")]
        public int InsertReview([FromBody] Reviews review)
        {
            ReviewsDB db = new ReviewsDB();
            db.Insert(review);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        [ActionName("FollowingInsert")]
        public int InsertFollowing([FromBody] Following following)
        {
            FollowingDB db = new FollowingDB();
            db.Insert(following);
            int x = db.SaveChanges();
            return x;
        }
    }
}
