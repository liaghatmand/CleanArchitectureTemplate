using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string? PostalCode;
        public string? country;
        public string? State;
        public string? City;
        public string? Street;
        public string? No;
    }
}
