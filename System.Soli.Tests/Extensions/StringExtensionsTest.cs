using System.Soli.Extensions;
using Xunit;

namespace System.Soli.Tests.Extensions
{
    public class StringExtensionsTest
    {
        [Theory]
        [InlineData(EnumTest.One)]
        public void ToLower_EnumType_ReturnLowerCaseEnumItem(EnumTest enumTest)
        {
           Assert.Equal(enumTest.ToLower(),EnumTest.One.ToString().ToLower());                                  
        }
    }
}