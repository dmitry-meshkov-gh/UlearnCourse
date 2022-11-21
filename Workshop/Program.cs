// Дан массив чисел. Нужно его сдвинуть циклически на K позиций влево, не используя других массивов.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

int[] numbers = new[] { 5, 7, 15, 19, 20, 21, 21, 34, 70 };
int[] anotherNumbers = new[] { 4, 6, 9, 19, 31, 55 }; 
MoveArrayToTheLeft(numbers, 4);

// Даны два неубывающих массива чисел. Сформировать неубывающие массивы, являющиеся объединением, пересечением
// и разностью этих двух массивов (разность в смысле мультимножеств).
int[] concatArrays = numbers.Concat(anotherNumbers).ToArray();
Console.WriteLine(String.Join(", ", concatArrays));
int[] intersectArrays = numbers.Intersect(anotherNumbers).ToArray();
Console.WriteLine(String.Join(", ", intersectArrays));

// Перевести число из системы счисления с основанием A в систему с основанием B.
// Можно считать, что 2 ≤ A, B ≤ 10, а число дано в виде массива цифр.
int[] ints = new[] { 672 };
ConvertToDifferentNumberSystem(ints, 8);

// Превратить рациональную дробь a/b (0 < a < b < 100000) в десятичную.
// Возможен период. "1/6" должна превратиться в "0.1(6)"
double a = 1;
double b = 6;
double result = a / b;
Console.WriteLine(result);


static int[] ConvertToDifferentNumberSystem(int[] ints, int value)
{   
    int[] result = new int[ints.Length];
    for (int i = 0; i < ints.Length; i++)
    {
        List<int> converted = new List<int>();
        while (ints[i] > 0)
        {
            result[i] = ints[i] % value;
            ints[i] = ints[i] / value;
            converted.Add(result[i]);
        }
        converted.Reverse();
        result[i] = Convert.ToInt32(String.Join<int>("", converted));
    }
    return result;
}

static void MoveArrayToTheLeft(int[] numbers, int delta)
{
    for (int i = 0; i < numbers.Length; i++)
        numbers[i] = numbers[i] + delta;
}