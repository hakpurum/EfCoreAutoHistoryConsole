using EfCoreAutoHistoryConsole.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EfCoreAutoHistoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SampleDbContext())
            {
                var detail = db.Users.FirstOrDefault(f => f.Id == 1);
                //detail.Name = "Hasan";
                //detail.Surname = "Akpürüm Update";
                db.Users.Remove(detail);

                db.EnsureAutoHistory();
                db.SaveChanges();
            }
        }
    }
}
