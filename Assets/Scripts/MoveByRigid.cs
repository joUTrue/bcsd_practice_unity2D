using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByRigid : MonoBehaviour
{

    Rigidbody2D rigidbody;
    public float jump = 1;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        //rigidbody.velocity = Vector3.right;
    }

    private void FixedUpdate()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    rigidbody.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        //}

        //Vector2 vec = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        //rigidbody.AddForce (vec, ForceMode2D.Impulse);

        rigidbody.AddTorque(1);
    }
}
