using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class EggRotation : MonoBehaviour
{

    void Update() {
        if (Input.GetMouseButton(0)) {
            Vector3 a = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));

            float rotation = Mathf.Rad2Deg * Mathf.Atan2(a.x, a.y);
            transform.rotation = Quaternion.Euler(0,0,-rotation);
        }
    }

}
