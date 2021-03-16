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
        [Fact]
        public void CollectionInitializers()
        {
            var favoriteNumbers = new List<int>()
            {
                9, 20, 108
            };
            Assert.Equal(20, favoriteNumbers[1]);

            var friends = new Dictionary<char, string>
            {
                { 's', "Sean Carlin" },
                { 'd', "David" },
                { 'j', "Jessika" }
            };
            Assert.Equal("David", friends['d']);

            friends['s'] = "Susan";
            friends['x'] = "Xander";

            // Assert.Equal("Yanne", friends['y']);

            Assert.True(friends.ContainsKey('d'));
            Assert.False(friends.ContainsKey('y'));

            
        }

        [Fact]
        public void EnumeratingCollections()
        {
            // Enumerating means "going through one at a time with a goal"
            var favoriteNumbers = new List<int>()
            {
                9, 20, 108
            };
            

            var friends = new Dictionary<char, string>
            {
                { 's', "Sean Carlin" },
                { 'd', "David" },
                { 'j', "Jessika" }
            };

            int total = 0;
            foreach(int current in favoriteNumbers)
            {
                total += current;
            }
            Assert.Equal(137, total);
        }
    }
}
