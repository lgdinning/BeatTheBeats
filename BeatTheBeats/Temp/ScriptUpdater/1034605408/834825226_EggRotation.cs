using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class EggRotation : MonoBehaviour
{
    void Update() {
        float opposite = Mouse.current.position.x.ReadValue() - transform.position.x;
        float adjacent = Mouse.current.position.y.ReadValue() - transform.position.y;
        Ray ray = GetComponent<Camera>().ScreenPointToRay(new Vector3(opposite, adjacent, 0));

        Debug.Log(opposite);
        Debug.Log(adjacent);
        float rotation = Mathf.Rad2Deg * Mathf.Atan2(adjacent, opposite);
        transform.rotation = Quaternion.Euler(0,rotation,0);
    }

}
