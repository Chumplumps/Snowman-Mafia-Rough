using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Spawners")]
    public GameObject[] snowmanWaypoint;
    //snowballs spawn at snowmen transform.position
  
    [Header("Prefabs")]
    public GameObject snowBall;
    public GameObject snowMan;
    public int waypointNum;
    public int snowmanNum;
    public float snowballTimer;
    public float snowmanTimer;
    private GameObject[] newSnowMan = new GameObject[3];
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
        if (snowmanTimer > 4)
        {
            SnowmanSpawner();
            snowmanTimer = 0;
        }
        //timer for snowball spawn
        snowballTimer += Time.deltaTime;
        if (snowballTimer > 1)
        {
            SnowballSpawner();
            snowballTimer = 0;
        }



    }
   
    //spawn snowman at random waypoint
    public void SnowmanSpawner()
    {
        
        waypointNum = Random.Range(0, 3);
        //instantiate new snowman
       newSnowMan[waypointNum]= Instantiate(snowMan, snowmanWaypoint[waypointNum].transform.position, Quaternion.identity);
       
       

    }
    //spawn snowball at snowman location
    public void SnowballSpawner()
    {


        snowmanNum = Random.Range(0, 3);
        Vector3 spawnPos = new Vector3(0, 0, -3);
        //only spawn snowball if newsnowman[snowmanNum] exists
        if (newSnowMan[snowmanNum] != null && !newSnowMan[snowmanNum].Equals(null))
        {
            //instantiate snowball at random newsnowman position 
            Instantiate(snowBall, newSnowMan[snowmanNum].transform.position + spawnPos, Quaternion.identity);

        }
     


    }

}
