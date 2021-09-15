using System;
using System.Collections.Generic;
using System.Linq;

namespace ManualCacheSystem
{
    class Program
    {
        public static List<UserDetails> UserDetails;
        static void Main(string[] args)
        {
            
        }
    }

    public class UserDetails
    {
        public Guid Id { get; set; }
        public  string Name { get; set; }
    }

    public class CacheSystem
    {
        private static Dictionary<int, dynamic> Storage { get; set; }
        private static Dictionary<int, int> LRU { get; set; }

        public void StoreData(dynamic data)
        {
            if(!Storage.ContainsKey(data.GetHashCode()))
            {
                Storage.Add(data.GetHashCode(), data);
            }
        }

        public object GetData(Guid id)
        {
            return Storage.Values.FirstOrDefault(x => x.Id == id);
        }
    }
}
