namespace CSharpAdvanced
{
    class AnagramsMaker
    {
        public static string ReverseOnlyLetters(string StringToReverse)
        {
            char[] stringToChar = StringToReverse.ToCharArray();
            int arrayStart = 0;
            int arrayEnd = stringToChar.Length - 1;

            while (arrayStart < arrayEnd)
            {
                if (char.IsLetter(stringToChar[arrayStart]) && char.IsLetter(stringToChar[arrayEnd]))
                {
                    char temp = stringToChar[arrayStart];
                    stringToChar[arrayStart] = stringToChar[arrayEnd];
                    stringToChar[arrayEnd] = temp;

                    arrayStart++;
                    arrayEnd--;
                }
                else if (char.IsLetter(stringToChar[arrayStart]) && !char.IsLetter(stringToChar[arrayEnd]))
                {
                    arrayEnd--;
                }
                else if (!char.IsLetter(stringToChar[arrayStart]) && char.IsLetter(stringToChar[arrayEnd]))
                {
                    arrayStart++;
                }
                else
                {
                    arrayStart++;
                    arrayEnd--;
                }
            }

            return new string(stringToChar);
        }
    }
}