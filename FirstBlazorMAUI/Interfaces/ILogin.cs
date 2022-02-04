using FirstBlazorMAUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBlazorMAUI.Interfaces
{
    interface ILogin
    {
        Task<Login> Authenticate(UserMin user);
    }
}
