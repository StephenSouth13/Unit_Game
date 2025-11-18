using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerModelTest
{
    // 1 test case: TakeDamage reduces health correctly
    [Test]
    public void TakeDamage_ReducesHealth()
    {
        // Arrange
        var playerModel = new PlayerModel(100f);
        
        // Act
        playerModel.TakeDamage(30f);
        
        // Assert
        Assert.AreEqual(70f, playerModel.health);
    }
    
    // 2 test case: Heal increases health correctly
    [Test]
    public void Heal_IncreasesHealth()
    {
        // Arrange
        var playerModel = new PlayerModel(100f);
        playerModel.TakeDamage(50f);
        
        // Act
        playerModel.Heal(30f);
        
        // Assert
        Assert.AreEqual(80f, playerModel.health);
    }
    
    
    
    
    
    
    // A Test behaves as an ordinary method
    [Test]
    public void PlayerModelTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PlayerModelTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
