using Unity.VisualScripting;
using UnityEngine;

public class spawnrandom_y_speed : MonoBehaviour
{
    public float speed;
    void Start()
    {
        transform.position = new Vector3(transform.position.x,Random.Range(-2.1f, 2.32f),0);// transform ở đây là transform của đối tượng (spawnrandom)
                     //transform.position.x để pipe spawn đúng vị trị ở scirpt PipeSpawner  // mà script đang được gắn vào sau đó gán giá trị vector3 mới vào 
                                                                                            // transform
    }

    void Update()
    {
        transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
        if(transform.position.x < -5)
        {
            Destroy(gameObject); //phá hủy gameobject (Pipe) khi vượt qua -5
        }    

    }
}
