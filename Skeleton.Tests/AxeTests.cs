using NUnit.Framework;
using System;
[TestFixture]
public class AxeTests
{//По този начин може да създаваме различни test cases
    [Test]
    [TestCase(100, 100, 100, 100, 99)]
    public void Weapon_Should_Lose_Durability_After_Attack(
        int health,
        int exp, 
        int attack, 
        int durability, 
        int expectedResult)
    {
        //Arrange
        
        Dummy dummy = new Dummy(health, exp);
        Axe axe = new Axe(attack, durability);

        //Act
        axe.Attack(dummy);

        //Assert
        
        var actualResult = axe.DurabilityPoints;

        Assert.AreEqual(expectedResult,actualResult);
    }
    [Test]
    public void AttackShouldThrowInvalidOperetaionExceptionWhenAxeDurabilityIsBelowZero()
    {
        //Arrange
        Dummy dummy = new Dummy(10, 10);
        Axe axe = new Axe(20,0);

        //Act-Assert
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));

        
    }
}