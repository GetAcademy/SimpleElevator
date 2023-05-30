namespace SimpleElevator.Test
{
    internal class DummyTest
    {
        [Test]
        public void TestCoverage1()
        {
            var elevator = new Elevator(5);
            elevator.Dummy(5);
        }

        [Test]
        public void TestCoverage2()
        {
            var elevator = new Elevator(5);
            elevator.Dummy(16);
        }
    }
}
