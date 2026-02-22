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
using System.Threading.Tasks.Dataflow;


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
                    var baseUri = "https://8rdr4sf5-5265.euw.devtunnels.ms";
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
            var bookSeries = await buyerService.GetAllBookSeries();
            Console.WriteLine(bookSeries.Count);

            //Book_Series insertBs = new Book_Series
            //{
            //    NameSeries = "new Bs"
            //};
            //await buyerService.InsertABookSeries(insertBs);
            //bookSeries = await buyerService.GetAllBookSeries();
            //Console.WriteLine(bookSeries.Count);

            //Book_Series updateBs = bookSeries.Last();
            //updateBs.NameSeries = "updated Bs";
            //await buyerService.UpdateABookSeries(updateBs);
            //bookSeries = await buyerService.GetAllBookSeries();
            //Console.WriteLine(bookSeries.Last());

            //id = bookSeries.Last().Id;
            //await buyerService.DeleteABookSeries(id);
            //bookSeries = await buyerService.GetAllBookSeries();
            //Console.WriteLine(bookSeries.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Genre:");

            var genre = await buyerService.GetAllGenres();
            Console.WriteLine(genre.Count);

            //Genre insertG = new Genre
            //{
            //    Name = "new G"
            //};
            //await buyerService.InsertAGenre(insertG);
            //genre = await buyerService.GetAllGenres();
            //Console.WriteLine(genre.Count);

            //Genre updateG = genre.Last();
            //updateG.Name = "updated G";
            //await buyerService.UpdateAGenre(updateG);
            //genre = await buyerService.GetAllGenres();
            //Console.WriteLine(genre.Last());

            //id = genre.Last().Id;
            //await buyerService.DeleteAGenre(id);
            //genre = await buyerService.GetAllGenres();
            //Console.WriteLine(genre.Count);

            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Intrest:");

            var intrest = await buyerService.GetAllIntrests();
            Console.WriteLine(intrest.Count);

            //Intrest insertI = new Intrest
            //{
            //    Name = "new I"
            //};
            //await buyerService.InsertAnIntrest(insertI);
            //intrest = await buyerService.GetAllIntrests();
            //Console.WriteLine(intrest.Count);

            //Intrest updateI = intrest.Last();
            //updateI.Name = "updated I";
            //await buyerService.UpdateAnIntrest(updateI);
            //intrest = await buyerService.GetAllIntrests();
            //Console.WriteLine(intrest.Last());

            //id = intrest.Last().Id;
            //await buyerService.DeleteAnIntrest(id);
            //intrest = await buyerService.GetAllIntrests();
            //Console.WriteLine(intrest.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Language:");

            var language = await buyerService.GetAllLanguages();
            Console.WriteLine(language.Count);

            //Language insertL = new Language
            //{
            //    Name = "new L"
            //};
            //await buyerService.InsertALanguage(insertL);
            //language = await buyerService.GetAllLanguages();
            //Console.WriteLine(language.Count);

            //Language updateL = language.Last();
            //updateL.Name = "updated L";
            //await buyerService.UpdateALanguage(updateL);
            //language = await buyerService.GetAllLanguages();
            //Console.WriteLine(language.Last());

            //id = language.Last().Id;
            //await buyerService.DeleteALanguage(id);
            //language = await buyerService.GetAllLanguages();
            //Console.WriteLine(language.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Permission:");

            var permission = await buyerService.GetAllPermissions();
            Console.WriteLine(permission.Count);

            //Permission insertP = new Permission
            //{
            //    Name = "new P"
            //};
            //await buyerService.InsertAPermission(insertP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission updateP = permission.Last();
            //updateP.Name = "updated P";
            //await buyerService.UpdateAPermission(updateP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Last());

            //id = permission.Last().Id;
            //await buyerService.DeleteAPermission(id);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("User:");

            var user = await buyerService.GetAllUsers();
            Console.WriteLine(user.Count);

            //User insertU = new User
            //{
            //    FirstName = "new U",
            //    LastName = "new U",
            //    PhoneNumber = "123456789",
            //    Email = "jjjjjj@gmail.com",
            //    Username = "jjjjj",
            //    Pass = "jjjjj",
            //    Birthdate = new DateTime(2000, 1, 1)
            //};
            //await buyerService.InsertAUser(insertU);
            //user = await buyerService.GetAllUsers();
            //Console.WriteLine(user.Count);

            //User updateU = user.Last();
            //updateU.FirstName = "updated U";
            //updateU.LastName = "updated U";
            //updateU.PhoneNumber = "987654321";
            //updateU.Email = "kkkkkkkk";
            //updateU.Username = "kkkkk";
            //updateU.Pass = "kkkkk";
            //updateU.Birthdate = new DateTime(1999, 12, 31);
            //await buyerService.UpdateAUser(updateU);
            //user = await buyerService.GetAllUsers();
            //Console.WriteLine(user.Last());

            //id = user.Last().Id;
            //await buyerService.DeleteAUser(id);
            //user = await buyerService.GetAllUsers();
            //Console.WriteLine(user.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Author:");

            var author = await buyerService.GetAllAuthors();
            Console.WriteLine(author.Count);

            //Author insertA = new Author
            //{
            //    FirstName = "new A",
            //    LastName = "new A",
            //    PhoneNumber = "123456789",
            //    Email = "jjjjjj@gmail.com",
            //    Username = "jjjjj",
            //    Pass = "jjjjj",
            //    Birthdate = new DateTime(2000, 1, 1),
            //    PenName = "new A",
            //    Genre = genre.First(),
            //    InformationAboutAuthor = "new A"
            //};
            //await buyerService.InsertAnAuthor(insertA);
            //author = await buyerService.GetAllAuthors();
            //Console.WriteLine(author.Count);

            //Author updateA = author.Last();
            //updateA.FirstName = "updated A";
            //updateA.LastName = "updated A";
            //updateA.PhoneNumber = "987654321";
            //updateA.Email = "kkkkkkkk";
            //updateA.Username = "kkkkk";
            //updateA.Pass = "kkkkk";
            //updateA.Birthdate = new DateTime(1999, 12, 31);
            //updateA.PenName = "updated A";
            //updateA.Genre = genre.Last();
            //updateA.InformationAboutAuthor = "updated A";
            //await buyerService.UpdateAnAuthor(updateA);
            //author = await buyerService.GetAllAuthors();
            //Console.WriteLine(author.Last());

            //id = author.Last().Id;
            //await buyerService.DeleteAnAuthor(id);
            //author = await buyerService.GetAllAuthors();
            //Console.WriteLine(author.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Book:");

            var book = await buyerService.GetAllBooks();
            Console.WriteLine(book.Count);

            Book insertB = new Book
            {
                BookName = "new B",
                PublicationDate = new DateTime(2020, 1, 1),
                Price = 99.9,
                IdAuthor = author.First(),
                IdLanguage = language.First(),
                IdGenre = genre.First(),
                Discount = true,
                Information = "new B",
                Cover = "jjjjjjj"
            };
            await buyerService.InsertABook(insertB);
            book = await buyerService.GetAllBooks();
            Console.WriteLine(book.Count);

            //Permission updateP = permission.Last();
            //updateP.Name = "updated P";
            //await buyerService.UpdateAPermission(updateP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Last());

            //id = permission.Last().Id;
            //await buyerService.DeleteAPermission(id);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Reader:");

            //var permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission insertP = new Permission
            //{
            //    Name = "new P"
            //};
            //await buyerService.InsertAPermission(insertP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission updateP = permission.Last();
            //updateP.Name = "updated P";
            //await buyerService.UpdateAPermission(updateP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Last());

            //id = permission.Last().Id;
            //await buyerService.DeleteAPermission(id);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Book_List:");

            //var permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission insertP = new Permission
            //{
            //    Name = "new P"
            //};
            //await buyerService.InsertAPermission(insertP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission updateP = permission.Last();
            //updateP.Name = "updated P";
            //await buyerService.UpdateAPermission(updateP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Last());

            //id = permission.Last().Id;
            //await buyerService.DeleteAPermission(id);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Intrest_Reader:");

            //var permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission insertP = new Permission
            //{
            //    Name = "new P"
            //};
            //await buyerService.InsertAPermission(insertP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission updateP = permission.Last();
            //updateP.Name = "updated P";
            //await buyerService.UpdateAPermission(updateP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Last());

            //id = permission.Last().Id;
            //await buyerService.DeleteAPermission(id);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("List_Detail:");

            //var permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission insertP = new Permission
            //{
            //    Name = "new P"
            //};
            //await buyerService.InsertAPermission(insertP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission updateP = permission.Last();
            //updateP.Name = "updated P";
            //await buyerService.UpdateAPermission(updateP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Last());

            //id = permission.Last().Id;
            //await buyerService.DeleteAPermission(id);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Permission_for_Administrator:");

            //var permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission insertP = new Permission
            //{
            //    Name = "new P"
            //};
            //await buyerService.InsertAPermission(insertP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission updateP = permission.Last();
            //updateP.Name = "updated P";
            //await buyerService.UpdateAPermission(updateP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Last());

            //id = permission.Last().Id;
            //await buyerService.DeleteAPermission(id);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Series_Detail:");

            //var permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission insertP = new Permission
            //{
            //    Name = "new P"
            //};
            //await buyerService.InsertAPermission(insertP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission updateP = permission.Last();
            //updateP.Name = "updated P";
            //await buyerService.UpdateAPermission(updateP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Last());

            //id = permission.Last().Id;
            //await buyerService.DeleteAPermission(id);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Cart:");

            //var permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission insertP = new Permission
            //{
            //    Name = "new P"
            //};
            //await buyerService.InsertAPermission(insertP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission updateP = permission.Last();
            //updateP.Name = "updated P";
            //await buyerService.UpdateAPermission(updateP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Last());

            //id = permission.Last().Id;
            //await buyerService.DeleteAPermission(id);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Cart_Detail:");

            //var permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission insertP = new Permission
            //{
            //    Name = "new P"
            //};
            //await buyerService.InsertAPermission(insertP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            //Permission updateP = permission.Last();
            //updateP.Name = "updated P";
            //await buyerService.UpdateAPermission(updateP);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Last());

            //id = permission.Last().Id;
            //await buyerService.DeleteAPermission(id);
            //permission = await buyerService.GetAllPermissions();
            //Console.WriteLine(permission.Count);

            Console.WriteLine();
            Console.WriteLine();





            Console.ReadLine();
        }
    }
}