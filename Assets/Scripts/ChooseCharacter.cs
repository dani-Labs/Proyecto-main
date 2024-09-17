using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseCharacter : MonoBehaviour
{
    public bool nora = false;
    public bool barbie = false;
    public bool ethan= false;

    public void ChooseNora()
    {
        nora = true;
        barbie = false;
        ethan = false;
        SceneManager.LoadScene(1);
    }
    public void ChooseBarbie()
    {
        nora = false;
        barbie = true;
        ethan = false;
        SceneManager.LoadScene(1);
    }
    public void ChooseEthan()
    {
        nora = false;
        barbie = false;
        ethan = true;
        SceneManager.LoadScene(1);
    }
}
