using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoTextEnable : MonoBehaviour
{
    public GameObject infoText;

    public void LoadText()
    {
        infoText.SetActive(true);
    }
    public void UnloadText()
    {
        infoText.SetActive(false);
    }
}
