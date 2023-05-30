using System.Text;

namespace SimpleElevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Vi bruker heis som eksempel
             *  - litt komplisert, men målet er jevn progresjon, ikke å løse alt
             *  - uni testing hjelper oss å fokusere på små enkle skritt!
             *
             * Kort om MVC
             */

            Console.OutputEncoding = Encoding.UTF8;
            var elevator = new Elevator(5);
            elevator.Call('A', 3, 1);
            ElevatorConsole.Write(elevator);
        }
    }
}