using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HitHeart : MonoBehaviour
{
    public int numToGo;
    public bool hitting;
    public GameObject itemHitting;
    public bool offCD;

    void OnTriggerEnter(Collider other) {
        hitting = true;
        itemHitting = other.gameObject;
    }

    void OnTriggerExit(Collider other) {
        hitting = false;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offCD = true;
        numToGo = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && offCD) {
            if (hitting) {
                Debug.Log("Yep");
                Destroy(itemHitting);
                numToGo -= 1;
                hitting = false;
            } else {
                offCD = false;
                StartCoroutine(MissCooldown());
            }
        }
        if (numToGo <= 0) {
            StartCoroutine(Win());
        }
    }

    IEnumerator Win() {
        yield return new WaitForSeconds(1f);
        GameManager.game.LoadNext();
    }

    IEnumerator MissCooldown() {
        yield return new WaitForSeconds(0.4f);
        offCD = true;
    }
}
