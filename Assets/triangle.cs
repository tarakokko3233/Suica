using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    public float speed = 5.0f; // 移動速度
    // X軸の現在位置を取得するプロパティ
    public float CurrentX { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = 0; // ローカル変数として定義
        if(Input.GetKey("a")){
            // X軸に沿って左に移動
            x = -speed * Time.deltaTime;
        } else if(Input.GetKey("d")){
            // X軸に沿って右に移動
            x = speed * Time.deltaTime;
        }

        // 移動があれば適用
        if(x != 0){
            transform.Translate(x, 0, 0);
            CurrentX = transform.position.x;
        }
    }
}
