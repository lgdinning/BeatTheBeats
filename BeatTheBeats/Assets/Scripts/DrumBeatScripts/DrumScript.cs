using UnityEngine;

public class DrumScript : MonoBehaviour
{
    public Sprite drumNotHit;
    public Sprite drumHit;

    private int drumHitCount = 0;
    private int clearHitCount = 20;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // space pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            drumHitCount++;
            spriteRenderer.sprite = drumHit;
            //Debug.Log("E pressed! Total count: " + drumHitCount);
            if (drumHitCount >= clearHitCount)
            {
                TimerShrink.globalTimer.paused = true;
                GameManager.game.LoadNext();
                //Debug.Log("LIMMIT REACHED!!! " + drumHitCount);
            }
        }
        // space not pressed anymore
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            spriteRenderer.sprite = drumNotHit;
        }
    }
}
