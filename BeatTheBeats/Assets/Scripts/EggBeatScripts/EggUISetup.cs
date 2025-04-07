using UnityEngine;

public class EggUISetup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UIClass.canvas.GetComponent<Canvas>().worldCamera = Camera.main;
        UIClass.canvas.Restart();
        UIClass.canvas.UnpauseTimer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
