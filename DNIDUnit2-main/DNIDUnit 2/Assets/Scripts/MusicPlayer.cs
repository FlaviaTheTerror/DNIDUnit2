using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MusicPlayer : MonoBehaviour
{
    private static MusicPlayer instance = null;
    public static MusicPlayer Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource source in audioSources)
        {
            // Check if there is another active AudioSource in the scene and it is not this one
            if (source != this.GetComponent<AudioSource>() && source.isPlaying)
            {
                this.GetComponent<AudioSource>().Stop();
                break; // Stop checking other sources once one is found playing
            }
        }
    }

    void OnDestroy()
    {
        // Unregister the event to avoid memory leaks
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
