using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HeartSpawn : MonoBehaviour
{
    public GameObject hitHeart;
    public GameObject hitBubble;
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
            newHeart.GetComponent<MoveHeartLeft>().hitBubble = hitBubble;
            StartCoroutine(WaitToSpawn());
        }
    }

    IEnumerator WaitToSpawn() {
        float waitTime = Random.Range(0.2f, 1f);
        yield return new WaitForSeconds(waitTime);
        shouldSpawn = true;
    }
}
