﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp1
{
        class SchoolContext : DbContext
        {
                public SchoolContext() : base()
                {

                }

                public DbSet<Student> Students { get; set; }
                public DbSet<Grade> Grades { get; set; }
        }
}
