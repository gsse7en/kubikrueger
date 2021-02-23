using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(this.gameObject.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
