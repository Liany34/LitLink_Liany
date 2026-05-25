using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace LitLink_By_Liany.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class UpdateController : ControllerBase
    {
        [HttpPut]
        [ActionName("GenreUpdate")]
        public int UpdateGenre([FromBody] Genre genre)
        {
            GenreDB db = new GenreDB();
            db.Update(genre);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("LanguageUpdate")]
        public int UpdateLanguage([FromBody] Language language)
        {
            LanguageDB db = new LanguageDB();
            db.Update(language);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("DiscountCodesUpdate")]
        public int UpdateDiscountCodes([FromBody] DiscountCodes discountCodes)
        {
            DiscountCodesDB db = new DiscountCodesDB();
            db.Update(discountCodes);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("UserUpdate")]
        public int UpdateUser([FromBody] User user)
        {
            UserDB db = new UserDB();
            db.Update(user);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("AuthorUpdate")]
        public int UpdateAuthor([FromBody] Author author)
        {
            AuthorDB db = new AuthorDB();
            db.Update(author);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("ReaderUpdate")]
        public int UpdateReader([FromBody] Reader reader)
        {
            ReaderDB db = new ReaderDB();
            db.Update(reader);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("BookUpdate")]
        public int UpdateBook([FromBody] Book book)
        {
            BookDB db = new BookDB();
            db.Update(book);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("BookSeriesUpdate")]
        public int UpdateBookSeries([FromBody] Book_Series bookSeries)
        {
            Book_SeriesDB db = new Book_SeriesDB();
            db.Update(bookSeries);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("SeriesDetailUpdate")]
        public int UpdateSeriesDetail([FromBody] Series_Detail seriesDetail)
        {
            Series_DetailDB db = new Series_DetailDB();
            db.Update(seriesDetail);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("BookGenreUpdate")]
        public int UpdateBookGenre([FromBody] Book_Genre bookGenre)
        {
            Book_GenreDB db = new Book_GenreDB();
            db.Update(bookGenre);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("GenreReaderUpdate")]
        public int UpdateGenreReader([FromBody] Genre_Reader genreReader)
        {
            Genre_ReaderDB db = new Genre_ReaderDB();
            db.Update(genreReader);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("CartUpdate")]
        public int UpdateCart([FromBody] Cart cart)
        {
            CartDB db = new CartDB();
            db.Update(cart);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("CartDetailUpdate")]
        public int UpdateCartDetail([FromBody] Cart_Detail cartDetail)
        {
            Cart_DetailDB db = new Cart_DetailDB();
            db.Update(cartDetail);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("NewsUpdate")]
        public int UpdateNews([FromBody] News news)
        {
            NewsDB db = new NewsDB();
            db.Update(news);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("ReviewsUpdate")]
        public int UpdateReview([FromBody] Reviews review)
        {
            ReviewsDB db = new ReviewsDB();
            db.Update(review);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPut]
        [ActionName("FollowingUpdate")]
        public int UpdateFollowing([FromBody] Following following)
        {
            FollowingDB db = new FollowingDB();
            db.Update(following);
            int x = db.SaveChanges();
            return x;
        }
    }
}
