using OOP;
using static System.Console;

int[][] array = WorkWithArray.getArrayFromUser();
int[] resultArray = WorkWithArray.concateAndSortArray(array[0], array[1]);
foreach (int item in resultArray)
{
    Write($"{item} ");
}






