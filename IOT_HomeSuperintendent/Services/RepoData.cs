using IOT_HomeSuperintendent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IOT_HomeSuperintendent.Services
{
    public class RepoData
    {
        public static int Add(Data data)
        {
            using (var db = new Context())
            {
                db.Datas.Add(data);
                return db.SaveChanges();
            }
        }

        public static List<Data> Get()
        {
            using (var db = new Context())
            {
                return db.Datas.ToList();
            }
        }

        public static List<Data> Get(Expression<Func<Data, bool>> predicate)
        {
            using (var db = new Context())
            {
                return db.Datas.Where(predicate).ToList();
            }
        }

        public static Data GetSingle(Expression<Func<Data, bool>> predicate)
        {
            using (var db = new Context())
            {
                return db.Datas.Where(predicate).Single();
            }
        }

        public static bool Exist(Expression<Func<Data, bool>> predicate)
        {
            using (var db = new Context())
            {
                return db.Datas.Any(predicate);
            }
        }
    }
}
