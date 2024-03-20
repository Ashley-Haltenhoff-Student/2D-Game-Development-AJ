using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float CactiTimer = 1.0f;
    public float WolfTimer = 4.0f;
    public GameObject cactiPrefab;
    public GameObject wolfPrefab;

    public GameObject[] cactiInstances;
    public GameObject wolf;
    public int numberOfInstances = 10;
    public int instanceIndex = 0;

    Vector2 startingPosition;

    private void Start()
    {
        startingPosition = gameObject.transform.position;

        cactiInstances = new GameObject[numberOfInstances];
        wolf = Instantiate(wolfPrefab, startingPosition, Quaternion.identity);
        wolf.SetActive(false);

        for (int i = 0; i < cactiInstances.Length; i++)
        {
            cactiInstances[i] = Instantiate(cactiPrefab, startingPosition, Quaternion.identity);
            cactiInstances[i].transform.position = startingPosition;
            cactiInstances[i].SetActive(false);
        }
    }

    void Update()
    {
        CactiTimer -= Time.deltaTime;
        WolfTimer -= Time.deltaTime;

        if (CactiTimer <= 0f)
        {
            SpawnCacti();
            CactiTimer = Random.Range(2.0f, 4.0f);
        }

        if (WolfTimer <= 0f)
        {
            SpawnWolf();
            WolfTimer = Random.Range(4.0f, 6.0f);
        }
    }

    void SpawnCacti()
    {
        cactiInstances[instanceIndex].SetActive(true);
        cactiInstances[instanceIndex].transform.position = startingPosition;
        instanceIndex++;
        if(instanceIndex == numberOfInstances) instanceIndex = 0;
    }

    void SpawnWolf()
    {
        wolf.SetActive(true);
        wolf.transform.position = startingPosition;
    }
}
