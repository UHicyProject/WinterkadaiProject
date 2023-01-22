using UnityEngine;
using UnityEngine.UI;

public class ballM : MonoBehaviour
{
    [SerializeField] private Canvas resultCanvas;
    [SerializeField] private BottonScript button;

    private void Start()
    {

        resultCanvas.gameObject.SetActive(false);
    }

    //private void OnControllerColliderHit(Collision other) 
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Finish")
        {
            button.EndGame();
            resultCanvas.gameObject.SetActive(true);
        }

    }
}
