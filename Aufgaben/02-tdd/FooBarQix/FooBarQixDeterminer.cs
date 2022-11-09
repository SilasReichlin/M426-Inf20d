
namespace FooBarQix
{
    public static class FooBarQixDeterminer
    {
        public static string Determine(int input)
        {
            string result = string.Empty;

            if (input % 3 == 0)
            {
                result += "Foo";
            }

            if (input % 5 == 0)
            {
                result += "Bar";
            }

            if (input % 7 == 0)
            {
                result += "Qix";
            }

            string inputnumber = input.ToString();

            foreach (char c in inputnumber)
            {
                if (c == '3')
                    result += "Foo";

                if (c == '5')
                    result += "Bar";

                if (c == '7')
                    result += "Qix";
            }

            return string.IsNullOrEmpty(result) ? input.ToString() : result;
        }
    }
}
