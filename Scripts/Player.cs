using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int keys = 0;
    public float speed = 5.0f;
    public Text youWin;
    public GameObject door;
    public GameObject mazeLevel2Prefab;
    public GameObject mazeLevel3Prefab;
    void Update()
    {
        MovePlayer();

        if (keys >= 3)
        {
            OpenDoor();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Keys")
        {
            keys++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Princess")
        {
            SceneManager.LoadScene("gameoverscene");
            //youWin.text = "YOU WIN!!!";

        }



        if (collision.gameObject.tag == "Prince")
        {
            //  youWin.text = "YOU WIN!!!";
            // Load the next level when the player touches the prince
            LoadNextLevel();
        }

        if (collision.gameObject.tag == "Prince2")
        {
            //  youWin.text = "YOU WIN!!!";
            // Load the next level when the player touches the prince
            LoadNextLevel1();
        }

        if (collision.gameObject.tag == "Enemies")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("Enemy Hit");
        }

        BounceOffWalls(collision.gameObject);
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
    }

    void BounceOffWalls(GameObject wall)
    {
        if (wall.tag == "Walls")
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
        }
    }

    void OpenDoor()
    {
        GameObject door = GameObject.FindGameObjectWithTag("Doorz");

        if (door != null)
        {
            Destroy(door);
        }
    }


    void LoadNextLevel()
    {
        Destroy(GameObject.Find("Maze_level1"));
        Destroy(gameObject);

        // Instantiate the Maze_level2 prefab
        Instantiate(mazeLevel2Prefab);
    }

    void LoadNextLevel1()
    {
        Destroy(GameObject.Find("Maze_level2(Clone)"));
        Destroy(gameObject);

        // Instantiate the Maze_level2 prefab
        Instantiate(mazeLevel3Prefab);
    }

}


