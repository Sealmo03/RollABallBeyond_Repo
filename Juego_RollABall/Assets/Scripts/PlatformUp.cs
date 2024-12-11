using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUp : MonoBehaviour
{

    public float UpSpeed;
    public float maxHeight;

        private void OnCollisionStay(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player") && transform.position.y < maxHeight)
            {
                transform.Translate(Vector3.up * UpSpeed * Time.deltaTime);
            }
        }
}
