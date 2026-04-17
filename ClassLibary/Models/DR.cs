namespace ClassLibary.Models
{
    public class DR
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public int Duration { get; set; }
        public int PublishedYear { get; set; }

        public override string ToString()
        {
            return $"DR: Id={Id}, Title={Title}, Artist={Artist}, Duration={Duration}, PublishedYear={PublishedYear}";
        }

    }
}

