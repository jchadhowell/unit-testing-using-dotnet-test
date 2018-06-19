using System;

namespace set
{
    public class Set
    {
        int count = 0;
        public int Count{
            get {return this.count;}
            set{}
        }

        public void Add(string item){
            this.count++;
        }
    }
}
