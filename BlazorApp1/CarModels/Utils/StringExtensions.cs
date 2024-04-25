using System.Text;

namespace BlazorApp1.CarModels.Utils
{
    public static class StringExtensions
    {
        public static string ToFriendlyCase(this string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            StringBuilder builder = new StringBuilder(str.Length * 2);
            builder.Append(str[0]);
            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsUpper(str[i])) builder.Append(' ');
                builder.Append(str[i]);
            }
            return builder.ToString();
        }
    }

}
