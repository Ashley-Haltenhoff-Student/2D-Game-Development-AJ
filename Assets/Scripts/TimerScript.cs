using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float timer = 1.0f;
    public GameObject prefab;

    Vector2 startingPosition;

    private void Start()
    {
        startingPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnObstacle();
            timer = Random.Range(1.0f, 2.0f);
        }
    }

    void SpawnObstacle()
    {
        Instantiate(prefab, startingPosition, Quaternion.identity);
    }
}
