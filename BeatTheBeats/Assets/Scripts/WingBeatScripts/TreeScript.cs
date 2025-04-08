using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public float moveSpeed = 8;
    public float difficultyModifier;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        difficultyModifier = 1 + ((float)GameManager.game.score / 20);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (difficultyModifier * (Vector3.left * moveSpeed) * Time.deltaTime);
    }
}
