using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaLoja.ViewModels
{
    public class UserView
    {
         public string UserId { get; set; }
        public string Nome { get; set; }

        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        


    }
}