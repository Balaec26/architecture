using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DataAccess;
using AutoMapper;
namespace Mapping
{
    class LoginProfile:Profile
    {
       
       public LoginProfile()
        {
            CreateMap<Login, tbl_login_status>();
           
        }

    }
}
