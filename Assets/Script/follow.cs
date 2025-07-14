using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class boom : MonoBehaviour
{
    public Transform player_trans;
    public float moveSpeed;
    private Rigidbody2D rb;
    private Vector2 startPos;


void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 startPos = player_trans.transform.position;
        transform.position = Vector2.MoveTowards(transform.position, startPos, moveSpeed * Time.deltaTime);
    }
}
