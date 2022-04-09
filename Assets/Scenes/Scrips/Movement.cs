using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float Hor,Ver;
    public int velocidad;
    // Start is called before the first frame update
    void Start()
    {
        velocidad=10;
        
    }

    // Update is called once per frame
    void Update()
    {
        Hor = Input.GetAxis("Horizontal")*velocidad*Time.deltaTime;
       // Ver = Input.GetAxis("Vertical")*velocidad*Time.deltaTime;
        this.transform.Translate(Hor,Ver,0);
        
    }
}
