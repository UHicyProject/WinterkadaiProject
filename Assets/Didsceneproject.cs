using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Didsceneproject : MonoBehaviour
{
    [SerializeField] private Canvas resultCanvas;
    [SerializeField] private Button loadButton;

    private void Awake()
    {

        loadButton = GetComponent<Button>();

    }
    private void Start()
    {

        loadButton.onClick.AddListener(SampleScene);
    }
    public void SampleScene()
    {

        resultCanvas.gameObject.SetActive(false);


    }
}

    
  
   