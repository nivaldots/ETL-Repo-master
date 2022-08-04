using FarmSystem.Test1.Models;
using System;

namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        private int _noOfLegs = 4;
        private string _type = "Horse";
        private string _talk = "Horse says neigh!";

        public override int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = value;
            }
        }

        //Created to identify the animal
        public override string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public override string Talk
        {
            get
            {
                return _talk;
            }
            set
            {
                _talk = value;
            }

        }


        public void Run()
        {
            Console.WriteLine("Horse is running");
        }

    }
}