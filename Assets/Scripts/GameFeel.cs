using UnityEngine;

public class GameFeel : MonoBehaviour
{
    public static GameFeel instance;

    public float cameraShakeTime = 0f;

    Vector3 cameraStartingPoint;

    void Awake()
    {
        if (instance) Destroy(this);
        else instance = this;
    }

    private void Start()
    {
        cameraStartingPoint = Camera.main.transform.position;
    }

    public static void AddCameraShake(float time)
    {
        if (instance)
        {
            instance.cameraShakeTime = time;
        }
    }

    void Update()
    {
        if (cameraShakeTime > 0f)
        {
            cameraShakeTime -= Time.deltaTime;
            Vector3 newCameraPosition = new Vector3();
            newCameraPosition.x = Random.Range(-0.001f, 0.1f);
            newCameraPosition.y = Random.Range(3.56f, 3.76f);
            newCameraPosition.z = -10;
            Camera.main.transform.position = newCameraPosition;
             
        }
        else Camera.main.transform.position = cameraStartingPoint;
    }
}
