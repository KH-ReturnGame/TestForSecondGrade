using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{

    public float spin_S;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, spin_S* Time.deltaTime));
    }
}
