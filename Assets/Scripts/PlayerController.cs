using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SpriteRenderer sr;
    private Animator animator;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        sr= GetComponent<SpriteRenderer>();//obtengo el objeto spriterender de player
      //  Debug.Log("hola mundo este es un metodo que se ejecuta una vez");
        //sr.flipX = true;
        animator = GetComponent<Animator>();

        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            run();
            rb2d.velocity = new Vector2(10,rb2d.velocity.y);
        }else
        {
            SetIdleAnimation();
            rb2d.velocity = new Vector2(0,rb2d.velocity.y);
        }


        //cuando presiono la flecha a la derecha cambio la animacion
        //Input .GetKey(); //mientras presiono
        //Input .GetKeyUp(); //cuando suelto la tecla
        //Input .GetKeyDown();//cuando presiono por primera vez
        //sr.flipX = !sr.flipX;
        //run();
         Debug.Log("hola");
    }
    public void run(){
        animator.SetInteger("Estado", 1);
    }
    //public void SetJumpAnimation(){
      //  animator.SetInteger("Estado", 1;
    //}
    public void SetIdleAnimation(){
        animator.SetInteger("Estado", 1);        
    }
}
