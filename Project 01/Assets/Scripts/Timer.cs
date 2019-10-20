using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f; // 현재시간
    float startingTime = 25f; // 시작시간
    [SerializeField] Text countdownText; // 타이머 카운트 텍스트

    private void Start() // Update 함수가 호출되기 직전에 한 번만 호출되는 함수
    {
        currentTime = startingTime; // 현재시간 = 시작시간
    }

    private void OnGUI() // GUI를 그리거나 이벤트를 처리하기 위해 호출되는 함수
    {
        if(currentTime <= 0.5f) // 만약 현재시간이 0.5초보다 작거나 같아지면
        {
            GUI.Label(new Rect(Screen.width / 100, 80, 100, 40), "GameOver"); // 화면에 "GameOver" 텍스트 출력
        }
    }

    void Update() // 매 프레임마다 호출되는 함수
    {
        currentTime -= 1 * Time.deltaTime; // 현재시간을 초당 1씩 감소
        countdownText.text = currentTime.ToString("0"); // 현재시간의 텍스트를 하나의 문자열로 표현

        if(currentTime <= 0) // 현재시간이 0보다 작거나 같으면
        {
            currentTime = 0; // 현재시간을 0으로 고정
            SceneManager.LoadScene("Velocity"); // 게임 재시작(Velocity 씬을 다시 로드)
        }
    }
}
