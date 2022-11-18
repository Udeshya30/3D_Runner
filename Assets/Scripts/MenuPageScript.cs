using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPageScript : MonoBehaviour
{
    public GameObject[] task;
    public Button[] lvlBtn;
    // Start is called before the first frame update
    void Start()
    {
        HideAllTask();
        task[0].gameObject.SetActive(true);
        int levelActivated = PlayerPrefs.GetInt("level");
        for (int i = 0; i < levelActivated; i++)
        {
            lvlBtn[i].interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //To activate desired task page
    public void NxtTask(int n)
    {
        HideAllTask();
        task[n].gameObject.SetActive(true);
    }

    //use to hide all task pages
    void HideAllTask()
    {
        for (int i = 0; i < task.Length; i++)
        {
            task[i].gameObject.SetActive(false);
        }
    }

    public void loadScene(int n)
    {
        SceneManager.LoadSceneAsync(n);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }
}
