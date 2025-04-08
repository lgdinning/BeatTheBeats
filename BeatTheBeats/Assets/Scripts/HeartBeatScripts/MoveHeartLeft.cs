using UnityEngine;

public class MoveHeartLeft : MonoBehaviour
{
    public GameObject hitHeart;
    public float difficultyModifier;
    public GameObject hitBubble;

    // void OnDestroy() {
    //     Instantiate(hitBubble, transform.position, Quaternion.identity);
    // }

    public void SetDifficulty(float mod) {
        difficultyModifier = mod;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        difficultyModifier = 2;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position -= new Vector3(difficultyModifier * Time.deltaTime * 5, 0, 0);
        if (hitHeart.GetComponent<HitHeart>().numToGo <= 0) {
            Destroy(gameObject);
        }
        //Debug.Log(gameObject.transform.position);
    }
}
