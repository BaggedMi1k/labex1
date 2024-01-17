using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabEx1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         int muffinPrice = 5;
         int donutsPrice = 3;
         int muffinSold = 200;
         int donutsSold = 450;

        Debug.Log("Muffin price:" + muffinPrice);
        Debug.Log("Quantity of muffins sold:" + muffinSold);
        Debug.Log("Donuts price:" +  donutsPrice);
        Debug.Log("Quantity of donuts sold:" + donutsSold);
        Debug.Log("Muffin sales:" + muffinPrice * muffinSold + "$");
        Debug.Log("Donut sales:" + donutsPrice * donutsSold + "$");
        Debug.Log("A total of " + (muffinSold + donutsSold) + " items were sold");
        Debug.Log("$" + (muffinPrice * muffinSold + donutsPrice * donutsSold) + " was collected in sales");
    }

    [SerializeField] int MuffinsSold;
    [SerializeField] int DonutsSold;
    [SerializeField] int muffinPrice;
    [SerializeField] int donutsPrice;


    // Update is called once per frame
    void Update()
    {
        
    }
}
