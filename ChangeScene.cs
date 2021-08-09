using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string transferMapName;
    //private Playerxy thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        //thePlayer = FindObjectOfType<Playerxy>(); // GetComeponent는 단일객체이고, FindObjectOfType는 하이어라키에 있는 모든 객책의 컴포너트를 검색해서 리턴
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F) && collision.gameObject.name == "Player")
        {
            //thePlayer.currenMapName = transferMapName;
            SceneManager.LoadScene(transferMapName);
        }
    }

// Update is called once per frame
    void Update()
    {

    }
}