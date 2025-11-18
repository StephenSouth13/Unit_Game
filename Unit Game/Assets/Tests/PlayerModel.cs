using UnityEngine;

public class PlayerModel 
{
    public float health { get; private set; }
    public float maxHealth { get; private set; }
    
    public bool IsDead => health <= 0;
    
    public PlayerModel(float maxHealth)
    {
        this.maxHealth = maxHealth;
        this.health = maxHealth;
    }
    
    public void TakeDamage(float damage)
    {
        if(damage < 0) return;
        health -= damage;
        if (health < 0) health = 0;
    }
    
    public void Heal(float amount)
    {
        if(amount < 0) return;
        health += amount;
        if (health > maxHealth) health = maxHealth;
    }
    
    public Vector3 CalculateMovement(float horizontalInput, float verticalInput, 
        float speed, float deltaTime)
    {
        return new Vector3(horizontalInput, verticalInput, 0f) * speed * deltaTime;
    }
}
