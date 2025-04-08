using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager game;
    public List<string> sceneList;
    public string lastGame;
    public TMP_Text scoreCounter;
    public TMP_Text finalScore;
    
    void Awake() {
        game = this;
        sceneList = new List<string>() {"EggBeat", "DrumBeat", "HeartBeat", "WingBeat"};
        score = 10;
        lastGame = "";
        finalScore.enabled = false;
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
        while (sceneList[randomChoice] == lastGame) {
            randomChoice = Random.Range(0,sceneList.Count);
        }
        lastGame = sceneList[randomChoice];
        score += 1;
        scoreCounter.text = score.ToString();
        finalScore.text = score.ToString();
        SceneManager.LoadScene(sceneList[randomChoice]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
