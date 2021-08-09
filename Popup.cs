using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    public GameObject GmObj;
    public Image img;
    Animator ani;

    public static Popup Instance { get; private set; }

    public Text txtTitle, txtContent1, txtContent2, txtContent3;
    Action onClickContinue;

    private void Awake()
    {
        Instance = this;
        ani = GmObj.GetComponent<Animator>();
    }

    /*private void Update()
    {
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("PopUp"))
        {
            if(ani.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            GmObj.SetActive(false);
        }
    }*/

    public void PushEsc(
        string title,
        string content1,
        string content2,
        string content3,
        Action onClickContinue)
    {
        txtTitle.text = title;
        txtContent1.text = content1;
        txtContent2.text = content2;
        txtContent3.text = content3;
        this.onClickContinue = onClickContinue;
        GmObj.SetActive(true);
        img.gameObject.SetActive(true);
    }

    public void OnClickContinue()
    {
        if(onClickContinue != null)
        {
            onClickContinue();
        }

        PopupClose();
        PlayerNogravity.speed = Pause.PauspeedSave;
    }

    void PopupClose()
    {
        ani.SetTrigger("PopUp");
        GmObj.SetActive(false);
        img.gameObject.SetActive(false);
    }
}
