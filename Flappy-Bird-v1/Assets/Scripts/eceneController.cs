using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject LoserCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YouLose()
    {
        LoserCanvas.SetActive(true);
        //SceneManager.loadScene(1);
        Time.timeScale = 0;
        
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene (0);
    }
}
