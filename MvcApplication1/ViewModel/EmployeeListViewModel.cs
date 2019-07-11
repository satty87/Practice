using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.ViewModel
{
    public class EmployeeListViewModel
    {
        public List<EmployeeListViewModel> employees {get;set;}
        public string UserName { get; set; }
    }
}