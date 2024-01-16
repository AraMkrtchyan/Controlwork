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
