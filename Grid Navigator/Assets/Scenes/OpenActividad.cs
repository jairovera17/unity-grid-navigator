using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenActividad : MonoBehaviour
{

    public void openActivity()
    {
        SceneManager.LoadScene("Actividad");
    }

    public void returnOrigin()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
