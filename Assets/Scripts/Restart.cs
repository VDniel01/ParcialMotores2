using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private int initialPlayer; // Variable para almacenar el jugador inicial
    void Start()
    {
        initialPlayer = GameManager.actualPlayer; // Almacena el jugador inicial al iniciar el juego
    }
    void Update()
    {
        GetInput();
    }
    private void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0); // Recarga la escena actual

            // Restaura el jugador inicial al reiniciar
            GameManager.actualPlayer = initialPlayer;
            GameManager.gameOver = false; // Reinicia el estado de gameOver
            GameManager.winCondition = false; // Reinicia el estado de winCondition
        }
    }
}
