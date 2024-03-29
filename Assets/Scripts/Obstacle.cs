using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Parallax.Layer layer;
    public float destroyObstaclePoint = -15.0f;

    void Update()
    {
        Vector2 currentPosition = gameObject.transform.position;
        Vector2 targetPosition = new Vector2(destroyObstaclePoint, currentPosition.y);
        gameObject.transform.position = Vector2.MoveTowards(currentPosition, targetPosition, Parallax.GetSpeed(layer) * Time.deltaTime);

        if (currentPosition == targetPosition)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health.TryDamageTarget(collision.gameObject, 1);
    }
}
