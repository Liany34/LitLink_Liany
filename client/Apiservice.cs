using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel;

namespace Service
{
    public class Apiservice : IAPIService
    {
        string uri;
        public HttpClient client;

        //public Apiservice()
        //{
        //    uri = "https://8rdr4sf5-5265.euw.devtunnels.ms";
        //    client = new HttpClient();
        //}
        public Apiservice(HttpClient client, string baseUri)
        {
            uri = "https://8rdr4sf5-5265.euw.devtunnels.ms";
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.client = client ?? throw new 
                ArgumentNullException(nameof(client));
            this.uri = baseUri ?? throw new 
                ArgumentNullException(nameof(baseUri));
        }

        public async Task<ListAuthor> GetAllAuthors()
        {
            return await client.GetFromJsonAsync<ListAuthor>(uri + "/api/Select/AuthorSelector");
        }
        public async Task<int> InsertAnAuthor(Author a)
        {
            return (await client.PostAsJsonAsync<Author>(uri + "/api/Select/InsertAnAuthor", a)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAnAuthor(Author a)
        {
            return (await client.PutAsJsonAsync<Author>(uri + "/api/Select/UpdateAnAuthor/", a)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteAnAuthor(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteAnAuthor/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListBook> GetAllBooks()
        {
            return await client.GetFromJsonAsync<ListBook>(uri + "/api/Select/BookSelector");
        }
        public async Task<int> InsertABook(Book b)
        {
            return (await client.PostAsJsonAsync<Book>(uri + "/api/Select/InsertABook", b)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateABook(Book b)
        {
            return (await client.PutAsJsonAsync<Book>(uri + "/api/Select/UpdateABook", b)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteABook(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteABook/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListBook_List> GetAllBookLists()
        {
            return await client.GetFromJsonAsync<ListBook_List>(uri + "/api/Select/BookListSelector");
        }
        public async Task<int> InsertABookList(Book_List bl)
        {
            return (await client.PostAsJsonAsync<Book_List>(uri + "/api/Select/InsertABookList", bl)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateABookList(Book_List bl)
        {
            return (await client.PutAsJsonAsync<Book_List>(uri + "/api/Select/UpdateABookList", bl)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteABookList(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteABookList/{id}")).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<ListBook_Series> GetAllBookSeries()
        {
            return await client.GetFromJsonAsync<ListBook_Series>(uri + "/api/Select/BookSeriesSelector");
        }
        public async Task<int> InsertABookSeries(Book_Series bs)
        {
            return (await client.PostAsJsonAsync<Book_Series>(uri + "/api/Select/InsertABookSeries", bs)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateABookSeries(Book_Series bs)
        {
            return (await client.PutAsJsonAsync<Book_Series>(uri + "/api/Select/UpdateABookSeries", bs)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteABookSeries(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteABookSeries/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListGenre> GetAllGenres()
        {
            return await client.GetFromJsonAsync<ListGenre>(uri + "/api/Select/GenreSelector");
        }
        public async Task<int> InsertAGenre(Genre g)
        {
            return (await client.PostAsJsonAsync<Genre>(uri + "/api/Select/InsertAGenre", g)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAGenre(Genre g)
        {
            return (await client.PutAsJsonAsync<Genre>(uri + "/api/Select/UpdateAGenre", g)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteAGenre(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteAGenre/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListIntrest> GetAllIntrests()
        {
            return await client.GetFromJsonAsync<ListIntrest>(uri + "/api/Select/IntrestSelector");
        }
        public async Task<int> InsertAnIntrest(Intrest i)
        {
            return (await client.PostAsJsonAsync<Intrest>(uri + "/api/Select/InsertAnIntrest", i)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAnIntrest(Intrest i)
        {
            return (await client.PutAsJsonAsync<Intrest>(uri + "/api/Select/UpdateAnIntrest", i)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteAnIntrest(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteAnIntrest/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListIntrest_Reader> GetAllIntrestReaders()
        {
            return await client.GetFromJsonAsync<ListIntrest_Reader>(uri + "/api/Select/IntrestReaderSelector");
        }
        public async Task<int> InsertAnIntrestReader(Intrest_Reader ir)
        {
            return (await client.PostAsJsonAsync<Intrest_Reader>(uri + "/api/Select/InsertAnIntrestReader", ir)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAnIntrestReader(Intrest_Reader ir)
        {
            return (await client.PutAsJsonAsync<Intrest_Reader>(uri + "/api/Select/UpdateAnIntrestReader", ir)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteAnIntrestReader(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteAnIntrestReader/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListLanguage> GetAllLanguages()
        {
            return await client.GetFromJsonAsync<ListLanguage>(uri + "/api/Select/LanguageSelector");
        }
        public async Task<int> InsertALanguage(Language l)
        {
            return (await client.PostAsJsonAsync<Language>(uri + "/api/Select/InsertALanguage", l)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateALanguage(Language l)
        {
            return (await client.PutAsJsonAsync<Language>(uri + "/api/Select/UpdateALanguae", l)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteALanguage(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteALanguage/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListList_Detail> GetAllListDetails()
        {
            return await client.GetFromJsonAsync<ListList_Detail>(uri + "/api/Select/ListDetailSelector");
        }
        public async Task<int> InsertAListDetail(List_Detail ld)
        {
            return (await client.PostAsJsonAsync<List_Detail>(uri + "/api/Select/InsertAListDetail", ld)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAListDetail(List_Detail ld)
        {
            return (await client.PutAsJsonAsync<List_Detail>(uri + "/api/Select/UpdateAListDetail", ld)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteAListDetail(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteAListDetail/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListPermission> GetAllPermissions()
        {
            return await client.GetFromJsonAsync<ListPermission>(uri + "/api/Select/PermissionSelector");
        }
        public async Task<int> InsertAPermission(Permission p)
        {
            return (await client.PostAsJsonAsync<Permission>(uri + "/api/Select/InsertAPermission", p)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAPermission(Permission p)
        {
            return (await client.PutAsJsonAsync<Permission>(uri + "/api/Select/UpdateAPermission", p)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteAPermission(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteAPermission/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListPermissions_for_Administrator> GetAllPermissionsForAdministrators()
        {
            return await client.GetFromJsonAsync<ListPermissions_for_Administrator>(uri + "/api/Select/PermissionforAdministratorSelector");
        }
        public async Task<int> InsertAPermissionForAdministrator(Permissions_for_Administrator pa)
        {
            return (await client.PostAsJsonAsync<Permissions_for_Administrator>(uri + "/api/Select/InsertAPermissions_for_Administrator", pa)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAPermissionForAdministrator(Permissions_for_Administrator pa)
        {
            return (await client.PutAsJsonAsync<Permissions_for_Administrator>(uri + "/api/Select/UpdateAPermissions_for_Administrator", pa)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteAPermissionForAdministrator(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteAPermissions_for_Administrator/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListReader> GetAllReaders()
        {
            return await client.GetFromJsonAsync<ListReader>(uri + "/api/Select/ReaderSelector");
        }
        public async Task<int> InsertAReader(Reader r)
        {
            return (await client.PostAsJsonAsync<Reader>(uri + "/api/Select/InsertAReader", r)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAReader(Reader r)
        {
            return (await client.PutAsJsonAsync<Reader>(uri + "/api/Select/UpdateAReader", r)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteAReader(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteAReader/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListSeries_Detail> GetAllSeriesDetails()
        {
            return await client.GetFromJsonAsync<ListSeries_Detail>(uri + "/api/Select/SeriesDetailSelector");
        }
        public async Task<int> InsertASeriesDetail(Series_Detail sd)
        {
            return (await client.PostAsJsonAsync<Series_Detail>(uri + "/api/Select/InsertASeriesDetail", sd)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateASeriesDetail(Series_Detail sd)
        {
            return (await client.PutAsJsonAsync<Series_Detail>(uri + "/api/Select/UpdateASeriesDetail", sd)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteASeriesDetail(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteASeriesDetail/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListUser> GetAllUsers()
        {
            return await client.GetFromJsonAsync<ListUser>(uri + "/api/Select/UserSelector");
        }
        public async Task<int> InsertAUser(User u)
        {
            return (await client.PostAsJsonAsync<User>(uri + "/api/Select/InsertAUser", u)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAUser(User u)
        {
            return (await client.PutAsJsonAsync<User>(uri + "/api/Select/UpdateAUser", u)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteAUser(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteAUser/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListCart> GetAllCarts()
        {
            return await client.GetFromJsonAsync<ListCart>(uri + "/api/Select/CartSelector");
        }

        public async Task<int> InsertACart(Cart c)
        {
            return (await client.PostAsJsonAsync<Cart>(uri + "/api/Select/InsertACart", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateACart(Cart c)
        {
            return (await client.PutAsJsonAsync<Cart>(uri + "/api/Select/UpdateACart", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteACart(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteACart/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ListCart_Detail> GetAllCartDetails()
        {
            return await client.GetFromJsonAsync<ListCart_Detail>(uri + "/api/Select/CartDetailSelector");
        }

        public async Task<int> InsertACartDetail(Cart_Detail cd)
        {
            return (await client.PostAsJsonAsync<Cart_Detail>(uri + "/api/Select/InsertACartDetail", cd)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateACartDetail(Cart_Detail cd)
        {
            return (await client.PutAsJsonAsync<Cart_Detail>(uri + "/api/Select/UpdateACartDetail", cd)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteACartDetail(int id)
        {
            return (await client.DeleteAsync(uri + $"/api/Select/DeleteACartDetail/{id}")).IsSuccessStatusCode ? 1 : 0;
        }
    }
}
