﻿using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName,int hoursWorked)
        {
            this.HoursWorked = hoursWorked;
            this.PartName = partName;
        }
        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }
        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}
