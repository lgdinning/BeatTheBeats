using UnityEngine;

public class DrumScript : MonoBehaviour
{
    public Sprite drumNotHit;
    public Sprite drumHit;

    private int drumHitCount = 0;
    private int clearHitCount = 20;
    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // E pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            drumHitCount++;
            spriteRenderer.sprite = drumHit;
            Debug.Log("E pressed! Total count: " + drumHitCount);
            if (drumHitCount >= clearHitCount)
            {
                GameManager.game.LoadNext();
                Debug.Log("LIMMIT REACHED!!! " + drumHitCount);
            }
        }
        // E not pressed anymore
        else if (Input.GetKeyUp(KeyCode.E))
        {
            spriteRenderer.sprite = drumNotHit;
        }
    }
}
