// Виды методов

//Вид 1
void Method1()
{
    Console.WriteLine("Autor is ...");
}

Method1();

//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("The given text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21("second text", 5);
Method21(count: 7, msg: "my text");

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "fhjhl");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "text");
Console.WriteLine(res);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

string TextReplace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string text = "Князь сказал что он будет...";
string txt = TextReplace(text, ' ', '-');
Console.WriteLine(txt);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 12, 2, 3, 6, 8, 15};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

SortArray(arr);
PrintArray(arr);