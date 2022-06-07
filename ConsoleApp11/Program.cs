class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов ");
        int a = int.Parse(Console.ReadLine());
        int[] b = new int[a];
        Console.WriteLine("Заполните массив ");
        for (int i = 0; i < a; i++)
        {
            b[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Порядковый номер числа N ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Число в массиве: " + b[c - 1]);
    }
}