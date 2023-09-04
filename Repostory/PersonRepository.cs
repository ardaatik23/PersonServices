
using PersonServices.WebApp.Models;

namespace PersonService.WebApp.Repository;

public class PersonRepository
{
    private readonly List<Person> _persons;
    public PersonRepository()
    {
        _persons = new List<Person>()
        {
            // Anonymous class
            new Person()
            {
                Id = 1,
                Name = "Arda",
                Surname= "Atik",
                Email= "arda@gmail.com",
                Age= 22,
                Phone = "0555555555"
            },
             new Person()
            {
               Id = 2,
                Name = "Mauro",
                Surname= "Icardi",
                Email= "mauro@gmail.com",
                Age= 22,
                Phone = "050000330"
            },
                   new Person()
            {
                Id =3,
                Name = "Muhammed",
                Surname= "Puşulu",
                Email= "muhammed@gmail.com",
                Age= 22,
                Phone = "0555555"
            },
       new Person()
            {
                Id = 4,
                Name = "Mauro",
                Surname= "Icardi",
                Email= "mauro@gmail.com",
                Age= 28,
                Phone = "050000330"
            }
        };
    }

    public List<Person> GetAll()
    {
        return _persons;
    }

    public void Add(Person person)
    {
        _persons.Add(person);
    }

    public Person GetById(int id)
    {
        // Düz yöntem 
        //foreach (Person person in _persons)
        //{
        //    if (person.Id == id)
        //    {
        //        return person;
        //    }
        //}
        //return new Person()
        //{
        //    Name = "Boş",
        //    Age = 0,
        //    Email = "Boş",
        //    Phone = "Boş",
        //    Id = id,
        //    Surname = "Boş"
        //};

        var person = _persons.FirstOrDefault(x => x.Id == id);
        if (person == null)
        {
            return new Person()
            {
                Name = "Boş",
                Age = 0,
                Email = "Boş",
                Phone = "Boş",
                Id = id,
                Surname = "Boş"
            };
        }
        return person;


    }

    public List<Person> GetAllByPersonOfAgeRange(int min, int max)
    {

        //List<Person> result = new List<Person>();

        //foreach (var x in _persons)
        //{
        //    if (x.Age>=min && x.Age<=max)
        //    {
        //        result.Add(x);
        //    }

        //}
        //return result;
        //return _persons.Where(x => x.Age >= min && x.Age <= max).ToList(); minimum ve max degerleri döndür.

        return _persons.ToList();
    }

}