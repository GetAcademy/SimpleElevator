namespace SimpleElevator.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // arrange
            var elevator = new Elevator(5);

            // act
            elevator.Call('A', 3, 1);
            var textFloor3 = elevator.GetPeopleOnFloor(3);

            // assert
            Assert.AreEqual("A->1 ", textFloor3);
        }
    }
}