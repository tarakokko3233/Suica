using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doooon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // シーン開始時に、gravityScaleを1に設定
        ApplyGravityScale(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 5.0f)
        {
            // 特定の条件下で、gravityScaleを-1に変更
            ApplyGravityScale(-1);
        }

    }

    // gravityScaleを指定値に設定するメソッド
    void ApplyGravityScale(float scale)
    {
        Rigidbody2D[] allRigidbodies = FindObjectsOfType<Rigidbody2D>();
        foreach (Rigidbody2D rb in allRigidbodies)
        {
            rb.gravityScale = scale;
        }
        GameObject[] allGameObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject go in allGameObjects)
        {
            Destroy(go);
        }
    }
}
