using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int currentHealth = 3;
    int health;

    private void Awake()
    {
        health = currentHealth;
    }

    public void EnemyTakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }    
}
