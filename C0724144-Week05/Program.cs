using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0724144_Week05
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator e = new Elevator();
            e.run();
        }
    }

    class Node
    {
        public Node() { }
        public Node floor;
        public Node elevatorUp;
        public string FloorNumber;
    }

    class Elevator
    {
        Node FirstFloor;
        Node SecondFloor;
        Node ThirdFloor;
        Node FourthFloor;

        public void run()
        {
            FirstFloor = new Node();
            SecondFloor = new Node();
            ThirdFloor = new Node();
            FourthFloor = new Node();
            FirstFloor.FloorNumber = "First Floor";
            FirstFloor.elevatorUp = SecondFloor;
            Console.WriteLine("Your current floor is {0}",FirstFloor.FloorNumber);
            SecondFloor.FloorNumber = "Second Floor";
            SecondFloor.elevatorUp = ThirdFloor;
            Console.WriteLine("Your current floor is {0}", SecondFloor.FloorNumber);
            ThirdFloor.FloorNumber = "Third Floor";
            ThirdFloor.elevatorUp = ThirdFloor;
            Console.WriteLine("Your current floor is {0}", ThirdFloor.FloorNumber);
            FourthFloor.FloorNumber = "Fourth Floor";
            FourthFloor.elevatorUp = null;
            Console.WriteLine("Your current floor is {0}", FourthFloor.FloorNumber);


        }
    }
}
