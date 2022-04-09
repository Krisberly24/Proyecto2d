using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float fuerzaSalto; //Define la fuerza de salto
    public Transform pie; //pie que detecta el suelo
    public float radiopie; //Radio de ejecucion del suelo
    public LayerMask Suelo; //layer del suelo
    public bool piso; //Caida del piso
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Obtiene el cuerpo fisico
        radiopie =2f;
        fuerzaSalto =10f;
        piso = false;

        
    }

    // Update is called once per frame
    //Tiempo de ejcución a medida que voy jugando va ir pasando lo que este ahí
    void Update()
    {
        piso = Physics2D.OverlapCircle(pie.transform.position, radiopie, Suelo); //recibe posicion de pie radio y el suelo
        if(Input.GetKey("w") && piso == true)
        {
            //se realiza el salto
            rb.velocity = new Vector2(0, fuerzaSalto);

        }

        
    }
}
