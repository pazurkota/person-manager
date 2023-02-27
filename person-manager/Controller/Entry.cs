namespace person_manager.Controller;

public static class Entry
{
    public static int GetInput(string str, int maxValue, int minValue = 0)
    {
        int? number = null;

        do
        {
            try
            {
                string? s;

                do
                {
                    Console.Write(str);
                    s = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(s));

                number = int.Parse(s);
                if (number < minValue || number > maxValue) throw new Exception("Invalid number");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        } while (!number.HasValue);

        return number.Value;
    }
}