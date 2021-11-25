using IOT_HomeSuperintendent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IOT_HomeSuperintendent.Services
{
    public class RepoIOTDevice
    {
        public static int Add(IOTDevice device)
        {
            using (var db = new Context())
            {
                db.IOTDevices.Add(device);
                return db.SaveChanges();
            }
        }
        public static async Task<int> AddAsync(IOTDevice device)
        {
            using (var db = new Context())
            {
                Context context = new Context();
                context.IOTDevices.Update(device);

                return await context.SaveChangesAsync();
            }
        }

        public static List<IOTDevice> Get()
        {
            using (var db = new Context())
            {
                return db.IOTDevices.ToList();
            }
        }

        public static List<IOTDevice> Get(Expression<Func<IOTDevice, bool>> predicate)
        {
            using (var db = new Context())
            {
                return db.IOTDevices.Where(predicate).ToList();
            }
        }

        public static IOTDevice GetSingle(Expression<Func<IOTDevice, bool>> predicate)
        {
            using (var db = new Context())
            {
                return db.IOTDevices.Where(predicate).Single();
            }
        }

        public static bool Exist(Expression<Func<IOTDevice, bool>> predicate)
        {
            using (var db = new Context())
            {
                return db.IOTDevices.Any(predicate);
            }
        }
    }
}
