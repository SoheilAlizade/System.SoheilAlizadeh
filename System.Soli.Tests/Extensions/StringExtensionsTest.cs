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

        [Fact]
        public void ToToman_ReturnPersianText()
        {
            long? num;
            long num2 = 2;

            int? num3;
            int num4 = 1;

            Assert.NotEmpty(num.ToToman());
            Assert.NotEmpty(num2.ToToman());
            Assert.NotEmpty(num3.ToToman());
            Assert.NotEmpty(num4.ToToman());

        }
    }
}    