// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

void PrintTable(double[,] hights){
    for (int i = 0; i < hights.GetLength(0); i++)
    {
        for (int j = 0; j < 2; j++)
        {
            if (j == 0) Console.Write($"({hights[i,j]},");
            else Console.Write($"{hights[i,j]}) ");
        }
    }
}
double[,] FillTable(double[,] hights){
    Random rnd = new Random();
    for (int i = 0; i < hights.GetLength(0); i++)
    {
        for (int j = 0; j < 2; j++)
        {
            hights[i,j] = rnd.Next(-10,10);
        }
    }
    return hights;
}
void PrintScalingTable(double[,] hights, double k){
    for (int i = 0; i < hights.GetLength(0); i++)
    {
        for (int j = 0; j < 2; j++)
        {
            if (j == 0) Console.Write($"({hights[i,j] * k},");
            else Console.Write($"{hights[i,j] * k}) ");
        }
    }
}
Console.Write("Enter the amount of hights: ");
int amount = int.Parse(Console.ReadLine()!);

Console.Write("Enter scaling factor: ");
double k = double.Parse(Console.ReadLine()!);

double[,] hights = new double[amount,2]; // [amount,0] = x | [amount,1] = y

hights = FillTable(hights);
PrintTable(hights);
Console.WriteLine();
PrintScalingTable(hights,k);
