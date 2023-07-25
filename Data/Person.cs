using System.ComponentModel.DataAnnotations;

namespace CreateCRUDOperation.Data
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
