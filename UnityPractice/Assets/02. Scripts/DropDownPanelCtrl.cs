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
        {"모니터", new itemData[3] {new itemData("허름한 모니터",100), new itemData("평범한 모니터", 1000), new itemData("고오급 모니터", 10000) } },
        {"키보드", new itemData[3] {new itemData("허름한 키보드",100), new itemData("평범한 키보드",1000), new itemData("고오급 키보드",10000) } },
        {"마우스", new itemData[3] {new itemData("허름한 마우스",100), new itemData("평범한 마우스",1000), new itemData("고오급 마우스",10000) } }
    };

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
