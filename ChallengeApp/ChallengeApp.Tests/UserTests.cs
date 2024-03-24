namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrange 
            Employee user1 = new Employee("Daniel", "Kowalski", 35);
            user1.AddScore(5);
            user1.AddScore(-5);
            // act
            var result = user1.result;
            // assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void WhenUserCollectThreeScores_ShouldCorrectResul()
        {
            // arrange 
            Employee user1 = new Employee("Daniel", "Kowalski", 35);
            user1.AddScore(5);
            user1.AddScore(-5);
            user1.AddScore(5);
            // act
            var result = user1.result;
            // assert
            Assert.AreEqual(5, result);
            
        }
        [Test]
        public void WhenThreeUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrange 
            Employee user1 = new Employee("Daniel", "Kowalski", 35);
            Employee user2 = new Employee("Monika", "Nowak", 33);
            Employee user3 = new Employee("Lena", "Duda", 18);
            user1.AddScore(5);
            user1.AddScore(-5);
            user2.AddScore(5);
            user2.AddScore(-5);
            user3.AddScore(5);
            user3.AddScore(-5);
            // act
            var result = user1.result;
            var result1 = user2.result;
            var result2 = user3.result;
            // assert
            Assert.AreEqual(result1, result, result2);
            
        }
    }

}