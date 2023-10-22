using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject BallPrefab;
    public Transform ballTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //クリックされたらボール生成
        if(Input.GetMouseButtonDown(0))
        {
            if(BallPrefab != null)
            {
                GameObject ball = GameObject.Instantiate(BallPrefab);

                ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -25);
                
                ball.transform.position = ballTransform.position;
            }
        }
    }
}
