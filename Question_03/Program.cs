// Написать программу копирования массива

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] FillArray(int[] array){
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,10);
    }
    return array;
}
int[] CopyArray(int[] array){
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

Console.WriteLine();

int[] copy = CopyArray(array);
PrintArray(copy);