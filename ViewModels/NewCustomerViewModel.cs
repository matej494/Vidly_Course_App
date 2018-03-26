using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Course_App.Models;

namespace Vidly_Course_App.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}