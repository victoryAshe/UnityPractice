using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DropDownPanelCtrl : MonoBehaviour
{

    public class itemData
    {
        public string itemName;
        public int itemPrice;


        public itemData(string itemName, int itemPrice)
        {
            this.itemName = itemName;
            this.itemPrice = itemPrice;
        }


    }

    public Dictionary<string, itemData[]> Shop = new Dictionary<string, itemData[]>()
    {
        {"�����", new itemData[3] {new itemData("�㸧�� �����",100), new itemData("����� �����", 1000), new itemData("����� �����", 10000) } },
        {"Ű����", new itemData[3] {new itemData("�㸧�� Ű����",100), new itemData("����� Ű����",1000), new itemData("����� Ű����",10000) } },
        {"���콺", new itemData[3] {new itemData("�㸧�� ���콺",100), new itemData("����� ���콺",1000), new itemData("����� ���콺",10000) } }
    };

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
