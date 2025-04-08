using UnityEngine;

public class TreeSpawnerScript : MonoBehaviour
{
    public GameObject tree;
    private float spawnRate = 1.5f;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTree();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnTree();
            timer = 0;
        }
    }

    void spawnTree()
    {
        float yDiff = Random.Range(0f,6.5f);
        Instantiate(tree, transform.position + new Vector3(0, yDiff, 0), transform.rotation);
    }
}
