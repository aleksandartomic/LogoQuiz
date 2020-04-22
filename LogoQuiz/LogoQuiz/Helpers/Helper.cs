using System;
using System.Collections.Generic;
using System.Text;

namespace LogoQuiz.Helpers
{
    static class Helper
    {
        public static string GetRandomGUID()
        {
            string guidResult = Guid.NewGuid().ToString();

            guidResult = guidResult.Replace("-", string.Empty).ToUpper();

            return guidResult;
        }
    }
}
