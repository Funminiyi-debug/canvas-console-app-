using Microsoft.Extensions.Configuration;

namespace CanvasApplication
{
    public static class Constants
    {
        public static int DecimalPlaces { get; private set; } = 3;

        public static void InitializeFromConfiguration(IConfiguration configuration)
        {
            var decimalPlacesConfig = configuration["DecimalPlaces"];

            if (int.TryParse(decimalPlacesConfig, out int decimalPlaces))
            {
                DecimalPlaces = decimalPlaces;
            }
        }
    }
}
