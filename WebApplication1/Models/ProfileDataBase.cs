using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProfileDataBase
    {
        public static List<Profile> Profiles = new List<Profile>(
            new []
            {
                new Profile { Id = 1, Name = "Tomas", Age = 17 },
                new Profile { Id = 2, Name = "Joana", Age = 18 }
            }
        );
        public static bool Add(int id, string name, int age)
        {
            if (id>Profiles.Count())
            {
                Profiles.Add(new Profile() { Id = id, Name = name, Age = age });
                return true;
            }
            return false;
        }
    }
}
