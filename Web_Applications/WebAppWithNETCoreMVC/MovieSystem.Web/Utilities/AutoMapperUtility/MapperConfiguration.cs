using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSystem.Web.Utilities.AutoMapperUtility
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
