using CQRS_Library.Data;
using CQRS_Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Library.Repos
{
    public class itemRepository : IitemRepository
    {
        private readonly AppDbContext appDbContext;

        public itemRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public int DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<Items> GetItems()
        {
            throw new NotImplementedException();
        }

        public Items GetItems(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertItem(Items item)
        {
            throw new NotImplementedException();
        }

        public int UpdateItem(Items item)
        {
            throw new NotImplementedException();
        }
    }
}
