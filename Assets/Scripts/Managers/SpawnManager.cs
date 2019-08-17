using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Spawners")]
    public GameObject[] snowmanWaypoint;
    //snowballs spawn at snowmen transform.position
    public GameObject[] snowMen;
    [Header("Prefabs")]
    public GameObject snowBall;
    public GameObject snowMan;
    public int waypointNum;
    public int snowmanNum;
    public float snowballTimer;
    public float snowmanTimer;
    // Start is called before the first frame update
    void Start()
    {
        snowmanWaypoint[0] = GameObject.Find("WaypointLeft");
        snowmanWaypoint[1] = GameObject.Find("WaypointMiddle");
        snowmanWaypoint[2] = GameObject.Find("WaypointRight");




    }

    // Update is called once per frame
    void Update()
    {
        //timer for snowman spawn
        snowmanTimer += Time.deltaTime;
        if (snowmanTimer > 3)
        {
            SnowmanSpawner();
            snowmanTimer = 0;
        }
        //timer for snowball spawn
        snowballTimer += Time.deltaTime;
        if (snowballTimer > 3)
        {
            SnowballSpawner();
            snowballTimer = 0;
        }



    }
    public void SnowmanSpawner()
    {
        waypointNum = Random.Range(0, 3);
        Instantiate(snowMan, snowmanWaypoint[waypointNum].transform.position, Quaternion.identity);

        Debug.Log("if you got to here you are doing kinda good");
        //rename prefab in scene based on which waypoint it spawns at
        if (waypointNum == 1)
        {
            snowMan.name = "Snowman1";

        }
        if (waypointNum == 2)
        {
            snowMan.name = "Snowman2";

        }
        if (waypointNum == 3)
        {
            snowMan.name = "Snowman3";

        }


        //array snowman = gameobject in scene
        snowMen[0] = GameObject.Find("Snowman1(Clone)");
        snowMen[1] = GameObject.Find("Snowman2(Clone)");
        snowMen[2] = GameObject.Find("Snowman3(Clone)");
    }
    public void SnowballSpawner()
    {


        snowmanNum = Random.Range(0, 3);
        Vector3 spawnPos = new Vector3(0, 0, -3);
        //if (snowMen[0] == null)
        //{
        //    snowmanNum = Random.Range(2, 3);
        //}
        //if (snowMen[1] == null)
        //{
        //    if (Random.value<.5f)
        //    {
        //        snowmanNum = 1;
        //    }
        //    else
        //    {
        //        snowmanNum = 2;
        //    }
        //}
        //if (snowMen[2] == null)
        //{
        //    if (Random.value<.5f)
        //    {
        //        snowmanNum = 1;
        //    }
        //    else
        //    {
        //        snowmanNum = 3;
        //    }
        //}
        Instantiate(snowBall, snowMen[snowmanNum].transform.position + spawnPos, Quaternion.identity);


    }

}
