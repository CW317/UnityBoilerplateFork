using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindAnyObjectByType<LevelUIController>().Collect(points);
            // destroy the collectible once it is touched
            Destroy(gameObject);
        }
    }
}
