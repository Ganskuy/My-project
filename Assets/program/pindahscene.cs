using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pindahscene : MonoBehaviour
{
    // Start is called before the first frame update
    public void scene1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void scene2()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void scene3()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void scene4()
    {
        SceneManager.LoadScene("Scene4");
    }
}
