using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HeartSpawn : MonoBehaviour
{
    public GameObject hitHeart;
    public GameObject heart;
    public GameObject spawnAnchor;
    public bool shouldSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shouldSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldSpawn) {
            shouldSpawn = false;
            GameObject newHeart = Instantiate(heart, spawnAnchor.transform.position, Quaternion.identity);
            newHeart.GetComponent<MoveHeartLeft>().hitHeart = hitHeart;
            StartCoroutine(WaitToSpawn());
        }
    }

    IEnumerator WaitToSpawn() {
        float waitTime = Random.Range(0.5f, 2f);
        yield return new WaitForSeconds(waitTime);
        shouldSpawn = true;
    }
}
