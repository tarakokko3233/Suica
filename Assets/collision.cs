using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject circle1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(this.gameObject.name==other.gameObject.name){
        Destroy(this.gameObject);

        other.gameObject.GetComponent<collision>().circle1=null;

        if(circle1){
            Instantiate(circle1,this.transform.position,this.transform.rotation);
        }
        }
    }
}
