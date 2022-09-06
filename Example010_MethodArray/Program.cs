//Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
//1. Установить счётчик index в позицию 0, 
//2. Если Array [index]=find, алгоритм завершил работу успешно.
//3. Увеличить индекс на 1.
//4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершмл работу безуспешно.
// int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };
// int n = array.Length;
// int find = 18;

// int index = 0;
// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//     }
//     //index++
//     index = index + 1;
// } выдаёт два индекса, которые равны 18


int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };
int n = array.Length;
int find = 18;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;//находит только 1 элемент равный 18
    }
    //index++
    index = index + 1;
}