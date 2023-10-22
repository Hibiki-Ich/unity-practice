using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAction : MonoBehaviour{
    void Start(){
        
    }

    void Update(){
        
    }

    //何かとぶつかった時に呼び出される関数
    private void OnCollisionEnter(Collision collision){
        //Debug.Log("collision bullet&enemy");
        if (collision.gameObject.tag == "Enemy"){
            //Debug.Log("destroy at the next line");
            Destroy(collision.gameObject);
        }
    }
}

