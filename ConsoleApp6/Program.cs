namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            int[] sits = new int[10];
            int place, input = 0;
            do
            {
                place = 0;
                Console.Write("Choose place: 0 - exit   1-smoke   2-no smoke: ");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case 1:
                        {
                            for (int i = 0; i < sits.Length / 2; i++)
                            {
                                if (sits[i] == 0)
                                {
                                    sits[i] = 1;
                                    place = i + 1;
                                    break;
                                }
                            }
                            if (place == 0)
                            {
                                Console.WriteLine("No smoking place"); 
                                input = int.Parse(Console.ReadLine());      
                                if(input == 1) { goto case 2; }
                            }
                            else
                            {
                                Console.WriteLine($"Your place - {place}");
                            }
                            break;
                        }
                    case 2:
                        {
                            for(int i = sits.Length / 2; i < sits.Length; i++)
                            {
                                if (sits[i] == 0)
                                {
                                    sits[i] = 1;
                                    place = i + 1;
                                    break;
                                }
                            }
                            if (place == 0)
                            {
                                Console.WriteLine("No smoking place");
                            }
                            else
                            {
                                Console.WriteLine($"Your place - {place}");
                            }
                            break;
                        }
                    default:
                        break;
                }
            } while (true);   
        }
    }
}
