using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 3;

    public void TakeDamage(int damage)
    {
        health -= damage;
        GameFeel.AddCameraShake(0.1f);

        print($"Took Damage - Current Health: {health}");

        if (health <= 0)
        {
            GameManager.instance.EndGame();
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
