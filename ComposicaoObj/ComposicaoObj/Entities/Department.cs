using System;
using System.Collections.Generic;

namespace ComposicaoObj.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department() { }

        public Department(string name)
        {
            Name = name;
        }
    }
}
