using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Windows;

public class PlayerControll : MonoBehaviour{
    // Start is called before the first frame update
    private GameObject PlayerGun;
    void Start(){
        PlayerGun = GameObject.FindWithTag("player");
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-0.06f, 0, 0);
        }
        else if(Input.GetKey(KeyCode.D)){
            transform.Translate(0.06f, 0, 0);
        }
        else if(Input.GetKey(KeyCode.W)){
            transform.Translate(0, 0, 0.06f);
        }
        else if(Input.GetKey(KeyCode.S)){
            transform.Translate(0, 0, -0.06f);
        }
    }
}
