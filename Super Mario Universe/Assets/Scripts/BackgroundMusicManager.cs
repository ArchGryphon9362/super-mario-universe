using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class BackgroundMusicManager : MonoBehaviour
{

    public static BackgroundMusicManager instance;

    AudioSource asource;
    public AudioClip start;
    public AudioClip loop;
    public AudioClip end;
    bool shouldLoop;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;

        asource = gameObject.AddComponent<AudioSource>();
        asource.clip = start;
        asource.Play();

        shouldLoop = true;
    }

    void Update()
    {
        if (asource.isPlaying == false && shouldLoop == true)
        {
            shouldLoop = false;

            asource.clip = loop;
            asource.loop = true;
            asource.Play();
        }
    }

    #region EndScene
    #region EndScene Functions
    public void EndScene(string scene)
    {
        StartCoroutine(endScene(scene));
    }

    public void EndScene(int scene)
    {
        StartCoroutine(endScene(scene));
    }

    public void EndScene(int scene, LoadSceneMode loadSceneMode)
    {
        StartCoroutine(endScene(scene, loadSceneMode));
    }

    public void EndScene(int scene, LoadSceneParameters loadSceneParameters)
    {
        StartCoroutine(endScene(scene, loadSceneParameters));
    }

    public void EndScene(string scene, LoadSceneMode loadSceneMode)
    {
        StartCoroutine(endScene(scene, loadSceneMode));
    }

    public void EndScene(string scene, LoadSceneParameters loadSceneParameters)
    {
        StartCoroutine(endScene(scene, loadSceneParameters));
    }
    #endregion

    #region endScene IEnumerators
    IEnumerator endScene(string scene)
    {
        asource.loop = false;
        shouldLoop = false;

        yield return new WaitUntil(() => asource.isPlaying == false);

        asource.clip = end;
        asource.loop = false;
        asource.Play();

        yield return new WaitUntil(() => asource.isPlaying == false);

        Destroy(asource);
        SceneManager.LoadScene(scene);
    }

    IEnumerator endScene(int scene)
    {
        asource.loop = false;
        shouldLoop = false;

        yield return new WaitUntil(() => asource.isPlaying == false);

        asource.clip = end;
        asource.loop = false;
        asource.Play();

        yield return new WaitUntil(() => asource.isPlaying == false);

        Destroy(asource);
        SceneManager.LoadScene(scene);
    }

    IEnumerator endScene(int scene, LoadSceneMode loadSceneMode)
    {
        asource.loop = false;
        shouldLoop = false;

        yield return new WaitUntil(() => asource.isPlaying == false);

        asource.clip = end;
        asource.loop = false;
        asource.Play();

        yield return new WaitUntil(() => asource.isPlaying == false);

        Destroy(asource);
        SceneManager.LoadScene(scene, loadSceneMode);
    }

    IEnumerator endScene(int scene, LoadSceneParameters loadSceneParameters)
    {
        asource.loop = false;
        shouldLoop = false;

        yield return new WaitUntil(() => asource.isPlaying == false);

        asource.clip = end;
        asource.loop = false;
        asource.Play();

        yield return new WaitUntil(() => asource.isPlaying == false);

        Destroy(asource);
        SceneManager.LoadScene(scene, loadSceneParameters);
    }

    IEnumerator endScene(string scene, LoadSceneMode loadSceneMode)
    {
        asource.loop = false;
        shouldLoop = false;

        yield return new WaitUntil(() => asource.isPlaying == false);

        asource.clip = end;
        asource.loop = false;
        asource.Play();

        yield return new WaitUntil(() => asource.isPlaying == false);

        Destroy(asource);
        SceneManager.LoadScene(scene, loadSceneMode);
    }

    IEnumerator endScene(string scene, LoadSceneParameters loadSceneParameters)
    {
        asource.loop = false;
        shouldLoop = false;

        yield return new WaitUntil(() => asource.isPlaying == false);

        asource.clip = end;
        asource.loop = false;
        asource.Play();

        yield return new WaitUntil(() => asource.isPlaying == false);

        Destroy(asource);
        SceneManager.LoadScene(scene, loadSceneParameters);
    }
    #endregion
    #endregion

}
