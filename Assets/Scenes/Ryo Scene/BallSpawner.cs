//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BallSpawner : MonoBehaviour
//{
//    // Start is called before the first frame update
//    public GameObject ballPrefab;
//    public float spawnInterval = 2f;
//    private float timer = 0f;

//    void Update()
//    {
//        timer += Time.deltaTime;

//        if (timer >= spawnInterval)
//        {
//            SpawnBall();
//            timer = 0f;
//        }
//    }

//    void SpawnBall()
//    {
//        // �{�[���𐶐����鏈��
//        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

//        // �V�����{�[���̐����ʒu���Œ肷��i��: x���W��0�Ay���W��5�j
//        newBall.transform.position = new Vector2(5f, 5f);

//        // �{�[����Rigidbody2D��ǉ����āA�d�͂������悤�ɂ���
//        Rigidbody2D ballRigidbody = newBall.GetComponent<Rigidbody2D>();
//        if (ballRigidbody == null)
//        {
//            ballRigidbody = newBall.AddComponent<Rigidbody2D>();
//        }

//        // �d�͂������悤�ɂ���
//        ballRigidbody.gravityScale = 1.0f;
//    }

//}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BallSpawner : MonoBehaviour
//{
//    public GameObject ballPrefab;
//    public float spawnInterval = 2f;
//    private float timer = 0f;

//    void Update()
//    {
//        timer += Time.deltaTime;

//        if (timer >= spawnInterval)
//        {
//            SpawnBall();
//            timer = 0f;
//        }
//    }

//    void SpawnBall()
//    {
//        // �{�[���𐶐����鏈��
//        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

//        // �{�[����Rigidbody2D��ǉ����āA�d�͂������悤�ɂ���
//        Rigidbody2D ballRigidbody = newBall.GetComponent<Rigidbody2D>();
//        if (ballRigidbody == null)
//        {
//            ballRigidbody = newBall.AddComponent<Rigidbody2D>();
//        }

//        // �V�����{�[���̐����ʒu�������_���Ɏw�肷��i��: x���W�̓����_���Ay���W��5�j
//        float randomX = Random.Range(-5f, 5f);
//        newBall.transform.position = new Vector2(randomX, 5f);

//        // �d�͂������悤�ɂ���
//        ballRigidbody.gravityScale = 1.0f;
//    }
//}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BallSpawner : MonoBehaviour
//{
//    public GameObject ballPrefab;
//    private float spawnInterval = 2f;
//    private float timer = 0f;

//    void Update()
//    {
//        timer += Time.deltaTime;

//        if (timer >= spawnInterval)
//        {
//            SpawnBall();
//            timer = 0f;
//        }
//    }

//    void SpawnBall()
//    {
//        // �{�[���𐶐����鏈��
//        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

//        // �{�[����Rigidbody2D��ǉ����āA�d�͂������悤�ɂ���
//        Rigidbody2D ballRigidbody = newBall.GetComponent<Rigidbody2D>();
//        if (ballRigidbody == null)
//        {
//            ballRigidbody = newBall.AddComponent<Rigidbody2D>();
//        }

//        // ��ʊO�ɏo����V������������
//        StartCoroutine(DestroyOutOfScreen(newBall));
//    }

//    IEnumerator DestroyOutOfScreen(GameObject ball)
//    {
//        while (true)
//        {
//            // ��ʊO�ɏo����{�[�����폜���A�V�����{�[���𐶐�����
//            if (!IsVisibleFromCamera(ball.GetComponent<Renderer>()))
//            {
//                Destroy(ball);
//                break;
//            }

//            yield return null;
//        }
//    }

//    bool IsVisibleFromCamera(Renderer renderer)
//    {
//        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);

//        return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
//    }
//}






//using UnityEngine;

//public class BallSpawner : MonoBehaviour
//{
//    public GameObject ballPrefab;
//    public float spawnInterval = 2f;
//    private float timer = 0f;

//    void Update()
//    {
//        timer += Time.deltaTime;

//        if (timer >= spawnInterval)
//        {
//            SpawnBall();
//            timer = 0f;
//        }
//    }

//    void SpawnBall()
//    {
//        // �{�[���𐶐����鏈��
//        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

//        // �V�����{�[���̐����ʒu���Œ肷��i��: x���W��0�Ay���W��5�j
//        newBall.transform.position = new Vector2(0f, 5f);

//        // �{�[����Rigidbody2D��ǉ����āA�d�͂������悤�ɂ���
//        Rigidbody2D ballRigidbody = newBall.GetComponent<Rigidbody2D>();
//        if (ballRigidbody == null)
//        {
//            ballRigidbody = newBall.AddComponent<Rigidbody2D>();
//        }

//        // �d�͂������悤�ɂ���
//        ballRigidbody.gravityScale = 1.0f;
//    }
//}

using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnInterval = 2f;
    private float timer = 0f;
    private GameObject previousBall;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnBall();
            timer = 0f;
        }
    }

    void SpawnBall()
    {
        // �O�̃{�[�������݂���ꍇ�A������폜����
        if (previousBall != null)
        {
            Destroy(previousBall);
        }

        // �V�����{�[���𐶐�����
        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

        // �V�����{�[���̐����ʒu���Œ肷��i��: x���W��0�Ay���W��5�j
        newBall.transform.position = new Vector2(6f, 5f);

        // �{�[����Rigidbody2D��ǉ����āA�d�͂������悤�ɂ���
        Rigidbody2D ballRigidbody = newBall.GetComponent<Rigidbody2D>();
        if (ballRigidbody == null)
        {
            ballRigidbody = newBall.AddComponent<Rigidbody2D>();
        }

        // �d�͂������悤�ɂ���
        ballRigidbody.gravityScale = 1.0f;

        // previousBall��V�����{�[���ɐݒ�
        previousBall = newBall;
    }
}