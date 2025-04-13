using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI Scoretxt;
    private int Scored;

    private void Start()
    {
        GameObject ObjectFind = GameObject.Find("Scored showboard");//Tìm object bên hierychi và đặt tên biến là ObjectFind
        Scoretxt = ObjectFind.GetComponent<TextMeshProUGUI>();//sau đó lấy cái phần TextMestProUGUI bên Scored showboard
       //Gán Scoretxt bên phần TextMeshProUGUI = cái mới tìm được bằng lệnh getcomponent
    }
    private void OnTriggerEnter2D(Collider2D ColliderInformation)
    {
        if(ColliderInformation.CompareTag("Player"))
        {
            Scored = int.Parse(Scoretxt.text); //chuyển chuỗi bên text sang int và gán cho Scored
            Scored += 1;
            Scoretxt.text = Scored.ToString();
            GameObject.Find("Audio Manager").GetComponent<AudioManager>().GetPointSfxSource.Play();//Tìm AudioManager và chạy hàm GetPointSfxSource.Play() 
        }
    }
}
