using Server.Models;

namespace Server
{
    public class PersonCreator
    {
        public List<Person> CreateList()
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person()
            {
                Name = "Nick",
                Age = 25,
                Sex = "Male",
                Car = new Car()
                {
                    Model = "Kia Cee'd II",
                    Plate = "3785AC-4",
                    Volume = 1600,
                    CreateYear = 2012
                },
            });

            persons.Add(new Person()
            {
                Name = "Mike",
                Age = 21,
                Sex = "Male",
                Car = new Car()
                {
                    Model = "Jeep Compass I",
                    Plate = "9365OT-4",
                    Volume = 2400,
                    CreateYear = 2006
                },
            });

            persons.Add(new Person()
            {
                Name = "Hanna",
                Age = 23,
                Sex = "Female",
                Car = new Car()
                {
                    Model = "Toyota Camry XV70",
                    Plate = "9362KE-4",
                    Volume = 2500,
                    CreateYear = 2020
                },
            });

            return persons;
        }

        public Person CreatePerson()
        {
            return new Person()
            {
                Name = "Karen",
                Age = 30,
                Sex = "Female",
                Car = new Car()
                {
                    Model = "Mercedes-Benz CLA C117",
                    Plate = "6172PM-4",
                    Volume = 1500,
                    CreateYear = 2020
                },
            };
        }
    }
}
