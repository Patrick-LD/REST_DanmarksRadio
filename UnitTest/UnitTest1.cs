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

        [Fact]
        public void GetById_Test()
        {
            var dr = _repository.GetById(1);
            Assert.NotNull(dr);
            Assert.Equal("Smells Like Teen Spirit", dr.Title);
        }

        [Fact]
        public void GetByTitle_Test()
        {
            var drs = _repository.GetByTitle("Bohemian Rhapsody");
            Assert.Single(drs);
            Assert.Equal("Queen", drs[0].Artist);

        }

        [Fact]
        public void Add_Test()
        {
            var newDr = new DR
            {
                Title = "Hotel California",
                Artist = "Eagles",
                Duration = 391,
                PublishedYear = 1977
            };

            var result = _repository.Add(newDr);

            Assert.NotNull(result);
            Assert.Equal(4, result.Id);
            Assert.Equal("Hotel California", result.Title);
            Assert.Equal("Eagles", result.Artist);
            Assert.Equal(4, _repository.GetAll().Count);
        }
    }
}
