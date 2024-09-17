using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour

{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject optionsMenu;
    // Start is called before the first frame update
    public void StartPlaying()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void LogOff()
    {
        Application.Quit();
    }

    //public void Options()
    //{
    //    if (Input.GetMouseButtonDown(0)&&CompareTag("Options"))
    //    {
    //        mainMenu.SetActive(false);
    //        optionsMenu.SetActive(true);
    //    }
    //    else
    //    {
    //        optionsMenu.SetActive(false);
    //        mainMenu.SetActive(true);
    //    }
    //}
}


