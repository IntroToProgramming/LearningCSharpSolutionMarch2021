using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class OldSkoolCollections
    {
        [Fact]
        public void FavoriteNumbersList()
        {
            var favoriteNumbers = new ArrayList();
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(20);
            favoriteNumbers.Add(42);
            favoriteNumbers.Add(108);

            Assert.Equal(9, favoriteNumbers[0]);
            Assert.Equal(108, favoriteNumbers[3]);
            favoriteNumbers[1] = 22;
            Assert.Equal(22, favoriteNumbers[1]);
           // favoriteNumbers[0] = "Tacos";
            int firstTwo = ((int)favoriteNumbers[0]) + ((int) favoriteNumbers[1]);

            Assert.Equal(31, firstTwo);
        }
    }
}
