﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class User
    {
        public string Name { get; set; }
       
        public void DisplayBooks(Library library)
        {
            library.Display();
        }
    }
}
