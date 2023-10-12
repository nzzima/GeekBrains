void CatalogInfo(string path, string indent = "")
{
    //string path = "C:/Users/nzzima/Desktop/GitHub/GeekBrains/C#_lessons/Examples/Example013_RecursiveDirectory";
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();

    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{indent}{files[i].Name}");
    }
}

<<<<<<< HEAD
string path = @"...";
=======
string path = @"C:\Users\HYPERPC\PycharmProjects\GB_github\my_geekbrains\C#_lessons\Examples\Example013_RecursiveDirectory";
>>>>>>> 53c69365034318c8837519a3090feb011ac3b33a
CatalogInfo(path);
