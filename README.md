# 버튼 잡기 게임 (C# 코딩)

## 개요
- C# 프로그래밍 학습
- 핵심기능 : 버튼에 마우스를 올리면 버튼이 랜덤한 위치로 이동, 버튼을 클릭 시 점수가 20씩 감소하도록 설정, 버튼을 클릭하면 100점이 증가, 점수가 -200이 된다면 모든 버튼 비활성화 후 다시하기 버튼만 활성화, 다시하기 버튼을 누르면 게임과 점수를 리셋 후 다시시작
  
- 화면 구성 :
  <img width="792" height="478" alt="image" src="https://github.com/user-attachments/assets/17614991-70ef-444d-b958-09616da24966" />



## 실행화면
- 1단계 코드의 실행 스크린샷
  <img width="803" height="491" alt="image" src="https://github.com/user-attachments/assets/1e9b9543-bc88-4d07-9638-85b981649dc9" />

- 2단계 코드의 실행 스크린샷
  <img width="1041" height="651" alt="image" src="https://github.com/user-attachments/assets/1d3946c6-1f2f-47c0-87be-635de74a6d7d" />

- 3단계 코드의 실행 스크린샷
  <img width="796" height="488" alt="image" src="https://github.com/user-attachments/assets/b68181b9-cdbf-4a6f-9dd4-0ba8886566a3" />

- 4단계 코드의 실행 스크린샷
  게임오버가 된 경우
  <img width="862" height="496" alt="image" src="https://github.com/user-attachments/assets/47c3cb61-4ac7-4586-9d23-e66ca7e0d281" />
  
  다시시작을 눌러 게임이 리셋됨
  <img width="796" height="485" alt="image" src="https://github.com/user-attachments/assets/2ca8601f-9858-4bf4-bdc2-6e1605793291" />



## 구현 시 어려웠던 점
-버튼 이동범위를 조정하는데 어려움이 있었지만 Copilot의 도움을 받아 최대 이동범위에서 버튼의 크기를 빼면서 버튼이 테두리 바깥으로 나가는 현상을 조정했습니다.
-게임오버가 되었을 때 다시시작버튼을 활성화하고 다른버튼을 비활성화하는 방법을 찾는데 힘이 들었지만 Copilot을 활용하여 방법을 알아내고 제가 원하는 방향으로 수정을 거듭하여 완성하였습니다.
