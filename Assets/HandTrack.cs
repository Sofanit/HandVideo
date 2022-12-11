using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HandTrack : MonoBehaviour
{
    // Start is called before the first frame update
    public UDPrecieve udprec;
    public GameObject[] handPoints;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string data = udprec.data;
        //remove square bracket
        data= data.Remove(0,1);
        data=data.Remove(data.Length-1,1);
        string[] points=data.Split(',');
        print(points[0]);
        
    }
}
