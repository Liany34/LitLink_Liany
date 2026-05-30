using Model;
using System.Diagnostics;
using ViewModel;
using Service;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;


public class Program
{
    //public static void Main(string[] args)
    //{
    //    int x;
    //    int y;
    //    int z;

    //    Console.WriteLine("Genre:");

    //    GenreDB gdb = new GenreDB();
    //    ListGenre gList = gdb.SelectAll();
    //    //foreach (Genre g in gList)
    //    //    Console.WriteLine(g);
    //    //Console.WriteLine();

    //    //Genre gInsert = new Genre();
    //    //gInsert.Name = "Adventure";
    //    //gdb.Insert(gInsert);
    //    //x = gdb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    //Genre gUpdate = gList.Last();
    //    //gUpdate.Name = "update";
    //    //gdb.Update(gUpdate);
    //    //y = gdb.SaveChanges();
    //    //Console.WriteLine($"{y} rows were updated");
    //    //Console.WriteLine();

    //    //Genre gDelete = gList.Last();
    //    //gdb.Delete(gDelete);
    //    //z = gdb.SaveChanges();
    //    //Console.WriteLine($"{z} rows were deleted");
    //    //Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Language:");

    //    LanguageDB ldb = new LanguageDB();
    //    ListLanguage lList = ldb.SelectAll();
    //    //foreach (Language l in lList)
    //    //    Console.WriteLine(l);
    //    //Console.WriteLine();

    //    //Language lInsert = new Language();
    //    //lInsert.Name = "German";
    //    //ldb.Insert(lInsert);
    //    //x = ldb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    //Language lUpdate = lList.Last();
    //    //lUpdate.Name = "update";
    //    //ldb.Update(lUpdate);
    //    //y = ldb.SaveChanges();
    //    //Console.WriteLine($"{y} rows were updated");
    //    //Console.WriteLine();

    //    //Language lDelete = lList.Last();
    //    //ldb.Delete(lDelete);
    //    //z = ldb.SaveChanges();
    //    //Console.WriteLine($"{z} rows were deleted");
    //    //Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();



    //    //Console.WriteLine("DiscountCodes:");

    //    DiscountCodesDB ddb = new DiscountCodesDB();
    //    ListDiscountCodes dList = ddb.SelectAll();
    //    //foreach (DiscountCodes d in dList)
    //    //    Console.WriteLine(d);
    //    //Console.WriteLine();

    //    //DiscountCodes dInsert = new DiscountCodes();
    //    //dInsert.CodeText = "SUMMER20";
    //    //dInsert.IsActive = true;
    //    //dInsert.ValidUntil = new DateTime(2024, 8, 31);
    //    //dInsert.Amount = 20;
    //    //ddb.Insert(dInsert);
    //    //x = ddb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    //DiscountCodes dUpdate = dList.Last();
    //    //dUpdate.CodeText = "update";
    //    //dUpdate.IsActive = false;
    //    //dUpdate.ValidUntil = new DateTime(2024, 8, 31);
    //    //dUpdate.Amount = 20;
    //    //ddb.Update(dUpdate);
    //    //y = ddb.SaveChanges();
    //    //Console.WriteLine($"{y} rows were updated");
    //    //Console.WriteLine();

    //    //DiscountCodes dDelete = dList.Last();
    //    //ddb.Delete(dDelete);
    //    //z = ddb.SaveChanges();
    //    //Console.WriteLine($"{z} rows were deleted");
    //    //Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("User:");

    //    UserDB udb = new UserDB();
    //    ListUser uList = udb.SelectAll();
    //    //foreach (User u in uList)
    //    //    Console.WriteLine(u);
    //    //Console.WriteLine();

    //    //User uInsert = new User();
    //    //uInsert.FirstName = "Alice";
    //    //uInsert.LastName = "Johnson";
    //    //uInsert.PhoneNumber = "0567284932";
    //    //uInsert.Email = "aliceJhon22@gmail.com";
    //    //uInsert.Username = "aliceJhon22";
    //    //uInsert.Pass = "alicePass22";
    //    //uInsert.Birthdate = new DateTime(1992, 7, 15);
    //    //uInsert.Picture = "alice.jpg";
    //    //udb.Insert(uInsert);
    //    //x = udb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    //User uUpdate = uList.Last();
    //    //uUpdate.FirstName = "Update";
    //    //uUpdate.LastName = "Update";
    //    //uUpdate.PhoneNumber = "0567284932";
    //    //uUpdate.Email = "aliceJhon22@gmail.com";
    //    //uUpdate.Username ="update";
    //    //uUpdate.Pass = "alicePass22";
    //    //uUpdate.Picture = "alice.jpg";
    //    //udb.Update(uUpdate);
    //    //y = udb.SaveChanges();
    //    //Console.WriteLine($"{y} rows were updated");
    //    //Console.WriteLine();

    //    //User uDelete = uList.Last();
    //    //udb.Delete(uDelete);
    //    //z = udb.SaveChanges();
    //    //Console.WriteLine($"{z} rows were deleted");
    //    //Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Author:");

    //    AuthorDB adb = new AuthorDB();
    //    ListAuthor aList = adb.SelectAll();
    //    //foreach (Author a in aList)
    //    //    Console.WriteLine(a.FirstName);
    //    //Console.WriteLine();

    //    //Author aInsert = new Author();
    //    //aInsert.FirstName = "Mark";
    //    //aInsert.LastName = "Twain";
    //    //aInsert.PhoneNumber = "0523456789";
    //    //aInsert.Email = "markTwin1@gmail.com";
    //    //aInsert.Username = "markTwin1";
    //    //aInsert.Pass = "markPass1";
    //    //aInsert.Birthdate = new DateTime(1835, 11, 30);
    //    //aInsert.Picture = "mark_twain.jpg";
    //    //aInsert.PenName = "Mark Twain";
    //    //aInsert.Genre = GenreDB.SelectById(122);
    //    //aInsert.InformationAboutAuthor = "Famous American author";
    //    //adb.Insert(aInsert);
    //    //x = adb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    //Author aUpdate = aList.Last();
    //    //aUpdate.FirstName = "Update";
    //    //aUpdate.LastName = "Update";
    //    //aUpdate.PhoneNumber = "0523456789";
    //    //aUpdate.Email = "markTwin1@gmail.com";
    //    //aUpdate.Username = "markTwin1";
    //    //aUpdate.Pass = "markPass1";
    //    //aUpdate.Picture = "mark_twain.jpg";
    //    //aUpdate.PenName = "update";
    //    //aUpdate.Genre = gList.First();
    //    //aUpdate.InformationAboutAuthor = "Famous American author";
    //    //adb.Update(aUpdate);
    //    //y = adb.SaveChanges();
    //    //Console.WriteLine($"{y} rows were updated");
    //    //Console.WriteLine();

    //    //Author aDelete = aList.Last();
    //    //adb.Delete(aDelete);
    //    //z = adb.SaveChanges();
    //    //Console.WriteLine($"{z} rows were deleted");
    //    //Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Reader:");

    //    ReaderDB rdb = new ReaderDB();
    //    ListReader rList = rdb.SelectAll();
    //    //foreach (Reader r in rList)
    //    //    Console.WriteLine(r);
    //    //Console.WriteLine();

    //    //Reader rInsert = new Reader();
    //    //rInsert.FirstName = "Bob";
    //    //rInsert.LastName = "Smith";
    //    //rInsert.PhoneNumber = "0543216789";
    //    //rInsert.Email = "bobsmithdm@gmail.com";
    //    //rInsert.Username = "bobsmithdm";
    //    //rInsert.Pass = "bobPassdm";
    //    //rInsert.Birthdate = new DateTime(1985, 3, 10);
    //    //rInsert.Picture = "bob_smith.jpg";
    //    //rInsert.Nickname = "BookLoverBob";
    //    //rdb.Insert(rInsert);
    //    //x = rdb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    //Reader rUpdate = rList.Last();
    //    //rUpdate.FirstName = "UPdate";
    //    //rUpdate.LastName = "Smith";
    //    //rUpdate.PhoneNumber = "0543216789";
    //    //rUpdate.Email = "bobsmithdm@gmail.com";
    //    //rUpdate.Username = "bobsmithdm";
    //    //rUpdate.Pass = "bobPassdm";
    //    //rUpdate.Picture = "bob_smith.jpg";
    //    //rUpdate.Nickname = "update";
    //    //rdb.Update(rUpdate);
    //    //y = rdb.SaveChanges();
    //    //Console.WriteLine($"{y} rows were updated");
    //    //Console.WriteLine();

    //    //Reader rDelete = rList.Last();
    //    //rdb.Delete(rDelete);
    //    //z = rdb.SaveChanges();
    //    //Console.WriteLine($"{z} rows were deleted");
    //    //Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    Console.WriteLine("Admin:");

    //    AdminDB addb = new AdminDB();
    //    ListAdmin adList = addb.SelectAll();
    //    //foreach (Admin a in adList)
    //    //    Console.WriteLine(a);
    //    //Console.WriteLine();

    //    //Admin adInsert = new Admin();
    //    //adInsert.FirstName = "Bob";
    //    //adInsert.LastName = "Smith";
    //    //adInsert.PhoneNumber = "0543216789";
    //    //adInsert.Email = "bobsmithdm@gmail.com";
    //    //adInsert.Username = "bobsmithdm";
    //    //adInsert.Pass = "bobPassdm";
    //    //adInsert.Birthdate = new DateTime(1985, 3, 10);
    //    //adInsert.Picture = "bob_smith.jpg";
    //    //addb.Insert(adInsert);
    //    //x = addb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    //Admin adDelete = adList.Last();
    //    //addb.Delete(adDelete);
    //    //z = addb.SaveChanges();
    //    //Console.WriteLine($"{z} rows were deleted");
    //    //Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Book:");

    //    BookDB bdb = new BookDB();
    //    ListBook bList = bdb.SelectAll();
    //    //foreach (Book b in bList)
    //    //    Console.WriteLine(b);
    //    //Console.WriteLine();

    //    //Book bInsert = new Book();
    //    //bInsert.BookName = "The ";
    //    //bInsert.PublicationDate = new DateTime(2019, 2, 5);
    //    //bInsert.Price = 18;
    //    //bInsert.IdAuthor = aList.First();
    //    //bInsert.Information = "A thrilling";
    //    //bInsert.Cover = "silent_patient.jpg";
    //    //bInsert.IdLanguage = lList.First();
    //    //bInsert.BookLink = "link.epub";
    //    //bdb.Insert(bInsert);
    //    //x = bdb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    //Book bUpdate = bList.Last();
    //    //bUpdate.BookName = "Updated";
    //    //bUpdate.PublicationDate = new DateTime(2019, 2, 5);
    //    //bUpdate.Price = 18;
    //    //bUpdate.IdAuthor = aList.First();
    //    //bUpdate.Information = "A thrilling";
    //    //bUpdate.Cover = "silent_patient.jpg";
    //    //bUpdate.IdLanguage = lList.First();
    //    //bdb.Update(bUpdate);
    //    //y = bdb.SaveChanges();
    //    //Console.WriteLine($"{y} rows were updated");
    //    //Console.WriteLine();

    //    //Book bDelete = BookDB.SelectById(155);
    //    //bdb.Delete(bDelete);
    //    //z = bdb.SaveChanges();
    //    //Console.WriteLine($"{z} rows were deleted");
    //    //Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Book_Series:");

    //    Book_SeriesDB bsdb = new();
    //    ListBook_Series bsList = bsdb.SelectAll();
    //    //foreach (Book_Series bs in bsList)
    //    //    Console.WriteLine(bs);
    //    //Console.WriteLine();

    //    //Book_Series bsInsert = new Book_Series();
    //    //bsInsert.NameSeries = "nEWS";
    //    //bsInsert.IdUser = uList.First();
    //    //bsdb.Insert(bsInsert);
    //    //x = bsdb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    //Book_Series bsUpdate = Book_SeriesDB.SelectById(137);
    //    //bsUpdate.NameSeries = "Update";
    //    //bsUpdate.IdUser = uList.First();
    //    //bsdb.Update(bsUpdate);
    //    //y = bsdb.SaveChanges();
    //    //Console.WriteLine($"{y} rows were updated");
    //    //Console.WriteLine();

    //    //Book_Series bsDelete = Book_SeriesDB.SelectById(137);
    //    //bsdb.Delete(bsDelete);
    //    //z = bsdb.SaveChanges();
    //    //Console.WriteLine($"{z} rows were deleted");
    //    //Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Series_Detail:");

    //    Series_DetailDB sddb = new Series_DetailDB();
    //    ListSeries_Detail sdList = sddb.SelectAll();
    //    foreach (Series_Detail sd in sdList)
    //        Console.WriteLine(sd);
    //    Console.WriteLine();

    //    Series_Detail sdInsert = new Series_Detail();
    //    sdInsert.IdSeries = bsList.First();
    //    sdInsert.IdBook = bList.First();
    //    sdInsert.Number = 2;
    //    sddb.Insert(sdInsert);
    //    x = sddb.SaveChanges();
    //    Console.WriteLine($"{x} rows were inserted");
    //    Console.WriteLine();

    //    //Series_Detail sdUpdate = sdList.Last();
    //    //sdUpdate.IdSeries = bsList.Last();
    //    //sdUpdate.IdBook = bList.Last();
    //    //sddb.Update(sdUpdate);
    //    //y = sddb.SaveChanges();
    //    //Console.WriteLine($"{y} rows were updated");
    //    //Console.WriteLine();

    //    //Series_Detail sdDelete = sdList.Last();
    //    //sddb.Delete(sdDelete);
    //    //z = sddb.SaveChanges();
    //    //Console.WriteLine($"{z} rows were deleted");

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Book_Genre:");

    //    //Book_GenreDB bgdb = new Book_GenreDB();
    //    //ListBook_Genre bgList = bgdb.SelectAll();
    //    ////foreach (Book_Genre bg in bgList)
    //    //    Console.WriteLine(bg);
    //    //Console.WriteLine();

    //    //Book_Genre bgInsert = new Book_Genre();
    //    //bgInsert.IdBook = bList.First();
    //    //bgInsert.IdGenre = gList.First();
    //    //bgdb.Insert(bgInsert);
    //    //x = bgdb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    //Book_Genre bgUpdate = bgList.Last();
    //    //bgUpdate.IdGenre = gList.Last();
    //    //bgUpdate.IdBook = bList.Last();
    //    //bgdb.Update(bgUpdate);
    //    //y = bgdb.SaveChanges();
    //    //Console.WriteLine($"{y} rows were updated");
    //    //Console.WriteLine();

    //    ////Book_Genre bgDelete = Book_GenreDB.SelectById(2);
    //    ////bgdb.Delete(bgDelete);
    //    ////z = bgdb.SaveChanges();
    //    ////Console.WriteLine($"{z} rows were deleted");
    //    ////Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Intrest_Reader:");

    //    //Intrest_ReaderDB irdb = new Intrest_ReaderDB();
    //    //ListIntrest_Reader irList = irdb.SelectAll();
    //    //foreach (Intrest_Reader ir in irList)
    //    //    Console.WriteLine(ir);
    //    //Console.WriteLine();

    //    //Intrest_Reader irInsert = new Intrest_Reader();
    //    //irInsert.IdReader = rList.First();
    //    //irInsert.IdIntrest = iList.First();
    //    //irdb.Insert(irInsert);
    //    //x = irdb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    ////Intrest_Reader irUpdate = Intrest_ReaderDB.SelectById(98);
    //    ////irUpdate.IdReader = ReaderDB.SelectById(381);
    //    ////irUpdate.IdIntrest = IntrestDB.SelectById(122);
    //    ////irdb.Update(irUpdate);
    //    ////y = irdb.SaveChanges();
    //    ////Console.WriteLine($"{y} rows were updated");
    //    ////Console.WriteLine();

    //    ////Intrest_Reader irDelete = Intrest_ReaderDB.SelectById(98);
    //    ////irdb.Delete(irDelete);
    //    ////z = irdb.SaveChanges();
    //    ////Console.WriteLine($"{z} rows were deleted");
    //    ////Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Book_List:");

    //    //Book_ListDB bldb = new Book_ListDB();
    //    //ListBook_List blList = bldb.SelectAll();
    //    //foreach (Book_List bl in blList)
    //    //    Console.WriteLine(bl);
    //    //Console.WriteLine();

    //    //Book_List blInsert = new Book_List();
    //    //blInsert.IdReader = rList.First();
    //    //blInsert.ListName = "Summer Reads";
    //    //bldb.Insert(blInsert);
    //    //x = bldb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    ////Book_List blUpdate = Book_ListDB.SelectById(74);
    //    ////blUpdate.IdReader = ReaderDB.SelectById(381);
    //    ////blUpdate.ListName = "Updated";
    //    ////bldb.Update(blUpdate);
    //    ////y = bldb.SaveChanges();
    //    ////Console.WriteLine($"{y} rows were updated");
    //    ////Console.WriteLine();

    //    ////Book_List blDelete = Book_ListDB.SelectById(74);
    //    ////bldb.Delete(blDelete);
    //    ////z = bldb.SaveChanges();
    //    ////Console.WriteLine($"{z} rows were deleted");
    //    ////Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("List_Detail:");

    //    //List_DetailDB lddb = new List_DetailDB();
    //    //ListList_Detail ldList = lddb.SelectAll();
    //    //foreach (List_Detail ld in ldList)
    //    //    Console.WriteLine(ld);
    //    //Console.WriteLine();

    //    //List_Detail ldInsert = new List_Detail();
    //    //ldInsert.IdList = blList.First();
    //    //ldInsert.IdBook = bList.First();
    //    //lddb.Insert(ldInsert);
    //    //x = lddb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    ////List_Detail ldUpdate = List_DetailDB.SelectById(111);
    //    ////ldUpdate.IdList = Book_ListDB.SelectById(74);
    //    ////ldUpdate.IdBook = BookDB.SelectById(120);
    //    ////lddb.Update(ldUpdate);
    //    ////y = lddb.SaveChanges();
    //    ////Console.WriteLine($"{y} rows were updated");
    //    ////Console.WriteLine();

    //    ////List_Detail ldDelete = List_DetailDB.SelectById(111);
    //    ////lddb.Delete(ldDelete);
    //    ////z = lddb.SaveChanges();
    //    ////Console.WriteLine($"{z} rows were deleted");
    //    ////Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Cart:");

    //    //CartDB cdb = new CartDB();
    //    //ListCart cList = cdb.SelectAll();
    //    //foreach (Cart c in cList)
    //    //    Console.WriteLine(c);
    //    //Console.WriteLine();

    //    //Cart cInsert = new Cart();
    //    //cInsert.IdReader = rList.First();
    //    //cInsert.DiscountCode = "jjjjjj";
    //    //cdb.Insert(cInsert);
    //    //x = cdb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    ////Cart cUpdate = CartDB.SelectById(16);
    //    ////cUpdate.IdReader = ReaderDB.SelectById(381);
    //    ////cUpdate.DiscountCode = "update";
    //    ////cdb.Update(cUpdate);
    //    ////y = cdb.SaveChanges();
    //    ////Console.WriteLine($"{y} rows were updated");
    //    ////Console.WriteLine();

    //    ////Cart cDelete = CartDB.SelectById(16);
    //    ////cdb.Delete(cDelete);
    //    ////z = cdb.SaveChanges();
    //    ////Console.WriteLine($"{z} rows were deleted");
    //    ////Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();

    //    //Console.WriteLine("Cart_Detail:");

    //    //Cart_DetailDB cddb = new Cart_DetailDB();
    //    //ListCart_Detail cdList = cddb.SelectAll();
    //    //foreach (Cart_Detail cd in cdList)
    //    //    Console.WriteLine(cd);
    //    //Console.WriteLine();

    //    //Cart_Detail cdInsert = new Cart_Detail();
    //    //cdInsert.IdCart = cList.First();
    //    //cdInsert.IdBook = bList.First();
    //    //cddb.Insert(cdInsert);
    //    //x = cddb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    ////Cart_Detail cdUpdate = Cart_DetailDB.SelectById(17);
    //    ////cdUpdate.IdCart = CartDB.SelectById(16);
    //    ////cdUpdate.IdBook = BookDB.SelectById(120);
    //    ////cddb.Update(cdUpdate);
    //    ////y = cddb.SaveChanges();
    //    ////Console.WriteLine($"{y} rows were updated");
    //    ////Console.WriteLine();

    //    ////Cart_Detail cdDelete = Cart_DetailDB.SelectById(17);
    //    ////cddb.Delete(cdDelete);
    //    ////z = cddb.SaveChanges();
    //    ////Console.WriteLine($"{z} rows were deleted");
    //    ////Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("News");

    //    //NewsDB ndb = new NewsDB();
    //    //ListNews nList = ndb.SelectAll();
    //    //foreach (News n in nList)
    //    //    Console.WriteLine(n);
    //    //Console.WriteLine();

    //    //News nInsert = new News();
    //    //nInsert.IdUser = uList.First();
    //    //nInsert.Content = "New Book Release!";
    //    //nInsert.PublishDate = new DateTime(2026, 4, 24);
    //    //nInsert.Titel = "Exciting News";
    //    //ndb.Insert(nInsert);
    //    //x = ndb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    ////News nUpdate = NewsDB.SelectById(3);
    //    ////nUpdate.IdUser = UserDB.SelectById(379);
    //    ////nUpdate.Content = "Update!";
    //    ////nUpdate.PublishDate = new DateTime(2026, 4, 25);
    //    ////nUpdate.Titel = "Updated News";
    //    ////ndb.Update(nUpdate);
    //    ////y = ndb.SaveChanges();
    //    ////Console.WriteLine($"{y} rows were updated");
    //    ////Console.WriteLine();

    //    ////News nDelete = NewsDB.SelectById(4);
    //    ////ndb.Delete(nDelete);
    //    ////z = ndb.SaveChanges();
    //    ////Console.WriteLine($"{z} rows were deleted");
    //    ////Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Reviews");

    //    //ReviewsDB redb = new ReviewsDB();
    //    //ListReviews reList = redb.SelectAll();
    //    //foreach (Reviews r in reList)
    //    //    Console.WriteLine(r);
    //    //Console.WriteLine();

    //    //Reviews reInsert = new Reviews();
    //    //reInsert.IdReader = rList.First();
    //    //reInsert.Text = "Great book!";
    //    //reInsert.Stars = 5;
    //    //reInsert.IdBook = bList.First();
    //    //redb.Insert(reInsert);
    //    //x = redb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    ////Reviews reUpdate = ReviewsDB.SelectById(4);
    //    ////reUpdate.IdReader = rList.First();
    //    ////reUpdate.Text = "Update";
    //    ////reUpdate.Stars = 4;
    //    ////reUpdate.IdBook = bList.First();
    //    ////redb.Update(reUpdate);
    //    ////y = redb.SaveChanges();
    //    ////Console.WriteLine($"{y} rows were updated");
    //    ////Console.WriteLine();

    //    ////Reviews reDelete = ReviewsDB.SelectById(4);
    //    ////redb.Delete(reDelete);
    //    ////z = redb.SaveChanges();
    //    ////Console.WriteLine($"{z} rows were deleted");
    //    ////Console.WriteLine();

    //    //Console.WriteLine();
    //    //Console.WriteLine();


    //    //Console.WriteLine("Following");

    //    //FollowingDB fdb = new FollowingDB();
    //    //ListFollowing fList = fdb.SelectAll();
    //    //foreach (Following f in fList)
    //    //    Console.WriteLine(f);
    //    //Console.WriteLine();

    //    //Following fInsert = new Following();
    //    //fInsert.IdReader = rList.First();
    //    //fInsert.IdAuthor = aList.First();
    //    //fdb.Insert(fInsert);
    //    //x = fdb.SaveChanges();
    //    //Console.WriteLine($"{x} rows were inserted");
    //    //Console.WriteLine();

    //    ////Following fUpdate = FollowingDB.SelectById(36);
    //    ////fUpdate.IdReader = ReaderDB.SelectById(380);
    //    ////fUpdate.IdAuthor = AuthorDB.SelectById(378);
    //    ////fdb.Update(fUpdate);
    //    ////y = fdb.SaveChanges();
    //    ////Console.WriteLine($"{y} rows were updated");
    //    ////Console.WriteLine();

    //    ////Following fDelete = FollowingDB.SelectById(36);
    //    ////fdb.Delete(fDelete);
    //    ////z = fdb.SaveChanges();
    //    ////Console.WriteLine($"{z} rows were deleted");
    //    ////Console.WriteLine();
    //}



    public static async Task Main(string[] args)
    {
        Apiservice buyerService = new Apiservice();
        int id;

        ////Console.WriteLine("Genre:");

        ////var genre = await buyerService.GetAllGenres();
        ////Console.WriteLine(genre.Count);

        //////Genre insertG = new Genre
        //////{
        //////    Name = "new G"
        //////};
        //////await buyerService.InsertGenre(insertG);
        //////genre = await buyerService.GetAllGenres();
        //////Console.WriteLine(genre.Count);

        //////Genre updateG = genre.Last();
        //////updateG.Name = "updated G";
        //////await buyerService.UpdateGenre(updateG);
        //////genre = await buyerService.GetAllGenres();
        //////Console.WriteLine(genre.Last());

        //////id = genre.Last().Id;
        //////await buyerService.DeleteGenre(id);
        //////genre = await buyerService.GetAllGenres();
        //////Console.WriteLine(genre.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Language:");

        ////var language = await buyerService.GetAllLanguages();
        ////Console.WriteLine(language.Count);

        //////Language insertl = new Language
        //////{
        //////    Name = "new l"
        //////};
        //////await buyerService.InsertLanguage(insertl);
        //////language = await buyerService.GetAllLanguages();
        //////Console.WriteLine(language.Count);

        //////Language updateL = language.Last();
        //////updateL.Name = "updated L";
        //////await buyerService.UpdateLanguage(updateL);
        //////language = await buyerService.GetAllLanguages();
        //////Console.WriteLine(language.Last());

        //////id = language.Last().Id;
        //////await buyerService.DeleteLanguage(id);
        //////language = await buyerService.GetAllLanguages();
        //////Console.WriteLine(language.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Discount Codes:");

        ////var discountCode = await buyerService.GetAllDiscountCodes();
        ////Console.WriteLine(discountCode.Count);

        //////DiscountCode insertD = new DiscountCode
        //////{
        //////    Name = "new D"

        //////};
        //////await buyerService.InsertIntrest(insertI);
        //////intrest = await buyerService.GetAllIntrests();
        //////Console.WriteLine(intrest.Count);

        //////Intrest updateI = intrest.Last();
        //////updateI.Name = "updated I";
        //////await buyerService.UpdateIntrest(updateI);
        //////intrest = await buyerService.GetAllIntrests();
        //////Console.WriteLine(intrest.Last());

        //////id = intrest.Last().Id;
        //////await buyerService.DeleteIntrest(id);
        //////intrest = await buyerService.GetAllIntrests();
        //////Console.WriteLine(intrest.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("User:");

        ////var user = await buyerService.GetAllUsers();
        ////Console.WriteLine(user.Count);

        ////////User insertU = new User
        ////////{
        ////////    FirstName = "Alice",
        ////////    LastName = "Johnson",
        ////////    PhoneNumber = "0567284932",
        ////////    Email = "aliceJhon22@gmail.com",
        ////////    Username = "aliceJhon22",
        ////////    Pass = "alicePass22",
        ////////    Birthdate = new DateTime(1992, 7, 15),
        ////////    Picture = "alice.jpg"
        ////////};
        ////////await buyerService.InsertUser(insertU);
        ////////user = await buyerService.GetAllUsers();
        ////////Console.WriteLine(user.Count);

        //////User updateU = user.Last();
        //////updateU.FirstName = "updated Alice";
        //////updateU.LastName = "Johnson";
        //////updateU.PhoneNumber = "0567284932";
        //////updateU.Email = "aliceJhon22@gmail.com";
        //////updateU.Username = "aliceJhon22";
        //////updateU.Pass = "alicePass22";
        //////updateU.Birthdate = new DateTime(1992, 7, 15);
        //////updateU.Picture = "alice.jpg";
        //////await buyerService.UpdateUser(updateU);
        //////user = await buyerService.GetAllUsers();
        //////Console.WriteLine(user.Last());

        //////id = user.Last().Id;
        //////await buyerService.DeleteAUser(id);
        //////user = await buyerService.GetAllUsers();
        //////Console.WriteLine(user.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Author:");

        ////var author = await buyerService.GetAllAuthors();
        ////Console.WriteLine(author.Count);

        ////////Author insertA = new Author
        ////////{
        ////////    FirstName = "Alice",
        ////////    LastName = "Johnson",
        ////////    PhoneNumber = "0567284932",
        ////////    Email = "aliceJhon22@gmail.com",
        ////////    Username = "aliceJhon22",
        ////////    Pass = "alicePass22",
        ////////    Birthdate = new DateTime(1992, 7, 15),
        ////////    Picture = "alice.jpg",
        ////////    PenName = "Mark Twain",
        ////////    Genre = genre.Last(),
        ////////    InformationAboutAuthor = "Famous American author"
        ////////};
        ////////await buyerService.InsertAuthor(insertA);
        ////////author = await buyerService.GetAllAuthors();
        ////////Console.WriteLine(author.Count);

        //////Author updateA = author.Last();
        //////updateA.FirstName = "updated Alice";
        //////updateA.LastName = "Johnson";
        //////updateA.PhoneNumber = "0567284932";
        //////updateA.Email = "aliceJhon22@gmail.com";
        //////updateA.Username = "aliceJhon22";
        //////updateA.Pass = "alicePass22";
        //////updateA.Birthdate = new DateTime(1992, 7, 15);
        //////updateA.Picture = "alice.jpg";
        //////updateA.PenName = "update";
        //////updateA.Genre = genre.First();
        //////updateA.InformationAboutAuthor = "Famous American author";
        //////await buyerService.UpdateAuthor(updateA);
        //////author = await buyerService.GetAllAuthors();
        //////Console.WriteLine(author.Last());

        //////id = author.Last().Id;
        //////await buyerService.DeleteAnAuthor(id);
        //////author = await buyerService.GetAllAuthors();
        //////Console.WriteLine(author.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Reader:");

        ////var reader = await buyerService.GetAllReaders();
        ////Console.WriteLine(reader.Count);

        ////////Reader insertR = new Reader
        ////////{
        ////////    FirstName = "Bob",
        ////////    LastName = "Smith",
        ////////    PhoneNumber = "0543216789",
        ////////    Email = "bobsmithdm@gmail.com",
        ////////    Username = "bobsmithdm",
        ////////    Pass = "bobPassdm",
        ////////    Birthdate = new DateTime(1985, 3, 10),
        ////////    Picture = "bob_smith.jpg",
        ////////    Nickname = "BookLoverBob",
        ////////    PremiumSubscription = true
        ////////};
        ////////await buyerService.InsertReader(insertR);
        ////////reader = await buyerService.GetAllReaders();
        ////////Console.WriteLine(reader.Count);

        //////Reader updateR = reader.Last();
        //////updateR.FirstName = "UPdate";
        //////updateR.LastName = "Smith";
        //////updateR.PhoneNumber = "0543216789";
        //////updateR.Email = "bobsmithdm@gmail.com";
        //////updateR.Username = "bobsmithdm";
        //////updateR.Pass = "bobPassdm";
        //////updateR.Birthdate = new DateTime(1985, 3, 10);
        //////updateR.Picture = "bob_smith.jpg";
        //////updateR.Nickname = "update";
        //////await buyerService.UpdateReader(updateR);
        //////reader = await buyerService.GetAllReaders();
        //////Console.WriteLine(reader.Last());

        //////id = reader.Last().Id;
        //////await buyerService.DeleteAReader(id);
        //////reader = await buyerService.GetAllReaders();
        //////Console.WriteLine(reader.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Admin:");

        ////var admin = await buyerService.GetAllAdmins();
        ////Console.WriteLine(admin.Count);

        ////////Admin insertAd = new Admin
        ////////{
        ////////    FirstName = "Bob",
        ////////    LastName = "Smith",
        ////////    PhoneNumber = "0543216789",
        ////////    Email = "bobsmithdm@gmail.com",
        ////////    Username = "bobsmithdm",
        ////////    Pass = "bobPassdm",
        ////////    Birthdate = new DateTime(1985, 3, 10),
        ////////    Picture = "bob_smith.jpg"
        ////////};
        ////////await buyerService.InsertAdmin(insertAd);
        ////////admin = await buyerService.GetAllAdmins();
        ////////Console.WriteLine(admin.Count);

        ////////id = admin.Last().Id;
        ////////await buyerService.DeleteAdmin(id);
        ////////admin = await buyerService.GetAllAdmins();
        ////////Console.WriteLine(admin.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Book:");

        ////var book = await buyerService.GetAllBooks();
        ////Console.WriteLine(book.Count);

        ////////Book insertB = new Book
        ////////{
        ////////    BookName = "The ",
        ////////    PublicationDate = new DateTime(2019, 2, 5),
        ////////    Price = 18,
        ////////    IdAuthor = author.First(),
        ////////    Discount = false,
        ////////    Information = "A thrilling",
        ////////    Cover = "silent_patient.jpg",
        ////////    IdLanguage = language.First(),
        ////////    BookLink = "link.epub"
        ////////};
        ////////await buyerService.InsertBook(insertB);
        ////////book = await buyerService.GetAllBooks();
        ////////Console.WriteLine(book.Count);

        //////Book bUpdate = book.Last();
        //////bUpdate.BookName = "The Silent Patient - Updated";
        //////bUpdate.PublicationDate = new DateTime(2019, 2, 5);
        //////bUpdate.Price = 18;
        //////bUpdate.IdAuthor = author.First();
        //////bUpdate.Information = "A thrilling";
        //////bUpdate.Cover = "silent_patient.jpg";
        //////bUpdate.IdLanguage = language.First();
        //////await buyerService.UpdateBook(bUpdate);
        //////book = await buyerService.GetAllBooks();
        //////Console.WriteLine(book.Last());

        //////id = book.Last().Id;
        //////await buyerService.DeleteABook(id);
        //////book = await buyerService.GetAllBooks();
        //////Console.WriteLine(book.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Book_Series:");

        //var bookSeries = await buyerService.GetAllBookSeries();
        //Console.WriteLine(bookSeries.Count);

        ////////Book_Series insertBS = new Book_Series
        ////////{
        ////////    NameSeries = "Boys Of Tommen Series",
        ////////    IdAuthor = author.First()
        ////////};
        ////////await buyerService.InsertBookSeries(insertBS);
        ////////bookSeries = await buyerService.GetAllBookSeries();
        ////////Console.WriteLine(bookSeries.Count);

        ////////Book_Series bsUpdate = bookSeries.Last();
        ////////bsUpdate.NameSeries = "Boys Of Tommen Series - Updated";
        ////////bsUpdate.IdAuthor = author.First();
        ////////await buyerService.UpdateBookSeries(bsUpdate);
        ////////bookSeries = await buyerService.GetAllBookSeries();
        ////////Console.WriteLine(bookSeries.Last());

        //////id = bookSeries.Last().Id;
        //////await buyerService.DeleteBookSeries(id);
        //////bookSeries = await buyerService.GetAllBookSeries();
        //////Console.WriteLine(bookSeries.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Series_Detail:");

        ////var seriesDetail = await buyerService.GetAllSeriesDetails();
        ////Console.WriteLine(seriesDetail.Count);

        //////Series_Detail insertSD = new Series_Detail
        //////{
        //////    IdSeries = bookSeries.First(),
        //////    IdBook = book.First(),
        //////    Number = 10
        //////};
        //////await buyerService.InsertSeriesDetail(insertSD);
        //////seriesDetail = await buyerService.GetAllSeriesDetails();
        //////Console.WriteLine(seriesDetail.Count);

        //////Series_Detail sdUpdate = seriesDetail.Last();
        //////sdUpdate.IdSeries = bookSeries.First();
        //////sdUpdate.IdBook = book.Last();
        //////await buyerService.UpdateASeriesDetail(sdUpdate);
        //////seriesDetail = await buyerService.GetAllSeriesDetails();
        //////Console.WriteLine(seriesDetail.Last());

        //////id = seriesDetail.Last().Id;
        //////await buyerService.DeleteASeriesDetail(id);
        //////seriesDetail = await buyerService.GetAllSeriesDetails();
        //////Console.WriteLine(seriesDetail.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Book_Genre:");

        var bookGenre = await buyerService.GetAllBookGenres();
        Console.WriteLine(bookGenre.Count);

        //////Book_Genre insertBG = new Book_Genre
        //////{
        //////    IdBook = book.First(),
        //////    IdGenre = genre.First()
        //////};
        //////await buyerService.InsertBookGenre(insertBG);
        //////bookGenre = await buyerService.GetAllBookGenres();
        //////Console.WriteLine(bookGenre.Count);

        //////Book_Genre bgUpdate = bookGenre.Last();
        //////bgUpdate.IdBook = book.First();
        //////bgUpdate.IdGenre = genre.Last();
        //////await buyerService.UpdateABookGenre(bgUpdate);
        //////bookGenre = await buyerService.GetAllBookGenres();
        //////Console.WriteLine(bookGenre.Last());

        //////id = bookGenre.Last().Id;
        //////await buyerService.DeleteABookGenre(id);
        //////bookGenre = await buyerService.GetAllBookGenres();
        //////Console.WriteLine(bookGenre.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Genre_Reader:");

        ////var genreReader = await buyerService.GetAllGenreReaders();
        ////Console.WriteLine(genreReader.Count);

        //////Intrest_Reader insertIR = new Intrest_Reader
        //////{
        //////    IdReader = reader.First(),
        //////    IdIntrest = intrest.First()
        //////};
        //////await buyerService.InsertIntrestReader(insertIR);
        //////intrestReader = await buyerService.GetAllIntrestReaders();
        //////Console.WriteLine(intrestReader.Count);

        //////Intrest_Reader irUpdate = intrestReader.Last();
        //////irUpdate.IdReader = reader.First();
        //////irUpdate.IdGenre = genre.Last();
        //////await buyerService.UpdateAnIntrestReader(irUpdate);
        //////intrestReader = await buyerService.GetAllIntrestReaders();
        //////Console.WriteLine(intrestReader.Last());

        //////id = intrestReader.Last().Id;
        //////await buyerService.DeleteAnIntrestReader(id);
        //////intrestReader = await buyerService.GetAllIntrestReaders();
        //////Console.WriteLine(intrestReader.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Cart:");

        ////var cart = await buyerService.GetAllCarts();
        ////Console.WriteLine(cart.Count);

        //////Cart insertCart = new Cart
        //////{
        //////    IdReader = reader.First(),
        //////    DiscountCode = "DISCOUNT10"
        //////};
        //////await buyerService.InsertCart(insertCart);
        //////cart = await buyerService.GetAllCarts();
        //////Console.WriteLine(cart.Count);

        //////Cart cUpdate = cart.Last();
        //////cUpdate.IdReader = reader.First();
        //////cUpdate.DiscountCode = "update";
        //////await buyerService.UpdateACart(cUpdate);
        //////cart = await buyerService.GetAllCarts();
        //////Console.WriteLine(cart.Last());

        //////id = cart.Last().Id;
        //////await buyerService.DeleteACart(id);
        //////cart = await buyerService.GetAllCarts();
        //////Console.WriteLine(cart.Count);

        //////Console.WriteLine();
        //////Console.WriteLine();


        ////Console.WriteLine("Cart_Detail:");

        ////var cartDetail = await buyerService.GetAllCartDetails();
        ////Console.WriteLine(cartDetail.Count);

        //////Cart_Detail insertCartDetail = new Cart_Detail
        //////{
        //////    IdCart = cart.First(),
        //////    IdBook = book.First()
        //////};
        //////    await buyerService.InsertCartDetail(insertCartDetail);
        //////    cartDetail = await buyerService.GetAllCartDetails();
        //////    Console.WriteLine(cartDetail.Count);

        //////    //Cart_Detail cdUpdate = cartDetail.Last();
        //////    //cdUpdate.IdCart = cart.First();
        //////    //cdUpdate.IdBook = book.First();
        //////    //await buyerService.UpdateACartDetail(cdUpdate);
        //////    //cartDetail = await buyerService.GetAllCartDetails();
        //////    //Console.WriteLine(cartDetail.Last());

        //////    //id = cartDetail.Last().Id;
        //////    //await buyerService.DeleteACartDetail(id);
        //////    //cartDetail = await buyerService.GetAllCartDetails();
        //////    //Console.WriteLine(cartDetail.Count);

        //////    Console.WriteLine();
        //////    Console.WriteLine();


        ////Console.WriteLine("News");

        ////var news = await buyerService.GetAllNews();
        ////Console.WriteLine(news.Count);

        //////    News insertNews = new News
        //////    {
        //////        IdUser = user.First(),
        //////        Text = "new",
        //////        Time = new DateTime(2026, 4, 24)
        //////    };
        //////    await buyerService.InsertNews(insertNews);
        //////    news = await buyerService.GetAllNews();
        //////    Console.WriteLine(news.Count);

        //////    //News nUpdate = news.Last();
        //////    //nUpdate.IdUser = user.First();
        //////    //nUpdate.Text = "update";
        //////    //nUpdate.Time = new DateTime(2026, 4, 25);
        //////    //await buyerService.UpdateANews(nUpdate);
        //////    //news = await buyerService.GetAllNews();
        //////    //Console.WriteLine(news.Last());

        //////    //id = news.Last().Id;
        //////    //await buyerService.DeleteANews(id);
        //////    //news = await buyerService.GetAllNews();
        //////    //Console.WriteLine(news.Count);

        //////    Console.WriteLine();
        //////    Console.WriteLine();


        ////Console.WriteLine("Reviews");

        ////var reviews = await buyerService.GetAllReviews();
        ////Console.WriteLine(reviews.Count);

        //////    Reviews insertRe = new Reviews
        //////    {
        //////        IdReader = reader.First(),
        //////        Text = "Great book!",
        //////        Stars = 5,
        //////        IdBook = book.First()
        //////    };
        //////    await buyerService.InsertReview(insertRe);
        //////    reviews = await buyerService.GetAllReviews();
        //////    Console.WriteLine(reviews.Count);

        //////    //Reviews rUpdate = reviews.Last();
        //////    //rUpdate.IdReader = reader.First();
        //////    //rUpdate.Text = "update";
        //////    //rUpdate.Stars = 4;
        //////    //rUpdate.IdBook = book.First();
        //////    //await buyerService.UpdateAReview(rUpdate);
        //////    //reviews = await buyerService.GetAllReviews();
        //////    //Console.WriteLine(reviews.Last());

        //////    //id = reviews.Last().Id;
        //////    //await buyerService.DeleteAReview(id);
        //////    //reviews = await buyerService.GetAllReviews();
        //////    //Console.WriteLine(reviews.Count);

        //////    Console.WriteLine();
        //////    Console.WriteLine();


        ////Console.WriteLine("Following");

        ////var followings = await buyerService.GetAllFollowings();
        ////Console.WriteLine(followings.Count);

        //////    Following insertFollowing = new Following
        //////    {
        //////        IdReader = reader.First(),
        //////        IdAuthor = author.First()
        //////    };
        //////    await buyerService.InsertFollowing(insertFollowing);
        //////    followings = await buyerService.GetAllFollowings();
        //////    Console.WriteLine(followings.Count);

        //////    //Following fUpdate = followings.Last();
        //////    //fUpdate.IdReader = reader.First();
        //////    //fUpdate.IdAuthor = author.First();
        //////    //await buyerService.UpdateAFollowing(fUpdate);
        //////    //followings = await buyerService.GetAllFollowings();
        //////    //Console.WriteLine(followings.Last());

        //////    //id = followings.Last().Id;
        //////    //await buyerService.DeleteAFollowing(id);
        //////    //followings = await buyerService.GetAllFollowings();
        //////    //Console.WriteLine(followings.Count);

        //////    Console.WriteLine("end");
        //////    Console.ReadLine();
    }
}
