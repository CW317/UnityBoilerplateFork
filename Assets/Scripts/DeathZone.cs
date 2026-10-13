using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform ResawnPoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            var controller = FindAnyObjectByType<LevelUIController>();
            controller.Kill();
            other.transform.position = ResawnPoint.position;
        }
    }
}
