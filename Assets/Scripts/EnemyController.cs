using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform postion1;
    public Transform postion2;

    public float velocity;
    
    private bool seguindoPos1 = true;
    private Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(this.gameObject.transform.position.x>postion1.position.x){
            rb.linearVelocity = new Vector2(-velocity, rb.linearVelocity.y);
        }else{
            rb.linearVelocity = new Vector2(velocity, rb.linearVelocity.y);
        }
    }
}
