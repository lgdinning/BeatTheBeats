using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public static Timer timer;
    public float time;
    public bool paused;

    void Awake() {
        DontDestroyOnLoad(gameObject);
        timer = this;
        time = 30;
        paused = true;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (timer != this) {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!paused) {
            time -= Time.deltaTime;
        }
    }
}
