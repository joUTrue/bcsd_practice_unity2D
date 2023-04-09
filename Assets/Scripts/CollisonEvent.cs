using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonEvent : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Material material;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        material = sprite.material;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            material.color = new Color(1, 1, 1);
        }
    }
}
