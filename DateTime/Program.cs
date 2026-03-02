using System.Globalization;

// --- DateTime Oluşturma ve Temel Bilgiler ---

// Şu anki yerel tarih ve saat
DateTime now = DateTime.Now;
Console.WriteLine($"Şu anki yerel zaman: {now}");

// Şu anki evrensel (UTC) tarih ve saat
DateTime utcNow = DateTime.UtcNow;
Console.WriteLine($"Şu anki UTC zamanı: {utcNow}");

// Belirli bir tarih oluşturma (Yıl, Ay, Gün)
DateTime specificDate = new DateTime(2024, 1, 1);
Console.WriteLine($"Belirli bir tarih: {specificDate}");

// Belirli bir tarih ve saat oluşturma (Yıl, Ay, Gün, Saat, Dakika, Saniye)
DateTime specificDateTime = new DateTime(2024, 5, 20, 14, 30, 0);
Console.WriteLine($"Belirli bir tarih ve saat: {specificDateTime}");

// --- DateTime Özellikleri (Properties) ---

Console.WriteLine($"\n--- DateTime Özellikleri ---");
Console.WriteLine($"Yıl: {now.Year}");
Console.WriteLine($"Ay: {now.Month}");
Console.WriteLine($"Gün: {now.Day}");
Console.WriteLine($"Saat: {now.Hour}");
Console.WriteLine($"Dakika: {now.Minute}");
Console.WriteLine($"Saniye: {now.Second}");
Console.WriteLine($"Milisaniye: {now.Millisecond}");
Console.WriteLine($"Haftanın Günü: {now.DayOfWeek}");
Console.WriteLine($"Yılın Kaçıncı Günü: {now.DayOfYear}");
Console.WriteLine($"Günün hangi saati (TimeOfDay): {now.TimeOfDay}");

// --- Tarih ve Saat Matematiksel İşlemleri ---

Console.WriteLine($"\n--- Tarih ve Saat İşlemleri ---");
DateTime tomorrow = now.AddDays(1);
DateTime nextMonth = now.AddMonths(1);
DateTime nextYear = now.AddYears(1);
DateTime twoHoursLater = now.AddHours(2);

Console.WriteLine($"Yarın: {tomorrow}");
Console.WriteLine($"Gelecek Ay: {nextMonth}");
Console.WriteLine($"Gelecek Yıl: {nextYear}");
Console.WriteLine($"2 Saat Sonra: {twoHoursLater}");

// Geçmiş tarihler için negatif değerler kullanılır
DateTime threeDaysAgo = now.AddDays(-3);
Console.WriteLine($"3 Gün Önce: {threeDaysAgo}");

// --- DateTime Formatlama (ToString) ---

Console.WriteLine($"\n--- DateTime Formatlama ---");
// Standart formatlar
Console.WriteLine($"Kısa Tarih (d): {now.ToString("d")}");
Console.WriteLine($"Uzun Tarih (D): {now.ToString("D")}");
Console.WriteLine($"Kısa Zaman (t): {now.ToString("t")}");
Console.WriteLine($"Uzun Zaman (T): {now.ToString("T")}");
Console.WriteLine($"Tam Tarih/Zaman (f): {now.ToString("f")}");
Console.WriteLine($"Genel Tarih/Zaman (G): {now.ToString("G")}");

// Özel formatlar
Console.WriteLine($"Özel (dd/MM/yyyy): {now.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Özel (yyyy-MM-dd HH:mm:ss): {now.ToString("yyyy-MM-dd HH:mm:ss")}");
Console.WriteLine($"Ay İsmi: {now.ToString("MMMM")}");
Console.WriteLine($"Gün İsmi: {now.ToString("dddd")}");

// Kültüre göre formatlama
Console.WriteLine($"ABD Kültürü (en-US): {now.ToString("D", new CultureInfo("en-US"))}");

// --- DateTime Parsing (Metni Tarihe Çevirme) ---

Console.WriteLine($"\n--- DateTime Parsing ---");
string dateString = "2024-12-31";
DateTime parsedDate = DateTime.Parse(dateString);
Console.WriteLine($"Parse edilen tarih: {parsedDate}");

string complexDateString = "20/05/2024 14:30";
// Belirli bir formatta parse etme
DateTime exactParsedDate = DateTime.ParseExact(complexDateString, "dd/MM/yyyy HH:mm", null);
Console.WriteLine($"ParseExact edilen tarih: {exactParsedDate}");

// Güvenli parse etme
bool isValid = DateTime.TryParse("geçersiz tarih", out DateTime resultParse);
Console.WriteLine($"Tarih geçerli mi?: {isValid}");

// --- TimeSpan (Zaman Farkı ve Süre) ---

Console.WriteLine($"\n--- TimeSpan ---");
DateTime startDate = new DateTime(2024, 1, 1);
DateTime endDate = new DateTime(2024, 1, 10);
TimeSpan difference = endDate - startDate;

Console.WriteLine($"Fark (Toplam Gün): {difference.TotalDays}");
Console.WriteLine($"Fark (Toplam Saat): {difference.TotalHours}");

TimeSpan duration = new TimeSpan(2, 10, 30, 0); // 2 gün, 10 saat, 30 dakika
Console.WriteLine($"Süre: {duration}");
DateTime endOfDuration = startDate.Add(duration);
Console.WriteLine($"Süre sonu: {endOfDuration}");

// --- DateTimeOffset ---
// Zaman dilimi (timezone) bilgisiyle birlikte tarih tutar

Console.WriteLine($"\n--- DateTimeOffset ---");
DateTimeOffset offsetNow = DateTimeOffset.Now;
Console.WriteLine($"Şu anki Offset: {offsetNow}");
Console.WriteLine($"Offset Değeri: {offsetNow.Offset}");

// --- Diğer Yardımıcı Metotlar ---

Console.WriteLine($"\n--- Diğer Özellikler ---");
bool isLeap = DateTime.IsLeapYear(2024);
Console.WriteLine($"2024 Artık Yıl mı?: {isLeap}");

int daysInMonth = DateTime.DaysInMonth(2024, 2);
Console.WriteLine($"2024 Şubat ayı kaç gün?: {daysInMonth}");

// Karşılaştırma
if (now > specificDate)
{
    Console.WriteLine("Şu anki zaman 1 Ocak 2024'ten büyüktür.");
}
