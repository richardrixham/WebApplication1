﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class EmployeeListViewModel:BaseViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
    }
}
