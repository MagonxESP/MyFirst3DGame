using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float maxTime = 60f; // segundos
    private float countDown = 0f;

    // Start is called before the first frame update
    void Start() {
        countDown = maxTime;
    }

    // Update is called once per frame
    void Update() {
        countDown -= Time.deltaTime;

        Debug.Log("Quedan " + countDown + " segundos para terminar");

        if (countDown <= 0) {
            Debug.Log("Has perdio!!");
        }
    }

    private void RestartScene() {
        Moneda.cantidadMonedas = 0;
        SceneManager.LoadScene("MainScene");
    }
}
