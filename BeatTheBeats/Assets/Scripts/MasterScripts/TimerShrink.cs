using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class TimerShrink : MonoBehaviour
{

    public float maxTime;
    public float maxHeight;
    public float difficultyModifier;
    public bool paused;
    public GameObject anchor;
    public GameObject visual;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHeight = 400f;
        difficultyModifier = 1.0f;
        paused = true;
        visual.GetComponent<SpriteRenderer>().enabled = false;
        //Debug.Log(gameObject.transform.position);
    }

    public void Restart() {
        gameObject.transform.localScale = new Vector3(50f, 400f, 1f);
        gameObject.transform.position = anchor.transform.position;
        visual.GetComponent<SpriteRenderer>().enabled = true;
        //Debug.Log()
    }

    public void SetDifficultyModifier(float mod) {
        difficultyModifier = mod;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.localScale.y > 0 && !paused) {
            gameObject.transform.localScale -= new Vector3(0,difficultyModifier * Time.deltaTime * 0.1f * maxHeight,0);
            gameObject.transform.position -= new Vector3(0,difficultyModifier * Time.deltaTime * 0.001f * maxHeight,0);
        } else if (gameObject.transform.localScale.y <= 0) {
            SceneManager.LoadScene("LossScreen");
        }
    }
}
