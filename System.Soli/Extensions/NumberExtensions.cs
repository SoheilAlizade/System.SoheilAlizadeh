namespace System.Soli.Extensions
{
    public static class NumberExtensions
    {
        public static string ToToman(this int? o) => InternalToToman(o);

        public static string ToToman(this int o) => InternalToToman(o);

        public static string ToToman(this long? o) => InternalToToman(o);

        public static string ToToman(this long o) => InternalToToman(o);

        private static string InternalToToman(this long? o)
        {
            return o == null ? "0 تومان" : $"{o:#,0} تومان";
        }                   
    }
}