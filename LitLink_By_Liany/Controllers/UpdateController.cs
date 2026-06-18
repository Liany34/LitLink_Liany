using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;
using System;
using System.IO;
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
        public IActionResult UpdateUser([FromBody] UserUpdateDto dto)
        {
            if (dto == null)
                return BadRequest("User data is missing.");

            try
            {
                string pictureFileName = dto.PicturePath;

                if (!string.IsNullOrWhiteSpace(dto.Base64Image))
                {
                    string coversFolder = System.IO.Path.Combine(BaseDB.Path(), "Covers");

                    if (!Directory.Exists(coversFolder))
                        Directory.CreateDirectory(coversFolder);

                    string ext = System.IO.Path.GetExtension(dto.FileName);

                    if (string.IsNullOrWhiteSpace(ext))
                        ext = ".png";

                    pictureFileName = $"user_{dto.Id}_{DateTime.Now.Ticks}{ext}";

                    string fullPath = System.IO.Path.Combine(coversFolder, pictureFileName);

                    string cleanBase64 = dto.Base64Image;

                    if (cleanBase64.Contains(","))
                        cleanBase64 = cleanBase64.Split(',')[1];

                    byte[] imageBytes = Convert.FromBase64String(cleanBase64);

                    System.IO.File.WriteAllBytes(fullPath, imageBytes);
                }

                User user = new User
                {
                    Id = dto.Id,

                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    PhoneNumber = dto.PhoneNumber,
                    Email = dto.Email,
                    Username = dto.Username,
                    Pass = dto.Pass,
                    Birthdate = dto.Birthdate,

                    PicturePath = string.IsNullOrEmpty(pictureFileName)
                        ? null
                        : System.IO.Path.GetFileName(pictureFileName)
                };

                UserDB db = new UserDB();
                db.Update(user);

                int rows = db.SaveChanges();

                if (rows > 0)
                    return Ok(rows);

                return NotFound("User was not updated.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("AuthorUpdate")]
        public IActionResult UpdateAuthor([FromBody] AuthorUpdateDto dto)
        {
            if (dto == null)
                return BadRequest("Author data is missing.");

            try
            {
                string pictureFileName = dto.PicturePath;

                if (!string.IsNullOrWhiteSpace(dto.Base64Image))
                {
                    string coversFolder = System.IO.Path.Combine(BaseDB.Path(), "Covers");

                    if (!Directory.Exists(coversFolder))
                        Directory.CreateDirectory(coversFolder);

                    string ext = System.IO.Path.GetExtension(dto.FileName);

                    if (string.IsNullOrWhiteSpace(ext))
                        ext = ".png";

                    pictureFileName = $"user_{dto.Id}_{DateTime.Now.Ticks}{ext}";

                    string fullPath = System.IO.Path.Combine(coversFolder, pictureFileName);

                    string cleanBase64 = dto.Base64Image;

                    if (cleanBase64.Contains(","))
                        cleanBase64 = cleanBase64.Split(',')[1];

                    byte[] imageBytes = Convert.FromBase64String(cleanBase64);

                    System.IO.File.WriteAllBytes(fullPath, imageBytes);
                }

                Author author = new Author
                {
                    Id = dto.Id,

                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    PhoneNumber = dto.PhoneNumber,
                    Email = dto.Email,
                    Username = dto.Username,
                    Pass = dto.Pass,
                    Birthdate = dto.Birthdate,

                    PicturePath = string.IsNullOrEmpty(pictureFileName)
                        ? null
                        : System.IO.Path.GetFileName(pictureFileName),

                    PenName = dto.PenName,
                    InformationAboutAuthor = dto.InformationAboutAuthor,
                    Genre = new Genre { Id = dto.IdGenre }
                };

                AuthorDB db = new AuthorDB();
                db.Update(author);

                int rows = db.SaveChanges();

                if (rows > 0)
                    return Ok(rows);

                return NotFound("Author was not updated.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("ReaderUpdate")]
        public IActionResult UpdateReader([FromBody] ReaderUpdateDto dto)
        {
            if (dto == null)
                return BadRequest("Reader data is missing.");

            try
            {
                string pictureFileName = dto.PicturePath;

                if (!string.IsNullOrWhiteSpace(dto.Base64Image))
                {
                    string coversFolder = System.IO.Path.Combine(BaseDB.Path(), "Covers");

                    if (!Directory.Exists(coversFolder))
                        Directory.CreateDirectory(coversFolder);

                    string ext = System.IO.Path.GetExtension(dto.FileName);

                    if (string.IsNullOrWhiteSpace(ext))
                        ext = ".png";

                    pictureFileName = $"user_{dto.Id}_{DateTime.Now.Ticks}{ext}";

                    string fullPath = System.IO.Path.Combine(coversFolder, pictureFileName);

                    string cleanBase64 = dto.Base64Image;

                    if (cleanBase64.Contains(","))
                        cleanBase64 = cleanBase64.Split(',')[1];

                    byte[] imageBytes = Convert.FromBase64String(cleanBase64);

                    System.IO.File.WriteAllBytes(fullPath, imageBytes);
                }

                Reader reader = new Reader
                {
                    Id = dto.Id,

                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    PhoneNumber = dto.PhoneNumber,
                    Email = dto.Email,
                    Username = dto.Username,
                    Pass = dto.Pass,
                    Birthdate = dto.Birthdate,

                    PicturePath = string.IsNullOrEmpty(pictureFileName)
                        ? null
                        : System.IO.Path.GetFileName(pictureFileName),

                    Nickname = dto.Nickname,
                    IsFlaged = dto.IsFlaged
                };

                ReaderDB db = new ReaderDB();
                db.Update(reader);

                int rows = db.SaveChanges();

                if (rows > 0)
                    return Ok(rows);

                return NotFound("Reader was not updated.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpPut]
        //[ActionName("AuthorUpdate")]
        //public int UpdateAuthor([FromBody] Author author)
        //{
        //    AuthorDB db = new AuthorDB();
        //    db.Update(author);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("ReaderUpdate")]
        //public int UpdateReader([FromBody] Reader reader)
        //{
        //    ReaderDB db = new ReaderDB();
        //    db.Update(reader);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        [HttpPut]
        [ActionName("BookUpdate")]
        public IActionResult UpdateBook([FromBody] BookUpdateDto dto)
        {
            if (dto == null)
                return BadRequest("Book data is missing.");

            try
            {
                string coverFileName = dto.CoverPath;

                if (!string.IsNullOrWhiteSpace(dto.Base64Image))
                {
                    string coversFolder = System.IO.Path.Combine(BaseDB.Path(), "Covers");

                    if (!Directory.Exists(coversFolder))
                        Directory.CreateDirectory(coversFolder);

                    string ext = System.IO.Path.GetExtension(dto.FileName);

                    if (string.IsNullOrWhiteSpace(ext))
                        ext = ".png";

                    coverFileName = $"book_{dto.Id}_{DateTime.Now.Ticks}{ext}";

                    string fullPath = System.IO.Path.Combine(coversFolder, coverFileName);

                    string cleanBase64 = dto.Base64Image;

                    if (cleanBase64.Contains(","))
                        cleanBase64 = cleanBase64.Split(',')[1];

                    byte[] imageBytes = Convert.FromBase64String(cleanBase64);

                    System.IO.File.WriteAllBytes(fullPath, imageBytes);
                }

                Book book = new Book
                {
                    Id = dto.Id,
                    BookName = dto.BookName,
                    PublicationDate = dto.PublicationDate,
                    Price = dto.Price,
                    Information = dto.Information,
                    BookLink = dto.BookLink,
                    IsFlaged = dto.IsFlaged,

                    IdAuthor = new Author { Id = dto.IdAuthor },
                    IdLanguage = new Language { Id = dto.IdLanguage },

                    CoverPath = string.IsNullOrEmpty(coverFileName)
                        ? null
                        : System.IO.Path.GetFileName(coverFileName)
                };

                BookDB db = new BookDB();
                db.Update(book);

                int rows = db.SaveChanges();

                if (rows > 0)
                    return Ok(book);

                return NotFound("Book was not updated.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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
