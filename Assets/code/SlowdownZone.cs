using UnityEngine;

public class SlowdownZone : MonoBehaviour
{
    // Facteur de ralentissement
    public float slowdownFactor = 0.5f;

    // Méthode appelée lorsque d'autres colliders entrent dans cette zone
    private void OnTriggerStay2D(Collider2D other)
    {
        // Vérifie si le collider qui entre est associé à un Rigidbody2D
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // Ralentir l'objet en ajustant sa vélocité
            rb.velocity *= slowdownFactor;
        }
    }
}
