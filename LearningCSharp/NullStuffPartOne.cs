using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class NullStuffPartOne
    {

        [Fact]
        public void ConditionalAssignment()
        {
            var age = 20;
            string message = age >= 21 ? "Old Enough" : "Too Young";
            //if(age>= 21)
            //{
            //    message = "Old Enough";
            //} else
            //{
            //    message = "Too Young";
            //}
            
            Assert.Equal("Too Young", message);
        }
        [Fact]
        public void NullCoalescingOperator()
        {
            string firstName = null, lastName = null;

            string preferredName = firstName ?? lastName ?? "Unknown";
            //if(firstName == null)
            //{
            //    preferredName = lastName;
            //} else
            //{
            //    preferredName = firstName;
            //}

            Assert.Equal("Unknown", preferredName);
        }
        [Fact]
        public void ElvisOperator()
        {
            Dinner d = new Dinner { MainCourse = "Tacos" };

            var mainCourse = d?.MainCourse ?? "None Assigned";
            //if(d != null)
            //{
            //    mainCourse = d.MainCourse;
            //} else
            //{
            //    mainCourse = "Non Assigned";
            //}

            Assert.Equal("None Assigned", mainCourse);
        }
    }
}
