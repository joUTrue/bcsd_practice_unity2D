using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        //게임 오브젝트가 실행될 때 최초로 실행
    }
    private void OnEnable()
    {
        //오브젝트가 활성화 될때
    }

    private void OnDisable()
    {
        //오브젝트가 비활성화 될때
    }
    void Start()
    {
        //업데이트 직전 최초 실행
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //물리적용전 실행
        //cpu 많이 사용
        //고정된 실행주기로 물리관련 코드 작성(1초에 약 50번)
    }
    void Update()
    {
        //환경에 따라서 실행주기 바뀜
    }

    private void LateUpdate()
    {
        //모든 업데이트 이후 실행
        //캐릭터를 따라가는 카메라, 로직의 후처리
        //업데이트와 동일한 주기
    }

    private void OnDestroy()
    {
        //오브젝트가 삭제될 때 실행
    }
}
