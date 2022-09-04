void FillArray (int[]array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(1,100);
        
}
}
int [] array = new int [8];
FillArray(array);
Console.WriteLine("[{0}]", string.Join(",", array));
