// See https://aka.ms/new-console-template for more information

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


PrintNumber("numbers", arr);
PrintNumber("even", arr.Where(x=>IsEven(x)));
PrintNumber("odd", arr.Where(x=>IsOdd(x)));


void PrintNumber(string title, IEnumerable<int> numbers)
{
    System.Console.WriteLine();
    System.Console.Write($"{title}: [");
    foreach (var n in numbers)
    {
        System.Console.Write($" {n}");
    }
    System.Console.Write(" ]");
    System.Console.WriteLine();
}
bool IsEven(int number){
    return  number %2==0;
}
bool IsOdd(int number){
    return  number %2!=0;
}


