using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroySelfMiss : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DestroySelf());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DestroySelf() {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }
}
