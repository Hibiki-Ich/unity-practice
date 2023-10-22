using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour{
    public GameObject BulletPrefab;
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        //クリックされたら弾を生成
        if(Input.GetMouseButtonDown(0)){
            GameObject bullet = GameObject.Instantiate(BulletPrefab);
        }
    }
}
