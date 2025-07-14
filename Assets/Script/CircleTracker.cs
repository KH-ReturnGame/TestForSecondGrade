using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CircleTracker : MonoBehaviour
{
    void Update()
    {
        Vector2 pos;

        pos = this.transform.position;
    }



    public GameObject EnemyPrefab;
    public GameObject Player;

    Vector2 start = new Vector2(0, 0);
    //Vector2 destination = new Vector2 (pos);

    private void TrackerMaking()
    {
        Instantiate(EnemyPrefab, new Vector2(0, 0), Quaternion.identity);
    }
}