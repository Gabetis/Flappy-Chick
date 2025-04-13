using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource JumpSoundSource;
    public AudioSource BackGroundMusicSource;
    public AudioSource GetPointSfxSource;
    public AudioSource DeathSfxSource;

    //Tạo audio clip (audio clip là file âm thanh)

    public AudioClip JumpSound;
    public AudioClip BackGroundMusic;
    public AudioClip GetPointSfx;
    public AudioClip Death;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BackGroundMusicSource.clip = BackGroundMusic;
        BackGroundMusicSource.Play();

        JumpSoundSource.clip = JumpSound;

        GetPointSfxSource.clip = GetPointSfx;

        DeathSfxSource.clip = Death;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Chicken") == isActiveAndEnabled)//Kiểm tra xem gà(Player) có đang hoạt động không
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                JumpSoundSource.Play();
            }
        }
        else
        {
            BackGroundMusicSource.Stop();
        }
    }
}
