using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    public string gameOverTag = "GameOver";
    private float masterTimer = 0;
    private float gameComplete = 7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == gameOverTag)
        {
            SceneManager.LoadScene("LossScreen");
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        masterTimer += Time.deltaTime;
        if (masterTimer >= gameComplete)
            {
                GameManager.game.LoadNext();
            }
    }
}
