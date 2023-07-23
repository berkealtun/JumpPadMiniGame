using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public static GameManager inst;
    public TextMeshProUGUI healthText;
    public int health = 3;
    public GameObject player;
    public Transform spawnPoint;
    public Camera cam;
    public GameObject ball;
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        inst = this;
        health = 3;
    }
    public void TotalScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
    public void Health()
    {
        health--;
        healthText.text = "Health: " + health;
        if (health == 0)
        {
            player.transform.position = spawnPoint.position;
            health = 3;
            healthText.text = "Health: " + health;
        }
    }
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            cam.gameObject.SetActive(true);
        }
        else
        {
            cam.gameObject.SetActive(false);
        }
        if (score == 10)
        {
            ball.gameObject.SetActive(true);
        }
    }
}
