﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.Models;

namespace VCart.BLL.Interfaces
{
    public interface IRoleBL
    {
        List<Role> GetRoles();
    }
}
