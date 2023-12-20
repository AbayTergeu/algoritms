using Newtonsoft.Json;
using Tolar.BiService.Domain.Abstractions.Common.Risks.Contracts;
using Tolar.BiService.Enumeration;

namespace SortByChoice;

/// <summary>
/// Сортировка выборкой, бегаем по всему списку и ставим на 0 индекс самое минимальное значение,
/// далее бегаем от 1 индекса по всему списку и ставим на 1 индекс сл минимальное значение и так до конца
/// Сложность On^2 тк в цикле бегаем по циклу.
/// </summary>
static class Program
{
    static void Main()
    {

        var a = new B();
        var contacts = new RiskData(RiskLevel.Undefined);
        contacts.Value = "12";
        var json = JsonConvert.SerializeObject(contacts, new RiskDataConverter());
        Console.WriteLine(json);
        
        var contactsObj = JsonConvert.DeserializeObject<RiskData>(json, new RiskDataConverter())!;
        Console.WriteLine(contactsObj);

        /*Console.WriteLine("Сортировка выбором");
        Console.WriteLine("Введите массив для сортировки");
        var interArr = Console.ReadLine()?.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
        if (interArr != null)
        {
            var arr = new int[interArr.Length];
            for (int i = 0; i < interArr.Length; i++)
            {
                arr[i] = Convert.ToInt32(interArr[i]);
            }
            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", SortByChoice(arr)));
        }

        Console.ReadLine();*/
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="array">Collection from numbers.</param>
    /// <param name="currentIndex">Current index.</param>
    /// <returns></returns>
    static int[] SortByChoice(int[] array, int currentIndex = 0)
    {
        if (currentIndex == array.Length)
            return array;

        var index = GetSmallestIndex(array, currentIndex);
        // Если другой индекс значит у текущего значение меньше чем 
        if (index != currentIndex)
        {
            Swap(ref array[index], ref array[currentIndex]);
        }

        return SortByChoice(array, currentIndex + 1);
    }
    
    /// <summary>
    /// For change method.
    /// </summary>
    static void Swap(ref int x, ref int y)
    {
        (x, y) = (y, x);
    }

    /// <summary>
    /// Api for search index with min number.
    /// </summary>
    /// <param name="array">Collection from number.</param>
    /// <param name="currentIdx">Current index.</param>
    static int GetSmallestIndex(int[] array, int currentIdx)
    {
        int smalledIdx = currentIdx;
        for (var i = currentIdx; i < array.Length; ++i)
        {
            if (array[i] < array[smalledIdx])
            {
                smalledIdx = i;
            }
        }

        return smalledIdx;
    }
}