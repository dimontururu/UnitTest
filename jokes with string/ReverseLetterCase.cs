
namespace jokes_with_string
{
    public class ReverseLetterCase
    {
        public string Reverse(string reversible)
        {
            string inverted = "";

            for (int i = 0; i < reversible.Length; i++)
            {
                if (reversible[i] > 64 && reversible[i] < 91)
                    inverted += (char)(reversible[i] + 32);

                if (reversible[i] > 97 && reversible[i] < 122)
                    inverted +=(char)(reversible[i] - 32);
            }

            return inverted;
        }
    }
}
