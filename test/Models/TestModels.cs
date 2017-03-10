using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class TestClass
    {
        private string _str = "123";  //初始宣告
        public string str
        {
            get { return _str; }
            set { _str = value; }

        }

    }
}
