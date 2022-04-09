using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Badnik : MonoBehaviour
{
    public float fuerza; //Esta es la fuerza de rebote

    //Método para validar las colisiones
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "plataforma") //Si colisiona con el tag
        {
            //rebote
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10*fuerza));


        }

    }
      


  
}
