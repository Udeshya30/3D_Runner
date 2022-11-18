using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public int levelUnlock;
    //public int LifeRemaining;
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1;
    }
    public void LoadNxtLevel()
    {
        SceneManager.LoadSceneAsync(levelUnlock);
    }
}
