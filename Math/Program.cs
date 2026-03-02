// --- Math Sınıfı Kullanımları ---

// 1. Math.Abs(x) - Mutlak Değer
int negativeNumber = -50;
Console.WriteLine($"\n--- Mutlak Değer ---");
Console.WriteLine($"Orjinal: {negativeNumber}");
Console.WriteLine($"Math.Abs({negativeNumber}): {Math.Abs(negativeNumber)}");

// 2. Yuvarlama İşlemleri (Ceiling, Floor, Round, Truncate)
double decimalNumber1 = 4.1;
double decimalNumber2 = 4.9;
double decimalNumber3 = 4.5;
double decimalNumber4 = -4.9;

Console.WriteLine($"\n--- Yuvarlama İşlemleri ---");
Console.WriteLine($"Math.Ceiling(4.1): {Math.Ceiling(decimalNumber1)}");  // 5
Console.WriteLine($"Math.Floor(4.9): {Math.Floor(decimalNumber2)}");      // 4
Console.WriteLine($"Math.Round(4.5): {Math.Round(decimalNumber3)}");      // 4 (Banker's rounding - en yakın çifte yuvarlar)
Console.WriteLine($"Math.Truncate(4.9): {Math.Truncate(decimalNumber2)}"); // 4 (Sadece tam kısmı alır)
Console.WriteLine($"Math.Truncate(-4.9): {Math.Truncate(decimalNumber4)}");// -4 (Floor -5 yapardı, ancak Truncate sadece keser)

// 3. Maksimum ve Minimum Değer Bulma (Max, Min)
int num1 = 100;
int num2 = 250;

Console.WriteLine($"\n--- Maksimum / Minimum Değer ---");
Console.WriteLine($"Math.Max({num1}, {num2}): {Math.Max(num1, num2)}");
Console.WriteLine($"Math.Min({num1}, {num2}): {Math.Min(num1, num2)}");

// 4. Kuvvet ve Karekök Alma (Pow, Sqrt)
double baseNumber = 5;
double exponent = 3;
double numberForSqrt = 144;

Console.WriteLine($"\n--- Kuvvet ve Karekök ---");
Console.WriteLine($"Math.Pow(5, 3): {Math.Pow(baseNumber, exponent)}");    // 5^3 = 125
Console.WriteLine($"Math.Sqrt(144): {Math.Sqrt(numberForSqrt)}");          // Kök 144 = 12

// 5. İşaret Bulma (Sign)
int positive = 8;
int zero = 0;
int negative = -15;

Console.WriteLine($"\n--- İşaret (Sign) ---");
Console.WriteLine($"Math.Sign(8): {Math.Sign(positive)}");    // 1 (Pozitif)
Console.WriteLine($"Math.Sign(0): {Math.Sign(zero)}");        // 0 (Sıfır)
Console.WriteLine($"Math.Sign(-15): {Math.Sign(negative)}");  // -1 (Negatif)

// 6. Matematik Sabitleri (PI ve E)
Console.WriteLine($"\n--- Sabitler ---");
Console.WriteLine($"Math.PI: {Math.PI}");   // ~3.14159
Console.WriteLine($"Math.E: {Math.E}");     // ~2.71828

// Gerçek Hayat Örneği: Bir dairenin alanını hesaplama (Alan = PI * r^2)
double radius = 5.0;
double area = Math.PI * Math.Pow(radius, 2);

Console.WriteLine($"\nYarıçapı {radius} olan dairenin alanı: {Math.Round(area, 2)}"); // Alanı hesaplayıp 2 ondalık basamağa yuvarladık.
