using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    public new Rigidbody2D rigidbody;
    public float jumpForce = 10.0f;
    public bool isFalling = true;



    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (!isFalling)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector2 forceDirection = transform.up;

                rigidbody.AddForce(forceDirection * jumpForce, ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isFalling = false;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0.0f;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isFalling = true;
        }
    }
}
