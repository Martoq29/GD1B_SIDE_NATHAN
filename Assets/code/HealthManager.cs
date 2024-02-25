using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    // M�thode pour r�duire la sant� du joueur
    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        health = Mathf.Max(health, 0); // S'assurer que la sant� ne devient pas n�gative
        UpdateHeartsDisplay();
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    // M�thode pour mettre � jour l'affichage des c�urs de sant�
    void UpdateHeartsDisplay()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
