using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    public void OnButtonDown()
    {

        SceneLoader.instance.LoadScene("OutdoorsScene");

    }

}