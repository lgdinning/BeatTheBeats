using UnityEngine;
using TMPro;
public class ClickToStart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnMouseDown() {
        GameManager.game.LoadNext();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
