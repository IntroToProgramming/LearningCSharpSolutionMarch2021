using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class PropertiesOnClasses
    {
        [Fact]
        public void UsingProperties()
        {
            var cust = new Customer()
            {
                FirstName = "Joe",
                LastName = "Schmidt"
            };
          
            Assert.Equal("Joe", cust.FirstName);
            Assert.Equal("Schmidt", cust.LastName);
        }
    }

    public class Customer
    {
        // state & behavior (data, code)
        private string _firstName; // "backing Field"

       

        public string FirstName // "property"
        {
            get { return _firstName;  }
            set { _firstName = value; }
        }

        public string LastName { get;  set; }

        public decimal CreditLimit { get; private set; } = 5000;

        public string GetInfo()
        {
            return $"This is {FirstName} {LastName} and their Credit Limit Is {CreditLimit:c}";
        }

    }
}
