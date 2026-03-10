using Model;
using Service;
using ViewModel;

public class Program
{
    public static async Task Main(string[] args)
    {
        //var host = Host.CreateDefaultBuilder(args)
        //    .ConfigureServices((context, services) =>
        //    {
        //        services.AddHttpClient();
        //        services.AddScoped<Apiservice>(sp =>
        //        {
        //            var client = sp.GetRequiredService<HttpClient>();
        //            var baseUri = "http://localhost:5265";
        //            return new Apiservice(client, baseUri);
        //        });
        //    })
        //    .Build();

        //using (var scope = host.Services.CreateScope())
        //{
        //    Console.WriteLine("Book_Series:");

        //    int id;
        //    var buyerService =
        //        scope.ServiceProvider.GetRequiredService<Apiservice>();
        //    var bookSeries = await buyerService.GetAllBookSeries();
        //    Console.WriteLine(bookSeries.Count);

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


        Apiservice buyerService = new Apiservice();

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
        //foreach (var a in author)
        //{
        //    Console.WriteLine(a.Username);
        //}

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

        //Book insertB = new Book 
        //{
        //    BookName = "new B",
        //    PublicationDate = new DateTime(2020, 1, 1),
        //    Price = 99.9,
        //    IdAuthor = author.First(),
        //    IdLanguage = language.First(),
        //    IdGenre = genre.First(),
        //    Discount = true,
        //    Information = "new B",
        //    Cover = "zzzzzzzzz"
        //};
        //int xxxxx = await buyerService.InsertABook(insertB);
        //book = await buyerService.GetAllBooks();
        //Console.WriteLine(book.Count);

        //Book updateB = book.Last(); 
        //updateB.BookName = "updated B";
        //updateB.PublicationDate = new DateTime(2021, 2, 2);
        //updateB.Price = 88.8;
        //updateB.IdAuthor = AuthorDB.SelectById(29);
        //updateB.IdLanguage = LanguageDB.SelectById(16);
        //updateB.IdGenre = GenreDB.SelectById(16);
        //updateB.Discount = false;
        //updateB.Information = "updated B";
        //updateB.Cover = "kkkkkkk";
        //await buyerService.UpdateABook(updateB);
        //book = await buyerService.GetAllBooks();
        //Console.WriteLine(book.Last());

        //id = book.Last().Id;
        //await buyerService.DeleteABook(id);
        //book = await buyerService.GetAllBooks();
        //Console.WriteLine(book.Count);

        Console.WriteLine();
        Console.WriteLine();





        Console.WriteLine("Reader:");

        var reader = await buyerService.GetAllReaders();
        Console.WriteLine(reader.Count);

        //Reader insertR = new Reader
        //{
        //    FirstName = "new r",
        //    LastName = "new r",
        //    PhoneNumber = "123456789",
        //    Email = "kkkkkk",
        //    Username = "llll",
        //    Pass = "llll",
        //    Birthdate = new DateTime(2000, 1, 1),
        //    Nickname = "new r",
        //    PremiumSubscription = true
        //};
        //await buyerService.InsertAReader(insertR);
        //reader = await buyerService.GetAllReaders();
        //Console.WriteLine(reader.Count);

        //Reader updateR = reader.Last();
        //updateR.FirstName = "updated R";
        //updateR.LastName = "updated R";
        //updateR.PhoneNumber = "987654321";
        //updateR.Email = "jjjjjjj";
        //updateR.Username = "jjjjjj";
        //updateR.Pass = "jjjjjj";
        //updateR.Birthdate = new DateTime(1999, 12, 31);
        //updateR.Nickname = "updated R";
        //updateR.PremiumSubscription = false;
        //await buyerService.UpdateAReader(updateR);
        //reader = await buyerService.GetAllReaders();
        //Console.WriteLine(reader.Last());

        //id = reader.Last().Id;
        //await buyerService.DeleteAReader(id);
        //reader = await buyerService.GetAllReaders();
        //Console.WriteLine(reader.Count);

        Console.WriteLine();
        Console.WriteLine();





        Console.WriteLine("Book_List:");

        var bookList = await buyerService.GetAllBookLists();
        Console.WriteLine(bookList.Count);

        //Book_List insertBL = new Book_List
        //{
        //    IdReader = ReaderDB.SelectById(39),
        //    ListName = "new BL",
        //    IsPublic = true
        //};
        //await buyerService.InsertABookList(insertBL);
        //bookList = await buyerService.GetAllBookLists();
        //Console.WriteLine(bookList.Count);

        //Book_List updateBL = bookList.Last(); 
        //updateBL.IdReader = ReaderDB.SelectById(39);
        //updateBL.ListName = "updated BL";
        //updateBL.IsPublic = false;
        //await buyerService.UpdateABookList(updateBL);
        //bookList = await buyerService.GetAllBookLists();
        //Console.WriteLine(bookList.Last());

        //id = bookList.Last().Id;
        //await buyerService.DeleteABookList(id);
        //bookList = await buyerService.GetAllBookLists();
        //Console.WriteLine(bookList.Count);

        Console.WriteLine();
        Console.WriteLine();





        Console.WriteLine("Intrest_Reader:");

        var intrestReader = await buyerService.GetAllIntrestReaders();
        Console.WriteLine(intrestReader.Count);

        //Intrest_Reader insertIR = new Intrest_Reader 
        //{
        //    IdReader = ReaderDB.SelectById(39),
        //    IdIntrest = IntrestDB.SelectById(16)
        //};
        //await buyerService.InsertAnIntrestReader(insertIR);
        //intrestReader = await buyerService.GetAllIntrestReaders();
        //Console.WriteLine(intrestReader.Count);

        Intrest_Reader updateIR = intrestReader.Last(); 
        updateIR.IdReader = ReaderDB.SelectById(39);
        updateIR.IdIntrest = IntrestDB.SelectById(16);
        await buyerService.UpdateAnIntrestReader(updateIR);
        intrestReader = await buyerService.GetAllIntrestReaders();
        Console.WriteLine(intrestReader.Last());

        //id = intrestReader.Last().Id;
        //await buyerService.DeleteAnIntrestReader(id);
        //intrestReader = await buyerService.GetAllIntrestReaders();
        //Console.WriteLine(intrestReader.Count);

        Console.WriteLine();
        Console.WriteLine();





        Console.WriteLine("List_Detail:");

        var listDetail = await buyerService.GetAllListDetails();
        Console.WriteLine(listDetail.Count);

        //List_Detail insertLD = new List_Detail
        //{
        //    IdList = Book_ListDB.SelectById(12),
        //    IdBook = BookDB.SelectById(115)
        //};
        //await buyerService.InsertAListDetail(insertLD);
        //listDetail = await buyerService.GetAllListDetails();
        //Console.WriteLine(listDetail.Count);

        List_Detail updateLD = listDetail.Last(); 
        updateLD.IdList = Book_ListDB.SelectById(12);
        updateLD.IdBook = BookDB.SelectById(115);
        await buyerService.UpdateAListDetail(updateLD);
        listDetail = await buyerService.GetAllListDetails();
        Console.WriteLine(listDetail.Last());

        //id = listDetail.Last().Id;
        //await buyerService.DeleteAListDetail(id);
        //listDetail = await buyerService.GetAllListDetails();
        //Console.WriteLine(listDetail.Count);

        Console.WriteLine();
        Console.WriteLine();





        Console.WriteLine("Permission_for_Administrator:");

        var permissionForAdmin = await buyerService.GetAllPermissionsForAdministrators();
        Console.WriteLine(permissionForAdmin.Count);

        //Permissions_for_Administrator insertPFA = new Permissions_for_Administrator 
        //{
        //    IdAdministrator = UserDB.SelectById(29),
        //    IdPermission = PermissionDB.SelectById(18)
        //};
        //await buyerService.InsertAPermissionForAdministrator(insertPFA);
        //permissionForAdmin = await buyerService.GetAllPermissionsForAdministrators(); ;
        //Console.WriteLine(permissionForAdmin.Count);

        Permissions_for_Administrator updatePFA = permissionForAdmin.Last(); 
        updatePFA.IdAdministrator = UserDB.SelectById(29);
        updatePFA.IdPermission = PermissionDB.SelectById(18);
        await buyerService.UpdateAPermissionForAdministrator(updatePFA);
        permissionForAdmin = await buyerService.GetAllPermissionsForAdministrators();
        Console.WriteLine(permissionForAdmin.Last());

        //id = permissionForAdmin.Last().Id;
        //await buyerService.DeleteAPermissionForAdministrator(id);
        //permissionForAdmin = await buyerService.GetAllPermissionsForAdministrators();
        //Console.WriteLine(permissionForAdmin.Count);

        Console.WriteLine();
        Console.WriteLine();





        Console.WriteLine("Series_Detail:");

        var seriesDetail = await buyerService.GetAllSeriesDetails();
        Console.WriteLine(seriesDetail.Count);

        //Series_Detail insertSD = new Series_Detail 
        //{
        //    IdSeries = Book_SeriesDB.SelectById(16),
        //    IdBook = BookDB.SelectById(115)
        //};
        //await buyerService.InsertASeriesDetail(insertSD);
        //seriesDetail = await buyerService.GetAllSeriesDetails();
        //Console.WriteLine(seriesDetail.Count);

        Series_Detail updateSD = seriesDetail.Last(); 
        updateSD.IdSeries = Book_SeriesDB.SelectById(13);
        updateSD.IdBook = BookDB.SelectById(115);
        await buyerService.UpdateASeriesDetail(updateSD);
        seriesDetail = await buyerService.GetAllSeriesDetails();
        Console.WriteLine(seriesDetail.Last());

        //id = seriesDetail.Last().Id;
        //await buyerService.DeleteASeriesDetail(id);
        //seriesDetail = await buyerService.GetAllSeriesDetails();
        //Console.WriteLine(seriesDetail.Count);

        Console.WriteLine();
        Console.WriteLine();





        Console.WriteLine("Cart:");

        var cart = await buyerService.GetAllCarts();
        Console.WriteLine(cart.Count);

        //Cart insertC = new Cart 
        //{
        //    IdReader = ReaderDB.SelectById(39),
        //    DiscountCode = "new C",
        //    TotalPrice = 99.9
        //};
        //await buyerService.InsertACart(insertC);
        //cart = await buyerService.GetAllCarts();
        //Console.WriteLine(cart.Count);

        Cart updateC = cart.Last(); 
        updateC.IdReader = ReaderDB.SelectById(39);
        updateC.DiscountCode = "updated C";
        updateC.TotalPrice = 88.8;
        await buyerService.UpdateACart(updateC);
        cart = await buyerService.GetAllCarts();
        Console.WriteLine(cart.Last());

        //id = cart.Last().Id;
        //await buyerService.DeleteACart(id);
        //cart = await buyerService.GetAllCarts();
        //Console.WriteLine(cart.Count);

        Console.WriteLine();
        Console.WriteLine();





        Console.WriteLine("Cart_Detail:");

        var cartDetail = await buyerService.GetAllCartDetails();
        Console.WriteLine(cartDetail.Count);

        //Cart_Detail insertCD = new Cart_Detail 
        //{
        //    IdCart = CartDB.SelectById(1),
        //    IdBook = BookDB.SelectById(115),
        //};
        //await buyerService.InsertACartDetail(insertCD);
        //cartDetail = await buyerService.GetAllCartDetails();
        //Console.WriteLine(cartDetail.Count);

        Cart_Detail updateCD = cartDetail.Last(); 
        updateCD.IdCart = CartDB.SelectById(2);
        updateCD.IdBook = BookDB.SelectById(115);
        await buyerService.UpdateACartDetail(updateCD);
        cartDetail = await buyerService.GetAllCartDetails();
        Console.WriteLine(cartDetail.Last());

        //id = cartDetail.Last().Id;
        //await buyerService.DeleteACartDetail(id);
        //cartDetail = await buyerService.GetAllCartDetails();
        //Console.WriteLine(cartDetail.Count);

        Console.WriteLine();
        Console.WriteLine();





        Console.ReadLine();
    }
}