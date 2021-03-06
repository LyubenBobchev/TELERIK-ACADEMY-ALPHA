﻿using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;

namespace Traveller.Commands.Creating
{
    public class ListTicketsCommand : ICommand
    {
        private readonly IDatabase database;

        public ListTicketsCommand(IDatabase database)
        {
            Guard.WhenArgument(database, "database");

            this.database = database;
        }

        public string Execute(IList<string> parameters)
        {
            var tickets = this.database.Tickets;

            if (tickets.Count == 0)
            {
                return "There are no registered tickets.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, tickets);
        }
    }
}
