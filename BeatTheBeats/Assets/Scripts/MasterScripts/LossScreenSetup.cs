using UnityEngine;

public class LossScreenSetup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.game.finalScore.enabled = true;
        GameManager.game.scoreCounter.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
