namespace TestApartment
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          //  FakeContext fakeContext = new FakeContext();
        public ApartmentController controller = new ApartmentController();

        [Fact]
        private void GetAll_ReturnList()
        {
            //AAA

            //ARRANGE
            // declare the parameters to post to fun

            //ACT
            // action the fun
          //  var controller = new ApartmentController();
            var result = controller.Get();
            //ASSERT
            // assert what is the expted ressult
            Assert.IsType<List<Apartment>>(result);
        }

        [Fact]
        private void GetAll_ReturnCount()
        {
            //AAA

            //ARRANGE
            // declare the parameters to post to fun

            //ACT
            // action the fun
            var controller = new ApartmentController();
            var result = controller.Get();
            //ASSERT
            // assert what is the expted ressult
            Assert.Equal(3, result.Count());
        }
    }
    }
}