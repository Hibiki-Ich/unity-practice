using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour{
    public GameObject BulletPrefab;
    //インスペクターからGunをアタッチする。Gunを削除した時にペタペタ貼り直す必要があるので非推奨
    public GameObject PlayerGun;
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        //クリックされたら弾を生成
        if(Input.GetMouseButtonDown(0)){
            //BulletPrefabはインスペクターから選択
            //座標はGunからZ軸方向（Gunのローカル座標）へ、0.3進んだところ（グローバル座標）
            Vector3 posi = PlayerGun.transform.position;
            Debug.Log(posi);
            posi.z += 0.3f;
            Debug.Log(posi);
            GameObject bullet = GameObject.Instantiate(BulletPrefab, posi, Quaternion.identity);
        }
    }
}
