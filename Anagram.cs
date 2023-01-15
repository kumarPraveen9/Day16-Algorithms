namespace day16
{
 public class Anagram
    { 
        public static void Main(string[] args)
        {
            string str1 = "heart";
            string str2 = "traeh";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Given Input string is Anagram.");
            }

            else
            {
                Console.WriteLine("This is not an Anagram");

            }
        }
    }
}
