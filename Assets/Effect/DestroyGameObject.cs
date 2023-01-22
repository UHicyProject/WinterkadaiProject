using UnityEngine;
using System.Collections;

public class DestroyGameObject : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player" )
        {

            Destroy(gameObject);

        }

    }
}