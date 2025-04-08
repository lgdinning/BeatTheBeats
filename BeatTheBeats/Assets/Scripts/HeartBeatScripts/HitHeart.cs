using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HitHeart : MonoBehaviour
{
    public int numToGo;
    public bool hitting;
    public GameObject itemHitting;
    public GameObject hitBubble;
    public GameObject missBubble;
    public GameObject girl;
    public GameObject boy;
    public bool offCD;
    public Sprite girlMad;
    public Sprite girlNeutral;
    public Sprite girlHappy;
    public Sprite boySad;
    public Sprite boyHappy;

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
                girl.GetComponent<SpriteRenderer>().sprite = girlHappy;
                Instantiate(hitBubble, itemHitting.transform.position, Quaternion.identity);
                Destroy(itemHitting);
                numToGo -= 1;
                hitting = false;
            } else {
                offCD = false;
                missBubble.GetComponent<SpriteRenderer>().enabled = true;
                boy.GetComponent<SpriteRenderer>().sprite = boySad;
                girl.GetComponent<SpriteRenderer>().sprite = girlMad;
                StartCoroutine(MissCooldown());
            }
        }
        if (numToGo <= 0) {
            TimerShrink.globalTimer.paused = true;
            StartCoroutine(Win());
        }
    }

    IEnumerator Win() {
        yield return new WaitForSeconds(1f);
        GameManager.game.LoadNext();
    }

    IEnumerator MissCooldown() {
        yield return new WaitForSeconds(0.4f);
        boy.GetComponent<SpriteRenderer>().sprite = boyHappy;
        girl.GetComponent<SpriteRenderer>().sprite = girlNeutral;
        missBubble.GetComponent<SpriteRenderer>().enabled = false;
        offCD = true;
    }
}
