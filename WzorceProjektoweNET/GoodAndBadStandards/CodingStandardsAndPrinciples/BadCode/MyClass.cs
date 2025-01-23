using CH01_CodingStandardsAndPrinciples.BadCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// Przykład złych nazw przestrzni nazw. Po pierwsze kod zawarty
// w tym przykładzie jest zły. W zaiwazku z tym przestrzeń nazw
// powinna nosić nazwę BadCode. Najwazniejszym wyróżnikiem dobrej nazwy dla 
// przestrzeni nazw jest zasada, zgodnie z którą nazwa przestrzeni nazw powinna odpowiadać
// strukturze folderów, w której została umiesczona.
namespace CH01_CodingStandardsAndPrinciples.GoodCode
{
    /// <summary>
    /// MyClass jest przykładem złego nazewnictwa klas.
    /// Czy na podstawie nazwy klasy jesteś w stanie 
    /// stwierdzić, za co ta klasa jest odpowiedzialna?
    /// </summary>
    public class MyClass
    {
        // Przykłady złych nazw i złych komentarzy
        // Brakuje także znaków podkreślenia identyfikujących zmienne składowe
        // i odróżniających je od zmiennych lokalnych.
        public string strMyString; // Zmienna przechowuje tekst!
        public int i; // Wartości całkowitoliczbowe użyte do indeksowania.
        private readonly byte[] Key;
        private readonly byte[] IV;

        public MyClass()
        {
            Key = Encoding.ASCII.GetBytes("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
            IV = Encoding.ASCII.GetBytes("a0b1c2d3e4f6gh78j9K0L1M2N3O4P5Q6R7S8T9U0V1W2X3Y4Z5");
        }

        // Przykład złej nazwy metody.  Format nazwy powinien być zgodny z konwencją 
        // PascalCase, a nie camelCase. 
        public int myMethod(int a, int b)
        {
            // Zła nazwa zmiennej lokalnej. 
            // Nawet gdyby nazwa była do przyjęcia, to powinna być 
            // w formacie camelCase, a nie PascalCase. 
            // Poza tym zmienna lokalna jest niepotrzebna,  
            // ponieważ metoda po prostu zwraca wynik dodawania. 
            // Dlatego kod metody może być pojedynczym wierszem. 
            // zwracającym wynik dodawania. 
            var SumValue = a + b;
            return SumValue;
        }

        // Przykład złego komentowania.  Twój kod  
        // powinien być zarządzany przez system kontroli wersji. Dzięki temu 
        // byłaby dostępna historia wprowadzanych w nim zmian. Więc zamiast komentować 
        // bloki kodu, które nie są już potrzebne,  
        // należałoby je usunąć. 
        /* Przestarzały kod.  Użyj zamiast tego wywołania Logger.LogText(string text).
        public void LogText(string text)
        {
            // Implementację pominięto
        }*/

        // Metoda pokazuje przykład złego komentarza.
        //Być może potrzebujesz śledzenia kodu źródłowego.  Powinieneś jednak co najmniej 
        // dodać komentarz TODO: tak, by można było go uwzględnić 
        // na liście zadań do zaimplementowania.  Jeszcze lepiej byłoby
        // zaimplementować metodę ArgumentNullValidator, która zgłasza 
        // wyjątek InvalidArgument, jeśli mianownik jest  
        // zerem.


        public double Divide(int numerator, int denominator)
        {
            // Czasami ta metoda powoduje dzielenie przez zero .
            // Nie wiem, dlaczego!
            return numerator / denominator;
        }

        // Ta metody jest zła z dwóch powodów:
        // [1] Nie wszystkie ścieżki kodu zwracają wartość.
        // [2] Robi dwie rzeczy:
        //     [1] Szyfruje ciąg znaków.
        //     [2] Odszyfrowuje ciąg znaków.
        // [3] Zgodnie z konwencją nazewnictwa nazwa powinna brzmieć  
        //     Security a nie security.
        // [4] Nazwa klasy nie odzwierciedla w czytelny sposób  
        //     jaką pracę ta klasa wykonuje.
        public string security(string plainText)
        {
            try
            {
                byte[] encrypted;
                using (AesManaged aes = new AesManaged())
                {
                    ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                    using (MemoryStream ms = new MemoryStream())
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
                Console.WriteLine($"Zaszyfrowane dane: {System.Text.Encoding.UTF8.GetString(encrypted)}");
                using (AesManaged aesm = new AesManaged())
                {
                    ICryptoTransform decryptor = aesm.CreateDecryptor(Key, IV);
                    using (MemoryStream ms = new MemoryStream(encrypted))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cs))
                                plainText = reader.ReadToEnd();
                        }
                    }
                }
                Console.WriteLine($"Odszyfrowane dane: {plainText}");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.ReadKey();
            return plainText;
        }

        public void BreFlowControlExample(BusinessRuleException bre)
        {
            switch (bre.Message)
            {
                case "OutOfAcceptableRange":
                    DoOutOfAcceptableRangeWork();
                    break;
                default:
                    DoInAcceptableRangeWork();
                    break;
            }
        }

        public void BetterFlowControlExample(bool isInAcceptableRange)
        {
            if (isInAcceptableRange)
                DoInAcceptableRangeWork();
            else
                DoOutOfAcceptableRangeWork();
        }

        private void DoOutOfAcceptableRangeWork()
        {
            Console.WriteLine("OutOfAcceptableRange()");
        }

        private void DoInAcceptableRangeWork()
        {
            Console.WriteLine("DoInAcceptableRangeWork()");
        }
    }
}
