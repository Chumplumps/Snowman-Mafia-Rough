using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Spawners")]
    public GameObject[] SnowmenWaypoints;
    //snowballs spawn at snowmen transform.position
    public GameObject[] snowMen;
    [Header("SnowBalls")]
    public GameObject snowBall;
    public int num;
    public float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > 3)
        {
            Spawner();
            spawnTimer = 0;
        }
        
    }
    public void Spawner()
    {
       num = Random.Range(0,3);

       Vector3 spawnPos = new Vector3(0,0,-3);
        Instantiate(snowBall, snowMen[num].transform.position + spawnPos, Quaternion.identity);
    }
   
}
