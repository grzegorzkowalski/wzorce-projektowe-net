// Liczba rzymska do konwersji
using Interpreter_sample;

string roman = "MCMXCIV"; // 1994

// Tworzenie kontekstu
Context context = new Context(roman);

// Tworzenie listy wyrażeń (kolejność ma znaczenie!)
List<Expression> tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

// Interpretacja liczby rzymskiej
foreach (Expression exp in tree)
{
    exp.Interpret(context);
}

// Wyświetlenie wyniku
Console.WriteLine($"Roman numeral: {roman}");
Console.WriteLine($"Arabic numeral: {context.Output}");