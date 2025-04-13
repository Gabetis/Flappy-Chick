using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpforce = 2f;
    public Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {                                         
            rb.linearVelocity = Vector2.zero; //linearVelociry là thể hiện vận tốc hiện tại của đối tượng giữa 2 hướng x,y 
                                              //Đồng thời câu lệnh này giúp reset vận tốc hiện của đối tượng về 0
                                              //VD nếu như ko rs vật tốc về 0 thì trong quá trình chim bay lên
                                              //hay rớt xuống vận tốc cũ vẫn sẽ còn đó và nó sẽ ảnh hướng tới
                                              //quá trình nhảy tiếp theo vì vậy trước khi nhảy phải luôn có 1 lệnh 
                                              //để reset vận tốc 
                                              //do vector2.zero là viết tắt của vector2(0,0)
            rb.AddForce(Vector2.up * jumpforce,ForceMode2D.Impulse); //impulse = áp dụng lực tức thời
        }
        //if(Input.GetKeyDown("d"))
        //{
        //    rb.AddForce(Vector2.right * 4, ForceMode2D.Impulse);
        //}
    }
}
