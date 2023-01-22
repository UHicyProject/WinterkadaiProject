using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private MainCoinScript coinCount;
    [SerializeField] private int _coinVar = 1;

    public void InitScore(MainCoinScript coinVar)
    {
        coinCount = coinVar;
    }

    public void ScoreReference(MainCoinScript reference)
    {
        coinCount = reference;
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Coin"))
        {

            coinCount.Addcoin(_coinVar);
            
        }
    }
}
