using System;
using System.Threading.Tasks;

namespace UnitOfWork
{
    public class BaseUnitOfWork : BaseAbstractionUnitOfWork
    {
        public override Task<int> SaveChangesAsync()
        {
            Console.WriteLine("Saved");
            return new Task<int>(() => 0);
        }
    }
}