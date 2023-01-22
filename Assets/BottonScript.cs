using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;
using PlayerMain;
public class BottonScript : MonoBehaviour
{
    [SerializeField] private PlayerScript player;
    [SerializeField] public Button left;
    [SerializeField] public Button right;
    [SerializeField] public Button leftup;
    [SerializeField] public Button rightup;

    private CompositeDisposable disposables = new();
    void Start()
    {
        left.OnPointerDownAsObservable().Subscribe(_ => player.LeftPushDown()).AddTo(disposables);
        left.OnPointerUpAsObservable().Subscribe(_ => player.LeftPushUp()).AddTo(disposables);

        right.OnPointerDownAsObservable().Subscribe(_ => player.RightPushDown()).AddTo(disposables);
        right.OnPointerUpAsObservable().Subscribe(_ => player.RightPushUp()).AddTo(disposables);

        leftup.OnClickAsObservable().Subscribe(_ => player.OnLeftJump()).AddTo(disposables);
        rightup.OnClickAsObservable().Subscribe(_ => player.OnrightJump()).AddTo(disposables);
    }

    
    public void EndGame()
    {
        disposables.Dispose();
    }
}
