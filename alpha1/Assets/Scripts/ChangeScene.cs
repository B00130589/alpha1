using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string URL = "https://github.com/B00130589/alpha1";
   public void GoToScne1()
    {
        SceneManager.LoadScene("scene1");
    }
    public void GoToSene2()
    {
        SceneManager.LoadScene("scene2");
    }

    public void LoadUrl()
    {
        Application.OpenURL(URL);
    }
}
