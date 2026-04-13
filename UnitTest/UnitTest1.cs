using ClassLibary;
using REST_DanmarksRadio.Models;

namespace UnitTest
{
    public class UnitTest1
    {
        private Repository _repository;

        public UnitTest1()
        {
            _repository = new Repository();
        }


        [Fact]
        public void GetAll_Test()
        {
            var all = _repository.GetAll();
            Assert.Equal(3, all.Count);
        }
    }
}
