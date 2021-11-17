using Microsoft.EntityFrameworkCore;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public class Applicationcontext:DbContext
    {
        public Applicationcontext(DbContextOptions<Applicationcontext> options) : base(options)
        {
        }
        public DbSet<StudentDetails> StudentDetails { get; set; }
    
    }
}
