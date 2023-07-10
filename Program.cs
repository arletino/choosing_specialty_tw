// Console.Clear();
// Console.WriteLine("Курсовая работа");
// string task = @"Введите  элементы массива строк через пробел,
// чтобы закончить ввод, нажмите 'Enter': ";
// Console.WriteLine();

// Promt(main, task);

// void Promt(Delegate method, string? task)
// {
// do
//     {
//         Console.Clear();
//         Console.Write(task);
//         string? str = Console.ReadLine(); 

//         if (str ==string.Empty || str.Trim() == string.Empty)
//         {
//             Console.WriteLine("Вы ввели не правильные данные, для выхода нажмите 'ESC'");
//             Console.WriteLine("Или любую клавишу для повтора");
//         }
//         else 
//         {
//             method.DynamicInvoke(str);
             
//             Console.WriteLine("Для выхода нажмите 'ESC' или любую клавишу для повтора");
//         }    
//     } while (Console.ReadKey().Key != ConsoleKey.Escape);
// }

// string?[] GetArrayFromString(string? str) // Method get Array by words from string
// {
//     str.Trim();
//     return str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// }

// void PrintArrayWords(string [] arrayWords) //print Array 
// {   
//     Console.Write('[' + string.Join("; ", arrayWords) + "]");
// }

// string?[] GetArrayShortWords(string [] arrayWords) //Method for new Array with string elements less 4 chars
// {    
//     string? str = string.Empty;
//     foreach (string word in arrayWords)
//     {
//         if (word.Length < 4) str +=word + ' ';
//     }
//     return GetArrayFromString(str);
// }

// void main(string? str)
// {
//     Console.Write("Исходный массив слов: ");
//     PrintArrayWords(GetArrayFromString(str));
//     Console.WriteLine();
//     Console.WriteLine("Массив слов с кол-вом букв менее 4-х: ");
//     PrintArrayWords(GetArrayShortWords(GetArrayFromString(str)));
//     Console.WriteLine();
//}
Console.WriteLine("Курсовая работа");
string? task = @"Введите  элементы массива строк через пробел,
чтобы закончить ввод, нажмите 'Enter': ";
Console.WriteLine(task);
string? firststr = Console.ReadLine();
string[] firstArray = firststr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
string? secondstr = string.Empty;
    foreach (string word in firstArray)
    {
        if (word.Length < 4) secondstr +=word + ' ';
    }
string[] secondArray = secondstr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.Write('[' + string.Join("; ", firstArray) + "]");
Console.WriteLine();
Console.Write('[' + string.Join("; ",secondArray) + "]");

