using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData.Entities
{
    public class TestDataRepository : ITestDataRepository
    {
        private readonly TestDataContext _context;

        public TestDataRepository(TestDataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<TestDataL1[]> GetAllTestDataAsync()
        {
            IQueryable<TestDataL1> query = _context.TestDatas;
            query = query.OrderByDescending(c => c.TestDataId);
            return await query.ToArrayAsync();
        }

        public async Task<TestDataL1> GetTestDataById(int id)
        {
            IQueryable<TestDataL1> query = _context.TestDatas.Where(c => c.TestDataId == id);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
