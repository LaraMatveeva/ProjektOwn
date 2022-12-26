//
void ArrayEnter(string[] arr, int num)
{
    Console.WriteLine("Ввeдите новое слово либо набор символов с новой строки: ");
    for (int i = 0; i < num; i++)
    {
        arr[i] = Console.ReadLine();
    }
}

int CountArr(string[] array1, int num)
{
    int summ = 0;
    for (int i = 0; i < num; i++)
    {
        if (array1[i].Length <= 3)
            summ++;
    }
    return summ;
}

string[] ExtructArr(string[] array, int num, int sumStr)
{
    string[] extrArray = new string[sumStr];
    int count = 0;
    if (sumStr > 0)
    {
        for (int i = 0; i < num; i++)
        {
            if (array[i].Length <= 3)
            {
                extrArray[count] = array[i];
                count++;
            }
        }
    }
    return extrArray;
}

void PrintArray(string[] arr1, bool marker)
{
    if (marker == false) Console.Write("--->");
    Console.Write("[");
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i < (arr1.Length - 1)) Console.Write($"\"{arr1[i]}\", ");
        else Console.Write($"\"{arr1[i]}\"]");
    }

}

void PrintArrayEmpty()
{
    Console.WriteLine("---->[]");
}

int number = 0;
while (number <= 0)
{
    Console.WriteLine("Введите количество слов: ");
    number = Convert.ToInt32(Console.ReadLine());
}
string[] array = new string[number];
string[] newArray;
bool mark = true;
ArrayEnter(array, number);
PrintArray(array, mark);
int countStr = CountArr(array, number);
mark = false;
if (countStr > 0)
{
    newArray = ExtructArr(array, number, countStr);
    PrintArray(newArray, mark);
}
else PrintArrayEmpty();