using System;

namespace c0732134_Week05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elevator e = new Elevator();
            //e.setup();
            //e.makeTreeTraversalList();

            BubbleSort bs = new BubbleSort();
            bs.run();
            Console.ReadLine();
        }
    }

    class Node
    {
        public Node() { }
        public Node elevatorUp;
        public string floorNumber;
    }

    class Department
    {
        public Department(string deptName)
        {
            departmentDescription = deptName;
        }
        public Department nextDepartment;
        public Department previousDepartment;
        public string departmentDescription;
    }

    class DepartmentStore
    {
        public void initializeDepartments()
        {
            Department Kitchenware = new Department("Kitchenware");
            Department Books = new Department("Books");

            Kitchenware.nextDepartment = Books;
            // Kitchenware.previousDepartment 

        }
    }

    class BubbleSort
    {
        public void run()
        {
            int[] ar = new int[5] { 4, 5, 6, 2, 3 };
            int mid = 0, temp = 0;

            for (int i = 0; i < ar.Length; i++)
            {

                for (int j = 0; j < ar.Length - 1; j++)
                {
                    temp = 0;
                    if (ar[j] > ar[j + 1])
                    {
                        temp = ar[j + 1];
                        ar[j + 1] = ar[j];
                        ar[j] = temp;
                    }
                }

            }
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write("{0} ", ar[i]);
            }

        }
    }

    class Elevator
    {
        public static Node head;
        public static Node firstFloor;
        public static Node secondFloor;
        public static Node thirdFloor;
        public static Node fourthFloor;

        public void setup()
        {
            firstFloor = new Node();
            secondFloor = new Node();
            thirdFloor = new Node();
            fourthFloor = new Node();

            head = firstFloor;

            firstFloor.floorNumber = "First Floor";
            secondFloor.floorNumber = "Second Floor";
            thirdFloor.floorNumber = "Third Floor";
            fourthFloor.floorNumber = "Fourth Floor";

            firstFloor.elevatorUp = secondFloor;
            secondFloor.elevatorUp = thirdFloor;
            thirdFloor.elevatorUp = fourthFloor;
            fourthFloor.elevatorUp = null;


            //Console.WriteLine("The Floor Number is : " + firstFloor.floorNumber);
            //Console.WriteLine("The Floor Number is : " + secondFloor.floorNumber);
            //Console.ReadLine();
        }

        public void makeTreeTraversalList()
        {
            Node temp;
            temp = head;
            while (temp != null)
            {

                Console.WriteLine(temp.floorNumber);
                temp = temp.elevatorUp;
            }
        }
    }
}