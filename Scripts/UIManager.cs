using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    /*
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    */

    public GameObject gameOverMenu;

    private void OnEnable()
    {
  //      Player.OnPlayerWin += EnableGameOverMenu;
    }

    private void OnDisable()
    {
   //     Player.OnPlayerWin -= EnableGameOverMenu;
    }

    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
        //SceneManager.LoadScene(1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
