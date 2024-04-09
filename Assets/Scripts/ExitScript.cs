using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("CarSelect");
    }
}
