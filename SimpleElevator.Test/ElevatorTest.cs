namespace SimpleElevator.Test
{
    public class ElevatorTest
    {
        /*
         * IsGoingDirection tester
         */
        [Test]
        public void TestNoPeople()
        {
            // arrange
            var elevator = new Elevator(2);

            // act
            var floor1Up = elevator.IsGoingDirection(1, true);
            var floor1Down = elevator.IsGoingDirection(1, false);
            var floor2Up = elevator.IsGoingDirection(2, true);
            var floor2Down = elevator.IsGoingDirection(2, false);


            // assert
            Assert.IsFalse(floor1Up);
            Assert.IsFalse(floor1Down);
            Assert.IsFalse(floor2Up);
            Assert.IsFalse(floor2Down);
        }

        [Test]
        public void TestAFrom2To1()
        {
            // arrange
            var elevator = new Elevator(2);

            // act
            elevator.Call('A', 2, 1);
            var floor1Up = elevator.IsGoingDirection(1, true);
            var floor1Down = elevator.IsGoingDirection(1, false);
            var floor2Up = elevator.IsGoingDirection(2, true);
            var floor2Down = elevator.IsGoingDirection(2, false);


            // assert
            Assert.IsFalse(floor1Up);
            Assert.IsFalse(floor1Down);
            Assert.IsFalse(floor2Up);
            Assert.IsTrue(floor2Down);
        }

        /*
         * GetPeopleOnFloor tester
         */
        [Test]
        public void TestOnePerson()
        {
            // arrangClass1.cse
            var elevator = new Elevator(5);

            // act
            elevator.Call('A', 3, 1);
            var textFloor3 = elevator.GetPeopleOnFloor(3);

            // assert
            Assert.AreEqual("A->1", textFloor3);
        }

        [Test]
        public void TestTwoPeople()
        {
            // arrange
            var elevator = new Elevator(5);

            // act
            elevator.Call('A', 3, 1);
            elevator.Call('B', 3, 2);
            var textFloor3 = elevator.GetPeopleOnFloor(3);

            // assert
            Assert.AreEqual("A->1 B->2", textFloor3);
        }

        [Test]
        public void TestNone()
        {
            // arrange
            var elevator = new Elevator(5);

            // act
            var textFloor3 = elevator.GetPeopleOnFloor(3);

            // assert
            Assert.AreEqual("", textFloor3);
        }
    }
}