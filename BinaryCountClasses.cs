namespace BinaryCountClasses
{
    public class BinaryCount
    {
        public static void BinaryCountMethod(int value)
        {
            int count = 0;
            int binary;

            while (value != 0)
            {
                binary = value % 2;
                count += binary;
                value = (value - binary) / 2;
            }

            Console.WriteLine($"Количество символов 1 - {count}");
        }
    }
}
