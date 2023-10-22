using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour
{
    private GameObject FlipperR;
    private GameObject FlipperL;
    private Rigidbody rigidbodyR;
    private Rigidbody rigidbodyL;

    //フリッパーの回る角度
    float tmpFlipperLRotate = 0;
    float tmpFlipperRRotate = 0;
    float rotateSpeed = 500;

    // Start is called before the first frame update
    void Start()
    {
        FlipperR = GameObject.Find("FlipperRPivot");
        FlipperL = GameObject.Find("FlipperLPivot");

        //フリッパーの重心
        rigidbodyR = FlipperR.GetComponentInChildren<Rigidbody>();
        rigidbodyR.centerOfMass = new Vector3(-0.7f, 0, 0);
        //xの移動分戻して回転の中心を変える
        rigidbodyL = FlipperL.GetComponentInChildren<Rigidbody>();
        rigidbodyL.centerOfMass = new Vector3(0.7f, 0, 0);
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("PUSH_L");
            //フリッパーの角度制御
            if(tmpFlipperLRotate < 30)
            {
                tmpFlipperLRotate += rotateSpeed * Time.deltaTime;
            }
            else
            {
                tmpFlipperLRotate = 30;
            }
        }
        else
        {
            if (tmpFlipperLRotate > -30)
            {
                tmpFlipperLRotate -= rotateSpeed * Time.deltaTime;
            }
            else
            {
                tmpFlipperLRotate = -30;
            }
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("PUSH_R");
            //Debug.Log("tmpFlipperRRotate");
            //フリッパーの角度制御
            if(tmpFlipperRRotate < 30)
            {
                tmpFlipperRRotate += rotateSpeed * Time.deltaTime;
            }
            else
            {
                tmpFlipperRRotate = 30;
            }
        }
        else
        {
            if (tmpFlipperRRotate > -30)
            {
                tmpFlipperRRotate -= rotateSpeed * Time.deltaTime;
            }
            else
            {
                tmpFlipperRRotate = -30;
            }
        }

        rigidbodyL.MoveRotation(FlipperL.transform.rotation * Quaternion.Euler(0, -tmpFlipperLRotate, 0));
        rigidbodyR.MoveRotation(FlipperR.transform.rotation * Quaternion.Euler(0, tmpFlipperRRotate, 0));

        Debug.Log(rigidbodyL.centerOfMass);
        Debug.Log(rigidbodyR.centerOfMass);
    }

}
