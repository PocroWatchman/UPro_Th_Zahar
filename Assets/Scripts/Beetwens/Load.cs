using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : Singleton<Load>
{
    public float load = 0f;
    public IEnumerator LoadScene(int index)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(index);
        asyncLoad.allowSceneActivation = false;
        while (asyncLoad.progress < 0.9f)
        {
            load = asyncLoad.progress;
            yield return null;
        }
        asyncLoad.allowSceneActivation = true;
        while (!asyncLoad.isDone)
        {
            load = asyncLoad.progress;
            yield return null;
        }
        load = 0;
    }
}
