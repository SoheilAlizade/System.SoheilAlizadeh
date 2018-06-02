namespace System.Soli.Extensions
{
    /// <summary>
    /// String object extensions
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Convert enum type to lower string
        /// </summary>
        /// <param name="o">eunm object</param>
        /// <returns> lower of enum string</returns>
        public static string ToLower(this Enum o) => o.ToString().ToLower();

        /// <summary>
        /// Convert object to lower string
        /// </summary>
        /// <param name="o">object</param>
        /// <returns>lower of object string</returns>
        public static string ToLower(this object o) => o.ToString().ToLower();


        /// <summary>
        /// check string is empty or null by using interl .net extensions
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string o) => string.IsNullOrEmpty(o) || string.IsNullOrWhiteSpace(o);
    }
}