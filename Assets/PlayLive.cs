using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayLive : MonoBehaviour

{

public Rigidbody rg;

void Start(){

rg=GetComponent<Rigidbody>();

}

void Update(){
if(Input.GetKey("up")){

rg.velocity=new Vector3(0,0,10);


}


}




private void OnCollisionEnter(Collision collision){

if(collision.gameObject.CompareTag("EnemyCube")){

Debug.Log("death");

}


}





}
