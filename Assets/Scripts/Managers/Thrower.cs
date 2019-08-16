using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    [Header("Spawners")]
    public GameObject[] SnowmenWaypoints;
    //snowballs spawn at snowmen transform.position
    public GameObject[] snowMen;
    [Header("SnowBalls")]
    public GameObject snowBall;
    public int num;
    // Start is called before the first frame update


    public void Throw()
    {
       Vector3 spawnPos = new Vector3(0,0,0);
        Instantiate(snowBall, snowMen[num].transform.position + spawnPos, Quaternion.identity);
    }

 

}
