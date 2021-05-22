using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMapping
{
    public class EfPersonelDal : IPersonelDal
    {
        public List<Personel> GetAll()
        {
            using(NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Personel>().ToList();
            }
        }
    }
}
