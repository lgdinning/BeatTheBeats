using UnityEngine;

public class LeftBoxTrigger : MonoBehaviour
{
    public GameObject score;

    void OnTriggerEnter(Collider other) {
        score.GetComponent<ScoreManager>().ChangeScore(true);
    }
}
