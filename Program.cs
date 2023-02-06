
Console.Clear();
Console.WriteLine("Курсовая работа");
Console.Write("Введите данные для анализа, элементы разделяйте запятой - ");
string inputString = Console.ReadLine();
Console.WriteLine();
string [] inputArray = inputString.Split(',');

string [] OutputArray(string [] array)
{    
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i].Trim();

        if (array[i].Length < 3) count +=1;
    }
    string [] outputArray = new string[count];
    int j = 0;
    foreach (string word in inputArray)
    {
        if (word.Length < 3) 
        {
            outputArray[j] = word;
            j += 1;
        }
    }
    return outputArray;
}

string [] SecondOutputArray(string [] array)
{
    string tempString = String.Empty;
    foreach (var word in array)
    {
        if (word.Length < 3) 
        {
            tempString += word + ' ';
        }
    }
    tempString = tempString.TrimEnd();
    return tempString.Split();
}

void PrintArray(string [] array)
{
    Console.Write("Массив с элементами менее 3-х знаков: ");
    foreach (var word in array)
    {
    Console.Write($"{word}, "); 
    }

}
string [] outputArray = OutputArray(inputArray); 
PrintArray(outputArray);
Console.WriteLine();
Console.WriteLine("Второй вариант решения");
PrintArray(SecondOutputArray(inputArray));