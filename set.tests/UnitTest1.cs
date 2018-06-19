using System;
using Xunit;

namespace set.tests
{
    public class Set_Should
    {
        [Fact]
        public void Exist()
        {
            var set = new Set();
        }
    }

    public class Set_Count_Should{

        private Set _set;
        public Set_Count_Should(){
            this._set = new Set();
        }

        [Fact]
        public void Return_0_On_Initialization()
        { 
            Assert.True(_set.Count == 0);
        }

        [Fact]
        public void Return_1_After_First_Add()
        { 
            _set.Add("test");
            Assert.True(_set.Count == 1);
        }

        [Fact]
        public void Return_2_After_Second_Add()
        {
            _set.Add("test1");
            _set.Add("test2");
            Assert.True(_set.Count == 2);
        }


    }


}
