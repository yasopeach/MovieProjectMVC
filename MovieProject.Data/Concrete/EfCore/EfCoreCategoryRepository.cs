using MovieProject.Data.Abstract;
using MovieProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, MovieProjectContext>, ICategoryRepository
    {
        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
