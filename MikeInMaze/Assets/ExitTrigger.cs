using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(2);
    }

}
