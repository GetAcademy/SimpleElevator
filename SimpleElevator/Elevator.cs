using System;
using System.Drawing;

namespace SimpleElevator
{
    public class Elevator
    {
        public int CurrentFloor { get; }
        public int NumberOfFloors { get; }

        private List<Person> _people;

        public Elevator(int numberOfFloors)
        {
            CurrentFloor = 1;
            NumberOfFloors = numberOfFloors;
            _people = new List<Person>();
        }

        public void Call(char name, int fromFloor, int toFloor)
        {
            var person = new Person(name, fromFloor, toFloor);
            _people.Add(person);
        }

        public bool IsGoingDirection(int floor, bool directionIsUp)
        {
            foreach (var person in _people)
            {
                if (person.FromFloor == floor)
                {
                    if (directionIsUp && person.ToFloor > floor) return true;
                    if (!directionIsUp && person.ToFloor < floor) return true;
                }
            }
            return false;
        }

        public string GetPeopleOnFloor(int floor)
        {
            var text = string.Empty;
            foreach (var person in _people)
            {
                if (!person.IsInElevator && floor == person.FromFloor)
                {
                    if (text != string.Empty)
                    {
                        text += " ";
                    }
                    text += person.Description;
                }
            }
            return text;
        }

        public string GetPeopleInside()
        {
            var text = string.Empty;
            foreach (var person in _people)
            {
                if (person.IsInElevator)
                {
                    text += person.Description + " ";
                }
            }
            return text;
        }

        public void Dummy(int a)
        {
            if (a < 10)
            {
                string s = null;
                var n = s.Length;
                Console.WriteLine("x");
            }
            else
            {
                Console.WriteLine("y");
            }

            var isEven = a % 2 == 0;
            if (isEven)
            {
                Console.WriteLine("kjfhkj");
            }
            else
            {
                Console.WriteLine("flhkjk");
            }
        }
    }
}
