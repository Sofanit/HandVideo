using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{


 public UDPrecieve udprec;
   public float speed=100.0f;
   Rigidbody m_rigid;
   
    // Start is called before the first frame update
    void Start()
    {
        m_rigid=GetComponent<Rigidbody>();
    }
   
  
     // Update is called once per frame
    void Update()
    {
    string data=udprec.data;
    if(data.Length >0){
    data=data.Remove(0,1);
    data=data.Remove(data.Length-1,1);
    string[] points= data.Split(',');
    float x = float.Parse(points[0])/100;
    if(x>2 && x<4){
    Vector3 inv=new Vector3(1,0,0);
    m_rigid.MovePosition(transform.position);
    }
    if(x>4 && x <8){
    
    transform.position=new Vector3(-1,0,0);
    m_rigid.MovePosition(transform.position);
    }
    
    else{
    transform.position= new Vector3(0,0,0);
    m_rigid.MovePosition(transform.position);
    
    }
    
    }
    
         
    }
    
    
}
