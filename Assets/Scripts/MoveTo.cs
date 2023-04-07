using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    Vector2 target = new Vector2 (10, 0);
    public float control = 1;
    // Update is called once per frame
    void Update()
    {
        //1.Movetoward
        //transform.position = Vector2.MoveTowards(transform.position, target, control);

        //2. SmoothDamp
        //Vector2 velo = Vector2.zero;
        //transform.position = Vector2.SmoothDamp(transform.position, target, ref velo, control);

        //3. Lerp
        transform.position = Vector2.Lerp(transform.position, target, control);

        //2D SLerpX
    }
}
