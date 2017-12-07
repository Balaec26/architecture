using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Mapping
{
    public class AutoMapperConfiguration
    {
        public static void config()
        {
            Mapper.Initialize(x =>
            {
              x.AddProfile<LoginProfile>();
            });
        }

    }
}
