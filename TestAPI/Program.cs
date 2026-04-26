using Model;
using Service;
using ViewModel;

public class Program
{
    public static async Task Main(string[] args)
    {
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


        Console.WriteLine("Language:");

        var language = await buyerService.GetAllLanguages();
        Console.WriteLine(language.Count);

        //Language insertl = new Language
        //{
        //    Name = "new l"
        //};
        //await buyerService.InsertALanguage(insertl);
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


        Console.WriteLine("User:");

        var user = await buyerService.GetAllUsers();
        Console.WriteLine(user.Count);

        //User insertU = new User
        //{
        //    FirstName = "Alice",
        //    LastName = "Johnson",
        //    PhoneNumber = "0567284932",
        //    Email = "aliceJhon22@gmail.com",
        //    Username = "aliceJhon22",
        //    Pass = "alicePass22",
        //    Birthdate = new DateTime(1992, 7, 15),
        //    Picture = "alice.jpg"
        //};
        //await buyerService.InsertAUser(insertU);
        //user = await buyerService.GetAllUsers();
        //Console.WriteLine(user.Count);

        //User updateU = user.Last();
        //updateU.FirstName = "updated Alice";
        //uUpdate.LastName = "Johnson";
        //uUpdate.PhoneNumber = "0567284932";
        //uUpdate.Email = "aliceJhon22@gmail.com";
        //uUpdate.Username = "aliceJhon22";
        //uUpdate.Pass = "alicePass22";
        //uUpdate.Birthdate = new DateTime(1992, 7, 15);
        //uUpdate.Picture = "alice.jpg";
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
        //    FirstName = "Alice",
        //    LastName = "Johnson",
        //    PhoneNumber = "0567284932",
        //    Email = "aliceJhon22@gmail.com",
        //    Username = "aliceJhon22",
        //    Pass = "alicePass22",
        //    Birthdate = new DateTime(1992, 7, 15),
        //    Picture = "alice.jpg",
        //    PenName = "Mark Twain",
        //    Genre = GenreDB.SelectById(122),
        //    InformationAboutAuthor = "Famous American author"
        //};
        //await buyerService.InsertAnAuthor(insertA);
        //author = await buyerService.GetAllAuthors();
        //Console.WriteLine(author.Count);

        //Author updateA = author.Last();
        //updateA.FirstName = "updated Alice";
        //updateA.LastName = "Johnson";
        //updateA.PhoneNumber = "0567284932";
        //updateA.Email = "aliceJhon22@gmail.com";
        //updateA.Username = "aliceJhon22";
        //updateA.Pass = "alicePass22";
        //updateA.Birthdate = new DateTime(1992, 7, 15);
        //updateA.Picture = "alice.jpg";
        //aUpdate.PenName = "update";
        //aUpdate.Genre = gList.First();
        //aUpdate.InformationAboutAuthor = "Famous American author";
        //await buyerService.UpdateAnAuthor(updateA);
        //author = await buyerService.GetAllAuthors();
        //Console.WriteLine(author.Last());

        //id = author.Last().Id;
        //await buyerService.DeleteAnAuthor(id);
        //author = await buyerService.GetAllAuthors();
        //Console.WriteLine(author.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Reader:");

        var reader = await buyerService.GetAllReaders();
        Console.WriteLine(reader.Count);

        //Reader insertR = new Reader
        //{
        //    FirstName = "Bob",
        //    LastName = "Smith",
        //    PhoneNumber = "0543216789",
        //    Email = "bobsmithdm@gmail.com",
        //    Username = "bobsmithdm",
        //    Pass = "bobPassdm",
        //    Birthdate = new DateTime(1985, 3, 10),
        //    Picture = "bob_smith.jpg",
        //    Nickname = "BookLoverBob",
        //    PremiumSubscription = true
        //};
        //await buyerService.InsertAReader(insertR);
        //reader = await buyerService.GetAllReaders();
        //Console.WriteLine(reader.Count);

        //Reader updateR = reader.Last();
        //rUpdate.FirstName = "UPdate";
        //rUpdate.LastName = "Smith";
        //rUpdate.PhoneNumber = "0543216789";
        //rUpdate.Email = "bobsmithdm@gmail.com";
        //rUpdate.Username = "bobsmithdm";
        //rUpdate.Pass = "bobPassdm";
        //rUpdate.Birthdate = new DateTime(1985, 3, 10);
        //rUpdate.Picture = "bob_smith.jpg";
        //rUpdate.Nickname = "update";
        //rUpdate.PremiumSubscription = true;
        //await buyerService.UpdateAReader(updateR);
        //reader = await buyerService.GetAllReaders();
        //Console.WriteLine(reader.Last());

        //id = reader.Last().Id;
        //await buyerService.DeleteAReader(id);
        //reader = await buyerService.GetAllReaders();
        //Console.WriteLine(reader.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Admin:");

        var admin = await buyerService.GetAllAdmins();
        Console.WriteLine(admin.Count);

        //Admin insertAd = new Admin
        //{
        //    FirstName = "Bob",
        //    LastName = "Smith",
        //    PhoneNumber = "0543216789",
        //    Email = "bobsmithdm@gmail.com",
        //    Username = "bobsmithdm",
        //    Pass = "bobPassdm",
        //    Birthdate = new DateTime(1985, 3, 10),
        //    Picture = "bob_smith.jpg"
        //};
        //await buyerService.InsertAnAdmin(insertAd);
        //admin = await buyerService.GetAllAdmins();
        //Console.WriteLine(admin.Count);

        //id = admin.Last().Id;
        //await buyerService.DeleteAnAdmin(id);
        //admin = await buyerService.GetAllAdmins();
        //Console.WriteLine(admin.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Book:");

        var book = await buyerService.GetAllBooks();
        Console.WriteLine(book.Count);

        //Book insertB = new Book
        //{
        //    BookName = "The ",
        //    PublicationDate = new DateTime(2019, 2, 5),
        //    Price = 18,
        //    IdAuthor = author.First(),
        //    Discount = false,
        //    Information = "A thrilling",
        //    Cover = "silent_patient.jpg",
        //    IdLanguage = language.First(),
        //    BookLink = "link.epub"
        //};
        //await buyerService.InsertABook(insertB);
        //book = await buyerService.GetAllBooks();
        //Console.WriteLine(book.Count);

        //Book bUpdate = book.Last();
        //bUpdate.BookName = "The Silent Patient - Updated";
        //bUpdate.PublicationDate = new DateTime(2019, 2, 5);
        //bUpdate.Price = 18;
        //bUpdate.IdAuthor = aList.First();
        //bUpdate.Discount = false;
        //bUpdate.Information = "A thrilling";
        //bUpdate.Cover = "silent_patient.jpg";
        //bUpdate.IdLanguage = lList.First();
        //await buyerService.UpdateABook(bUpdate);
        //book = await buyerService.GetAllBooks();
        //Console.WriteLine(book.Last());

        //id = book.Last().Id;
        //await buyerService.DeleteABook(id);
        //book = await buyerService.GetAllBooks();
        //Console.WriteLine(book.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Book_Series:");

        var bookSeries = await buyerService.GetAllBookSeries();
        Console.WriteLine(bookSeries.Count);

        //Book_Series insertBS = new Book_Series
        //{
        //    NameSeries = "Boys Of Tommen Series",
        //    IdAuthor = author.First()
        //};
        //await buyerService.InsertABookSeries(insertBS);
        //bookSeries = await buyerService.GetAllBookSeries();
        //Console.WriteLine(bookSeries.Count);

        //Book_Series bsUpdate = bookSeries.Last();
        //bsUpdate.NameSeries = "Boys Of Tommen Series - Updated";
        //bsUpdate.IdAuthor = author.First();
        //await buyerService.UpdateABookSeries(bsUpdate);
        //bookSeries = await buyerService.GetAllBookSeries();
        //Console.WriteLine(bookSeries.Last());

        //id = bookSeries.Last().Id;
        //await buyerService.DeleteABookSeries(id);
        //bookSeries = await buyerService.GetAllBookSeries();
        //Console.WriteLine(bookSeries.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Series_Detail:");

        var seriesDetail = await buyerService.GetAllSeriesDetails();
        Console.WriteLine(seriesDetail.Count);

        Series_Detail insertSD = new Series_Detail
        {
            IdSeries = bookSeries.First(),
            IdBook = book.First()
        };
        await buyerService.InsertASeriesDetail(insertSD);
        seriesDetail = await buyerService.GetAllSeriesDetails();
        Console.WriteLine(seriesDetail.Count);

        //Series_Detail sdUpdate = seriesDetail.Last();
        //sdUpdate.IdSeries = bookSeries.First();
        //sdUpdate.IdBook = book.Last();
        //await buyerService.UpdateASeriesDetail(sdUpdate);
        //seriesDetail = await buyerService.GetAllSeriesDetails();
        //Console.WriteLine(seriesDetail.Last());

        //id = seriesDetail.Last().Id;
        //await buyerService.DeleteASeriesDetail(id);
        //seriesDetail = await buyerService.GetAllSeriesDetails();
        //Console.WriteLine(seriesDetail.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Book_Genre:");

        var bookGenre = await buyerService.GetAllBookGenres();
        Console.WriteLine(bookGenre.Count);

        Book_Genre insertBG = new Book_Genre
        {
            IdBook = book.First(),
            IdGenre = genre.First()
        };
        await buyerService.InsertABookGenre(insertBG);
        bookGenre = await buyerService.GetAllBookGenres();
        Console.WriteLine(bookGenre.Count);

        //Book_Genre bgUpdate = bookGenre.Last();
        //bgUpdate.IdBook = book.First();
        //bgUpdate.IdGenre = genre.Last();
        //await buyerService.UpdateABookGenre(bgUpdate);
        //bookGenre = await buyerService.GetAllBookGenres();
        //Console.WriteLine(bookGenre.Last());

        //id = bookGenre.Last().Id;
        //await buyerService.DeleteABookGenre(id);
        //bookGenre = await buyerService.GetAllBookGenres();
        //Console.WriteLine(bookGenre.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Intrest_Reader:");

        var intrestReader = await buyerService.GetAllIntrestReaders();
        Console.WriteLine(intrestReader.Count);

        Intrest_Reader insertIR = new Intrest_Reader
        {
            IdReader = reader.First(),
            IdIntrest = intrest.First()
        };
        await buyerService.InsertAnIntrestReader(insertIR);
        intrestReader = await buyerService.GetAllIntrestReaders();
        Console.WriteLine(intrestReader.Count);

        //Intrest_Reader irUpdate = intrestReader.Last();
        //irUpdate.IdReader = reader.First();
        //irUpdate.IdGenre = genre.Last();
        //await buyerService.UpdateAnIntrestReader(irUpdate);
        //intrestReader = await buyerService.GetAllIntrestReaders();
        //Console.WriteLine(intrestReader.Last());

        //id = intrestReader.Last().Id;
        //await buyerService.DeleteAnIntrestReader(id);
        //intrestReader = await buyerService.GetAllIntrestReaders();
        //Console.WriteLine(intrestReader.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Book_List:");

        var bookList = await buyerService.GetAllBookLists();
        Console.WriteLine(bookList.Count);

        Book_List insertBL = new Book_List
        {
            IdReader = reader.First(),
            ListName = "Summer Reads"
        };
        await buyerService.InsertABookList(insertBL);
        bookList = await buyerService.GetAllBookLists();
        Console.WriteLine(bookList.Count);

        //Book_List blUpdate = bookList.Last();
        //blUpdate.IdReader = reader.First();
        //blUpdate.ListName = "Updated";
        //await buyerService.UpdateABookList(blUpdate);
        //bookList = await buyerService.GetAllBookLists();
        //Console.WriteLine(bookList.Last());

        //id = bookList.Last().Id;
        //await buyerService.DeleteABookList(id);
        //bookList = await buyerService.GetAllBookLists();
        //Console.WriteLine(bookList.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("List_Detail:");

        var listDetail = await buyerService.GetAllListDetails();
        Console.WriteLine(listDetail.Count);

        List_Detail insertLD = new List_Detail
        {
            IdList = bookList.First(),
            IdBook = book.First()
        };
        await buyerService.InsertAListDetail(insertLD);
        listDetail = await buyerService.GetAllListDetails();
        Console.WriteLine(listDetail.Count);

        //List_Detail ldUpdate = listDetail.Last();
        //ldUpdate.IdList = bookList.First();
        //ldUpdate.IdBook = book.First();
        //await buyerService.UpdateAListDetail(ldUpdate);
        //listDetail = await buyerService.GetAllListDetails();
        //Console.WriteLine(listDetail.Last());

        //id = listDetail.Last().Id;
        //await buyerService.DeleteAListDetail(id);
        //listDetail = await buyerService.GetAllListDetails();
        //Console.WriteLine(listDetail.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Cart:");

        var cart = await buyerService.GetAllCarts();
        Console.WriteLine(cart.Count);

        Cart insertCart = new Cart
        {
            IdReader = reader.First(),
            DiscountCode = "DISCOUNT10"
        };
        await buyerService.InsertACart(insertCart);
        cart = await buyerService.GetAllCarts();
        Console.WriteLine(cart.Count);

        //Cart cUpdate = cart.Last();
        //cUpdate.IdReader = reader.First();
        //cUpdate.DiscountCode = "update";
        //await buyerService.UpdateACart(cUpdate);
        //cart = await buyerService.GetAllCarts();
        //Console.WriteLine(cart.Last());

        //id = cart.Last().Id;
        //await buyerService.DeleteACart(id);
        //cart = await buyerService.GetAllCarts();
        //Console.WriteLine(cart.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Cart_Detail:");

        var cartDetail = await buyerService.GetAllCartDetails();
        Console.WriteLine(cartDetail.Count);

        Cart_Detail insertCartDetail = new Cart_Detail
        {
            IdCart = cart.First(),
            IdBook = book.First()
        };
        await buyerService.InsertACartDetail(insertCartDetail);
        cartDetail = await buyerService.GetAllCartDetails();
        Console.WriteLine(cartDetail.Count);

        //Cart_Detail cdUpdate = cartDetail.Last();
        //cdUpdate.IdCart = cart.First();
        //cdUpdate.IdBook = book.First();
        //await buyerService.UpdateACartDetail(cdUpdate);
        //cartDetail = await buyerService.GetAllCartDetails();
        //Console.WriteLine(cartDetail.Last());

        //id = cartDetail.Last().Id;
        //await buyerService.DeleteACartDetail(id);
        //cartDetail = await buyerService.GetAllCartDetails();
        //Console.WriteLine(cartDetail.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("News");

        var news = await buyerService.GetAllNews();
        Console.WriteLine(news.Count);

        News insertNews = new News
        {
            IdUser = user.First(),
            Text = "new",
            Time = new DateTime(2026, 4, 24)
        };
        await buyerService.InsertANews(insertNews);
        news = await buyerService.GetAllNews();
        Console.WriteLine(news.Count);

        //News nUpdate = news.Last();
        //nUpdate.IdUser = user.First();
        //nUpdate.Text = "update";
        //nUpdate.Time = new DateTime(2026, 4, 25);
        //await buyerService.UpdateANews(nUpdate);
        //news = await buyerService.GetAllNews();
        //Console.WriteLine(news.Last());

        //id = news.Last().Id;
        //await buyerService.DeleteANews(id);
        //news = await buyerService.GetAllNews();
        //Console.WriteLine(news.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Reviews");

        var reviews = await buyerService.GetAllReviews();
        Console.WriteLine(reviews.Count);

        Reviews insertRe = new Reviews
        {
            IdReader = reader.First(),
            Text = "Great book!",
            Stars = 5,
            IdBook = book.First()
        };
        await buyerService.InsertAReview(insertRe);
        reviews = await buyerService.GetAllReviews();
        Console.WriteLine(reviews.Count);

        //Reviews rUpdate = reviews.Last();
        //rUpdate.IdReader = reader.First();
        //rUpdate.Text = "update";
        //rUpdate.Stars = 4;
        //rUpdate.IdBook = book.First();
        //await buyerService.UpdateAReview(rUpdate);
        //reviews = await buyerService.GetAllReviews();
        //Console.WriteLine(reviews.Last());

        //id = reviews.Last().Id;
        //await buyerService.DeleteAReview(id);
        //reviews = await buyerService.GetAllReviews();
        //Console.WriteLine(reviews.Count);

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Following");

        var followings = await buyerService.GetAllFollowings();
        Console.WriteLine(followings.Count);

        Following insertFollowing = new Following   
        {
            IdReader = reader.First(),
            IdAuthor = author.First()
        };
        await buyerService.InsertAFollowing(insertFollowing);
        followings = await buyerService.GetAllFollowings();
        Console.WriteLine(followings.Count);

        //Following fUpdate = followings.Last();
        //fUpdate.IdReader = reader.First();
        //fUpdate.IdAuthor = author.First();
        //await buyerService.UpdateAFollowing(fUpdate);
        //followings = await buyerService.GetAllFollowings();
        //Console.WriteLine(followings.Last());

        //id = followings.Last().Id;
        //await buyerService.DeleteAFollowing(id);
        //followings = await buyerService.GetAllFollowings();
        //Console.WriteLine(followings.Count);

        Console.WriteLine("end");
        Console.ReadLine();
    }
}