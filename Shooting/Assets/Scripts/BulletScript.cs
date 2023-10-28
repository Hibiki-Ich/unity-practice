using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class BulletScript : MonoBehaviour{
    public GameObject BulletPrefab;
    //インスペクターからGunをアタッチする。Gunを削除した時にペタペタ貼り直す必要があるので非推奨
    private GameObject PlayerGun;
    void Start(){
        //Debug.Log("Bullet Script Start!");
        PlayerGun = GameObject.Find("Gun");
    }

    // Update is called once per frame
    void Update(){
        //クリックされたら弾を生成
        if(Input.GetMouseButtonDown(0)){
            //BulletPrefabはインスペクターから選択
            //座標はGunからZ軸方向（Gunのローカル座標）へ、0.3進んだところ（グローバル座標）
            Vector3 posi = PlayerGun.transform.position;
            //Debug.Log(posi);
            posi.z += 0.3f;
            //Debug.Log(posi);
            GameObject bullet = GameObject.Instantiate(BulletPrefab, posi, Quaternion.identity);
            //前（インスタンス化の時に初期方向は変更できる）に向かって初速を付ける。
            bullet.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 50);
        }
    }
}
