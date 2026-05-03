namespace WebMVCR1.Models
{
    public class PersonRepository
    {
        private List<Person> persons = new List<Person>();

        public int NumberOfPersons
        {
            get
            {
                return persons.Count;
            }
        }

        public IEnumerable<Person> GetAllPersons
        {
            get
            {
                return persons;
            }
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
    }

    
}
