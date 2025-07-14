using UnityEditor;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float cooldown;
    public float skillTime;
    public GameObject about;

    void Update()
    {
        skillTime += Time.deltaTime;

        if (skillTime > cooldown)
        {
            Instantiate(about, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            skillTime = 0;
        }
    }
}
