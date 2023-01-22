using UnityEditor.UI;
using UnityEngine;
using TMPro;
public class MainCoinScript : MonoBehaviour
{
    [SerializeField] public int coinPool = 0;
    [SerializeField] private int coinCount=0; 
    [SerializeField] private TextMeshProUGUI coinTM;
    /*private void OnTriggerEnter2D(Collider2D coll)
    {
            
        if (coll.CompareTag("Coin")){
            
            coinCount++;
        }
    }*/
   
    private void Awake()
    {
        if (coinTM == null)
        {
            coinTM = GetComponent<TextMeshProUGUI>();
        }

    }
        public void Addcoin(int coinInt)
        {

            coinCount += coinInt;
            coinPool++;
            coinTM.text = coinCount.ToString();
        }
    
}
