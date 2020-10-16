using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [key] // Add ID automatically as an ID column
        public int Id { get; set; }

        [Required] // Name cannot be null
        public string Name { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}
