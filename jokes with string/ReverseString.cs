namespace jokes_with_string
{
    public class ReverseString
    {
        public string Reverse(string reversible)
        {
            string inverted="";

            for(int i = reversible.Length-1;i>-1;i--)
                inverted += reversible[i];

            return inverted;
        }
    }
}
