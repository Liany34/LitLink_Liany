using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel;

namespace Service
{
    public interface IAPIService
    {
        public Task<ListAuthor> GetAllAuthors();
        public Task<int> InsertAnAuthor(Author author);
        public Task<int> UpdateAnAuthor(Author author);
        public Task<int> DeleteAnAuthor(int id);

        public Task<ListBook> GetAllBooks();
        public Task<int> InsertABook(Book book);
        public Task<int> UpdateABook(Book book);
        public Task<int> DeleteABook(int id);


        public Task<ListBook_List> GetAllBookLists();
        public Task<int> InsertABookList(Book_List bookList);
        public Task<int> UpdateABookList(Book_List bookList);
        public Task<int> DeleteABookList(int id);


        public Task<ListBook_Series> GetAllBookSeries();
        public Task<int> InsertABookSeries(Book_Series bookSeries);
        public Task<int> UpdateABookSeries(Book_Series bookSeries);
        public Task<int> DeleteABookSeries(int id);


        public Task<ListGenre> GetAllGenres();
        public Task<int> InsertAGenre(Genre genre);
        public Task<int> UpdateAGenre(Genre genre);
        public Task<int> DeleteAGenre(int id);


        public Task<ListIntrest> GetAllIntrests();
        public Task<int> InsertAnIntrest(Intrest intrest);
        public Task<int> UpdateAnIntrest(Intrest intrest);
        public Task<int> DeleteAnIntrest(int id);


        public Task<ListIntrest_Reader> GetAllIntrestReaders();
        public Task<int> InsertAnIntrestReader(Intrest_Reader intrestReader);
        public Task<int> UpdateAnIntrestReader(Intrest_Reader intrestReader);
        public Task<int> DeleteAnIntrestReader(int id);


        public Task<ListLanguage> GetAllLanguages();
        public Task<int> InsertALanguage(Language language);
        public Task<int> UpdateALanguage(Language language);
        public Task<int> DeleteALanguage(int id);


        public Task<ListList_Detail> GetAllListDetails();
        public Task<int> InsertAListDetail(List_Detail listDetail);
        public Task<int> UpdateAListDetail(List_Detail listDetail);
        public Task<int> DeleteAListDetail(int id);


        public Task<ListPermission> GetAllPermissions();
        public Task<int> InsertAPermission(Permission permission);
        public Task<int> UpdateAPermission(Permission permission);
        public Task<int> DeleteAPermission(int id);


        public Task<ListPermissions_for_Administrator> GetAllPermissionsForAdministrators();
        public Task<int> InsertAPermissionForAdministrator(Permissions_for_Administrator permissionForAdministrator);
        public Task<int> UpdateAPermissionForAdministrator(Permissions_for_Administrator permissionForAdministrator);
        public Task<int> DeleteAPermissionForAdministrator(int id);


        public Task<ListReader> GetAllReaders();
        public Task<int> InsertAReader(Reader reader);
        public Task<int> UpdateAReader(Reader reader);
        public Task<int> DeleteAReader(int id);


        public Task<ListSeries_Detail> GetAllSeriesDetails();
        public Task<int> InsertASeriesDetail(Series_Detail seriesDetail);
        public Task<int> UpdateASeriesDetail(Series_Detail seriesDetail);
        public Task<int> DeleteASeriesDetail(int id);


        public Task<ListUser> GetAllUsers();
        public Task<int> InsertAUser(User user);
        public Task<int> UpdateAUser(User user);
        public Task<int> DeleteAUser(int id);


        public Task<ListCart> GetAllCarts();
        public Task<int> InsertACart(Cart cart);
        public Task<int> UpdateACart(Cart cart);
        public Task<int> DeleteACart(int id);

        public Task<ListCart_Detail> GetAllCartDetails();
        public Task<int> InsertACartDetail(Cart_Detail cartDetail);
        public Task<int> UpdateACartDetail(Cart_Detail cartDetail);
        public Task<int> DeleteACartDetail(int id);
    }
}
