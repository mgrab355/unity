using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuUi : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;    
    }

    // Update is called once per frame
public void startGameButton(){
    SceneManager.LoadScene(1);
}
public void endGamebutton(){
    Application.Quit();
}
}