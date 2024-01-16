void Array(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1, 10);
        index++;
    }

}
void Printarray(int[] col)
{
    int count = col.Length;
    int ind = 0;
    while (ind < count)
    {
        System.Console.Write(col[ind] + " ");
        ind++;
    }
}
void NewList(int[] arr)
{
     int[] list =  arr;
    for (int i = 0; i <=2; i++)
    {
        System.Console.Write(list[i] + " ");
    }
}
int[] spisok = new int[5];
Array(spisok);
Printarray(spisok);
System.Console.WriteLine();
NewList(spisok);
