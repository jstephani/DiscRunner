using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public Transform parent;
    public GameObject tombstone;
    public GameObject coin;
    public GameObject spike;
    private GameObject[] objects;
    public float spawnRate = 5f;
    private float timer = 0f;
    public float positionOffset= 0.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objects = new GameObject[] {tombstone, coin, spike};
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) 
        {
            timer += Time.deltaTime;
        } else 
        {
            SpawnObject();
            timer = 0f;
        }
    }
    
    void SpawnObject()
    {
        GameObject obj = objects[Random.Range(0,objects.Length)];
        float lowestPoint = transform.position.y - positionOffset;
        float highestPoint = transform.position.y + positionOffset;
        Instantiate(obj, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation, parent);
    }
}
