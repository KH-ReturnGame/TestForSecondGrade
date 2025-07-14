using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracker : MonoBehaviour
{
    private Rigidbody2D rb;

    public GameObject self;

    public GameObject player;

    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(destroya());
    }

    private IEnumerator destroya()
    {
        yield return new WaitForSeconds(24f);
        Destroy(self);
    }

    // Update is called once per frame
    void Update()
    {
        rb.position = Vector2.MoveTowards(transform.position, player.transform.position, Time.deltaTime * moveSpeed);
    }
}
