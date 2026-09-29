using UnityEngine;

public class PlataformController : MonoBehaviour
{
    public Transform postion1;
    public Transform postion2;

    public float velocity;
    
    private bool seguindoPos1 = true;
    private Rigidbody2D rb;

    public float minimumDistance;
    private float targetX;




    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        targetX = postion1.position.x;
    }


    void Update()
    {
       float personagemX = this.gameObject.transform.position.x;
       float distance = Mathf.Abs(personagemX-targetX);

       if(distance < minimumDistance)
     
       if(seguindoPos1)
       {
           targetX = postion2.position.x;
       }
       else
       {
           targetX = postion1.position.x;
       }

        seguindoPos1 = !seguindoPos1;

    


        if(personagemX>targetX){
            rb.linearVelocity = new Vector2(-velocity, rb.linearVelocity.y);
        }else{
            rb.linearVelocity = new Vector2(velocity, rb.linearVelocity.y);
        }
    }
}
