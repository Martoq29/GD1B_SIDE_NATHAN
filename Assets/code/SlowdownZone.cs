using UnityEngine;

public class SlowdownZone : MonoBehaviour
{
    // Facteur de ralentissement
    public float slowdownFactor = 0.5f;

    // M�thode appel�e lorsque d'autres colliders entrent dans cette zone
    private void OnTriggerStay2D(Collider2D other)
    {
        // V�rifie si le collider qui entre est associ� � un Rigidbody2D
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // Ralentir l'objet en ajustant sa v�locit�
            rb.velocity *= slowdownFactor;
        }
    }
}
