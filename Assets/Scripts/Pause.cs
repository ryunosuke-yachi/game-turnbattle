using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject pause;//ポーズUI
    [SerializeField]
    GameObject ToTitle;//タイトルへ戻るかのUI
    // Start is called before the first frame update
    void Start()
    {
        pause.SetActive(false);
        ToTitle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            DisplayPause();
        }
    }

    public void DisplayPause()
    {
        pause.SetActive(true);
        ToTitle.SetActive(false);
    }

    public void DisplayToTitle()
    {
        pause.SetActive(true);
        ToTitle.SetActive(true);
    }

    public void ClosePause()
    {
        pause.SetActive(false);
        ToTitle.SetActive(false);
    }

    public void  ChangeToTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
