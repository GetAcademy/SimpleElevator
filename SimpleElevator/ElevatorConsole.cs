namespace SimpleElevator
{
    internal class ElevatorConsole
    {
        private static readonly int _elevatorWidth = 30;
        public static void Write(Elevator elevator)
        {
            var topFloor = elevator.NumberOfFloors;
            for (var floor = topFloor; floor >= 1; floor--)
            {
                if (floor == elevator.CurrentFloor) WriteFloorWithElevator(elevator, floor);
                else WriteFloorWithoutElevator(elevator, floor);
            }
        }

        private static void WriteFloorWithElevator(Elevator elevator, int floor)
        {
            Console.Write("|╔");
            Write('═', _elevatorWidth);
            Console.Write("╗| ");
            WriteButtonsAndFloorNo(elevator, floor);

            Console.Write("|║");
            var people = floor == elevator.CurrentFloor ? elevator.GetPeopleInside() : "";
            Console.Write(people);
            Write(' ', _elevatorWidth - people.Length);
            Console.Write("║| ");
            Console.WriteLine(elevator.GetPeopleOnFloor(floor));

            Console.Write("|╚");
            Write('═', _elevatorWidth);
            Console.Write("╝|");
            Write('-', _elevatorWidth);
            Console.WriteLine();
        }

        private static void WriteFloorWithoutElevator(Elevator elevator, int floor)
        {
            Console.Write("|");
            Write(' ', _elevatorWidth + 2);
            Console.Write("| ");
            WriteButtonsAndFloorNo(elevator, floor);

            Console.Write("|");
            Write(' ', _elevatorWidth +2);
            Console.Write("| ");
            Console.WriteLine(elevator.GetPeopleOnFloor(floor));

            Console.Write("|");
            Write(' ', _elevatorWidth + 2);
            Console.Write("|");
            Write('-', _elevatorWidth);
            Console.WriteLine();
        }

        private static void WriteButtonsAndFloorNo(Elevator elevator, int floor)
        {
            Write('▲', elevator.IsGoingDirection(floor, true));
            Write('▼', elevator.IsGoingDirection(floor, false));
            Console.Write($" Etasje {floor}");
            Console.WriteLine();
        }

        private static void Write(char c, int count)
        {
            var text = string.Empty.PadLeft(count, c);
            Console.Write(text);
        }

        private static void Write(char c, bool highlight)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = highlight? ConsoleColor.Yellow:ConsoleColor.DarkGray;
            Console.Write(c);
            Console.ForegroundColor = color;
        }
    }
}
