using System;
using System.IO;
using System.Reflection;

public class ImageToBase64Converter
{
    public static string ImageFromResourceToBase64(string fileName)
    {
        try
        {
            // תיקון קריטי: במקום GetExecutingAssembly, אנחנו לוקחים את ה-Assembly שבו המחלקה הזו יושבת
            var assembly = typeof(ImageToBase64Converter).Assembly;

            // נתיב ה-Resource בתוך פרויקט ViewModel
            string resourcePath = $"ViewModel.PRP.{fileName}";

            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            {
                if (stream == null)
                {
                    // אם זה עדיין לא מוצא, זה ידפיס לחלון ה-Output את השמות המדויקים
                    Console.WriteLine($"[שגיאה] ה-Resource לא נמצא בנתיב: {resourcePath}");
                    Console.WriteLine("הנה הרשימה האמיתית של ה-Resources בתוך ViewModel:");
                    foreach (string name in assembly.GetManifestResourceNames())
                    {
                        Console.WriteLine("-> " + name);
                    }
                    return "";
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return null;
        }
    }
}