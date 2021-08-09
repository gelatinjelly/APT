using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static float PauspeedSave;
    public void PushEscape()
    {
        Popup.Instance.PushEsc(
        "PAUSE", 
        "Continue", 
        "Retry", 
        "Game Quit",
        () =>
        {
            Debug.Log("Push Escape Popup");
        });

        PauspeedSave = PlayerNogravity.speed;
        PlayerNogravity.speed = 0;
    }
}
