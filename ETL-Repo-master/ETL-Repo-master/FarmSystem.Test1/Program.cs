using System;

namespace FarmSystem.Test1
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            Excercise1();
            Excercise2();
            Excercise3();
            Excercise4();
            Console.ReadKey();
        }

        #region + Test Excercise 1 - description
        /************************************************************************************************************
        Test Excercise 1
        Using your understanding of Object Oriented Programing concepts, modify the classes and program in Test1 to use abstraction and inheritence
        to make the FarmSystem more efficient and easier to maintain and extend 
        Introduce new classes if needed 
        Hold the animals in the farm so they are available for furture activities in a First in First Out basis (Queued animals)
 
        Expected Test1 Program Output

        Exercise 1 : Press any key when it is time to open the Farm to animals

        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm
        ***************************************************************************************************************/
        #endregion
        private static void Excercise1()
        {
            Console.WriteLine("Exercise 1 : Press any key when it is time to open the Farm to animals");
            Console.ReadKey();
            var farm = new EmydexFarmSystem();

            Cow cow = new Cow();
            Hen hen = new Hen();
            Horse horse = new Horse();
            Sheep sheep = new Sheep();

            Console.WriteLine();

            farm.Enter(cow);
            farm.Enter(hen);
            farm.Enter(horse);
            farm.Enter(sheep);

            Console.WriteLine();
            Console.ReadKey();
        }

        #region + Test Excercise 2 - description
        /***************************************************************************************************************
        Test Excercise 2
        If you have completed the first test excercise, you can continue with the second one

        Modify the program and EmydexFarmSystem.MakeNoise() method to get the below output

        Expected Test 2 Program Output

        Exercise 2 : Press any key to scare the animals in the farm

        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm

        Cow says Moo!
        Hen says CLUCKAAAAAWWWWK!
        Horse says Neigh!
        Sheep says baa!
         *****************************************************************************************************************/
        #endregion
        private static void Excercise2()
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 2 : Press any key to scare the animals in the farm");
            Console.ReadKey();
            var farm = new EmydexFarmSystem();

            Cow cow = new Cow();
            Hen hen = new Hen();
            Horse horse = new Horse();
            Sheep sheep = new Sheep();

            Console.WriteLine();

            farm.Enter(cow);
            farm.Enter(hen);
            farm.Enter(horse);
            farm.Enter(sheep);

            Console.WriteLine();

            farm.MakeNoise();

            //farm.MakeNoise();
            Console.WriteLine();
            Console.ReadKey();
        }

        #region + Test Excercise 3 - description
        /*****************************************************************************************************************
        Test Excercise 3
        If you have completed the previous test excercise, you can continue with this one 
        The project includes an interface IMilkableAnimal. Make use of this interface to implement on the relevant classes
        so that calling the EmydexFarmSystem.MilkAnimals() method to get the below output

        Expected Test 3 Program Output

        Exercise 3 : Press any key when it is time to milk animals

        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm

        Cow was milked!

        ************************************************************************************************************/
        #endregion
        private static void Excercise3()
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 3 : Press any key when it is time to milk animals");
            Console.ReadKey();

            var farm = new EmydexFarmSystem();

            Cow cow = new Cow();
            Horse horse = new Horse();
            Hen hen = new Hen();
            Sheep sheep = new Sheep();

            Console.WriteLine();

            farm.Enter(cow);
            farm.Enter(hen);
            farm.Enter(horse);
            farm.Enter(sheep);

            Console.WriteLine();

            farm.MilkAnimals();

            Console.WriteLine();
            Console.ReadKey();
        }

        #region + Test Excercise 4 - description
        /****************************************************************************************************
        Test Excercise 4
        Modify the EmydexFarmSystem.ReleaseAllAnimals() so that all animals are released (simply clear the collection )
        Expose an event on the FarmSystem FarmEmpty which is invoked once all the animals are released
        Subscribe to that event in the main to get the expected output

        Expected Test 4 Program Output

        Exercise 4: Press any key to free all animals
        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm

        Cow has left the farm
        Hen has left the farm
        Horse has left the farm
        Sheep has left the farm

        Emydex Farm is now empty
        ********************************************************************************************************************/
        #endregion
        private static void Excercise4()
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 4: Press any key to free all animals");
            Console.ReadKey();
            var farm = new EmydexFarmSystem();

            Cow cow = new Cow();
            Hen hen = new Hen();
            Horse horse = new Horse();
            Sheep sheep = new Sheep();

            Console.WriteLine();

            farm.Enter(cow);
            farm.Enter(hen);
            farm.Enter(horse);
            farm.Enter(sheep);

            Console.WriteLine();

            farm.ReleaseAllAnimals();

            Console.WriteLine();
            Console.ReadKey();
        }

    }
}