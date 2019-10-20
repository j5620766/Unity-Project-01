using UnityEngine;

public class SphereController : MonoBehaviour
{
    public float speed; // Sphere 속도에 대한 공용 변수
    private Rigidbody rb; // Sphere의 Rigidbody 구성 요소에 대한 비공개 변수

    void Start() // Update 함수가 호출되기 직전에 한 번만 호출되는 함수
    {
        rb = GetComponent<Rigidbody>(); // Rigidbody 구성 요소를 개인 rb 변수에 할당
    }

    void FixedUpdate() // 매 렌더링 프레임 사이에 여러 번 호출되는 함수
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // 수평 입력 값과 동일한 일부 지역 부동 변수를 설정
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f); // Vector3 변수를 만들고 위의 수평 부동 변수를 나타내는 X 값을 지정
        rb.AddForce(movement * speed); // 위의 Vector3 movement를 사용하여 Sphere 강체에 물리적 힘을 추가
    }

    private void OnGUI() // GUI를 그리거나 이벤트를 처리하기 위해 호출되는 함수
    {
        if(this.transform.position.z >= -81.3f) // 만약 Sphere의 Z 값이 -81.3보다 크거나 같아지면
        {
            GUI.Label(new Rect(Screen.width / 100, 80, 100, 40), "Clear"); // 화면에 "Clear" 텍스트 출력
        }
    }
}
