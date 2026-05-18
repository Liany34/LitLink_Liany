using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using static System.Net.WebRequestMethods;

namespace Service
{
    public class Apiservice : IApiService
    {
        string uri;
        public HttpClient client;
        public Apiservice()
        {
            //uri = "http://localhost:5193";
            uri = "https://mkrq0bm8-5193.uks1.devtunnels.ms";
            client = new HttpClient();
        }
        //public Apiservice(HttpClient client, string baseUri)
        //{
        //    uri = "https://mkrq0bm8-5193.uks1.devtunnels.ms";
        //    client = new HttpClient();
        //    this.client = client ?? throw new ArgumentNullException(nameof(client));
        //    this.uri = baseUri ?? throw new ArgumentNullException(nameof(baseUri));
        //}


        public async Task<ListGenre> GetAllGenres()
        {
            return await client.GetFromJsonAsync<ListGenre>(uri + "/api/Select/GenreSelector");
        }
        public async Task<int> InsertGenre(Genre g)
        {
            return (await client.PostAsJsonAsync<Genre>(uri + "/api/Insert/GenreInsert", g)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateGenre(Genre g)
        {
            return (await client.PutAsJsonAsync<Genre>(uri + "/api/Update/GenreUpdate", g)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteGenre(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/GenreDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListLanguage> GetAllLanguages()
        {
            return await client.GetFromJsonAsync<ListLanguage>(uri + "/api/Select/LanguageSelector");
        }
        public async Task<int> InsertLanguage(Language l)
        {
            return (await client.PostAsJsonAsync<Language>(uri + "/api/Insert/LanguageInsert", l)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateLanguage(Language l)
        {
            return (await client.PutAsJsonAsync<Language>(uri + "/api/Update/LanguageInsert", l)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteLanguage(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/LanguageDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListIntrest> GetAllIntrests()
        {
            return await client.GetFromJsonAsync<ListIntrest>(uri + "/api/Select/IntrestSelector");
        }
        public async Task<int> InsertIntrest(Intrest i)
        {
            return (await client.PostAsJsonAsync<Intrest>(uri + "/api/Insert/IntrestInsert", i)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateIntrest(Intrest i)
        {
            return (await client.PutAsJsonAsync<Intrest>(uri + "/api/Update/IntrestInsert", i)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteIntrest(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/IntrestDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListDiscountCodes> GetAllDiscountCodes()
        {
            return await client.GetFromJsonAsync<ListDiscountCodes>(uri + "/api/Select/DiscountCodesSelector");
        }
        public async Task<int> InsertDiscountCode(DiscountCodes dc)
        {
            return (await client.PostAsJsonAsync<DiscountCodes>(uri + "/api/Insert/DiscountCodesInsert", dc)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateDiscountCode(DiscountCodes dc)
        {
            return (await client.PutAsJsonAsync<DiscountCodes>(uri + "/api/Update/DiscountCodesInsert", dc)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteDiscountCode(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/DiscountCodesDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListUser> GetAllUsers()
        {
            return await client.GetFromJsonAsync<ListUser>(uri + "/api/Select/UserSelector");
        }
        public async Task<int> InsertUser(User u)
        {
            return (await client.PostAsJsonAsync<User>(uri + "/api/Insert/UserInsert", u)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateUser(User u)
        {
            return (await client.PutAsJsonAsync<User>(uri + "/api/Update/UserInsert", u)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteUser(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/UserDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListAuthor> GetAllAuthors()
        {
            return await client.GetFromJsonAsync<ListAuthor>(uri + "/api/Select/AuthorSelector");
        }
        public async Task<int> InsertAuthor(Author a)
        {
            return (await client.PostAsJsonAsync<Author>(uri + "/api/Insert/AuthorInsert", a)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAuthor(Author a)
        {
            return (await client.PutAsJsonAsync<Author>(uri + "/api/Update/AuthorInsert", a)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteAuthor(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/AuthorDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListReader> GetAllReaders()
        {
            return await client.GetFromJsonAsync<ListReader>(uri + "/api/Select/ReaderSelector");
        }
        public async Task<int> InsertReader(Reader r)
        {
            return (await client.PostAsJsonAsync<Reader>(uri + "/api/Insert/ReaderInsert", r)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateReader(Reader r)
        {
            return (await client.PutAsJsonAsync<Reader>(uri + "/api/Update/ReaderInsert", r)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteReader(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/ReaderDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListAdmin> GetAllAdmins()
        {
            return await client.GetFromJsonAsync<ListAdmin>(uri + "/api/Select/AdminSelector");
        }
        public async Task<int> InsertAdmin(Admin a)
        {
            return (await client.PostAsJsonAsync<Admin>(uri + "/api/Insert/AdminInsert", a)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAdmin(Admin a)
        {
            return (await client.PutAsJsonAsync<Admin>(uri + "/api/Update/AdminInsert", a)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteAdmin(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/AdminDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListBook> GetAllBooks()
        {
            return await client.GetFromJsonAsync<ListBook>(uri + "/api/Select/BookSelector");
        }
        public async Task<int> InsertBook(Book b)
        {
            return (await client.PostAsJsonAsync<Book>(uri + "/api/Insert/BookInsert", b)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateBook(Book b)
        {
            return (await client.PutAsJsonAsync<Book>(uri + "/api/Update/BookInsert", b)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteBook(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/BookDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListBook_Series> GetAllBookSeries()
        {
            return await client.GetFromJsonAsync<ListBook_Series>(uri + "/api/Select/BookSeriesSelector");
        }
        public async Task<int> InsertBookSeries(Book_Series bs)
        {
            return (await client.PostAsJsonAsync<Book_Series>(uri + "/api/Insert/BookSeriesInsert", bs)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateBookSeries(Book_Series bs)
        {
            return (await client.PutAsJsonAsync<Book_Series>(uri + "/api/Update/BookSeriesUpdate", bs)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteBookSeries(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/BookSeriesDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListSeries_Detail> GetAllSeriesDetails()
        {
            return await client.GetFromJsonAsync<ListSeries_Detail>(uri + "/api/Select/SeriesDetailSelector");
        }
        public async Task<int> InsertSeriesDetail(Series_Detail sd)
        {
            return (await client.PostAsJsonAsync<Series_Detail>(uri + "/api/Insert/SeriesDetailInsert", sd)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateSeriesDetail(Series_Detail sd)
        {
            return (await client.PutAsJsonAsync<Series_Detail>(uri + "/api/Update/SeriesDetailUpdate", sd)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteSeriesDetail(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/SeriesDetailDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListBook_Genre> GetAllBookGenres()
        {
            return await client.GetFromJsonAsync<ListBook_Genre>(uri + "/api/Select/BookGenreSelector");
        }
        public async Task<int> InsertBookGenre(Book_Genre bg)
        {
            return (await client.PostAsJsonAsync<Book_Genre>(uri + "/api/Insert/BookGenreInsert", bg)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateBookGenre(Book_Genre bg)
        {
            return (await client.PutAsJsonAsync<Book_Genre>(uri + "/api/Update/BookGenreUpdate", bg)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteBookGenre(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/BookGenreDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListIntrest_Reader> GetAllIntrestReaders()
        {
            return await client.GetFromJsonAsync<ListIntrest_Reader>(uri + "/api/Select/IntrestReaderSelector");
        }
        public async Task<int> InsertIntrestReader(Intrest_Reader ir)
        {
            return (await client.PostAsJsonAsync<Intrest_Reader>(uri + "/api/Insert/IntrestReaderInsert", ir)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateIntrestReader(Intrest_Reader ir)
        {
            return (await client.PutAsJsonAsync<Intrest_Reader>(uri + "/api/Update/IntrestReaderUpdate", ir)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteIntrestReader(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/IntrestReaderDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListBook_List> GetAllBookLists()
        {
            return await client.GetFromJsonAsync<ListBook_List>(uri + "/api/Select/BookListSelector");
        }
        public async Task<int> InsertBookList(Book_List bl)
        {
            return (await client.PostAsJsonAsync<Book_List>(uri + "/api/Insert/BookListInsert", bl)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateBookList(Book_List bl)
        {
            return (await client.PutAsJsonAsync<Book_List>(uri + "/api/Update/BookListUpdate", bl)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteBookList(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/BookListDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListList_Detail> GetAllListDetails()
        {
            return await client.GetFromJsonAsync<ListList_Detail>(uri + "/api/Select/ListDetailSelector");
        }
        public async Task<int> InsertListDetail(List_Detail ld)
        {
            return (await client.PostAsJsonAsync<List_Detail>(uri + "/api/Insert/ListDetailInsert", ld)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateListDetail(List_Detail ld)
        {
            return (await client.PutAsJsonAsync<List_Detail>(uri + "/api/Update/ListDetailUpdate", ld)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteListDetail(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/ListDetailDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListCart> GetAllCarts()
        {
            return await client.GetFromJsonAsync<ListCart>(uri + "/api/Select/CartSelector");
        }
        public async Task<int> InsertCart(Cart c)
        {
            return (await client.PostAsJsonAsync<Cart>(uri + "/api/Insert/CartInsert", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateCart(Cart c)
        {
            return (await client.PutAsJsonAsync<Cart>(uri + "/api/Update/CartUpdate", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteCart(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/CartDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListCart_Detail> GetAllCartDetails()
        {
            return await client.GetFromJsonAsync<ListCart_Detail>(uri + "/api/Select/CartDetailSelector");
        }
        public async Task<int> InsertCartDetail(Cart_Detail cd)
        {
            return (await client.PostAsJsonAsync<Cart_Detail>(uri + "/api/Insert/CartDetailInsert", cd)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateCartDetail(Cart_Detail cd)
        {
            return (await client.PutAsJsonAsync<Cart_Detail>(uri + "/api/Update/CartDetailUpdate", cd)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteCartDetail(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/CartDetailDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListNews> GetAllNews()
        {
            return await client.GetFromJsonAsync<ListNews>(uri + "/api/Select/NewsSelector");
        }
        public async Task<int> InsertNews(News n)
        {
            return (await client.PostAsJsonAsync<News>(uri + "/api/Insert/NewsInsert", n)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateNews(News n)
        {
            return (await client.PutAsJsonAsync<News>(uri + "/api/Update/NewsUpdate", n)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteNews(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/NewsDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListReviews> GetAllReviews()
        {
            return await client.GetFromJsonAsync<ListReviews>(uri + "/api/Select/ReviewsSelector");
        }
        public async Task<int> InsertReview(Reviews re)
        {
            return (await client.PostAsJsonAsync<Reviews>(uri + "/api/Insert/ReviewsInsert", re)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateReview(Reviews re)
        {
            return (await client.PutAsJsonAsync<Reviews>(uri + "/api/Update/ReviewsUpdate", re)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteReview(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/ReviewsDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListFollowing> GetAllFollowings()
        {
            return await client.GetFromJsonAsync<ListFollowing>(uri + "/api/Select/FollowingSelector");
        }
        public async Task<int> InsertFollowing(Following f)
        {
            return (await client.PostAsJsonAsync<Following>(uri + "/api/Insert/FollowingInsert", f)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateFollowing(Following f)
        {
            return (await client.PutAsJsonAsync<Following>(uri + "/api/Update/FollowingUpdate", f)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteFollowing(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Delete/FollowingDelete/{id}")).IsSuccessStatusCode ? 1 : 0;
        }
    }
}
