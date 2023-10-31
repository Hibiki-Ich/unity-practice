using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Windows;

public class PlayerControll : MonoBehaviour{
    // Start is called before the first frame update
    private GameObject PlayerGun;
    void Start(){
        PlayerGun = GameObject.FindWithTag("Player");
    }

    void Update(){
        if(Input.GetKey(KeyCode.A)){
            PlayerGun.transform.Translate(-0.06f, 0, 0);
        }
        else if(Input.GetKey(KeyCode.D)){
            PlayerGun.transform.Translate(0.06f, 0, 0);
        }
        else if(Input.GetKey(KeyCode.W)){
            PlayerGun.transform.Translate(0, 0, 0.06f);
        }
        else if(Input.GetKey(KeyCode.S)){
            PlayerGun.transform.Translate(0, 0, -0.06f);
        }
    }
}
