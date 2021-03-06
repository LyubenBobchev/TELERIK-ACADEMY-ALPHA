﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("First name cannot be null");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }


        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last name cannot be null");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }


    }
}
