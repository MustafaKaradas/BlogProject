﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Models.VMs.RegisterVM
{
    public class RegisterConfirmMailVm
    {
        public string Email { get; set; }
        public int ConfirmCode { get; set; }
    }
}
