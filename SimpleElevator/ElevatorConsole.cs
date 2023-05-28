namespace SimpleElevator
{
    internal class ElevatorConsole
    {
        private static readonly int _columnWidth = Console.WindowWidth / 3;

        public static void Write(Elevator elevator)
        {
            var topFloor = elevator.NumberOfFloors;
            for (var floor = topFloor; floor >= 1; floor--)
            {

            }
        }

        private static void Write(string text, int column)
        {
            var col = _columnWidth * (column - 1);
            var whiteSpaceWidth = _columnWidth - text.Length;
            var leftPadding = (column - 1) * whiteSpaceWidth / 2;
            Console.CursorLeft = col;
            Console.Write(text);
        }
    }
}
