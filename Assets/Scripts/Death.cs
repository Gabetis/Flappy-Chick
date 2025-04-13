using Unity.VisualScripting;
using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collisioninformation)
    {
        if (collisioninformation.collider.CompareTag("Player"))
        {
            FindAnyObjectByType<GameManager>().OnGameOver();
            FindAnyObjectByType<GameManager>().DeathAnimation();
            GameObject.Find("Audio Manager").GetComponent<AudioManager>().DeathSfxSource.Play();
            //tìm GameObject có tên là Audio Manager và chạy hàm DeathSfxSource.Play()
        }
    }
}
