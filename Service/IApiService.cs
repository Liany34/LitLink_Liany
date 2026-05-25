using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IApiService
    {
        public Task<ListGenre> GetAllGenres();
        public Task<int> InsertGenre(Genre genre);
        public Task<int> UpdateGenre(Genre genre);
        public Task<int> DeleteGenre(int id);


        public Task<ListLanguage> GetAllLanguages();
        public Task<int> InsertLanguage(Language language);
        public Task<int> UpdateLanguage(Language language);
        public Task<int> DeleteLanguage(int id);


        public Task<ListIntrest> GetAllIntrests();
        public Task<int> InsertIntrest(Intrest intrest);
        public Task<int> UpdateIntrest(Intrest intrest);
        public Task<int> DeleteIntrest(int id);


        public Task<ListDiscountCodes> GetAllDiscountCodes();
        public Task<int> InsertDiscountCode(DiscountCodes discountCode);
        public Task<int> UpdateDiscountCode(DiscountCodes discountCode);
        public Task<int> DeleteDiscountCode(int id);


        public Task<ListUser> GetAllUsers();
        public Task<int> InsertUser(User user);
        public Task<int> UpdateUser(User user);
        public Task<int> DeleteUser(int id);
        public Task<string> GetPRPByUserIDByte64(int id);


        public Task<ListAuthor> GetAllAuthors();
        public Task<int> InsertAuthor(Author author);
        public Task<int> UpdateAuthor(Author author);
        public Task<int> DeleteAuthor(int id);


        public Task<ListReader> GetAllReaders();
        public Task<int> InsertReader(Reader reader);
        public Task<int> UpdateReader(Reader reader);
        public Task<int> DeleteReader(int id);


        public Task<ListAdmin> GetAllAdmins();
        public Task<int> InsertAdmin(Admin admin);
        public Task<int> DeleteAdmin(int id);


        public Task<ListBook> GetAllBooks();
        public Task<int> InsertBook(Book book);
        public Task<int> UpdateBook(Book book);
        public Task<int> DeleteBook(int id);
        public Task<string> GetBookCoverByBookIDByte64(int id);


        public Task<ListBook_Series> GetAllBookSeries();
        public Task<int> InsertBookSeries(Book_Series book_series);
        public Task<int> UpdateBookSeries(Book_Series book_series);
        public Task<int> DeleteBookSeries(int id);


        public Task<ListSeries_Detail> GetAllSeriesDetails();
        public Task<int> InsertSeriesDetail(Series_Detail series_detail);
        public Task<int> UpdateSeriesDetail(Series_Detail series_detail);
        public Task<int> DeleteSeriesDetail(int id);


        public Task<ListBook_Genre> GetAllBookGenres();
        public Task<int> InsertBookGenre(Book_Genre book_genre);
        public Task<int> UpdateBookGenre(Book_Genre book_genre);
        public Task<int> DeleteBookGenre(int id);


        public Task<ListGenre_Reader> GetAllIntrestReaders();
        public Task<int> InsertIntrestReader(Genre_Reader intrest_reader);
        public Task<int> UpdateIntrestReader(Genre_Reader intrest_reader);
        public Task<int> DeleteIntrestReader(int id);


        public Task<ListBook_List> GetAllBookLists();
        public Task<int> InsertBookList(Book_List book_list);
        public Task<int> UpdateBookList(Book_List book_list);
        public Task<int> DeleteBookList(int id);


        public Task<ListList_Detail> GetAllListDetails();
        public Task<int> InsertListDetail(List_Detail list_detail);
        public Task<int> UpdateListDetail(List_Detail list_detail);
        public Task<int> DeleteListDetail(int id);


        public Task<ListCart> GetAllCarts();
        public Task<int> InsertCart(Cart cart);
        public Task<int> UpdateCart(Cart cart);
        public Task<int> DeleteCart(int id);


        public Task<ListCart_Detail> GetAllCartDetails();
        public Task<int> InsertCartDetail(Cart_Detail cart_detail);
        public Task<int> UpdateCartDetail(Cart_Detail cart_detail);
        public Task<int> DeleteCartDetail(int id);


        public Task<ListNews> GetAllNews();
        public Task<int> InsertNews(News news);
        public Task<int> UpdateNews(News news);
        public Task<int> DeleteNews(int id);


        public Task<ListReviews> GetAllReviews();
        public Task<int> InsertReview(Reviews review);
        public Task<int> UpdateReview(Reviews review);
        public Task<int> DeleteReview(int id);


        public Task<ListFollowing> GetAllFollowings();
        public Task<int> InsertFollowing(Following following);
        public Task<int> UpdateFollowing(Following following);
        public Task<int> DeleteFollowing(int id);
    }
}
