using Model;
using System.Diagnostics;
using ViewModel;


public class Program
{
    public static void Main(string[] args)
    {
        int x;
        int y;
        int z;

        Console.WriteLine("Genre:");

        GenreDB gdb = new GenreDB();
        ListGenre gList = gdb.SelectAll();
        //foreach (Genre g in gList)
        //    Console.WriteLine(g);
        //Console.WriteLine();

        //Genre gInsert = new Genre();
        //gInsert.Name = "Adventure";
        //gdb.Insert(gInsert);
        //x = gdb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Genre gUpdate = GenreDB.SelectById(149);
        //gUpdate.Name = "update";
        //gdb.Update(gUpdate);
        //y = gdb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Genre gDelete = GenreDB.SelectById(149);
        //gdb.Delete(gDelete);
        //z = gdb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Language:");

        LanguageDB ldb = new LanguageDB();
        ListLanguage lList = ldb.SelectAll();
        //foreach (Language l in lList)
        //    Console.WriteLine(l);
        //Console.WriteLine();

        //Language lInsert = new Language();
        //lInsert.Name = "German";
        //ldb.Insert(lInsert);
        //x = ldb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Language lUpdate = LanguageDB.SelectById(135);
        //lUpdate.Name = "update";
        //ldb.Update(lUpdate);
        //y = ldb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Language lDelete = LanguageDB.SelectById(135);
        //ldb.Delete(lDelete);
        //z = ldb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Intrest:");

        IntrestDB idb = new IntrestDB();
        ListIntrest iList = idb.SelectAll();
        //foreach (Intrest i in iList)
        //    Console.WriteLine(i);
        //Console.WriteLine();

        //Intrest iInsert = new Intrest();
        //iInsert.Name = "Mystery";
        //idb.Insert(iInsert);
        //x = idb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Intrest iUpdate = IntrestDB.SelectById(149);
        //iUpdate.Name = "update";
        //idb.Update(iUpdate);
        //y = idb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Intrest iDelete = IntrestDB.SelectById(149);
        //idb.Delete(iDelete);
        //z = idb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("User:");

        UserDB udb = new UserDB();
        ListUser uList = udb.SelectAll();
        //foreach (User u in uList)
        //    Console.WriteLine(u);
        //Console.WriteLine();

        //User uInsert = new User();
        //uInsert.FirstName = "Alice";
        //uInsert.LastName = "Johnson";
        //uInsert.PhoneNumber = "0567284932";
        //uInsert.Email = "aliceJhon22@gmail.com";
        //uInsert.Username = "aliceJhon22";
        //uInsert.Pass = "alicePass22";
        //uInsert.Birthdate = new DateTime(1992, 7, 15);
        //uInsert.Picture = "alice.jpg";
        //udb.Insert(uInsert);
        //x = udb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //User uUpdate = UserDB.SelectById(396);
        //uUpdate.FirstName = "Update";
        //uUpdate.LastName = "Johnson";
        //uUpdate.PhoneNumber = "0567284932";
        //uUpdate.Email = "aliceJhon22@gmail.com";
        //uUpdate.Username = "aliceJhon22";
        //uUpdate.Pass = "alicePass22";
        //uUpdate.Birthdate = new DateTime(1992, 7, 15);
        //uUpdate.Picture = "alice.jpg";
        //udb.Update(uUpdate);
        //y = udb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //User uDelete = UserDB.SelectById(396);
        //udb.Delete(uDelete);
        //z = udb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Author:");

        AuthorDB adb = new AuthorDB();
        ListAuthor aList = adb.SelectAll();
        //foreach (Author a in aList)
        //    Console.WriteLine(a);
        //Console.WriteLine();

        //Author aInsert = new Author();
        //aInsert.FirstName = "Mark";
        //aInsert.LastName = "Twain";
        //aInsert.PhoneNumber = "0523456789";
        //aInsert.Email = "markTwin1@gmail.com";
        //aInsert.Username = "markTwin1";
        //aInsert.Pass = "markPass1";
        //aInsert.Birthdate = new DateTime(1835, 11, 30);
        //aInsert.Picture = "mark_twain.jpg";
        //aInsert.PenName = "Mark Twain";
        //aInsert.Genre = GenreDB.SelectById(122);
        //aInsert.InformationAboutAuthor = "Famous American author";
        //adb.Insert(aInsert);
        //x = adb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Author aUpdate = AuthorDB.SelectById(394);
        //aUpdate.FirstName = "Update";
        //aUpdate.LastName = "Twain";
        //aUpdate.PhoneNumber = "0523456789";
        //aUpdate.Email = "markTwin1@gmail.com";
        //aUpdate.Username = "markTwin1";
        //aUpdate.Pass = "markPass1";
        //aUpdate.Birthdate = new DateTime(1835, 11, 30);
        //aUpdate.Picture = "mark_twain.jpg";
        //aUpdate.PenName = "update";
        //aUpdate.Genre = gList.First();
        //aUpdate.InformationAboutAuthor = "Famous American author";
        //adb.Update(aUpdate);
        //y = adb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Author aDelete = AuthorDB.SelectById(394);
        //adb.Delete(aDelete);
        //z = adb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Reader:");

        ReaderDB rdb = new ReaderDB();
        ListReader rList = rdb.SelectAll();
        //foreach (Reader r in rList)
        //    Console.WriteLine(r);
        //Console.WriteLine();

        //Reader rInsert = new Reader();
        //rInsert.FirstName = "Bob";
        //rInsert.LastName = "Smith";
        //rInsert.PhoneNumber = "0543216789";
        //rInsert.Email = "bobsmithdm@gmail.com";
        //rInsert.Username = "bobsmithdm";
        //rInsert.Pass = "bobPassdm";
        //rInsert.Birthdate = new DateTime(1985, 3, 10);
        //rInsert.Picture = "bob_smith.jpg";
        //rInsert.Nickname = "BookLoverBob";
        //rInsert.PremiumSubscription = true;
        //rdb.Insert(rInsert);
        //x = rdb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Reader rUpdate = ReaderDB.SelectById(395);
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
        //rdb.Update(rUpdate);
        //y = rdb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Reader rDelete = ReaderDB.SelectById(395);
        //rdb.Delete(rDelete);
        //z = rdb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Admin:");

        AdminDB addb = new AdminDB();
        ListAdmin adList = addb.SelectAll();
        //foreach (Admin a in adList)
        //    Console.WriteLine(a);
        //Console.WriteLine();

        //Admin adInsert = new Admin();
        //adInsert.FirstName = "Bob";
        //adInsert.LastName = "Smith";
        //adInsert.PhoneNumber = "0543216789";
        //adInsert.Email = "bobsmithdm@gmail.com";
        //adInsert.Username = "bobsmithdm";
        //adInsert.Pass = "bobPassdm";
        //adInsert.Birthdate = new DateTime(1985, 3, 10);
        //adInsert.Picture = "bob_smith.jpg";
        //addb.Insert(adInsert);
        //x = addb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Admin adDelete = AdminDB.SelectById(392);
        //addb.Delete(adDelete);
        //z = addb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Book:");

        BookDB bdb = new BookDB();
        ListBook bList = bdb.SelectAll();
        //foreach (Book b in bList)
        //    Console.WriteLine(b);
        //Console.WriteLine();

        //Book bInsert = new Book();
        //bInsert.BookName = "The ";
        //bInsert.PublicationDate = new DateTime(2019, 2, 5);
        //bInsert.Price = 18;
        //bInsert.IdAuthor = AuthorDB.SelectById(388);
        //bInsert.Discount = false;
        //bInsert.Information = "A thrilling";
        //bInsert.Cover = "silent_patient.jpg";
        //bInsert.IdLanguage = LanguageDB.SelectById(122);
        //bInsert.BookLink = "link.epub";
        //bdb.Insert(bInsert);
        //x = bdb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Book bUpdate = BookDB.SelectById(151);
        //bUpdate.BookName = "The Silent Patient - Updated";
        //bUpdate.PublicationDate = new DateTime(2019, 2, 5);
        //bUpdate.Price = 18;
        //bUpdate.IdAuthor = aList.First();
        //bUpdate.Discount = false;
        //bUpdate.Information = "A thrilling";
        //bUpdate.Cover = "silent_patient.jpg";
        //bUpdate.IdLanguage = lList.First();
        //bdb.Update(bUpdate);
        //y = bdb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Book bDelete = BookDB.SelectById(151);
        //bdb.Delete(bDelete);
        //z = bdb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Book_Series:");

        Book_SeriesDB bsdb = new();
        ListBook_Series bsList = bsdb.SelectAll();
        //foreach (Book_Series bs in bsList)
        //    Console.WriteLine(bs);
        //Console.WriteLine();

        //Book_Series bsInsert = new Book_Series();
        //bsInsert.NameSeries = "Boys Of Tommen Series";
        //bsInsert.IdAuthor = AuthorDB.SelectById(388);
        //bsdb.Insert(bsInsert);
        //x = bsdb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Book_Series bsUpdate = Book_SeriesDB.SelectById(131);
        //bsUpdate.NameSeries = "Update";
        //bsUpdate.IdAuthor = AuthorDB.SelectById(388);
        //bsdb.Update(bsUpdate);
        //y = bsdb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Book_Series bsDelete = Book_SeriesDB.SelectById(131);
        //bsdb.Delete(bsDelete);
        //z = bsdb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Series_Detail:");

        Series_DetailDB sddb = new Series_DetailDB();
        ListSeries_Detail sdList = sddb.SelectAll();
        //foreach (Series_Detail sd in sdList)
        //    Console.WriteLine(sd);
        //Console.WriteLine();

        //Series_Detail sdInsert = new Series_Detail();
        //sdInsert.IdSeries = Book_SeriesDB.SelectById(124);
        //sdInsert.IdBook = BookDB.SelectById(119);
        //sddb.Insert(sdInsert);
        //x = sddb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Series_Detail sdUpdate = Series_DetailDB.SelectById(99);
        //sdUpdate.IdSeries = Book_SeriesDB.SelectById(131);
        //sdUpdate.IdBook = BookDB.SelectById(120);
        //sddb.Update(sdUpdate);
        //y = sddb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Series_Detail sdDelete = Series_DetailDB.SelectById(98);
        //sddb.Delete(sdDelete);
        //z = sddb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Book_Genre:");

        Book_GenreDB bgdb = new Book_GenreDB();
        ListBook_Genre bgList = bgdb.SelectAll();
        //foreach (Book_Genre bg in bgList)
        //    Console.WriteLine(bg);
        //Console.WriteLine();

        //Book_Genre bgInsert = new Book_Genre();
        //bgInsert.IdBook = BookDB.SelectById(119);
        //bgInsert.IdGenre = GenreDB.SelectById(122);
        //bgdb.Insert(bgInsert);
        //x = bgdb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Book_Genre bgUpdate = Book_GenreDB.SelectById(2);
        //bgUpdate.IdGenre = GenreDB.SelectById(122);
        //bgUpdate.IdBook = BookDB.SelectById(120);
        //bgdb.Update(bgUpdate);
        //y = bgdb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Book_Genre bgDelete = Book_GenreDB.SelectById(2);
        //bgdb.Delete(bgDelete);
        //z = bgdb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Intrest_Reader:");

        Intrest_ReaderDB irdb = new Intrest_ReaderDB();
        ListIntrest_Reader irList = irdb.SelectAll();
        //foreach (Intrest_Reader ir in irList)
        //    Console.WriteLine(ir);
        //Console.WriteLine();

        //Intrest_Reader irInsert = new Intrest_Reader();
        //irInsert.IdReader = ReaderDB.SelectById(380);
        //irInsert.IdIntrest = IntrestDB.SelectById(122);
        //irdb.Insert(irInsert);
        //x = irdb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Intrest_Reader irUpdate = Intrest_ReaderDB.SelectById(98);
        //irUpdate.IdReader = ReaderDB.SelectById(381);
        //irUpdate.IdIntrest = IntrestDB.SelectById(122);
        //irdb.Update(irUpdate);
        //y = irdb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Intrest_Reader irDelete = Intrest_ReaderDB.SelectById(98);
        //irdb.Delete(irDelete);
        //z = irdb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Book_List:");

        Book_ListDB bldb = new Book_ListDB();
        ListBook_List blList = bldb.SelectAll();
        //foreach (Book_List bl in blList)
        //    Console.WriteLine(bl);
        //Console.WriteLine();

        //Book_List blInsert = new Book_List();
        //blInsert.IdReader = ReaderDB.SelectById(380);
        //blInsert.ListName = "Summer Reads";
        //bldb.Insert(blInsert);
        //x = bldb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Book_List blUpdate = Book_ListDB.SelectById(74);
        //blUpdate.IdReader = ReaderDB.SelectById(381);
        //blUpdate.ListName = "Updated";
        //bldb.Update(blUpdate);
        //y = bldb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Book_List blDelete = Book_ListDB.SelectById(74);
        //bldb.Delete(blDelete);
        //z = bldb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("List_Detail:");

        List_DetailDB lddb = new List_DetailDB();
        ListList_Detail ldList = lddb.SelectAll();
        //foreach (List_Detail ld in ldList)
        //    Console.WriteLine(ld);
        //Console.WriteLine();

        //List_Detail ldInsert = new List_Detail();
        //ldInsert.IdList = Book_ListDB.SelectById(73);
        //ldInsert.IdBook = BookDB.SelectById(119);
        //lddb.Insert(ldInsert);
        //x = lddb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //List_Detail ldUpdate = List_DetailDB.SelectById(111);
        //ldUpdate.IdList = Book_ListDB.SelectById(74);
        //ldUpdate.IdBook = BookDB.SelectById(120);
        //lddb.Update(ldUpdate);
        //y = lddb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //List_Detail ldDelete = List_DetailDB.SelectById(111);
        //lddb.Delete(ldDelete);
        //z = lddb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Cart:");

        CartDB cdb = new CartDB();
        ListCart cList = cdb.SelectAll();
        //foreach (Cart c in cList)
        //    Console.WriteLine(c);
        //Console.WriteLine();

        //Cart cInsert = new Cart();
        //cInsert.IdReader = ReaderDB.SelectById(380);
        //cInsert.DiscountCode = "jjjjjj";
        //cdb.Insert(cInsert);
        //x = cdb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Cart cUpdate = CartDB.SelectById(16);
        //cUpdate.IdReader = ReaderDB.SelectById(381);
        //cUpdate.DiscountCode = "update";
        //cdb.Update(cUpdate);
        //y = cdb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Cart cDelete = CartDB.SelectById(16);
        //cdb.Delete(cDelete);
        //z = cdb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Cart_Detail:");

        Cart_DetailDB cddb = new Cart_DetailDB();
        ListCart_Detail cdList = cddb.SelectAll();
        //foreach (Cart_Detail cd in cdList)
        //    Console.WriteLine(cd);
        //Console.WriteLine();

        //Cart_Detail cdInsert = new Cart_Detail();
        //cdInsert.IdCart = CartDB.SelectById(15);
        //cdInsert.IdBook = BookDB.SelectById(119);
        //cddb.Insert(cdInsert);
        //x = cddb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Cart_Detail cdUpdate = Cart_DetailDB.SelectById(17);
        //cdUpdate.IdCart = CartDB.SelectById(16);
        //cdUpdate.IdBook = BookDB.SelectById(120);
        //cddb.Update(cdUpdate);
        //y = cddb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Cart_Detail cdDelete = Cart_DetailDB.SelectById(17);
        //cddb.Delete(cdDelete);
        //z = cddb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("News");

        NewsDB ndb = new NewsDB();
        ListNews nList = ndb.SelectAll();
        //foreach (News n in nList)
        //    Console.WriteLine(n);
        //Console.WriteLine();

        //News nInsert = new News();
        //nInsert.IdUser = UserDB.SelectById(379);
        //nInsert.Text = "New Book Release!";
        //nInsert.Time = new DateTime(2026, 4, 24);
        //ndb.Insert(nInsert);
        //x = ndb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //News nUpdate = NewsDB.SelectById(3);
        //nUpdate.IdUser = UserDB.SelectById(379);
        //nUpdate.Text = "Update!";
        //nUpdate.Time = new DateTime(2026, 4, 25);
        //ndb.Update(nUpdate);
        //y = ndb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //News nDelete = NewsDB.SelectById(4);
        //ndb.Delete(nDelete);
        //z = ndb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Reviews");

        ReviewsDB redb = new ReviewsDB();
        ListReviews reList = redb.SelectAll();
        //foreach (Reviews r in reList)
        //    Console.WriteLine(r);
        //Console.WriteLine();

        //Reviews reInsert = new Reviews();
        //reInsert.IdReader = ReaderDB.SelectById(380);
        //reInsert.Text = "Great book!";
        //reInsert.Stars = 5;
        //reInsert.IdBook = BookDB.SelectById(119);
        //redb.Insert(reInsert);
        //x = redb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Reviews reUpdate = ReviewsDB.SelectById(4);
        //reUpdate.IdReader = ReaderDB.SelectById(380);
        //reUpdate.Text = "Update";
        //reUpdate.Stars = 4;
        //reUpdate.IdBook = BookDB.SelectById(120);
        //redb.Update(reUpdate);
        //y = redb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Reviews reDelete = ReviewsDB.SelectById(4);
        //redb.Delete(reDelete);
        //z = redb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Following");

        FollowingDB fdb = new FollowingDB();
        ListFollowing fList = fdb.SelectAll();
        //foreach (Following f in fList)
        //    Console.WriteLine(f);
        //Console.WriteLine();

        //Following fInsert = new Following();
        //fInsert.IdReader = ReaderDB.SelectById(380);
        //fInsert.IdAuthor = AuthorDB.SelectById(388);
        //fdb.Insert(fInsert);
        //x = fdb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Following fUpdate = FollowingDB.SelectById(36);
        //fUpdate.IdReader = ReaderDB.SelectById(380);
        //fUpdate.IdAuthor = AuthorDB.SelectById(378);
        //fdb.Update(fUpdate);
        //y = fdb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Following fDelete = FollowingDB.SelectById(36);
        //fdb.Delete(fDelete);
        //z = fdb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();
    }
}
