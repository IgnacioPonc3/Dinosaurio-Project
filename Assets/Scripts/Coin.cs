using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public float tiempoVivo = 0f;
    public float tiempoMaximoDeVida = 15f;
    public float velocidad = 12f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(velocidad * (Time.deltaTime), 0, 0);
        tiempoVivo += Time.deltaTime;

        if (tiempoVivo >= tiempoMaximoDeVida)
        {
            Destroy(this.gameObject);
        }
    }
}