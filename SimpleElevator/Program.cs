using System.Text;

namespace SimpleElevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 
             * Unit test - en fin måte å jobbe videre med objektorientering på
             *
             * Vise Greps
             *  
             * Vi bruker heis som eksempel
             *  - litt komplisert, men målet er jevn progresjon, ikke å løse alt
             *  - unit testing hjelper oss å fokusere på små enkle skritt!
             *  - grensetilfeller
             *  - robust
             *
             * Kort om MVC
             *
             * + Code coverage
             * + Testdrevet utvikling
             * + Testbar kode er god kode
             * + Automatisere kjøring av tester
             */

            Console.OutputEncoding = Encoding.UTF8;
            var elevator = new Elevator(5);
            elevator.Call('A', 3, 1);
            ElevatorConsole.Write(elevator);
        }
    }
}