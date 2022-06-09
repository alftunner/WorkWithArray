namespace OOP;
using static System.Console;

public class WorkWithArray
{
    public static int[] initArray()
    {
        int a;
        Write("Введите размерность массива: ");
        while (!int.TryParse(ReadLine(), out a))
        {
            Write("Введите размерность массива: ");
        }
    
        int[] array = new int[a];
        for (int i = 0; i < a; i++)
        {
            int b;
            Write($"Введите {i+1} - й элемент: ");
            while (!int.TryParse(ReadLine(), out b))
            {
                Write($"Введите {i+1} - й элемент: ");
            }
    
            array[i] = b;
        }
    
        return array;
    }
    
    public static int[][] getArrayFromUser()
    {
        int a;
        Write("Введите количество массивов для создания: ");
        while (!int.TryParse(ReadLine(), out a))
        {
            Write("Введите количество массивов для создания: ");
        }
    
        int[][] array = new int[a][];
        for (int i = 0; i < a; i++)
        {
            array[i] = initArray();
        }
    
        return array;
    }
    
    public static int[] concateAndSortArray(int[] array1, int[] array2)
    {
        int[] resultArray = array1.Concat(array2).ToArray();
        Array.Sort(resultArray);
        return resultArray;
    }
}