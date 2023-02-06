
Console.Clear();
Console.WriteLine("Курсовая работа");
Console.Write(@"Введите данные элементы массива строк, для ввода элемента нажмите 
'Enter', чтобы закончить ввод, в пустой строке нажмите 'Enter': ");
Console.WriteLine();

string [] InputArray() // Method input Array by elements from console
{
    int count = 0;
    string [] tempArray = new string[count];
    string inputString = string.Empty;
    do
    {
       inputString = Console.ReadLine();
       if (inputString != string.Empty)
            {
                count ++;   
                string [] temp = new string[count];
                for (int i =0; i < count - 1; i++)             
                    temp[i] = tempArray[i];
                temp[count-1] = inputString;
                tempArray = temp; 
                }
    } while (inputString != string.Empty);

    return tempArray;
}

string [] OutputArray(string [] array) //Method for new Array with string elements less 4 chars
{    
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length < 4) count +=1;
    }
    string [] outputArray = new string[count];
    int j = 0;
    foreach (string word in array)
    {
        if (word.Length < 4) 
        {
            outputArray[j] = word;
            j += 1;
        }
    }
    return outputArray;
}

void PrintArray(string [] array) // Output elements of Array
{
    Console.Write("[");
    foreach (var word in array)
        Console.Write($"{word};"); 
    Console.Write("]");
}

string [] inputArray = InputArray();
Console.WriteLine("Заданный массив строк:");
PrintArray(inputArray);

Console.WriteLine();

string [] outputArray = OutputArray(inputArray); 
Console.WriteLine("Полученный массив строк:");
PrintArray(outputArray);
Console.WriteLine();
