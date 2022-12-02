class Program {
    static int[] numbers = new init [] {10,2,3,4,5,1,9};

    static void Main(string[] args)
    {
        Console.WriteLine("Start");
        show();
        {
            int externIterations = 0;
            int internIterations = 0;
            for (int i = 0; i < i<numbers.Length> -1; i++)
            {
                externIterations++;
                for (int j=0; j< numbers.Length; j++)
                {
                    internIterations++;
                    if (numbers[j] > numbers[j + 1])
                    
                        int aux = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("# external iterations:" + externIterations);
            Console.WriteLine("# internal iterations" + internIterations);
            Console.WriteLine("Start");
            Show();
        }

    public static void Show(){
        foreach(var number in numbers)
        {
            Console.Write(number + ",")
                    Console.WriteLine("\n")
        }
    }
}