namespace CanvasApplication
{
    public static class Utilities
    {
        public static decimal ToNDecimalPlaces(this decimal number, int decimalPlaces)
        {
            var formatSpecifier = $"F{decimalPlaces}";

            if (decimal.TryParse(number.ToString(), out decimal numericOutput))
            {
                var formattedOutput = numericOutput.ToString(formatSpecifier);
                return Convert.ToDecimal(formattedOutput);
            }

            return number;
        }
    }
}
