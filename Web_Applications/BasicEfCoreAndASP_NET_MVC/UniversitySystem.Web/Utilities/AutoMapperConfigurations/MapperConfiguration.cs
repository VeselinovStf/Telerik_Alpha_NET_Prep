using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySystem.Web.Utilities.AutoMapperConfigurations
{
    public class MapperConfiguration
    {
        public static void Config()
        {
            AutoMapper.Mapper.Initialize(prof =>
            {
                prof.AddProfile<MappingProfile>();
            });
        }
    }
}
