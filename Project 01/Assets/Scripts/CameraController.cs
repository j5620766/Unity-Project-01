using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject sphere; // 게임 오브젝트인 Sphere에 대한 공용 변수
    private Vector3 offset; // Sphere와 카메라의 거리 차이에 대한 비공개 변수

    void Start() // Update 함수가 호출되기 직전에 한 번만 호출되는 함수
    {
        offset = transform.position - sphere.transform.position; // 카메라의 위치에서 Sphere 위치를 빼서 오프셋을 만듦
    }

    void LateUpdate() // 모든 Update 함수가 호출된 후 매 프레임마다 호출되는 함수
    {
        transform.position = sphere.transform.position + offset; // 카메라가 Sphere와 offset 거리를 유지하며 이동
    }
}
 