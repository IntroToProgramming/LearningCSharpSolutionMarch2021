using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class GenericCollections
    {
        [Fact]
        public void FavoriteNumbersAgain()
        {
            // Parametric Polymorphism
            var favoriteNumbers = new List<int>();
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(20);

            var firstTwo = favoriteNumbers[0] + favoriteNumbers[1];

            Assert.Equal(29, firstTwo);

        }

        [Fact]
        public void UsingADictionary()
        {
            var mealPlan = new Dictionary<string, Dinner>();

            mealPlan.Add("tuesday", new Dinner()
            {
                MainCourse = "Pizza"
            });
            mealPlan.Add("monday", new Dinner()
            {
                MainCourse = "Peanut Noodles with Tofu"
            });

            Assert.Equal("Pizza", mealPlan["tuesday"].MainCourse);

        }
        
    }
}
