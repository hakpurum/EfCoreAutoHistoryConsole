using System.ComponentModel.DataAnnotations;

namespace EfCoreAutoHistoryConsole.Infrastructure
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}