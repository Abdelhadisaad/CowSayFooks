namespace Test
{
    public class CowSay
    {
        private string previousInput = "";

        public List<string> CreateCow(string input)
        {
            if (input == "previous")
            {
                return CreateCow(previousInput);
            }

            // Save input to get previous input
            previousInput = input;

            var cowString = new List<string>();

            int width = Math.Min(input.Length, 40);

            // Line top
            cowString.Add(" " + new string('-', width + 2));

            // Text ballon
            int remainingChars = input.Length;
            int startIndex = 0;
            int lineCount = 0;
            while (remainingChars > 0)
            {
                lineCount++;
                int lineLength = Math.Min(remainingChars, 40);
                string textLine = input.Substring(startIndex, lineLength);
                if (lineCount == 1 && remainingChars <= 40)
                {
                    cowString.Add($@"< {textLine.PadRight(width)} >");
                } else if (lineCount == 1 && remainingChars >= 40)
                {
                    cowString.Add($@"/ {textLine.PadRight(width)} \");
                } else if (lineCount >= 1 && remainingChars >= 40)
                {
                    cowString.Add($@"| {textLine.PadRight(width)} |");
                } else if (lineCount >= 1 && remainingChars <= 40)
                {
                    cowString.Add($@"\ {textLine.PadRight(width)} /");
                }
                startIndex += lineLength;
                remainingChars -= lineLength;
            }

            // Line buttom
            cowString.Add(" " + new string('-', width + 2));

            // Our happy cow
            cowString.Add(@"        \   ^__^");
            cowString.Add(@"         \  (oo)\___");
            cowString.Add(@"            (__)\       )\/\");
            cowString.Add("                ||----w |");
            cowString.Add("                ||     ||");

            return cowString;
        }
    }


}