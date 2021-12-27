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
        //Unity Action ���
        action = () => OnButtonClick();
        panelButton.onClick.AddListener(action);

        //����޼��� ���
        //panelButton.onClick.AddListener(delegate { OnButtonClick(); });

        //���ٽ� ���
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
