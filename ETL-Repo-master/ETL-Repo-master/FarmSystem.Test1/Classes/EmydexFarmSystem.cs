using FarmSystem.Test1.Models;
using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //Added a queue to keep animals in the farm - FIFO style
        Queue<Animal> _list = new Queue<Animal>();

        /// <summary>
        /// TEST 1 - Method for entering animals into the farm and list.
        /// </summary>
        /// <param name="animal">Type of animal (Animal) </param>
        public void Enter(Animal obj)
        {
            try
            {
                //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
                //Hold all the animals so it is available for future activities
                Console.WriteLine($"{obj.Type} has entered the Emydex farm");
                //Add the animals to the list.
                _list.Enqueue(obj);
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, we encountered a problem. Please call your system administrator.(1)");
            }

        }

        /// <summary>
        /// TEST 2 - Method to display the sound of all animals that are on the farm
        /// </summary>
        public void MakeNoise()
        {
            try
            {
                foreach (Animal model in _list)
                {
                    if (model.GetType().GetProperties().Any(x => x.Name == "Talk"))
                    {
                        Console.WriteLine(model.Talk);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, we encountered a problem. Please call your system administrator.(2)");
            }
        }

        /// <summary>
        /// TEST 3 - Method for finding animals that can be milked.
        /// </summary>
        public void MilkAnimals()
        {
            try
            {
                //All classes that have this interface will be listed.

                #region + I tried to filter before but I couldn't.
                //if (_list.GetType().GetInterfaces().Count(x => x.Name == "IMilkableAnimal") == 0)
                //{
                //    Console.WriteLine("Cannot identify the farm animals which can be milked");
                //}                
                //else
                #endregion

                foreach (Animal model in _list)
                {
                    if (model.GetType().GetInterfaces().Any(x => x.Name == "IMilkableAnimal"))
                    {
                        IMilkableAnimal imilk = (IMilkableAnimal)model;

                        if (imilk.GetType().GetMethods().Any(x => x.Name == "ProduceMilk"))
                            imilk.ProduceMilk();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, we encountered a problem. Please call your system administrator.(3)");
            }
        }

        /// <summary>
        /// TEST 4 - Method to perform left of all farm animals
        /// </summary>
        public void ReleaseAllAnimals()
        {
            try
            {
                int qtd = _list.Count();

                for (int i = 1; i <= qtd; i++)
                {
                    Console.WriteLine($"{_list.Peek().Type} has left the farm");
                    _list.Dequeue();
                }

                //Queue<Animal>.Peek() -> Returns the object at the beginning of the Queue without removing it.

                Console.WriteLine();
                FarmEmpty();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, we encountered a problem. Please call your system administrator.(4)");
            }
        }

        public void FarmEmpty()
        {
            if (_list.Count == 0)
            {
                Console.WriteLine("There are no animals in the farm, farm is free");
            }
            else
            {
                Console.WriteLine("There are still animals in the farm, farm is not free");
            }
        }
    }
}