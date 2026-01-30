using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class MenuGroup
    {
        public string name_ { get; set; }
        public string description_ { get; set; }
        public MenuGroup(string name, string description)
        {
            name_ = name;
            description_ = description;
        }
        public override string ToString()
        {
            return name_;
        }
    }
}
