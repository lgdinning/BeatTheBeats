using UnityEngine;

public class LoseScript : MonoBehaviour
{
    public string gameOverTag = "GameOver";
    private float masterTimer = 0;
    private float gameComplete = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == gameOverTag)
        {
            Debug.Log("game over bietch");
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
                Debug.Log("game over bietch !!! slayed");
            }
    }
}
