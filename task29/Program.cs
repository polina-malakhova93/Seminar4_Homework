int[] array = new int [8];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
PrintArray(array);

void PrintArray( int[]array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}