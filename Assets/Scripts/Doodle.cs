using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doodle : MonoBehaviour
{
    private float _horizontal;
    
    public static Doodle Instance;
    public Rigidbody2D doodleRigid;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            _horizontal = Input.acceleration.x;
        }

        if (Input.acceleration.x < -0.06)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.acceleration.x > 0.08)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        doodleRigid.velocity = new Vector2(Input.acceleration.x * 8.5f, doodleRigid.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            RestartMenu.Instance.Restart();
        }
    }
}
