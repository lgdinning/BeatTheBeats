using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    void OnMouseDown() {
        GameManager.game.score = 0;
        GameManager.game.scoreCounter.enabled = true;
        GameManager.game.finalScore.enabled = false;
        GameManager.game.LoadNext();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
