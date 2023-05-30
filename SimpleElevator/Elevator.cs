using System;
using System.Drawing;

namespace SimpleElevator
{
    internal class Elevator
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
            return directionIsUp;
        }

        public string GetPeopleOnFloor(int floor)
        {
            var text = string.Empty;
            foreach (var person in _people)
            {
                if (!person.IsInElevator && floor == person.FromFloor)
                {
                    text += person.Description + " ";
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
    }
}
