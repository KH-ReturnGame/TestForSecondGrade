using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class boss_minute: MonoBehaviour
{
    
    public float angle = 0.12f;
    
    public void FixedUpdate()
    {
        this.transform.Rotate(0, 0, -angle);
    }


}
