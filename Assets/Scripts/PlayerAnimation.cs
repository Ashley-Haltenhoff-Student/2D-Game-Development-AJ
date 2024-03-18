using UnityEngine;


[RequireComponent (typeof(Player))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class PlayerAnimation : MonoBehaviour
{
    Player player;
    Animator animator;
    Rigidbody2D rigidbody;

    public GameObject particlePrefab;
    public ParallaxLayer layer;


    void Start()
    {
        player = GetComponent<Player>();
        animator = GetComponent<Animator>();   
        rigidbody = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        animator.SetBool("Falling", player.isFalling);
        animator.SetFloat("YVelocity", rigidbody.velocity.y);
    }

    public void Smoke()
    {
        Instantiate(particlePrefab, transform.position, Quaternion.identity);
    }
}
