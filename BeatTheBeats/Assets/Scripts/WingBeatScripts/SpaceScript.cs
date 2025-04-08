using UnityEngine;

public class SpaceScript : MonoBehaviour
{
    public Sprite spacePressed;
    public Sprite spaceNotPressed;
    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Space pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.sprite = spacePressed;
        }
        // Space not pressed anymore
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            spriteRenderer.sprite = spaceNotPressed;
        }
    }
}
