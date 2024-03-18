#include <stdio.h>

void main()
{
#pragma region 비트
	// 데이터를 나타내는 최소의 단위이며, 0 또는
	// 1의 조합으로 논리 계산을 수행하는 단위입니다.

#pragma region 십진수를 이진수로 변환하는 과정
	// 10 진수를 1이 될 때가지 계속 2로 나누어 준 다음
	// 나눈 위치의 나머지 값을 아래에서 위로 순서대로 정렬합니다.

	// 15 -> 2 진수 (1111)

#pragma endregion

#pragma region 이진수를 십진수로 변환하는 과정
	// 1 byte에 2 진수로 저장된 값을 2의 제곱으로 나타냅니다.


	// 각각의 비트에 1이 있다면 1과 2의 제곱의 위치를 계산한
	// 다음 각각의 비틀르 모두 더하여 10진수로 나타냅니다.
#pragma endregion

	// 메모리는 비트 단위로 데이터를 저장할 수 있으며,
	// 1개의 비트에는 0 또는 1의 값만 저장할 수 있습니다.
#pragma endregion

#pragma region 비트 연산자
	// 비트 단위로 논리 연산을 수행하기 위해 사용하는
	// 연산자입니다.

	// char x = 10; // 0000 1010
	// char y = 6;	 // 0000 0110
	// 
	// printf("x 변수와 y 변수를 AND 연산한 결과 : %d\n", x & y);
	// 
	// // AND 연산자는 두 개의 피연산자가 모두 1이면 1을 
	// // 반환하는 연산자입니다.
	// 
	// char n = 12; // 0000 1100
	// char m = 3;	 // 0000 0011
	// 
	// printf("n 변수와 m 변수를 OR 연산한 결과 : %d\n", n | m);
	// 
	// // OR 연산자는 두 개의 피연산자 중에 하나라도 1이 있다면
	// // 1을 반환하는 연산자입니다.
	// 
	// char w = 11; // 1011
	// char v = 5;  // 0101
	// 
	// printf("w 변수와 v 변수를 XOR 연산한 결과 : %d\n", w ^ v);
	// 
	// // XOR 연산자는 두 개의 피연산자가 서로 같으면 0을
	// // 반환하고, 서로 다르면 1을 반환하는 연산자입니다.
	// 
	// char k = 9; // 0000 1001
	// 
	// // 1111 0110
	// 
	// printf("k 변수를 NOT 연산한 결과 : %d\n", ~k);

	// 첫 번째 비트는 부호를 나타내며, 첫 번째 비트에 1이 있다면
	// 값은 음수가 됩니다.

#pragma endregion

#pragma region 시프트 연산자
	// 각각의 비트를 오른쪽 또는 왼쪽으로 한 칸씩 
	// 이동시키는 연산자입니다.

	// int value = 3; // 0000 0011
	// 
	// printf("value 변수를 왼쪽으로 3번 Shift 연산한 결과 : %d\n", value << 3); // 0001 1000
	// 
	// printf("value 변수를 오른쪽으로 1번 Shift 연산한 결과 : %d\n", value >> 1); // 0000 0001

#pragma endregion

#pragma region 산술 연산자

	int health = 100;
	const int contant = 10;

	// 1. int (result1) 변수 = 심볼릭 상수 + 리티럴 상수		
	int result1 = contant + 15;

	// 2. int (result2) 변수 = 리터럴 상수 - 리터럴 상수
	int result2 = 10 - 5;

	// 3. int (result3) 변수 = 변수 * 심볼릭 상수
	int result3 = health * contant;

	// 4. int (result4) 변수 = 변수 / 리터럴 상수
	int result4 = health / 10;

	printf("result1의 변수 : %d\n", result1);
	printf("result2의 변수 : %d\n", result2);
	printf("result3의 변수 : %d\n", result3);
	printf("result4의 변수 : %d\n", result4);
#pragma endregion
}






