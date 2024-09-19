using PersonDbLib;

namespace PersonDbTesting
{
    public class APersonRepository
    {
        

        [Test]
        public void CanCreateANewPersonInTheDatabase()
        {
            IMPersonDbContext context = new();
            using var db = context.CreateContext();
            IPersonRepository sut = new DbPersonRepository(db);
           
            Person p = new()
            {
                Id = 0,
                DateOfBirth = DateTime.Now,
                MiddleName = "J",
                LastName = "R",
                FirstName = "W"
            };

            Person savedPerson = sut.Create(p);
            Assert.That(savedPerson.FirstName, Is.EqualTo("W"));
            Assert.That(savedPerson.Id, Is.Not.EqualTo(0));
            Assert.Pass();
        }
    }
}