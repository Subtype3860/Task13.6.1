using System.Diagnostics;

namespace Task13._6._1;

internal class Program
{
    public static void Main()
    {
        const string text = "Простое слово";
        var textList = ReadTextFile.TextRead();
        var textLinkedList = new LinkedList<string>(textList!);
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        textList!.Add(text);
        stopWatch.Stop();
        var timeSpanList = stopWatch.Elapsed;
        Console.WriteLine($"Время вставки в List<T> равно: {timeSpanList}");
        stopWatch.Start();
        textLinkedList.AddFirst(text);
        stopWatch.Stop();
        var timeSpanLinkedList = stopWatch.Elapsed;
        Console.WriteLine($"Время вставки в LinkedList<T> равно: {timeSpanLinkedList}");
        Console.ReadKey();
    }
}