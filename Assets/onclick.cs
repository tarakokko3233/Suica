using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject[] list; // 生成するGameObjectのリスト
    private GameObject next;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if(!next){
                next = SpawnObjectAtPosition(new Vector3(8.0f, 4.0f, 0), 0);
                Vector3 currentScale = next.transform.localScale;
                Vector3 newScale = currentScale * 0.5f;
                next.transform.localScale = newScale;
            }
            else
            {
                Destroy(next);
                next = SpawnObjectAtPosition(next.transform.position, 0);
                Vector3 currentScale = next.transform.localScale;
                Vector3 newScale = currentScale * 0.5f;
                next.transform.localScale = newScale;
            }

            // 現在のtriangleの位置にlistの中からランダムなオブジェクトを生成し、重力を1に設定
            GameObject triangle = GameObject.Find("Triangle"); // triangleオブジェクトを検索
            SpawnObjectAtPosition(triangle.transform.position, 1);

        }
    }

    GameObject SpawnObjectAtPosition(Vector3 position, float gravityScale)
    {
        // if (list.Length == 0) return; // listが空なら何もしない

        // listからランダムなGameObjectを選択して生成
        GameObject toSpawn = list[Random.Range(0, list.Length)];
        GameObject spawned = Instantiate(toSpawn, position, Quaternion.identity);

        // 生成されたオブジェクトにRigidbodyがあるか確認し、gravityScaleを設定
        Rigidbody2D rb = spawned.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            if(gravityScale == 1)
            {
                rb.gravityScale = 1;
            }else if(gravityScale == 0)
            {
                rb.isKinematic = false;
            }
        }
        return spawned;
    }
}
