using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("OtherSceneName" , LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadB (int sceneANumber){
            
            SceneManager.LoadScene(sceneANumber);
    }
}
