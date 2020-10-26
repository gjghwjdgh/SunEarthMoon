using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunScript : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, -2000f, 0f) * Time.deltaTime);

    }
}
