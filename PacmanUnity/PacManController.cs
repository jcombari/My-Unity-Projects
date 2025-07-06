using UnityEngine;

public class PacManController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 direction = Vector2.zero;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) direction = Vector2.up;
        else if (Input.GetKey(KeyCode.DownArrow)) direction = Vector2.down;
        else if (Input.GetKey(KeyCode.LeftArrow)) direction = Vector2.left;
        else if (Input.GetKey(KeyCode.RightArrow)) direction = Vector2.right;
    }

    void FixedUpdate()
    {
        transform.Translate(direction * moveSpeed * Time.fixedDeltaTime);
    }
}