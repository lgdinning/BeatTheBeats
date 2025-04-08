using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroySelf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DestroySelfHit());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DestroySelfHit() {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
