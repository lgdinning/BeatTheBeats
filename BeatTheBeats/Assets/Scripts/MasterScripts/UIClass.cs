using UnityEngine;

public class UIClass : MonoBehaviour
{

    public static UIClass canvas;
    public GameObject timerBar;
    public TimerShrink timer;

    public void PauseTimer() {
        timer.paused = true;
    }

    public void UnpauseTimer() {
        timer.paused = false;
    }

    public void Restart() {
        timer.Restart();
    }

    public void SetDifficulty(float mod) {
        timer.SetDifficultyModifier(mod);
    }

    void Awake() {
        canvas = this;
        timer = timerBar.GetComponent<TimerShrink>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (canvas != this) {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
