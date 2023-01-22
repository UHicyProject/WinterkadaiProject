using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class newsceneproject : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private Button loadButton;

    private void Awake() {

        loadButton = GetComponent<Button>();

        if (loadButton == null) {

            Debug.LogError(message: "ボタンも付けられないお兄ちゃんのざぁこざぁこ♡");
        }
        if (sceneName == null) {

            Debug.LogError(message: "シーンも設定できないよわよわお兄ちゃん♡");
        }
    }

    private void Start()
    {
        loadButton.onClick.AddListener(SampleScene);
    }

    public void SampleScene(){

        Debug.Log(message: "しょうがないからシーンをロードするよ。ダメダメおにいちゃん♡");
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
}
}
