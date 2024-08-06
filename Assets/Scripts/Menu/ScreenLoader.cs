using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public Slider progressBar;
    public float loadDuration; 

    private float time;

    void Start()
    {
        loadDuration = Random.Range(2f, 4f);
        progressBar.value = 0;
        time = 0;
    }

    void Update()
    {
        if (time < loadDuration)
        {
            time += Time.deltaTime;
            progressBar.value = Mathf.Clamp01(time / loadDuration);
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
