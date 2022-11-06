using System.Globalization;

namespace ATProject.Randomly
{
    public class Randomizer
    {
        private static Random random = new Random();
        public bool GetBoolean()
        {
            return random.NextDouble() >= 0.5;
        }

        public int GetInteger()
        {
            return random.Next();
        }

        public long GetLong()
        {
            return random.NextInt64();
        }

        public float GetFloat()
        {
            return random.NextSingle();
        }

        public int GetDigit()
        {
            return random.Next(0, 10);
        }

        public char GetChar()
        {
            return (char)random.Next(256);
        }

        public string GetString()
        {
            string randomLongText = Math.Abs(random.NextInt64()).ToString();
            char[] chars = Enumerable.Range(0, randomLongText.Length / 2)
                                     .Select(i => randomLongText.Substring(i * 2, 2))
                                     .Select(i => (char)int.Parse(i))
                                     .ToArray();

            return new string(chars);
        }

        public DateTime GetDate()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;

            return start.AddDays(random.Next(range));
        }

        public string GetLanguageShortCode()
        {
            string[] codes = CultureInfo.GetCultures(CultureTypes.AllCultures)
                                        .Select(culture => culture.Name)
                                        .ToArray();
            return GetRandom(codes);
        }

        public string GetLanguage()
        {
            string[] languages = CultureInfo.GetCultures(CultureTypes.AllCultures)
                                            .Select(culture => culture.DisplayName)
                                            .ToArray();
            return GetRandom(languages);
        }

        public string GetCurrencySymbol()
        {
            string[] currencySymbol = CultureInfo.GetCultures(CultureTypes.AllCultures)
                                                 .Select(i => i.NumberFormat.CurrencySymbol)
                                                 .ToArray();

            return GetRandom(currencySymbol);
        }

        public string GetGUID()
        {
            return Guid.NewGuid().ToString();
        }

        public char GetSymbol()
        {
            char[] symbols = "$%#@!*/()={}?\\'+-£\"".ToCharArray();

            return GetRandom(symbols);
        }

        public string GetHEXColor()
        {
            return String.Format("#{0:X6}", random.Next(0x1000000));
        }

        public T GetRandom<T>(T[] array)
        {
            return array[random.Next(array.Length)];
        }
    }
}
