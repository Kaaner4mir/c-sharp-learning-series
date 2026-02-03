// Değer-değer , değişken-değer , değişken-değişken arasında aritmetik operatörler

int sum1 = 11 + 9;
int sum2 = sum1 + 4;
int sum3 = sum1 + sum2;

Console.WriteLine(sum3);

string firstName = "Sabiha";
string lastName = "Gökçen";

Console.WriteLine(firstName + lastName);
//Eğer string arasında boşluk bırakmak istenirse şu şekilde de yazılabilir.
Console.WriteLine(firstName + " " + lastName);

int number1 = 11;
int number2 = 2;

int result = number1 / number2;

Console.WriteLine(result); // Sonuc 5,5 çıkması gerekirken değişken int olduğu için 5 çıkmıştır.

int x = 5;
int y = x++;

int v = 5;
int z = ++v;


// ++ işlemi eğer değişkenin sağına yazılırsa ilk önce atama işlemini yapar daha sonra attırır.
// ++ işlemi eğer değişkenin soluna yazılırsa ilk önce arttırma işlemini yapar daha sonra atama işlemini yapar.

Console.WriteLine($"x: {x}");
Console.WriteLine($"y: {y}\n"); 

Console.WriteLine($"v: {v}");
Console.WriteLine($"z: {z}");
A


