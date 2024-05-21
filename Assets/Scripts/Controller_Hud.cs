using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller_Hud : MonoBehaviour
{
    public Text gameOverText;
    void Start()
    {
        gameOverText.gameObject.SetActive(false); // Desactiva el texto de Game Over al inicio del juego
    }
    void Update()
    {
        // Verifica si el juego ha terminado
        if (GameManager.gameOver)
        {
            Time.timeScale = 0; // Pausa el juego
            gameOverText.text = "Game Over"; 
            gameOverText.gameObject.SetActive(true); // Activa el texto de Game Over
        }
        // Verifica si se ha cumplido la condición de victoria
        else if (GameManager.winCondition)
        {
            Time.timeScale = 0; 
            gameOverText.text = "You Win"; 
            gameOverText.gameObject.SetActive(true); 
        }
    }
}

