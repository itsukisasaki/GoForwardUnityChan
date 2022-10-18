using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("衝突" + other.gameObject.tag);
        if (other.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }

        if (other.gameObject.tag == "GroundTag")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}