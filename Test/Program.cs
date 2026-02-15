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

        Console.WriteLine("Book_Series:");
        Book_SeriesDB bsdb = new();
        ListBook_Series bsList = bsdb.SelectAll();
        //foreach (Book_Series bs in bsList)
        //    Console.WriteLine(bs);
        //Console.WriteLine();

        //Book_Series bsInsert = new Book_Series();
        //bsInsert.NameSeries = "Boys Of Tommen Series";
        //bsdb.Insert(bsInsert);
        //x = bsdb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Book_Series bsUpdate = bsList.Last();
        //bsUpdate.NameSeries = "Boys of Tommen";
        //bsdb.Update(bsUpdate);
        //y = bsdb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Book_Series bsDelete = bsList.Last();
        //bsdb.Delete(bsDelete);
        //z = bsdb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        //Console.WriteLine();
        //Console.WriteLine();




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

        //Genre gUpdate = gList.Last();
        //gUpdate.Name = "Dark Romance";
        //gdb.Update(gUpdate);
        //y = gdb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Genre gDelete = gList.Last();
        //gdb.Delete(gDelete);
        //z = gdb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        //Console.WriteLine();
        //Console.WriteLine();




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

        //Intrest iUpdate = iList.Last();
        //iUpdate.Name = "Thriller";
        //idb.Update(iUpdate);
        //y = idb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Intrest iDelete = iList.Last();
        //idb.Delete(iDelete);
        //z = idb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        //Console.WriteLine();
        //Console.WriteLine();




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

        //Language lUpdate = lList.Last();
        //lUpdate.Name = "Italian";
        //ldb.Update(lUpdate);
        //y = ldb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Language lDelete = lList.Last();
        //ldb.Delete(lDelete);
        //z = ldb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        //Console.WriteLine();
        //Console.WriteLine();




        Console.WriteLine("Permission:");

        PermissionDB pdb = new PermissionDB();
        ListPermission pList = pdb.SelectAll();
        //foreach (Permission p in pList)
        //    Console.WriteLine(p);
        //Console.WriteLine();

        //Permission pInsert = new Permission();
        //pInsert.Name = "Moderator";
        //pdb.Insert(pInsert);
        //x = pdb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Permission pUpdate = pList.Last();
        //pUpdate.Name = "Super Moderator";
        //pdb.Update(pUpdate);
        //y = pdb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Permission pDelete = pList.Last();
        //pdb.Delete(pDelete);
        //z = pdb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        //Console.WriteLine();
        //Console.WriteLine();




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
        //udb.Insert(uInsert);
        //x = udb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //uList = udb.SelectAll();
        //User uUpdate = uList.Last();
        //uUpdate.FirstName = "Alicia";
        //uUpdate.LastName = "Johnson";
        //uUpdate.PhoneNumber = "0567284932";
        //uUpdate.Email = "aliceJhon22@gmail.com";
        //uUpdate.Username = "aliceJhon22";
        //uUpdate.Pass = "alicePass22";
        //uUpdate.Birthdate = new DateTime(1992, 7, 15);
        //udb.Update(uUpdate);
        //y = udb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //User uDelete = uList.Last();
        //udb.Delete(uDelete);
        //z = udb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        //Console.WriteLine();
        //Console.WriteLine();




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
        //aInsert.PenName = "Mark Twain";
        //aInsert.Genre = gList.First();
        //aInsert.InformationAboutAuthor = "Famous American author";
        //adb.Insert(aInsert);
        //x = adb.SaveChanges();
        //Console.WriteLine($"{x} rows were inserted");
        //Console.WriteLine();

        //Author aUpdate = aList.Last();
        //aUpdate.FirstName = "Markus";
        //aUpdate.LastName = "Twain";
        //aUpdate.PhoneNumber = "0523456789";
        //aUpdate.Email = "markTwin1@gmail.com";
        //aUpdate.Username = "markTwin1";
        //aUpdate.Pass = "markPass1";
        //aUpdate.PenName = "Mark Twain";
        //aUpdate.Genre = gList.First();
        //aUpdate.InformationAboutAuthor = "Famous American author";
        //adb.Update(aUpdate);
        //y = adb.SaveChanges();
        //Console.WriteLine($"{y} rows were updated");
        //Console.WriteLine();

        //Author aDelete = aList.Last();
        //adb.Delete(aDelete);
        //z = adb.SaveChanges();
        //Console.WriteLine($"{z} rows were deleted");
        //Console.WriteLine();

        //Console.WriteLine();
        //Console.WriteLine();




        Console.WriteLine("Book:");

        BookDB bdb = new BookDB();
        ListBook bList = bdb.SelectAll();
        foreach (Book b in bList)
            Console.WriteLine(b);
        Console.WriteLine();

        Book bInsert = new Book();
        bInsert.BookName = "The Silent Patient";
        bInsert.PublicationDate = new DateTime(2019, 2, 5);
        bInsert.Price = 18;
        bInsert.IdAuthor = aList.First();
        bInsert.IdGenre = gList.First();
        bInsert.Discount = false;
        bInsert.Information = "A thrilling";
        bInsert.Cover = "silent_patient.jpg";
        bInsert.IdLanguage = lList.First();
        bdb.Insert(bInsert);
        x = bdb.SaveChanges();
        Console.WriteLine($"{x} rows were inserted");
        Console.WriteLine();

        ////bList = bdb.SelectAll();
        ////Book bUpdate = bList.Last();
        ////bUpdate.BookName = "The Silent Patient - Updated";
        ////bUpdate.PublicationDate = new DateTime(2019, 2, 5);
        ////bUpdate.Price = 18;
        ////bUpdate.IdAuthor = aList.First();
        ////bUpdate.IdGenre = gList.First();
        ////bUpdate.Discount = false;
        ////bUpdate.Information = "A thrilling";
        ////bUpdate.Cover = "silent_patient.jpg";
        ////bUpdate.IdLanguage = lList.First();
        ////bdb.Update(bUpdate);
        ////y = bdb.SaveChanges();
        ////Console.WriteLine($"{y} rows were updated");
        ////Console.WriteLine();

        ////Book bDelete = bList.Last();
        ////bdb.Delete(bDelete);
        ////z = bdb.SaveChanges();
        ////Console.WriteLine($"{z} rows were deleted");
        ////Console.WriteLine();

        ////Console.WriteLine();
        ////Console.WriteLine();




        ////Console.WriteLine("Reader:");

        ////ReaderDB rdb = new ReaderDB();
        ////ListReader rList = rdb.SelectAll();
        ////foreach (Reader r in rList)
        ////    Console.WriteLine(r);
        ////Console.WriteLine();

        ////Reader rInsert = new Reader();
        ////rInsert.FirstName = "Bob";
        ////rInsert.LastName = "Smith";
        ////rInsert.PhoneNumber = "0543216789";
        ////rInsert.Email = "bobsmithdm@gmail.com";
        ////rInsert.Username = "bobsmithdm";
        ////rInsert.Pass = "bobPassdm";
        ////rInsert.Nickname = "BookLoverBob";
        ////rInsert.PremiumSubscription = true;
        ////rdb.Insert(rInsert);
        ////x = rdb.SaveChanges();
        ////Console.WriteLine($"{x} rows were inserted");
        ////Console.WriteLine();

        ////rList = rdb.SelectAll();
        ////Reader rUpdate = rList.Last();
        ////rUpdate.FirstName = "Robert";
        ////rUpdate.LastName = "Smith";
        ////rUpdate.PhoneNumber = "0543216789";
        ////rUpdate.Email = "bobsmithdm@gmail.com";
        ////rUpdate.Username = "bobsmithdm";
        ////rUpdate.Pass = "bobPassdm";
        ////rUpdate.Nickname = "BookLoverBob";
        ////rUpdate.PremiumSubscription = true;
        ////rdb.Update(rUpdate);
        ////y = rdb.SaveChanges();
        ////Console.WriteLine($"{y} rows were updated");
        ////Console.WriteLine();

        ////Reader rDelete = rList.Last();
        ////rdb.Delete(rDelete);
        ////z = rdb.SaveChanges();
        ////Console.WriteLine($"{z} rows were deleted");
        ////Console.WriteLine();

        ////Console.WriteLine();
        ////Console.WriteLine();




        ////Console.WriteLine("Book_List:");

        ////Book_ListDB bldb = new Book_ListDB();
        ////ListBook_List blList = bldb.SelectAll();
        ////foreach (Book_List bl in blList)
        ////    Console.WriteLine(bl);
        ////Console.WriteLine();

        ////Book_List blInsert = new Book_List();
        ////blInsert.IdReader = rList.First();
        ////blInsert.ListName = "Summer Reads";
        ////blInsert.IsPublic = true;
        ////bldb.Insert(blInsert);
        ////x = bldb.SaveChanges();
        ////Console.WriteLine($"{x} rows were inserted");
        ////Console.WriteLine();

        ////Book_List blUpdate = blList.Last();
        ////blUpdate.IdReader = rList.First();
        ////blUpdate.ListName = "Summer Reads Updated";
        ////blUpdate.IsPublic = true;
        ////bldb.Update(blUpdate);
        ////y = bldb.SaveChanges();
        ////Console.WriteLine($"{y} rows were updated");
        ////Console.WriteLine();

        ////Book_List blDelete = blList.Last();
        ////bldb.Delete(blDelete);
        ////z = bldb.SaveChanges();
        ////Console.WriteLine($"{z} rows were deleted");
        ////Console.WriteLine();

        ////Console.WriteLine();
        ////Console.WriteLine();




        ////Console.WriteLine("Intrest_Reader:");

        ////Intrest_ReaderDB irdb = new Intrest_ReaderDB();
        ////ListIntrest_Reader irList = irdb.SelectAll();
        ////foreach (Intrest_Reader ir in irList)
        ////    Console.WriteLine(ir);
        ////Console.WriteLine();

        ////Intrest_Reader irInsert = new Intrest_Reader();
        ////irInsert.IdReader = rList.First();
        ////irInsert.IdIntrest = iList.First();
        ////irdb.Insert(irInsert);
        ////x = irdb.SaveChanges();
        ////Console.WriteLine($"{x} rows were inserted");
        ////Console.WriteLine();

        ////Intrest_Reader irUpdate = irList.Last();
        ////irUpdate.IdReader = rList.First();
        ////irUpdate.IdIntrest = iList.First();
        ////irdb.Update(irUpdate);
        ////y = irdb.SaveChanges();
        ////Console.WriteLine($"{y} rows were updated");
        ////Console.WriteLine();

        ////Intrest_Reader irDelete = irList.Last();
        ////irdb.Delete(irDelete);
        ////z = irdb.SaveChanges();
        ////Console.WriteLine($"{z} rows were deleted");
        ////Console.WriteLine();

        ////Console.WriteLine();
        ////Console.WriteLine();




        ////Console.WriteLine("List_Detail:");

        ////List_DetailDB lddb = new List_DetailDB();
        ////ListList_Detail ldList = lddb.SelectAll();
        ////foreach (List_Detail ld in ldList)
        ////    Console.WriteLine(ld);
        ////Console.WriteLine();

        ////List_Detail ldInsert = new List_Detail();
        ////ldInsert.IdList = blList.First();
        ////ldInsert.IdBook = bList.First();
        ////lddb.Insert(ldInsert);
        ////x = lddb.SaveChanges();
        ////Console.WriteLine($"{x} rows were inserted");
        ////Console.WriteLine();

        //////List_Detail ldUpdate = ldList.Last();
        //////ldUpdate.IdList = blList.First();
        //////ldUpdate.IdBook = bList.First();
        //////lddb.Update(ldUpdate);
        //////y = lddb.SaveChanges();
        //////Console.WriteLine($"{y} rows were updated");
        //////Console.WriteLine();

        //////List_Detail ldDelete = ldList.Last();
        //////lddb.Delete(ldDelete);
        //////z = lddb.SaveChanges();
        //////Console.WriteLine($"{z} rows were deleted");
        //////Console.WriteLine();

        //////Console.WriteLine();
        //////Console.WriteLine();




        //////Console.WriteLine("Permission_for_Administrator:");

        //////Permissions_for_AdministratorDB pfadb = new Permissions_for_AdministratorDB();
        //////ListPermissions_for_Administrator pfaList = pfadb.SelectAll();
        //////foreach (Permissions_for_Administrator pfa in pfaList)
        //////    Console.WriteLine(pfa);
        //////Console.WriteLine();

        //////Permissions_for_Administrator pfaInsert = new Permissions_for_Administrator();
        //////pfaInsert.IdAdministrator = uList.First();
        //////pfaInsert.IdPermission = pList.First();
        //////pfadb.Insert(pfaInsert);
        //////x = pfadb.SaveChanges();
        //////Console.WriteLine($"{x} rows were inserted");
        //////Console.WriteLine();

        //////Permissions_for_Administrator pfaUpdate = pfaList.Last();
        //////pfaUpdate.IdAdministrator = uList.First();
        //////pfaUpdate.IdPermission = pList.First();
        //////pfadb.Update(pfaUpdate);
        //////y = pfadb.SaveChanges();
        //////Console.WriteLine($"{y} rows were updated");
        //////Console.WriteLine();

        //////Permissions_for_Administrator pfaDelete = pfaList.Last();
        //////pfadb.Delete(pfaDelete);
        //////z = pfadb.SaveChanges();
        //////Console.WriteLine($"{z} rows were deleted");
        //////Console.WriteLine();

        //////Console.WriteLine();
        //////Console.WriteLine();




        //////Console.WriteLine("Series_Detail:");

        //////Series_DetailDB sddb = new Series_DetailDB();
        //////ListSeries_Detail sdList = sddb.SelectAll();
        //////foreach (Series_Detail sd in sdList)
        //////    Console.WriteLine(sd);
        //////Console.WriteLine();

        //////Series_Detail sdInsert = new Series_Detail();
        //////sdInsert.IdSeries = bsList.First();
        //////sdInsert.IdBook = bList.First();
        //////sddb.Insert(sdInsert);
        //////x = sddb.SaveChanges();
        //////Console.WriteLine($"{x} rows were inserted");
        //////Console.WriteLine();

        //////sdList = sddb.SelectAll();
        //////Series_Detail sdUpdate = sdList.Last();
        //////sdUpdate.IdSeries = bsList.First();
        //////sdUpdate.IdBook = bList.First();
        //////sddb.Update(sdUpdate);
        //////y = sddb.SaveChanges();
        //////Console.WriteLine($"{y} rows were updated");
        //////Console.WriteLine();

        //////Series_Detail sdDelete = sdList.Last();
        //////sddb.Delete(sdDelete);
        //////z = sddb.SaveChanges();
        //////Console.WriteLine($"{z} rows were deleted");

        //////Console.WriteLine();
        //////Console.WriteLine();




        //////Console.WriteLine("Cart:");

        //////CartDB cdb = new CartDB();
        //////ListCart cList = cdb.SelectAll();
        //////foreach (Cart c in cList)
        //////    Console.WriteLine(c);
        //////Console.WriteLine();

        //////Cart cInsert = new Cart();
        //////cInsert.IdReader = rList.First();
        //////cInsert.DiscountCode = "jjjjjj";
        //////cInsert.TotalPrice = 45.99;
        //////cdb.Insert(cInsert);
        //////x = cdb.SaveChanges();
        //////Console.WriteLine($"{x} rows were inserted");
        //////Console.WriteLine();

        //////Cart cUpdate = cList.Last();
        //////cUpdate.IdReader = rList.First();
        //////cUpdate.DiscountCode = "hello";
        //////cUpdate.TotalPrice = 39.99;
        //////cdb.Update(cInsert);
        //////y = cdb.SaveChanges();
        //////Console.WriteLine($"{y} rows were updated");
        //////Console.WriteLine();

        //////Cart cDelete = cList.Last();
        //////cdb.Delete(cDelete);
        //////z = cdb.SaveChanges();
        //////Console.WriteLine($"{z} rows were deleted");
        //////Console.WriteLine();
        //////Console.WriteLine();




        //////Console.WriteLine("Cart_Detail:");

        //////Cart_DetailDB cddb = new Cart_DetailDB();
        //////ListCart_Detail cdList = cddb.SelectAll();
        //////foreach (Cart_Detail cd in cdList)
        //////    Console.WriteLine(cd);
        //////Console.WriteLine();

        //////Cart_Detail cdInsert = new Cart_Detail();
        //////cdInsert.IdCart = cList.First();
        //////cdInsert.IdBook = bList.First();
        //////cddb.Insert(cdInsert);
        //////x = cddb.SaveChanges();
        //////Console.WriteLine($"{x} rows were inserted");
        //////Console.WriteLine();

        //////Cart_Detail cdUpdate = cdList.Last();
        //////cdUpdate.IdCart = cList.First();
        //////cdUpdate.IdBook = bList.First();
        //////cddb.Update(cdUpdate);
        //////y = cddb.SaveChanges();
        //////Console.WriteLine($"{y} rows were updated");
        //////Console.WriteLine();

        //////Cart_Detail cdDelete = cdList.Last();
        //////cddb.Delete(cdDelete);
        //////z = cddb.SaveChanges();
        //////Console.WriteLine($"{z} rows were deleted");
    }
}
