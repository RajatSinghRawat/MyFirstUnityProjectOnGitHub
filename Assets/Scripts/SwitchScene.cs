using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public Button sceneButton;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        sceneButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
