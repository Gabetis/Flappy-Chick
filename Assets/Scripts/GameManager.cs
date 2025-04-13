using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject DeadChicken;
    public GameObject Chicken;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnGameOver()
    {
        Time.timeScale = 1f; //chỉnh tốt độ của game = 0 (dừng game)
        gameOverUI.SetActive(true); //bật UI game over lên 
    }

    public void Replay()
    {
        SceneManager.LoadScene("Replay");
        Time.timeScale = 1.0f;
    }

    public void DeathAnimation()
    {
        Chicken.SetActive(false);//Dấu con gà đi khi chết
        DeadChicken.transform.position = Chicken.transform.position;
        rb = DeadChicken.GetComponent<Rigidbody2D>();
        DeadChicken.SetActive(true);
        rb.AddForce(Vector2.left + Vector2.up * 10, ForceMode2D.Impulse); //PHẢI BẬT BẬT DEADCHICKEN LÊN TRƯỚC KHI ADDFORCE
                                                                          //NẾU KO NÓ SẼ KO LẤY ĐƯỢC GIÁ TRỊ ĐỂ TÍNH TOÁN  
    }
}