namespace Brackets
{
    public static class Brackets
    {
        public static bool IsCorrect(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;

            Stack<char> brackets = new();
            Dictionary<char, char> avalaibleBrackets = new()
            {
                { '{','}' },
                { '[',']' },
                { '(',')' },
                { '<','>' }
            };

            foreach(char character in value)
            {
                if (avalaibleBrackets.ContainsKey(character))
                {
                    brackets.Push(character);
                }
                else if (avalaibleBrackets.ContainsValue(character))
                {
                    if (brackets.Count == 0) continue;

                    if (character == avalaibleBrackets[brackets.First()])
                    {
                        brackets.Pop();
                    }
                }
            }

            return brackets.Count == 0;
        }
    }
}