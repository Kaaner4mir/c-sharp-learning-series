
                    // 0 0 0 0 0 1 1 1
                    // 0 0 0 0 0 0 1 0 
byte number1 = 7;
number1 &= 2;

Console.WriteLine($"Number1: {number1}");

                    // 0 0 0 0 0 1 1 1
                    // 0 0 0 0 0 0 1 0 
byte number2 = 7;
number2 |= 2;

Console.WriteLine($"Number2: {number2}");

                    // 0 0 0 0 0 1 1 1
                    // 0 0 0 0 0 0 1 0 
byte number3 = 7;
number3 ^= 2;

Console.WriteLine($"Number3: {number3}");