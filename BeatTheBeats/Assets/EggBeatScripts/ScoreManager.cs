using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public Sprite egg1;
    public Sprite egg2;
    public Sprite egg3;
    public GameObject eggObject;
    public int totalSpins;
    public int halfSpins;
    public bool leftNext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalSpins = 20;
        halfSpins = 20;
        leftNext = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore(bool isLeft) {
        if (isLeft == leftNext) {
            halfSpins -= 1;
            leftNext = !leftNext;
        }
        Debug.Log(halfSpins);
        if (halfSpins < 0) {
            eggObject.GetComponent<SpriteRenderer>().sprite = egg3;
        }
        else if (halfSpins < totalSpins / 2) {
            eggObject.GetComponent<SpriteRenderer>().sprite = egg2;
        }
    }
}
