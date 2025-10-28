using Model;
using ViewModel;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Genre:");
        GenreDB gdb = new();
        ListGenre gList = gdb.SelectAll();
        foreach (Genre g in gList)
            Console.WriteLine(g.Name);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Intrest:");
        IntrestDB idb = new();
        ListIntrest iList = idb.SelectAll();
        foreach (Intrest i in iList)
            Console.WriteLine(i.Name);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Language:");
        LanguageDB ldb = new();
        ListLanguage lList = ldb.SelectAll();
        foreach (Language l in lList)
            Console.WriteLine(l.Name);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Permission:");
        PermissionDB pdb = new();
        ListPermission pList = pdb.SelectAll();
        foreach (Permission p in pList)
            Console.WriteLine(p.Name);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("User:");
        UserDB udb = new();
        ListUser uList = udb.SelectAll();
        foreach (User u in uList)
            Console.WriteLine(u.FirstName);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Book_Series:");
        Book_SeriesDB bsdb = new();
        ListBook_Series bsList = bsdb.SelectAll();
        foreach (Book_Series bs in bsList)
            Console.WriteLine(bs.NameSeries);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Author:");
        AuthorDB adb = new();
        ListAuthor aList = adb.SelectAll();
        foreach (Author a in aList)
            Console.WriteLine(a.PenName);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Book:");
        BookDB bdb = new();
        ListBook bList = bdb.SelectAll();
        foreach (Book b in bList)
            Console.WriteLine(b.BookName);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Book_List:");
        Book_ListDB bldb = new();
        ListBook_List blList = bldb.SelectAll();
        foreach (Book_List bl in blList)
            Console.WriteLine(bl.ListName);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Intrest_Reader:");
        Intrest_ReaderDB irdb = new();
        ListIntrest_Reader irList = irdb.SelectAll();
        foreach (Intrest_Reader ir in irList)
            Console.WriteLine(ir);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("List_Detail:");
        List_DetailDB lddb = new();
        ListList_Detail ldList = lddb.SelectAll();
        foreach (List_Detail ld in ldList)
            Console.WriteLine(ld);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Permissions_for_Administer:");
        Permissions_for_AdministratorDB padb = new();
        ListPermissions_for_Administrator paList = padb.SelectAll();
        foreach (Permissions_for_Administrator pa in paList)
            Console.WriteLine(pa);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Reader");
        ReaderDB rdb = new();
        ListReader rList = rdb.SelectAll();
        foreach (Reader r in rList)
            Console.WriteLine(r.Nickname);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Series_Detail:");
        Series_DetailDB sddb = new();
        ListSeries_Detail sdList = sddb.SelectAll();
        foreach (Series_Detail sd in sdList)
            Console.WriteLine(sd.IdBook);
        Console.WriteLine();
        Console.WriteLine();
    }
}
