#include <stdio.h>

void main()
{
#pragma region 문자열
	// 연속적인 메모리 공간에 저장된 문자
	// 변수의 집합입니다.

	// const char * ptr = "Game";
	// 
	// // *ptr = 'T';
	// 
	// // %s : 문자열을 출력하는 서식 지정자
	// printf("ptr이 가라키는 값 : %s\n", ptr);
	// 
	// ptr = "School";
	// 
	// printf("ptr이 가라키는 값 : %s\n", ptr);

	// 문자열의 경우 포인터를 이용하여 문자열
	// 상수를 가리키도록 할 수 있으며, 문자열 상수는
	// 데이터 영역의 읽기 전용 공간에 저장되기 때문에
	// 문자열의 값을 변경할 수 없습니다.

	// char string [] = "Control";
	
	// printf("string 배열의 크기 : %d\n", sizeof(string));

	// 문자열은 공백도 함께 메모리 공간에 포함하여 크기를
	// 결정하며, 마지막 문자열의 끝을 알려주는 제어 문자가
	// 추가됩니다.

	// char name[] = "Ba\0rd";
	// 
	// name[0] = 'W';
	// 
	// name = "Alistar";
	// 
	// printf("name 배열의 값 : %s\n", name);

	// 문자열의 경우 서로 연속적인 메모리 공간으로 연결되어 
	// 있지만, 문자 배열 사이에 무효의 문자를 넣게 되면 무효의
	// 문자까지만 문자열을 출력합니다.

#pragma endregion

#pragma region 약수

	//	int value = 0;
	//	
	//	printf("value의 값 입력 : ");
	//	scanf_s("%d", &value);
	//	
	//	for (int i = 1; i <= value; i++)
	//	{
	//		if (value % i == 0)
	//		{
	//			printf("%d ", i);
	//		}
	//	}

#pragma endregion

#pragma region 범용 포인터
	// 자료형이 정해지지 않은 상태로 모든 자료형을
	// 저장할 수 있는 포인터입니다.

	// int data = 100;
	// float health = 99.75f;
	// 
	// void * vptr = &data;
	// 
	// *vptr = 1000;

	// 범용 포인터는 메모리 주소에 접근해서 값을 
	// 변경할 수 없습니다.

	// *(int*)vptr = 1000;
	// 
	// printf("data 변수의 값 : %d\n", data);
	// 
	// vptr = &health;
	// 
	// *(float*)vptr = 100.0f;
	// 
	// printf("health 변수의 값 : %f\n", health);
	// 
	// vptr = "Visual Stduio";
	// 
	// printf("vptr이 가리키는 값 : %s\n", vptr);

	// 범용 포인터로 변수의 메모리에 접근하려면
	// 범용 포인터가 가리키는 변수의 자료형으로
	// 자료형 변환을 해주어야 합니다.

#pragma endregion
}






