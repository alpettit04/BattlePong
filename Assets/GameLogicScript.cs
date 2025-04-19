using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameLogicScript : MonoBehaviour
{
    private int numPlayers = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayerJoined(PlayerInput input)
    {
        var playerScript = input.gameObject.GetComponent<PlayerScript>();
        playerScript.Paddle = GameObject.FindGameObjectWithTag(input.playerIndex == 0 ? "LPaddle" : "RPaddle");

        if(++numPlayers == 2)
            StartGame();
    }

    public void OnPlayerLeft() 
    {
        numPlayers--;
        EndGame();
    }

    private void StartGame()
    {
        
    }

    private void EndGame()
    {
    }
}
