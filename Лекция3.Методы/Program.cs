// Вид1
//Ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();//скобки обязательны

// Вид2
//что то принимают, ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i=0;
    while(i < count)//Увел. счетчика на 1 называют инкриментом (наоборот декремент)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст",count: 4);//можем указывать к какому аргументу какое значение присвоить
//Method21(count: 4, msg: "Новый Текст"); Именнованные аргументы не обязательно писать по порядку

//Вид 3
//Ничего не принимают, что то возвращают
//Если метод что то возвращает, обязательно надо указать тип данных
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//Вид4
//что то принимают, что то возвращают
//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
//
//    while (i < count)
//    {
//        result = result + text;
//        i ++;
//    }
//    return result;
//}
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i =0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

//вывод таблицы умножения на экран
for (int i=2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");//Интерполяция строк
    }
    Console.WriteLine();//Переход на новую строку
}
//Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие
//"С" заменить маленькими.

//1. Ясна ли задача?(уточнять до малейшей подробности)
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы.Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к','К');
Console.WriteLine(newText);
//Упорядочить массив
//1 2 3 4 5 6 7 8
//1.Найти позицию минимального элемента в неотсортированной части массива
//2.Произвести обмен этого значения со значением первой неотсортированной позиции
//3.Повторять пока есть не отсортированные элементы

int [] arr ={1, 5, 4, 3, 2, 6, 7, 1, 1};
//пишем функцию вывода массива на экран
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//Пишем метод упорядочивания массива
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        //снизу блок кода ищущий макс.элемент
        for (int j = i + 1; j < array.Length; j++)
        {
            //ищем минимальный элемент
            if (array[j] < array[minPosition]) minPosition = j;
        }
        //
        //
        //
        //Потребуется поменять значение мин.позиции с той позицией которую нашли
        int temporary = array[i];
        array[i] = array[minPosition];//обмен 2-х перменных местами
        array [minPosition] = temporary;//в мин позицию кладем временный элемент
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
