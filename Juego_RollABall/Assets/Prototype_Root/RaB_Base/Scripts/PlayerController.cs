using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Public References")]
    public Rigidbody playerRb; // Variable para referenciar el rigidbody del jugador, y así modificarlo cuando quera por código

    [Header("Movement Variables")]
    public float speed;
    private float horInput; //Almacén del vector X del Input
    private float verInput; //Almacén del vector Y del Input (Se lo pasaré al eje Z)

    [Header("Jump Variables")]
    public float jumpForce;
    public bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Conectar las variables float al Input de teclado
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");
        Jump();
    }

    void FixedUpdate()
    {
        Movement();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }


    void Movement()
    {
        // Velocidad del rigidbody = Vector3 (Movimiento en X, constante Y, movimiento en Z)
        playerRb.velocity = new Vector3(horInput * speed, playerRb.velocity.y, verInput * speed);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                isGrounded = false;
                playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
