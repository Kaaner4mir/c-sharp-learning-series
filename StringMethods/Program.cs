// string metotları ve özellikleri

string message = "Merhaba Dünya";

Console.WriteLine($"Bu mesajın uzunluğu: {message.Length}");
Console.WriteLine($"Büyük harflere çevirmek için: {message.ToUpper()}");
Console.WriteLine($"Küçük harflere çevirmek için: {message.ToLower()}");

string message2 = "####Merhaba Dünya####";

Console.WriteLine($"Trim('#'): {message2.Trim('#')}");
Console.WriteLine($"TrimStart('#'): {message2.TrimStart('#')}");
Console.WriteLine($"TrimEnd('#'): {message2.TrimEnd('#')}");

bool result = message.Contains("Merhaba");
Console.WriteLine($"Contains('Merhaba'): {result}");

bool result2 = message2.StartsWith("#");
Console.WriteLine($"StartsWith('#'): {result2}");
Console.WriteLine($"EndsWith('a'): {message.EndsWith("a")}");

Console.WriteLine($"\n--- Diğer Popüler String Metotları ---");

Console.WriteLine($"IndexOf('a'): {message.IndexOf("a")}");
Console.WriteLine($"LastIndexOf('a'): {message.LastIndexOf("a")}");

Console.WriteLine($"Substring(8): {message.Substring(8)}");
Console.WriteLine($"Substring(0, 7): {message.Substring(0, 7)}");

Console.WriteLine($"Replace('Dünya', 'Mars'): {message.Replace("Dünya", "Mars")}");

Console.WriteLine($"Remove(7): {message.Remove(7)}"); // 7. indeksten sonrasını siler
Console.WriteLine($"Remove(7, 5): {message.Remove(7, 5)}"); // 7. indeksten itibaren 5 karakter siler

Console.WriteLine($"Insert(7, 'Güzel '): {message.Insert(7, "Güzel ")}");

string message3 = "C# Java Python C++";
string[] words = message3.Split(' ');
Console.WriteLine($"Split(' ') ile dizinin ilk kelimesi: {words[0]}");

string joinedString = string.Join(" - ", words);
Console.WriteLine($"Join(' - ', words): {joinedString}");

string message4 = "C#";
Console.WriteLine($"PadLeft(10, '*'): {message4.PadLeft(10, '*')}");
Console.WriteLine($"PadRight(10, '*'): {message4.PadRight(10, '*')}");

Console.WriteLine($"Equals('Merhaba Dünya'): {message.Equals("Merhaba Dünya")}");

// Compare sonucu -1 (küçük), 0 (eşit), 1 (büyük) olabilir.
Console.WriteLine($"Compare('A', 'B'): {string.Compare("A", "B")}");

string emptyString = "";
string spaceString = "   ";
Console.WriteLine($"IsNullOrEmpty(''): {string.IsNullOrEmpty(emptyString)}");
Console.WriteLine($"IsNullOrWhiteSpace('   '): {string.IsNullOrWhiteSpace(spaceString)}");

Console.WriteLine($"\n--- İleri Düzey ve Ekstra String Metotları ---");

// String.Format
string formattedStr = string.Format("Dil: {0}, Yıl: {1}", "C#", 2024);
Console.WriteLine($"String.Format ile: {formattedStr}");

// String.Concat
string s1 = "Merhaba";
string s2 = "Dostum";
Console.WriteLine($"String.Concat: {string.Concat(s1, " ", s2, "!")}");

// ToCharArray
char[] chars = s1.ToCharArray();
Console.WriteLine($"ToCharArray sonucu ilk eleman: {chars[0]}");

// String.Copy() ve Clone() - (Eski sürümlerden kalma, immutable yapıda referans kopyası döner)
string originalStr = "Orjinal Metin";
string clonedStr = (string)originalStr.Clone();
Console.WriteLine($"Clone metodu (Aynı referans): {clonedStr}");

// CopyTo
char[] destination = new char[5];
originalStr.CopyTo(0, destination, 0, 5); // 0. indeksten 5 karakteri hedef char dizisine atar
Console.WriteLine($"CopyTo ile char dizisine aktarılan: {new string(destination)}");

// CompareTo (Kendisi üzerinden karşılaştırma)
string txt1 = "Elma";
string txt2 = "Armut";
Console.WriteLine($"CompareTo ('Elma' vs 'Armut'): {txt1.CompareTo(txt2)}"); // Pozitif döner çünkü 'E' harfi 'A'dan sonra gelir

// Replace Chaining (Zincirleme kullanımı)
string mess = "b_u b.ir d,eneme";
mess = mess.Replace("_", "").Replace(".", "").Replace(",", ""); // Çoklu replace kullanımı
Console.WriteLine($"Chaining Replace: {mess}");

Console.WriteLine($"\n--- Nadir Kullanılan / Performanslı Ekstra Metotlar ---");

// String.CompareOrdinal (Ordinal karşılaştırma - harf büyüklüğü / kültürel (dil) farkları gözetmeden byte sırasına göre bakar. Performanslıdır.)
Console.WriteLine($"CompareOrdinal ('A', 'a'): {string.CompareOrdinal("A", "a")}");

// Contains içerisinde StringComparison kullanımı (.NET Core ve .NET 5+ ile gelir, performansı artırır)
bool resultContainsIgnoreCase = message.Contains("merhaba", StringComparison.OrdinalIgnoreCase);
Console.WriteLine($"Contains (Büyük-Küçük harf duyarsız): {resultContainsIgnoreCase}");

// Replace(char, char) methodu string replace'e göre (bazı durumlarda ve tek karakter değiştirmede) biraz daha hızlıdır.
string charReplacer = "kedi".Replace('k', 'y');
Console.WriteLine($"Char bazlı Replace: {charReplacer}");

// Split (Ayırma limitli overload) -> Mesela sadece ilk 2 boşluktan böl, kalanını bir bütün halinde dizinin son elemanına koy.
string csvStr = "İsim,Soyisim,Yaş,Şehir";
string[] splitWithLimit = csvStr.Split(',', 3);
Console.WriteLine($"Split(limit: 3) sonrası 3. eleman: '{splitWithLimit[2]}'");

// IndexOf(char, startIndex) -> Belirli bir indeksten ASLA ÖNCESİNE bakma, o noktadan itibaren aramaya başla.
int indexSearch = message.IndexOf('a', 5); // 5. indeksten (yani 5. karakterden) aramaya başlar.
Console.WriteLine($"IndexOf('a', startIndex: 5): {indexSearch}");

// String Interpolation özellikleri (Alignment - Sağa veya sola yaslama, boşluk bırakma)
// İsimleri 10 karakterlik alana sola (negatif rakam) yaslar, Sayıları sağa (pozitif rakam) yaslar (Formatlama mantığı katar).
Console.WriteLine($"|{"Can",-10}| |{5,10}|");
Console.WriteLine($"|{"Mustafa",-10}| |{2500,10}|");