using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace LitLink_By_Liany.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class DeleteController : ControllerBase
    {
        [HttpDelete("{id}")]
        [ActionName("GenreDelete")]
        public int DeleteGenre(int id)
        {
            GenreDB db = new GenreDB();
            Genre genreToDelete = GenreDB.SelectById(id);
            db.Delete(genreToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("LanguageDelete")]
        public int DeleteLanguage(int id)
        {
            LanguageDB db = new LanguageDB();
            Language languageToDelete = LanguageDB.SelectById(id);
            db.Delete(languageToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("IntrestDelete")]
        public int DeleteIntrest(int id)
        {
            IntrestDB db = new IntrestDB();
            Intrest intrestToDelete = IntrestDB.SelectById(id);
            db.Delete(intrestToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("UserDelete")]
        public int DeleteUser(int id)
        {
            UserDB db = new UserDB();
            User userToDelete = UserDB.SelectById(id);
            db.Delete(userToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("AuthorDelete")]
        public int DeleteAuthor(int id)
        {
            AuthorDB db = new AuthorDB();
            Author authorToDelete = AuthorDB.SelectById(id);
            db.Delete(authorToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("ReaderDelete")]
        public int DeleteReader(int id)
        {
            ReaderDB db = new ReaderDB();
            Reader readerToDelete = ReaderDB.SelectById(id);
            db.Delete(readerToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("AdminDelete")]
        public int DeleteAdmin(int id)
        {
            AdminDB db = new AdminDB();
            Admin adminToDelete = AdminDB.SelectById(id);
            db.Delete(adminToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("BookDelete")]
        public int DeleteBook(int id)
        {
            BookDB db = new BookDB();
            Book bookToDelete = BookDB.SelectById(id);
            db.Delete(bookToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("BookSeriesDelete")]
        public int DeleteBookSeries(int id)
        {
            Book_SeriesDB db = new Book_SeriesDB();
            Book_Series bookSeriesToDelete = Book_SeriesDB.SelectById(id);
            db.Delete(bookSeriesToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("SeriesDetailDelete")]
        public int DeleteSeriesDetail(int id)
        {
            Series_DetailDB db = new Series_DetailDB();
            Series_Detail seriesDetailToDelete = Series_DetailDB.SelectById(id);
            db.Delete(seriesDetailToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("BookGenreDelete")]
        public int DeleteBookGenre(int id)
        {
            Book_GenreDB db = new Book_GenreDB();
            Book_Genre bookGenreToDelete = Book_GenreDB.SelectById(id);
            db.Delete(bookGenreToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("IntrestReaderDelete")]
        public int DeleteIntrestReader(int id)
        {
            Intrest_ReaderDB db = new Intrest_ReaderDB();
            Intrest_Reader intrestReaderToDelete = Intrest_ReaderDB.SelectById(id);
            db.Delete(intrestReaderToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("BookListDelete")]
        public int DeleteBookList(int id)
        {
            Book_ListDB db = new Book_ListDB();
            Book_List bookListToDelete = Book_ListDB.SelectById(id);
            db.Delete(bookListToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("ListDetailDelete")]
        public int DeleteListDetail(int id)
        {
            List_DetailDB db = new List_DetailDB();
            List_Detail listDetailToDelete = List_DetailDB.SelectById(id);
            db.Delete(listDetailToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("CartDelete")]
        public int DeleteCart(int id)
        {
            CartDB db = new CartDB();
            Cart cartToDelete = CartDB.SelectById(id);
            db.Delete(cartToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("CartDetailDelete")]
        public int DeleteCartDetail(int id)
        {
            Cart_DetailDB db = new Cart_DetailDB();
            Cart_Detail cartDetailToDelete = Cart_DetailDB.SelectById(id);
            db.Delete(cartDetailToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("NewsDelete")]
        public int DeleteNews(int id)
        {
            NewsDB db = new NewsDB();
            News newsToDelete = NewsDB.SelectById(id);
            db.Delete(newsToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("ReviewsDelete")]
        public int DeleteReview(int id)
        {
            ReviewsDB db = new ReviewsDB();
            Reviews reviewToDelete = ReviewsDB.SelectById(id);
            db.Delete(reviewToDelete);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        [ActionName("FollowingDelete")]
        public int DeleteFollowing(int id)
        {
            FollowingDB db = new FollowingDB();
            Following followingToDelete = FollowingDB.SelectById(id);
            db.Delete(followingToDelete);
            int x = db.SaveChanges();
            return x;
        }
    }
}
