using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 3;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print($"Took Damage - Current Health: {health}");

        if (health <= 0)
        {
            GameManager.instance.Restart();
        }
    }

    public static void TryDamageTarget(GameObject target, int damage)
    {
        Health targetHealth = target.GetComponent<Health>();

        if (targetHealth)
        {
            targetHealth.TakeDamage(damage);
        }
    }
}
