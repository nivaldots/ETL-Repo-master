using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1.Models
{
    public abstract class Animal
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set
            {
                //Moved the new Guid to each time the constructor is called
                _id = Guid.NewGuid().ToString();
            }
        }

        public abstract int NoOfLegs { get;  set; }
        public abstract string Type { get; set; }

        //Change to property, to be called as an inheritance.
        public abstract string Talk { get; set; }

    }
}
