using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{

    void OnTriggerEnter(Collider other) {
        Debug.Log("You've been beat!");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
