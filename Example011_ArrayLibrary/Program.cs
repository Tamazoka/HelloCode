// void FillArray(int[] collection) //void - метод, который ничего не возвращает - (нет return)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10); //решение задачи с использованием генератора псевлослучайных чисел        
//         //index = index + 1;
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int[] array = new int[10]; // создай новый массив с 10 элементами (по умолчанию он будет заполнен 0).

// FillArray(array);
// PrintArray(array);


void FillArray(int[] collection) //void - метод, который ничего не возвращает - (нет return)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //решение задачи с использованием генератора псевлослучайных чисел        
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //int position = 0; при 0, если будет число, которого нет в массиве, например, int pos = IndexOf(array, 444);, то программа выдаст 0
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // при нахождении первого нужного числа остановится, без этой комманды будет искать последнее нужное число
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай новый массив с 10 элементами (по умолчанию он будет заполнен 0).

FillArray(array);
array[4] = 4; // добавили принудительно 4 в 4 и 6 индекс
array[6] = 4;

PrintArray(array);
Console.WriteLine(); // этой строкой добавляем пустую строку к выводу

int pos = IndexOf(array, 444);
Console.WriteLine(pos);