﻿using System;
using System.Runtime.CompilerServices;

namespace Postgrest.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKeyAttribute : Attribute
    {
        public string ColumnName { get; set; }

        public PrimaryKeyAttribute([CallerMemberName] string columnName = null)
        {
            ColumnName = columnName;
        }
    }
}
