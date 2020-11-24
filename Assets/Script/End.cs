using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    float timer = 0;

    void Update()
    {
        if (Data.isGameOver)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                SceneManager.LoadScene("Gameover");
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}