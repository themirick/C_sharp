string path = "D:/C_sharp/Clesson/xmpl2_dimensional_arrays_recursion";
DirectoryInfo di = new DirectoryInfo(path);

System.Console.WriteLine(di.CreationTime);

FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}