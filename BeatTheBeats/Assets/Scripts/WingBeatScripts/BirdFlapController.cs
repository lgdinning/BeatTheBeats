using UnityEngine;

public class BirdFlapController : MonoBehaviour
{
    public Sprite[] wingSprites;
    private SpriteRenderer spriteRenderer;
    private int wingSpriteIndex = 0; 
    private float frameTime = 0.03f;
    private float timer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            timer += Time.deltaTime;
            if (timer >= frameTime)
            {
                timer = 0;
                // check to make sure if at the end of array, restart
                if (wingSpriteIndex == wingSprites.Length - 1)
                {
                    wingSpriteIndex = 0; 
                }
                else
                {
                    wingSpriteIndex++;
                }
                // change bird to next animation frame 
                spriteRenderer.sprite = wingSprites[wingSpriteIndex];
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            timer = 0; 
            wingSpriteIndex = 0; 
            spriteRenderer.sprite = wingSprites[0]; 
        }


    }
}

