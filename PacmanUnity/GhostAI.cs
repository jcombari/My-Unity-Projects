using UnityEngine;

public class GhostAI : MonoBehaviour
{
    public float speed = 3f;
    private Vector2[] directions = { Vector2.up, Vector2.down, Vector2.left, Vector2.right };
    private Vector2 currentDirection;

    void Start()
    {
        ChangeDirection();
    }

    void FixedUpdate()
    {
        transform.Translate(currentDirection * speed * Time.fixedDeltaTime);
    }

    void ChangeDirection()
    {
        currentDirection = directions[Random.Range(0, directions.Length)];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall") || other.CompareTag("Edge"))
            ChangeDirection();

        if (other.name == "PacMan")
        {
            GameManager.instance.LoseLife();
        }
    }
}