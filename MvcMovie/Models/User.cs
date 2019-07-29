using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class User
    {
        public string ID {get; set;}
        public string Username {get; set;}
        public string Email{get;set;}
    }
}