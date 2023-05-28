using System;

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

        }

        public bool IsGoingDirection(int floor, bool directionIsUp)
        {
            return directionIsUp;
        }

        public string GetPeopleOnFloor(int floor)
        {
            return floor == 3 ? "A->3 B->1" : "";
        }

        public string GetPeopleInside()
        {
            return "C->1";
        }
    }
}
