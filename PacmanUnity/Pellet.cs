using UnityEngine;

public class Pellet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "PacMan")
        {
            GameManager.instance.AddScore(10);
            Destroy(gameObject);
        }
    }
}