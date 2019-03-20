using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Button playButton;

    void Start()
    {
        playButton.onClick.AddListener(Play);
    }

    void Play()
    {
        Debug.Log("button clicked");
        //Application.LoadLevel("MeshGenerator");
        SceneManager.LoadScene(1,LoadSceneMode.Single);
    }
}
