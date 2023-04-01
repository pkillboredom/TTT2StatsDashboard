namespace TTT2StatsDashboard
{
    public static class StringMapperUtil
    {
        public static string ToRoleFriendlyName(this string str)
        {
            if (str != null)
            {
                if (str == "0") return "Innocent";
                if (str == "1") return "Traitor";
            }
            return str;
        }

        // Rounds a double to two decimal places returning as string
        public static string ToRoundedString(this double d)
        {
            return Math.Round(d, 2).ToString();
        }
    }
}
