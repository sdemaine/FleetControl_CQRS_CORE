using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FluentValidation.Attributes;

namespace FleetControl.WebUI.ViewModels
{
    //[Validator(typeof(CredentialsViewModel))]
    public class CredentialsViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
