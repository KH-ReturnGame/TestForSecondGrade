using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class boss_hour: MonoBehaviour
{
    public float angle = 0.02f;
    public Transform tr;
    public void Start()
    {
        tr = GameObject.Find("boss").GetComponent<Transform>();
    }
    public void FixedUpdate()
    {
        //transform.RotateAround(Vector3.up, tr.position, 1);ㅅㅂ;;
        
        this.transform.Rotate(0, 0, -angle);

    }


}
