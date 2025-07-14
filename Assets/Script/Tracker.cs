using System.Collections;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    bool TrackerMake = false;
    float TrackerTime = 10f;
    public GameObject EnemyPrefab;

    private void TrackerMaking()
    {
        Instantiate(EnemyPrefab, new Vector2(0, -10f), Quaternion.identity);
        Instantiate(EnemyPrefab, new Vector2(-10f, 0), Quaternion.identity);
        Instantiate(EnemyPrefab, new Vector2(0, 10f), Quaternion.identity);
    }

    /*IEnumerator Trackerbeendo(float TrackerTime)
    {
        bool TrackerMake = true;
        yield return new WaitForSeconds(TrackerTime);
    }*/

}
