using UnityEngine;

public class TopBoxScript : MonoBehaviour
{
    public GameObject score;

    void OnTriggerEnter(Collider other) {
        score.GetComponent<ScoreManager>().ChangeScore(false);
    }
}
