using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References.Test
{
    public class AddingNumbers
    {
        [Fact]
        public void CanAddTwoNumbers()
        {
            int a = 10;
            int b = 20;
            int answer;

            answer = a + b;

            Assert.Equal(31,answer);
        }

    }
}
