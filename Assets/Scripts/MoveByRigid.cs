using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByRigid : MonoBehaviour
{

    Rigidbody2D rigid;
    public float jump = 1, speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        //rigid.velocity = Vector3.right;
    }

    private void FixedUpdate()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    rigid.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        //}

        Vector2 vec = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(vec*speed);

        //rigid.AddTorque(1);
    }

    public void Jump()
    {
            rigid.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        
    }
}
