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
//        // ボールを生成する処理
//        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

//        // 新しいボールの生成位置を固定する（例: x座標は0、y座標は5）
//        newBall.transform.position = new Vector2(5f, 5f);

//        // ボールにRigidbody2Dを追加して、重力が働くようにする
//        Rigidbody2D ballRigidbody = newBall.GetComponent<Rigidbody2D>();
//        if (ballRigidbody == null)
//        {
//            ballRigidbody = newBall.AddComponent<Rigidbody2D>();
//        }

//        // 重力が働くようにする
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
//        // ボールを生成する処理
//        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

//        // ボールにRigidbody2Dを追加して、重力が働くようにする
//        Rigidbody2D ballRigidbody = newBall.GetComponent<Rigidbody2D>();
//        if (ballRigidbody == null)
//        {
//            ballRigidbody = newBall.AddComponent<Rigidbody2D>();
//        }

//        // 新しいボールの生成位置をランダムに指定する（例: x座標はランダム、y座標は5）
//        float randomX = Random.Range(-5f, 5f);
//        newBall.transform.position = new Vector2(randomX, 5f);

//        // 重力が働くようにする
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
//        // ボールを生成する処理
//        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

//        // ボールにRigidbody2Dを追加して、重力が働くようにする
//        Rigidbody2D ballRigidbody = newBall.GetComponent<Rigidbody2D>();
//        if (ballRigidbody == null)
//        {
//            ballRigidbody = newBall.AddComponent<Rigidbody2D>();
//        }

//        // 画面外に出たら新しく生成する
//        StartCoroutine(DestroyOutOfScreen(newBall));
//    }

//    IEnumerator DestroyOutOfScreen(GameObject ball)
//    {
//        while (true)
//        {
//            // 画面外に出たらボールを削除し、新しいボールを生成する
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
//        // ボールを生成する処理
//        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

//        // 新しいボールの生成位置を固定する（例: x座標は0、y座標は5）
//        newBall.transform.position = new Vector2(0f, 5f);

//        // ボールにRigidbody2Dを追加して、重力が働くようにする
//        Rigidbody2D ballRigidbody = newBall.GetComponent<Rigidbody2D>();
//        if (ballRigidbody == null)
//        {
//            ballRigidbody = newBall.AddComponent<Rigidbody2D>();
//        }

//        // 重力が働くようにする
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
        // 前のボールが存在する場合、それを削除する
        if (previousBall != null)
        {
            Destroy(previousBall);
        }

        // 新しいボールを生成する
        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

        // 新しいボールの生成位置を固定する（例: x座標は0、y座標は5）
        newBall.transform.position = new Vector2(6f, 5f);

        // ボールにRigidbody2Dを追加して、重力が働くようにする
        Rigidbody2D ballRigidbody = newBall.GetComponent<Rigidbody2D>();
        if (ballRigidbody == null)
        {
            ballRigidbody = newBall.AddComponent<Rigidbody2D>();
        }

        // 重力が働くようにする
        ballRigidbody.gravityScale = 1.0f;

        // previousBallを新しいボールに設定
        previousBall = newBall;
    }
}