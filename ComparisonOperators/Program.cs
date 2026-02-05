Console.WriteLine(1 == 1);  // 1 1'e eşit midir? => True ya da false döndürür.

int a = 5;
int b = 10;

Console.WriteLine($"a=b: {a == b}");
Console.WriteLine($"a=b: {a != b}");

Console.WriteLine($"a>b: {a > b}");
Console.WriteLine($"a<b: {a < b}");

string fakeName = "jhonny";
string realName = "Jhonny";

Console.WriteLine(realName == fakeName);

Console.WriteLine(realName.Equals(fakeName, StringComparison.OrdinalIgnoreCase));  // Büyük küçük harf duyarlılığını kaldırır.

double x = 0.1 + 0.2;

Console.WriteLine(x == 0.3);
Console.WriteLine(x.ToString("R"));    // R komutu hiçbir değeri kaybetmeden stringe çevirir.

decimal z = 0.1m + 0.2m;

Console.WriteLine(z == 0.3m);          // Bu işlem yapıldığında double false döndürürken decimal true döndürür.
Console.WriteLine(z.ToString("R"));
