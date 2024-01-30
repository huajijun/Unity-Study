using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public AudioClip m;

    // 单例模式，确保只有一个 AudioManager 实例存在
    public static AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject audioManagerObject = new GameObject("AudioManager");
                instance = audioManagerObject.AddComponent<AudioManager>();
            }
            return instance;
        }
    }

    private AudioSource audioSource;

    private void Awake()
    {
        // 如果 AudioManager 实例已存在，则销毁新创建的对象
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // 将 AudioManager 实例设置为当前对象
        instance = this;
        DontDestroyOnLoad(gameObject);

        // 添加 AudioSource 组件用于播放音乐
        audioSource = gameObject.AddComponent<AudioSource>();
        PlayMusic(m);
    }

    // 播放音乐的方法
    public void PlayMusic(AudioClip music)
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        audioSource.clip = music;
        // audioSource.loop = true; // 设置循环播放
        audioSource.Play();
    }
}