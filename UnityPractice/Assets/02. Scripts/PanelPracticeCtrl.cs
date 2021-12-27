using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PanelPracticeCtrl : MonoBehaviour
{
    public Button panelButton;
    public GameObject Panel;

    private UnityAction action;

    void Start()
    {
        //Unity Action 사용
        action = () => OnButtonClick();
        panelButton.onClick.AddListener(action);

        //무명메서드 사용
        //panelButton.onClick.AddListener(delegate { OnButtonClick(); });

        //람다식 사용
        //panelButton.onClick.AddListener(() => OnButtonClick());
    }

    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        Panel.SetActive(true);
    }
}
