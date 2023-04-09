using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByRigid : MonoBehaviour
{

    Rigidbody2D rigid;
    public float jump = 1;
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
        rigid.AddForce (vec, ForceMode2D.Impulse);

        rigid.AddTorque(1);
    }
}
