using UnityEngine;


public class player : MonoBehaviour
{
    private Vector3 direction = Vector3.zero;   // 이동 방향
    public float playerHP = 100f;
    public bool isHP = true;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");   // 좌우 이동
        float y = Input.GetAxisRaw("Vertical");     // 상하 이동

        direction = new Vector3(x, y, 0);
        transform.position += direction * Time.deltaTime*3;




        Hp();
    }
    public void Hp()
    {
        if(collision.collider.gameObject.CompareTag("boss")&&isHP == true)
        {
            isHP = false;
            playerHP -= 10f;

        }
        else
        {
            isHP = true;
        }
    }

}