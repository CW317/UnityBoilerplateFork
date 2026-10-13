using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindAnyObjectByType<LevelUIController>().Collect();
            // destroy the collectible once it is touched
            Destroy(gameObject);
        }
    }
}
