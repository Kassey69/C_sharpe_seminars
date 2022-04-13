
 
            int size = 5;
            for (int y = 0; y < size; y++)
            {
                int c = 1;
                for (int q = 0; q < size - y; q++)
                {
                    Console.Write("   ");
                }
                for (int x = 0; x <= y; x++)
                {
                    Console.Write("   {0:D} ", c);
                    c = c * (y - x) / (x + 1);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
        