// short hand if else statement
// condition ? true : false

string result;
Console.Write("Yaşınızı giriniz: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
    result = "Reşitsiniz!";
else
    result = "Reşit değilsiniz!";

Console.Write(result + "\n");


// Ternary operator

result = age >= 18 ? "Reşitsiniz!" : "Reşit değilsiniz!";

int number = 4;
string result2 = (number > 0) ? "Pozitif" : (number < 0) ? "Negatif" : "Sıfır";

Console.Write(result2);

