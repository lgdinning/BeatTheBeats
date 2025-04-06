using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager game;
    public List<string> sceneList;
    
    void Awake() {
        game = this;
        sceneList = new List<string>() {"EggBeat", "DrumBeat"};
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (game != this) {
            Destroy(gameObject);
        }
    }

    public void LoadNext() {
        int randomChoice = Random.Range(0,sceneList.Count);
        SceneManager.LoadScene(sceneList[randomChoice]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
