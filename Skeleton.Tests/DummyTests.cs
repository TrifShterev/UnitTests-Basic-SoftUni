using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyShouldLoseHealthIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(100,100);

        //Act
        dummy.TakeAttack(10);

        //Assert
        var expectedResult = 90;
        var actualResult = dummy.Health;

        Assert.AreEqual(expectedResult,actualResult);
    }
    [Test]
    public void DeadDummyShouldThrowExceptionIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 100);



        //Assert-Act


        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
    }
    [Test]
    public void DeadDummyShouldGiveXP()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 100);



        //Assert-Act
        var expectedResult = 100;
        var actualResult = dummy.GiveExperience();

        Assert.AreEqual(expectedResult, actualResult);
    }
    [Test]
    public void AliveDummyShouldNotGiveXP()
    {
        //Arrange
        Dummy dummy = new Dummy(100, 100);



        //Assert-Act
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }
}
