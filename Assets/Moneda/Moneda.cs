using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour {

    public static int cantidadMonedas = 0;

    // Start is called before the first frame update
    void Start() {
        Moneda.cantidadMonedas++;
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Algo ha colisionado con la moneda");

        if (other.CompareTag("Player")) {
            Moneda.cantidadMonedas--;

            if (Moneda.cantidadMonedas == 0) {
                Debug.Log("El juego ha terminado");
                GameObject gameManager = GameObject.Find("GameManager");
                Destroy(gameManager); // destruir gameManager para terminar con el temporizador
                GameObject[] fireworks = GameObject.FindGameObjectsWithTag("Fireworks");

                foreach (GameObject firework in fireworks) {
                    firework.GetComponent<ParticleSystem>().Play();
                }
            }

            Destroy(gameObject);
        }
    }

}
