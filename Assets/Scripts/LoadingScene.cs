using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;
public class LoadingScene : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;
    [SerializeField]
    private TextMeshProUGUI _percent;
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SampleScene");

        while (!asyncLoad.isDone)
        {
            _slider.value= asyncLoad.progress;
            _percent.text = (asyncLoad.progress * 100) + "%";
            yield return null;
        }
    }
}
