using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePopup : MonoBehaviour
{
    public GameObject popup;
    Animator anim;

    public static PuzzlePopup instance { get; private set; }
    Action onClickClose;

    private void Awake()
    {
        instance = this;
        anim = popup.GetComponent<Animator>();
    }

   private void Update()
    {
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                popup.SetActive(false);
            }
        }
    }

    public void OpenPopUp(Action onClickClose)
    {
        this.onClickClose = onClickClose;
        popup.SetActive(true);
    }

    public void OnClickClose()
    {
        if(onClickClose != null)
        {
            onClickClose();
        }

        ClosePopup();
        PlayerNogravity.speed = Open_Puzzle.PuzzlespeedSave;
    }

    void ClosePopup()
    {
        anim.SetTrigger("Close");
        //popup.SetActive(false);
    }
}
