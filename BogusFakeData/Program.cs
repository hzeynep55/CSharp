using Bogus;
using Bogus.DataSets;
using BogusFakeData.Entities;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;



namespace BogusFakeData
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Lorem paragraph = new Lorem();

            #region Manuel Olarak Fake Data Üretmek
            Random random = new Random();
            var UsersData = new Users()
            {
                Id = Guid.NewGuid(),
                Firstname = "Hanne Zeynep",
                Lastname = "Durhat",
                Age = random.Next(18, 65),
                Nickname = "hzeynep",
                Gender = Name.Gender.Female,
                Address = new Addres()
                {
                    City = "İstanbul",
                    PostCode = "33450",
                    Neighbourhood = "Ferahevler",
                    //Country="Turkiye",
                    StreetName = "Adnan Kahveci Cd."


                }



            };
            #endregion

            #region Bogus İle Fake Data Üretmek
            var addresFaker = new Faker<Addres>("tr")
                .RuleFor(i => i.City, i => i.Address.City())
                // .RuleFor(i => i.Country, i => i.Address.Country())
                .RuleFor(i => i.Neighbourhood, i => i.Address.FullAddress())
                .RuleFor(i => i.PostCode, i => i.Address.ZipCode())
                .RuleFor(i => i.StreetName, i => i.Address.StreetName());

            var userFaker = new Faker<Users>()
            .RuleFor(i => i.Address, addresFaker)
            // .RuleFor(h => h.Address.Country, h => h.Address.Country())
            .RuleFor(i => i.Age, i => i.Random.Int(18, 65))
            .RuleFor(i => i.Firstname, i => i.Person.FirstName)
            .RuleFor(i => i.Lastname, i => i.Person.LastName)
            .RuleFor(i => i.Nickname, (h, j) => h.Internet.UserName(j.Firstname, j.Lastname))
            .RuleFor(i => i.Id, i => i.Random.Guid())
            .RuleFor(i => i.Mail, i => i.Person.Email);
            //.RuleFor(i => i.Gender, i => i.PickRandom<Gender>());

            //Json Tipinde veriyi ekrana yazdırma

            var GeneretedObject = userFaker.Generate(4);
            var opt = new JsonSerializerOptions()
            {
                WriteIndented= true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)

            };

            string value=JsonSerializer.Serialize(GeneretedObject, opt );
            var test = paragraph.Lines(5);
            Console.WriteLine(test);
            Console.WriteLine(value);



            #endregion

        }
    }
}