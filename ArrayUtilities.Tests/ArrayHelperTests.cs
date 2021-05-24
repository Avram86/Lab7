using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayUtilities.Tests
{
    public class ArrayHelperTests
    {
        [Fact]
        public void Min_When_ArrayIsNull_Expect_ReturnsIntMinValue()
        {
            //Arrange(prepare data for tests)
            int[] array = null;

            //Act(chestia care 3 testat)
            int min = ArrayHelper.Min(array);

            //Assert(facem verificarile ca lucrurile au funct asa cum trebuie)
            Assert.Equal(int.MinValue, min);
        }

        [Fact]
        public void Min_When_ArrayIsEmpty_Expect_ReturnsIntMinValue()
        {
            //Arrange(prepare data for tests)
            int[] array = new int[0];

            //Act(chestia care 3 testat)
            int min = ArrayHelper.Min(array);

            //Assert(facem verificarile ca lucrurile au funct asa cum trebuie)
            Assert.Equal(int.MinValue, min);
        }

        [Fact]
        public void Min_When_ArrayHasOnelElement_Expect_ReturnsThatElement()
        {
            //Arrange(prepare data for tests)
            int[] array = new int[] { 100};

            //Act(chestia care 3 testat)
            int min = ArrayHelper.Min(array);

            //Assert(facem verificarile ca lucrurile au funct asa cum trebuie)
            Assert.Equal(array[0], min);
        }

        [Fact]
        public void Min_When_ArrayManyElements_Expect_ReturnsminumumElement()
        {
            //Arrange(prepare data for tests)
            int[] array = new int[] { 100 , -50, 500, -120};

            //Act(chestia care 3 testat)
            int min = ArrayHelper.Min(array);

            //Assert(facem verificarile ca lucrurile au funct asa cum trebuie)
            Assert.Equal(-120, min);
        }

        [Fact]
        public void Max_When_ArrayIsNull_Expect_ReturnsIntMinValue()
        {
            //Arrange(prepare data for tests)
            int[] array = null;

            //Act(chestia care 3 testat)
            int max = ArrayHelper.Max(array);

            //Assert(facem verificarile ca lucrurile au funct asa cum trebuie)
            Assert.Equal(int.MaxValue, max);
        }

        [Fact]
        public void Max_When_ArrayIsEmpty_Expect_ReturnsIntMinValue()
        {
            //Arrange(prepare data for tests)
            int[] array = new int[0];

            //Act(chestia care 3 testat)
            int max = ArrayHelper.Max(array);

            //Assert(facem verificarile ca lucrurile au funct asa cum trebuie)
            Assert.Equal(int.MaxValue, max);
        }

        [Fact]
        public void Max_When_ArrayHasOnelElement_Expect_ReturnsThatElement()
        {
            //Arrange(prepare data for tests)
            int[] array = new int[] { 100 };

            //Act(chestia care 3 testat)
            int max = ArrayHelper.Max(array);

            //Assert(facem verificarile ca lucrurile au funct asa cum trebuie)
            Assert.Equal(array[0], max);
        }

        [Fact]
        public void Max_When_ArrayManyElements_Expect_ReturnsminumumElement()
        {
            //Arrange(prepare data for tests)
            int[] array = new int[] { 100, -50, 500, -120 };

            //Act(chestia care 3 testat)
            int max = ArrayHelper.Max(array);

            //Assert(facem verificarile ca lucrurile au funct asa cum trebuie)
            Assert.Equal(500, max);
        }
    }
}
