using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManManager : MonoBehaviour
{
    public GameObject[] snowMen;
    public GameObject[] detectors;
    public int curSnowMan;
    public bool[] snowmanAlive = new bool[3];
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (curSnowMan = 0; curSnowMan < 3; curSnowMan++)
        {
            if (snowMen[curSnowMan].gameObject.activeInHierarchy)
            {
                Movement();
            }
        }

    }

    void Movement()
    {
        Vector3 num = new Vector3(0, 0, -1);
        snowMen[curSnowMan].transform.position = num;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "SnowMan1") { snowmanAlive[1] = true; }
        if (other.gameObject.tag == "SnowMan2") { snowmanAlive[2] = true; }
        if (other.gameObject.tag == "SnowMan3") { snowmanAlive[3] = true; }



    }
}
