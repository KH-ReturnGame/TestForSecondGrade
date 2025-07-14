using UnityEngine;

public class player_move : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveV;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveV = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveV * Time.fixedDeltaTime);
    }
}
