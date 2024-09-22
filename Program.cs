using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); //Creates new object called car from Car class 
            Motorcycle motorcycle = new Motorcycle(); //Creates new object called motorcycle from Motorcycle class 
            car.GetVehicleInfo("Honda", "Accord", 2015, 120); //Method GetVehicleInfo sets those in parameters to variables to be used
            car.GetNumberOfDoors(4); //Method GetNumberOfDoors sets whatever number in parameter as a variable
            motorcycle.GetVehicleInfo("Suzuki", "Raider R150", 2018, 150); //Method GetVehicleInfo sets those in parameters to variables to be used
            motorcycle.SidecarAttached("Yes"); //Method SidecarAttached sets bool value based on input in parameter

            car.DisplayInfo(); //Car class calls from inherit class Vehicle to display variables
            car.PrintOutDoors(); //Outputs doors from return value of GetNumberOfDoors()
            Console.WriteLine(); //Space to divide outputs
            motorcycle.DisplayInfo(); //Motorcycle class calls from inherit class Vehicle to display variables
            motorcycle.PrintOutSidecar(); //Outputs a statement if sidecar is attached from value change of SidecarAttached()
            Console.ReadLine(); //Pauses program to allow user to view output
        }
        //Main class called Vehicle
        class Vehicle
        {
            //Make public variables to allow access from other classes and hold values
            public string Make = "";
            public string Model = "";
            public int Year = 0;
            public int MaxSpeed = 0;
            //Method GetVehicleInfo allows for easier input to grab variables
            public void GetVehicleInfo(string aMake, string aModel, int aYear, int aMaxSpeed)
            {
                Make = aMake;
                Model = aModel;
                Year = aYear;
                MaxSpeed = aMaxSpeed;
            }
            //Method DisplayInfo outputs for every variable applicable to Vehicle class
            public void DisplayInfo()
            {
                Console.WriteLine($"The make is: {Make}");
                Console.WriteLine($"The model is: {Model}");
                Console.WriteLine($"The year is: {Year}");
                Console.WriteLine($"The max speed is: {MaxSpeed}");
            }
        }
        //Car class inherits from vehicle class
        class Car : Vehicle
        {
            //Set variable doors to zero for place value
            int doors = 0;
            //Method GetNumberOfDoors allows easier input to grab variable
            public int GetNumberOfDoors(int aDoor)
            {
                doors = aDoor;
                return doors;
            }
            //Method PrintOutDoors outputs number of doors
            public void PrintOutDoors()
            {
                Console.WriteLine($"The number of doors is: {doors}");
            }
        }
        //Motorcycle class inherits from vehicle class
        class Motorcycle : Vehicle
        {
            //Set a bool variable to allow for comparison
            bool HasSidecar;
            //Method SidecarAttached checks inside method to see if input has anything for sidecar or not
            public void SidecarAttached(string sidecar)
            {
                //if-else statement that checks inside method parameters to see if yes or no sidecar
                if (sidecar != "")
                {
                    HasSidecar = true; //set variable HasSidecar to true
                }
                else
                {
                    HasSidecar = false; //set variable HasSidecar to false
                }
            }
            //Method PrintOutSidecar checks HasSidecar bool var and prints out statement based on true/false
            public void PrintOutSidecar()
            {
                if (HasSidecar) //true statement
                {
                    Console.WriteLine("This motorcycle DOES have a sidecar."); //Prints out does have sidecar
                }
                else //false statement
                {
                    Console.WriteLine("This motorcycle does NOT have a sidecar."); //Prinouts out does NOT have sidecar
                }
            }
        }
    }
}
