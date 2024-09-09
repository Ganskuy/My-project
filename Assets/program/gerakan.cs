using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gerakan : MonoBehaviour
{
    Rigidbody2D rb;
    float spd;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spd = 4.5f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0.0);
        if(Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector2(spd,0);
        }
    }
}
