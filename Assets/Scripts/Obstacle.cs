using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Obstacle : MonoBehaviour
{
    public float speed = 5.0f;
    public float destroyObstaclePoint = -15.0f;


    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = gameObject.transform.position;
        Vector2 targetPosition = new Vector2(destroyObstaclePoint, currentPosition.y);
        gameObject.transform.position = Vector2.MoveTowards(currentPosition, targetPosition, speed * Time.deltaTime);

        if (currentPosition == targetPosition)
        {
            Destroy(gameObject);
        }
    }
}
