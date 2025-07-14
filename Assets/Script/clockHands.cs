using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockHands : MonoBehaviour
{
    public GameObject min;
    public GameObject hou;

    public GameObject boss;

    public GameObject player;

    private bool isAccelation = false;

    public float minRotationPerFrame = 22f;
    public float houRotationPerFrame = 2f;


    public float circlect1 = 2f;
    public float circlect2 = 10f;

    public float trianglect1 = 3f;
    public float trianglect2 = 14f;

    public float circleSpeed = 35f;
    public float triangleSpeed = 7f;

    private bool circlecd = false;
    private bool trianglecd = false;
    
    List<Vector2> triSpawns = new List<Vector2>{
        new Vector2(10f,0),
        new Vector2(-10f,0),
        new Vector2(0,10f),
        new Vector2(0,-10f)
    };




    // projectiles ㅅ비ㅏㄹ 아르먼ㅇ후먼휴뫃러ㅠㅁ로허뭄항ㅎㅇㄴ마 열감기 ㅅㅂ 
    
    public GameObject circlePrefab;
    public GameObject trianglePrefab;


    void Awake()
    {
       
       if(!circlecd)
       StartCoroutine(fireprojectiles());

       if(!trianglecd)
       StartCoroutine(firetrackers());
    }

    void Update()
    {
       min.transform.Rotate(0,0,-minRotationPerFrame * Time.deltaTime);
       hou.transform.Rotate(0,0,-houRotationPerFrame * Time.deltaTime);

      // if(!isAccelation)
       //StartCoroutine(accel());
    }

     private IEnumerator accel()
    {
        isAccelation = true;
        Time.timeScale = 3f;
        yield return new WaitForSeconds(Random.Range(10f,20f));
        Time.timeScale = 1f;
        yield return new WaitForSeconds(Random.Range(7f,17f));
        isAccelation = false;


    }


    private IEnumerator fireprojectiles()
    {
        yield return new WaitForSeconds(0.5f);

        GameObject circleclone = Instantiate(circlePrefab,new Vector2(0,0),Quaternion.identity);

        
         Vector2 fireDirection = (player.transform.position - boss.transform.position).normalized;

         Rigidbody2D cirrb = circleclone.GetComponent<Rigidbody2D>();

         cirrb.AddForce(fireDirection * circleSpeed * Time.deltaTime,ForceMode2D.Impulse);

         circlecd = true;
         yield return new WaitForSeconds(Random.Range(circlect1,circlect2));
         circlecd = false;
         yield return new WaitForSeconds(8f);
         Destroy(circleclone);
    }


    private IEnumerator firetrackers()
    {
        yield return new WaitForSeconds(0.2f);

        for (int i=0; i<4; i++)
        {
                GameObject triclone = Instantiate(trianglePrefab,triSpawns[i],Quaternion.identity);
                
                Rigidbody2D trirb = triclone.GetComponent<Rigidbody2D>();

                tracker TrackScrpt = triclone.GetComponent<tracker>();
                TrackScrpt.moveSpeed = triangleSpeed;
                TrackScrpt.self = triclone;
                TrackScrpt.player = player;
                

        }
         trianglecd = true;
         yield return new WaitForSeconds(Random.Range(trianglect1,trianglect2));
         trianglecd = false;
   
    }
}
