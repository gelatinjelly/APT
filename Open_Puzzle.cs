using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Open_Puzzle : MonoBehaviour
{
    public static float PuzzlespeedSave;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F) && collision.gameObject.name == "Player")
        {
            PuzzlePopup.instance.OpenPopUp(
            () =>
            {
                Debug.Log("open puzzle popup");
            });
            PuzzlespeedSave = PlayerNogravity.speed;
            PlayerNogravity.speed = 0;
        }
    }
}