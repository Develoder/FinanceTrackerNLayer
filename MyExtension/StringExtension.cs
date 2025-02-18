namespace MyExtension
{
    public static class StringExtension
    {
        public static bool IsNullOrWhiteSpace(this string? input)
        {
            return string.IsNullOrWhiteSpace(input);
        }
    }
}
