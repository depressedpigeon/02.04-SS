using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{

    public void Load(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
