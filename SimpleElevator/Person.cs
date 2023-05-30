namespace SimpleElevator
{
    internal class Person
    {
        public char Name { get; }
        public int FromFloor { get; }
        public int ToFloor { get;}
        public bool IsInElevator { get; }
        public string Description => $"{Name}->{ToFloor}";

        public Person(char name, int fromFloor, int toFloor)
        {
            FromFloor = fromFloor;
            ToFloor = toFloor;
            Name = name;
        }
    }
}
