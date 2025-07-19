using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public float movespeed;


    
    void Update()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 moveVelocity = new Vector3(x, y, 0) * movespeed * Time.deltaTime;
        this.transform.position += moveVelocity;
    }
}
