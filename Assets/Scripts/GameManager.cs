using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        if(gameManager != null)
        {
            GameObject.Destroy(this.gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            gameManager = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToNextLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
