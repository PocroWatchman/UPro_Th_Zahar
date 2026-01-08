using System.Collections;
using UnityEngine;
using TMPro;
using DG.Tweening;


public class EntryPointBootsrap : MonoBehaviour
{
    [SerializeField]
    private TMP_Text text;
    private void Start()
    {
        StartCoroutine(AnimAndLoadScene());
   
}
    private IEnumerator AnimAndLoadScene()
    {
        text.DOColor(new Color(1, 1, 1, 1), 2f);
        yield return new WaitForSeconds(2f);
        yield return Load.instanse.LoadScene(1);
    }
    

    }
