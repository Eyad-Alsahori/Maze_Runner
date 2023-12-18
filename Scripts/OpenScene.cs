using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    void OnEnabled()
    {
        Debug.LogError("LOAD THE SCENE!!");
        // Only specifying the sceneName or sceneBuilderIndex will load the Scene with the Single mode
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single); //in parenthesis it should be our next scene
        //SceneManager.LoadScene(1);
    }

    private void Update()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

}
