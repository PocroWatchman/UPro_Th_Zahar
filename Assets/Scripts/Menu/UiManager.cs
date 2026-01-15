using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] 
    private GameObject _panelMain;
    [SerializeField] 
    private GameObject _panelSetting;
    [SerializeField]
        private GameObject _panelChoose;
   private void Start()
    {
        OpenMain();
    }
     public void OpenMain()
    {
        _panelMain.SetActive(true);
        _panelSetting.SetActive(false);
         _panelChoose.SetActive(false);
    }
    public void OpenSettings()
    {
        _panelMain.SetActive(false);
        _panelSetting.SetActive(true);
        _panelChoose.SetActive(false);
    }

    public void OpenChoose()
    {
        _panelMain.SetActive(false);
        _panelSetting.SetActive(false);
        _panelChoose.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }


}
