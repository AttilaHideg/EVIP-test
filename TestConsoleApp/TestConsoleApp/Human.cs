using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Human
    {
        private int age;

        public string Name { get; set; }		

		public int Age
		{
			get { return age; }
			set
			{ 
				if(value >= 0)
					age = value;
			}
		}

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} vagyok, {Age} éves";
        }

    }
}
