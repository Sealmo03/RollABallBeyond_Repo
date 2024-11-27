using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDown : MonoBehaviour
{

    public float fallSpeed;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
        }
    }
}
