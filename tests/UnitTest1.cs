using System;
using Xunit;
using lol;

namespace lol
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           Person john = new Person("John Doe","Hola");
           Assert.Equal("John Doe", john.name);

        }
    }
}
