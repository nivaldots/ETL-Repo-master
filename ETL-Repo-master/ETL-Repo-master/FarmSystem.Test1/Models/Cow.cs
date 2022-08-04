using FarmSystem.Test1.Models;
using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        private int _noOfLegs = 4;
        private string _type = "Cow";
        private string _talk = "Cow says Moo!";

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

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

        public void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}