using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject[] list;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Vector3 fixedPosition = new Vector3(7, 4, 0); // Assuming a 2D setup or 3D with a fixed Z position
            int valueAtFixedPosition = UnityEngine.Random.Range(0, list.Length);
            GameObject instantiatedObject = Instantiate(list[valueAtFixedPosition], fixedPosition, Quaternion.identity);

            Rigidbody2D rb = instantiatedObject.GetComponent<Rigidbody2D>();
                rb.gravityScale = 0;
        }
    }
}
