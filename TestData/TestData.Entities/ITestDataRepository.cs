using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData.Entities
{
    public interface ITestDataRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        Task<TestDataL1[]> GetAllTestDataAsync();
        Task<TestDataL1> GetTestDataById(int id);
    }
}
