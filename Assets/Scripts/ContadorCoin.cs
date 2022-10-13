using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ContadorCoin : MonoBehaviour
{
    public Text coinText;
    private int Coins;



    // Start is called before the first frame update
    void Start()
    {
        Coins = 0;
        coinText.text = "Monedas: " + Coins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Moneda)
    {
        if (Moneda.tag == "Coin") 
        {
            Coins += 1;
            Destroy(Moneda.gameObject);
            coinText.text = "Monedas: " + Coins; 
        }
    }
}
