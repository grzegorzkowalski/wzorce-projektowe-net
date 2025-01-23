using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCodeBadCode.CH01
{
    /// <summary>
    /// Ta klasa pokazuje przykłady dobrego kodu.
    /// </summary>
    public class GoodCode
    {
        /// <summary>
        /// Przykład prawidłowych wcięć.
        /// </summary>
        public void DoSomething()
        {
            for (var i = 0; i < 1000; i++)
            {
                var productCode = $"PRC000{i}";
                //...implementacja
            }
        }

        /// <summary>
        /// Scala nazwy w odwrotnej kolejności.
        /// </summary>
        /// <param name="firstName">Imię osoby </param>
        /// <param name="lastName">Nazwisko osoby </param>
        /// <returns></returns>
        public string ConcatName(string firstName, string lastName)
        {
            return $"{lastName}, {firstName}";
        }
    }

    namespace CompanyName.ProductName.RegEx
    {
        using System;
        using System.Text.RegularExpressions;

        /// <summary>
        /// Klasa rozszerzeń zawierająca operacje z wykorzystaniem wyrażeń regularnych
        /// <summary>
        public static class RegularExpressions
        {
            private static string _preprocessed;

            public static string RegularExpression { get; set; }

            public static bool IsValidEmail(this string email)
            {
                // Adres e-mail: format RFC 2822.  
                // Pasuje do standardowego adresu e-mail. Nie sprawdza domeny najwyższego poziomu .
                // Wymaga ustawienia opcji "case insensitive" na ON.
                var exp = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                bool isEmail = Regex.IsMatch(email, exp, RegexOptions.IgnoreCase);
                return isEmail;
            }

            // ... pozostała część implementacji...

        }
    }

    public class Worker
    {
        public void DoSomeWork()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                // Wykonanie jednostki pracy.
            }
            // W tym miejscu obiekt UnitOfWork został zniszczony.
        }
    }

    public class UnitOfWork : IDisposable
    {
        #region IDisposable Support
        private bool disposedValue = false; // Aby wykryć redundantne wywołania 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: zniszczyć zarządzany stan (zarządzane obiekty).
                }

                // TODO: zwolnić niezarządzane zasoby (obiekty niezarządzane) i zastąpić finalizer poniżej.
                // TODO: ustaw duże pola na null.

                disposedValue = true;
            }
        }

        // TODO: zastąp finalizator tylko wtedy, gdy w metodzie Dispose(bool disposing) powyżej znajduje się kod odpowiedzialnu za zwalnianie niezarządzanych zasobów.
        // ~UnitOfWork()
        // {
        //   // Nie zmieniaj tego kodu . Umieść kod porządkowania w metodzie Dispose(bool disposing) powyżej.
        //   Dispose(false);
        // }

        // Ten kod został dodany w celu prawidłowej implementacji wzorca disposable.
        public void Dispose()
        {
            //   // Nie zmieniaj tego kodu . Umieść kod porządkowania w metodzie Dispose(bool disposing) powyżej.
            Dispose(true);
            // TODO: odkomentuj poniższy wiersz, jeśli powyżej jest nadpisany finalizator.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    /// <summary>
    /// Przestrzeń nazw zawierająca klasy, które definiują operacje na plikach i katalogach.
    /// </summary>
    namespace CompanyName.IO.FileSystem
    {
        public class File { }
        public class Directory { }
    }

    /// <summary>
    /// Przestrzeń nazw zawierająca klasy do wykonywania różnych operacji konwersji.
    /// </summary>
    namespace CompanyName.Converters
    {
        public class BindingTypeConverter { }
        public class BoolNegationConverter { }
    }

    /// <summary>
    ///Przestrzeń nazw zawierająca typy zarządzania strumieniami wejścia i wyjścia.
    /// </summary>
    namespace CompanyName.Streams
    {
        public class FileStream { }
        public class MemoryStream { }
    }
}
