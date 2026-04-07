using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachet
{
    public class Olenivod
    {
        private string name_;
        private int age_;
        private int call_;

        public Olenivod (string name, int age, int call)
        {
            name_ = name;
            age_ = age;
            call_ = call;
        }
        public string GetName()
        {
            return name_;
        }
    }

}
