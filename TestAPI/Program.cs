using Microsoft.Extensions.Hosting;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;


namespace TestAPI;

public class Program
{
    public static async Task Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddHttpClient();
                services.AddScoped<Apiservice>(sp =>
                {
                    var client = sp.GetRequiredService<HttpClient>();
                    var baseUri = "https://mcw4p0zt-5265.euw.devtunnels.ms";
                    return new Apiservice(client, baseUri);
                });
            })
            .Build();

        using (var scope = host.Services.CreateScope())
        {
            Console.WriteLine("Book_Series:");

            int id;
            var buyerService =
                scope.ServiceProvider.GetRequiredService<Apiservice>();
            var bookSeriess = await buyerService.GetAllBookSeries();
            Console.WriteLine(bookSeriess.Count);

            Book_Series bs = new Book_Series
            {
                NameSeries = "new bs"
            };
            await buyerService.InsertABookSeries(bs);
            bookSeriess = await buyerService.GetAllBookSeries();
            Console.WriteLine(bookSeriess.Count);

            Book_Series mybs = bookSeriess.Last();
            mybs.NameSeries = "Updated";
            await buyerService.UpdateABookSeries(mybs);

            id = bookSeriess.Last().Id;
            await buyerService.DeleteABookSeries(id);
            bookSeriess = await buyerService.GetAllBookSeries();
            Console.WriteLine(bookSeriess.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Genre:");

            ListGenre genres = await buyerService.GetAllGenres();
            Console.WriteLine(genres.Count);

            Genre g = new Genre
            {
                Name = "new g"
            };
            await buyerService.InsertAGenre(g);
            genres = await buyerService.GetAllGenres();
            Console.WriteLine(genres.Count);

            Genre myg = genres.Last();
            myg.Name = "Updated";
            await buyerService.UpdateAGenre(myg);

            id = genres.Last().Id;
            await buyerService.DeleteAGenre(id);
            genres = await buyerService.GetAllGenres();
            Console.WriteLine(genres.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Intrest:");

            ListIntrest intrests = await buyerService.GetAllIntrests();
            Console.WriteLine(intrests.Count);

            Intrest i = new Intrest
            {
                Name = "new i"
            };
            await buyerService.InsertAnIntrest(i);
            intrests = await buyerService.GetAllIntrests();
            Console.WriteLine(intrests.Count);

            Intrest myi = intrests.Last();
            myi.Name = "Updated";
            await buyerService.UpdateAnIntrest(i);

            id = intrests.Last().Id;
            await buyerService.DeleteAnIntrest(id);
            intrests = await buyerService.GetAllIntrests();
            Console.WriteLine(intrests.Count);

            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Language:");

            ListLanguage languages = await buyerService.GetAllLanguages();
            Console.WriteLine(languages.Count);

            Language l = new Language
            {
                Name = "new l"
            };
            await buyerService.InsertALanguage(l);
            languages = await buyerService.GetAllLanguages();
            Console.WriteLine(languages.Count);

            Language myl = languages.Last();
            myl.Name = "Updated";
            await buyerService.UpdateALanguage(myl);

            id = languages.Last().Id;
            await buyerService.DeleteALanguage(id);
            languages = await buyerService.GetAllLanguages();
            Console.WriteLine(languages.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Permission:");

            ListPermission permissions = await buyerService.GetAllPermissions();
            Console.WriteLine(permissions.Count);

            Permission p = new Permission
            {
                Name = "new p"
            };
            await buyerService.InsertAPermission(p);
            permissions = await buyerService.GetAllPermissions();
            Console.WriteLine(permissions.Count);

            Permission myp = permissions.Last();
            myp.Name = "Updated";
            await buyerService.UpdateAPermission(myp);

            id = permissions.Last().Id;
            await buyerService.DeleteAPermission(id);
            permissions = await buyerService.GetAllPermissions();
            Console.WriteLine(permissions.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("User:");

            ListUser users = await buyerService.GetAllUsers();
            Console.WriteLine(users.Count);

            User u = new User
            {
                FirstName = "new u",
                LastName = "new u",
                PhoneNumber = "0000000000",
                Email = "aaaaaaaa",
                Username = "new u",
                Pass = "new u"
            };
            await buyerService.InsertAUser(u);
            users = await buyerService.GetAllUsers();
            Console.WriteLine(users.Count);

            User myu = users.Last();
            myu.FirstName = "Updated";
            myu.LastName = "Updated";
            myu.PhoneNumber = "1111111111";
            myu.Email = "bbbbbbbb";
            myu.Username = "Updated";
            myu.Pass = "Updated";
            await buyerService.UpdateAUser(myu);

            id = users.Last().Id;
            await buyerService.DeleteAUser(id);
            users = await buyerService.GetAllUsers();
            Console.WriteLine(users.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Author:");

            ListAuthor authors = await buyerService.GetAllAuthors();
            Console.WriteLine(authors.Count);

            Author a = new Author
            {
                FirstName = "new a",
                LastName = "new a",
                PhoneNumber = "0000000000",
                Email = "aaaaaaaa",
                Username = "new a",
                Pass = "new a",
                PenName = "new a",
                Genre = genres.First(),
                InformationAboutAuthor = "new a"
            };
            await buyerService.InsertAnAuthor(a);
            authors = await buyerService.GetAllAuthors();
            Console.WriteLine(authors.Count);

            Author mya = authors.Last();
            mya.FirstName = "Updated";
            mya.LastName = "Updated";
            mya.PhoneNumber = "1111111111";
            mya.Email = "bbbbbbbb";
            mya.Username = "Updated";
            mya.Pass = "Updated";
            mya.PenName = "Updated";
            mya.Genre = genres.Last();
            mya.InformationAboutAuthor = "Updated";
            await buyerService.UpdateAnAuthor(mya);

            id = authors.Last().Id;
            await buyerService.DeleteAnAuthor(id);
            authors = await buyerService.GetAllAuthors();
            Console.WriteLine(authors.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Book:");

            ListBook books = await buyerService.GetAllBooks();
            Console.WriteLine(books.Count);

            Book b = new Book
            {
                BookName = "new b",
                PublicationDate = new DateTime(2025, 12, 12),
                Price = 100,
                IdAuthor = authors.First(),
                IdGenre = genres.First(),
                Discount = false,
                Information = "new b",
                Cover = "new b",
                IdLanguage = languages.First(),
            };
            await buyerService.InsertABook(b);
            books = await buyerService.GetAllBooks();
            Console.WriteLine(books.Count);

            Book myb = books.Last();
            myb.BookName = "Updated";
            myb.PublicationDate = new DateTime(2024, 11, 11);
            myb.Price = 200;
            myb.IdAuthor = authors.Last();
            myb.IdGenre = genres.Last();
            myb.Discount = true;
            myb.Information = "Updated";
            myb.Cover = "Updated";
            myb.IdLanguage = languages.Last();
            await buyerService.UpdateABook(myb);

            id = books.Last().Id;
            await buyerService.DeleteABook(id);
            books = await buyerService.GetAllBooks();
            Console.WriteLine(books.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Reader:");

            ListReader readers = await buyerService.GetAllReaders();
            Console.WriteLine(readers.Count);

            Reader r = new Reader
            {
                FirstName = "new r",
                LastName = "new r",
                PhoneNumber = "0000000000",
                Email = "aaaaaaaa",
                Username = "new r",
                Pass = "new r",
                Nickname = "new r",
                PremiumSubscription = false,
                DateOfBirth = new DateTime(2000, 12, 12)
            };
            await buyerService.InsertAReader(r);
            readers = await buyerService.GetAllReaders();
            Console.WriteLine(readers.Count);

            Reader myr = readers.Last();
            myr.FirstName = "Updated";
            myr.LastName = "Updated";
            myr.PhoneNumber = "1111111111";
            myr.Email = "bbbbbbbb";
            myr.Username = "Updated";
            myr.Pass = "Updated";
            myr.Nickname = "Updated";
            myr.PremiumSubscription = true;
            myr.DateOfBirth = new DateTime(1999, 11, 11);
            await buyerService.UpdateAReader(myr);

            id = readers.Last().Id;
            await buyerService.DeleteAReader(id);
            readers = await buyerService.GetAllReaders();
            Console.WriteLine(readers.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Book_List:");

            ListBook_List bookLists = await buyerService.GetAllBookLists();
            Console.WriteLine(bookLists.Count);

            Book_List bl = new Book_List
            {
                IdReader = readers.First(),
                ListName = "new bl",
                IsPublic = false
            };
            await buyerService.InsertABookList(bl);
            bookLists = await buyerService.GetAllBookLists();
            Console.WriteLine(bookLists.Count);

            Book_List mybl = bookLists.Last();
            mybl.IdReader = readers.Last();
            mybl.ListName = "Updated";
            mybl.IsPublic = true;
            await buyerService.UpdateABookList(mybl);

            id = bookLists.Last().Id;
            await buyerService.DeleteABookList(id);
            bookLists = await buyerService.GetAllBookLists();
            Console.WriteLine(bookLists.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Intrest_Reader:");

            ListIntrest_Reader intrestReaders = await buyerService.GetAllIntrestReaders();
            Console.WriteLine(intrestReaders.Count);

            Intrest_Reader ir = new Intrest_Reader
            {
                IdReader = readers.First(),
                IdIntrest = intrests.First()
            };
            await buyerService.InsertAnIntrestReader(ir);
            intrestReaders = await buyerService.GetAllIntrestReaders();
            Console.WriteLine(intrestReaders.Count);

            Intrest_Reader myir = intrestReaders.Last();
            myir.IdReader = readers.Last();
            myir.IdIntrest = intrests.Last();
            await buyerService.UpdateAnIntrestReader(myir);

            id = intrestReaders.Last().Id;
            await buyerService.DeleteAnIntrestReader(id);
            intrestReaders = await buyerService.GetAllIntrestReaders();
            Console.WriteLine(intrestReaders.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("List_Detail:");

            ListList_Detail listDetails = await buyerService.GetAllListDetails();
            Console.WriteLine(listDetails.Count);

            List_Detail ld = new List_Detail
            {
                IdList = bookLists.First(),
                IdBook = books.First()
            };
            await buyerService.InsertAListDetail(ld);
            listDetails = await buyerService.GetAllListDetails();
            Console.WriteLine(listDetails.Count);

            List_Detail myld = listDetails.Last();
            myld.IdList = bookLists.Last();
            myld.IdBook = books.Last();
            await buyerService.UpdateAListDetail(myld);

            id = listDetails.Last().Id;
            await buyerService.DeleteAListDetail(id);
            listDetails = await buyerService.GetAllListDetails();
            Console.WriteLine(listDetails.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Permissions_for_Administrator:");

            ListPermissions_for_Administrator permissionsForAdministrators = await buyerService.GetAllPermissionsForAdministrators();
            Console.WriteLine(permissionsForAdministrators.Count);

            Permissions_for_Administrator pfa = new Permissions_for_Administrator
            {
                IdAdministrator = users.First(),
                IdPermission = permissions.First()
            };
            await buyerService.InsertAPermissionForAdministrator(pfa);
            permissionsForAdministrators = await buyerService.GetAllPermissionsForAdministrators();
            Console.WriteLine(permissionsForAdministrators.Count);

            Permissions_for_Administrator mypfa = permissionsForAdministrators.Last();
            mypfa.IdAdministrator = users.Last();
            mypfa.IdPermission = permissions.Last();
            await buyerService.UpdateAPermissionForAdministrator(pfa);

            id = permissionsForAdministrators.Last().Id;
            await buyerService.DeleteAPermissionForAdministrator(id);
            permissionsForAdministrators = await buyerService.GetAllPermissionsForAdministrators();
            Console.WriteLine(permissionsForAdministrators.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Series_Detail:");

            ListSeries_Detail seriesDetails = await buyerService.GetAllSeriesDetails();
            Console.WriteLine(seriesDetails.Count);

            Series_Detail sd = new Series_Detail
            {
                IdSeries = bookSeriess.First(),
                IdBook = books.First()
            };
            await buyerService.InsertASeriesDetail(sd);
            seriesDetails = await buyerService.GetAllSeriesDetails();
            Console.WriteLine(seriesDetails.Count);

            Series_Detail mysd = seriesDetails.Last();
            mysd.IdSeries = bookSeriess.Last();
            mysd.IdBook = books.Last();
            await buyerService.UpdateASeriesDetail(mysd);

            id = seriesDetails.Last().Id;
            await buyerService.DeleteASeriesDetail(id);
            seriesDetails = await buyerService.GetAllSeriesDetails();
            Console.WriteLine(seriesDetails.Count);

            Console.ReadLine();
        }
    }
}