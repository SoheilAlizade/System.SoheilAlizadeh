namespace System.Soli.Extensions
{
    public static class DebugExtensions
    {
        /// <summary>
        /// This Method check you application mode is debug or not.
        /// <example>
        ///  <code>
        ///   bool isDebug = this.IsDebug(); // true
        ///   bool isDebug = this.IsDebug(); // false
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="o">The object that's unused just for prepare a extension</param>
        /// <returns></returns>
        public static bool IsDebug(this object o)
        {
#if DEBUG
            return true;
#else
            return false;
#endif  
        }
    }
}   