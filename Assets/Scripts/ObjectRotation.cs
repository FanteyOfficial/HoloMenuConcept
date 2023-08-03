using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(0, 50 * Time.deltaTime, 0);
    }
}
