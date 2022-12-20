namespace Task13._6._1;

public class ReadTextFile
{
    /// <summary>
    /// Чтене из файла
    /// </summary>
    /// <returns>Получение массива типа string</returns>
    public static List<string>? TextRead()
    {
        string fileText;
        try
        {
            fileText = File.ReadAllText("Text.txt");
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
        var charDelimetr = new char[] { ' ', '\r', '\n' };
        var textArrey = fileText.Split(charDelimetr, StringSplitOptions.RemoveEmptyEntries).ToList();
        return textArrey;
    }
}