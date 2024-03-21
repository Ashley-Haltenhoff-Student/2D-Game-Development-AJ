using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Health playerHealth;
    public Image[] heartImages;
    public Image[] heartBreakingImages;
    int health = 0;


    void Update()
    {

        if (!playerHealth) return;

        if (health != playerHealth.health) UpdateHealth();
    }

    void UpdateHealth()
    {
        health = playerHealth.health;

        for (int i = 0; i < heartImages.Length; i++)
        {
            if (i < health) heartImages[i].enabled = true;
            else heartImages[i].enabled = false;
        }
    }
}
