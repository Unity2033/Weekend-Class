#include <stdio.h>

void main()
{
#pragma region 조건문
	// 어떤 조건이 주어질 때 해당 조건에 따라
	// 동작을 수행하도록 실행하는 명령문입니다.

#pragma region 관계 연산자
	// 두 개의 피연산자의 값을 비교하여 그 결과를
	// 0 또는 1이라는 값으로 나타내는 연산자입니다.

	// int result = 0;
	// 
	// result = 10 > 5; // 1
	// 
	// printf("result 변수의 값 : %d\n", result);
	// 
	// result = 5 < 4;	 // 0
	// 
	// printf("result 변수의 값 : %d\n", result);
	// 
	// result = 5 >= 1; // 1
	// 
	// printf("result 변수의 값 : %d\n", result);
	// 
	// result = 3 <= 1; // 0
	// 
	// printf("result 변수의 값 : %d\n", result);
	// 
	// result = 10 == 10; // 1
	// 
	// printf("result 변수의 값 : %d\n", result);
	// 
	// result = 10 != 10; // 0
	// 
	// printf("result 변수의 값 : %d\n", result);

	// 관계 연산자는 조건이 맞을 때 1이라는 값으로
	// 반환하며, 조건이 틀릴 때 0이라는 값으로 반환합니다.

#pragma endregion

#pragma region if문
	// 어떤 특정한 조건을 비교하여 조건이 맞다면 
	// 실행되는 명령문입니다.

	//	int count = 5;
	//	
	//	if (count == 5)
	//	{
	//		printf("if문의 조건이 '참'입니다~\n");
	//	}

	// if문은 조건이 1일 때 실행되며, 0일 때 실행되지 않습니다.

#pragma endregion

#pragma region else if문
	// if문의 조건이 틀릴 때 else if문의 조건이
	// 맞다면 실행되는 명령문입니다.

	//	int level = 99;
	//	
	//	if (level == 81)
	//	{
	//		printf("1차 전직\n");
	//	}
	//	else if (level >= 99)
	//	{
	//		printf("2차 전직\n");
	//	}
#pragma endregion

#pragma region else문
	// if문과 else if문의 조건이 다 틀리면
	// 실행되는 명령문입니다.

	//	int health = 100;
	//	
	//	if (health <= 0)
	//	{
	//		printf("Destroy GameObject\n");
	//	}
	//	else if (health == 50)
	//	{
	//		printf("Warning\n");
	//	}
	//	else
	//	{
	//		printf("Exist Game Object");
	//	}

	// if문에 연결된 모든 조건문의 조건이 같다면
	// 가장 위에 있는 조건문만 실행됩니다.
#pragma endregion

#pragma region switch문
	// 어떤 결과에 따라 그 결과부터 실행되는 명령문입니다.

	//	int stage = 1;
	//	
	//	switch (stage)
	//	{
	//		case 1: printf("타이틀\n");
	//		case 2: printf("마을\n");
	//		case 3: printf("던전\n");
	//		case 4: printf("낚시터\n");
	//	}

	// switch문의 경우 조건에 해당하는 값에 따라
	// 조건의 위치로 이동합니다.

	// switch 문은 해당 조건이 완료되었을 때, break
	// 문이 없으면 나머지 밑에 있는 case 문까지 계속 
	// 실행시키다가 종료합니다.

#pragma endregion

#pragma region break문
   // 특정한 지점에서 분기를 탈출하는 제어문입니다.

	//	char grade = 'F';
	//	
	//	switch (grade)
	//	{
	//		case 'A': printf("A 등급\n");
	//			break;
	//		case 'B': printf("B 등급\n");
	//			break;	
	//		case 'C': printf("C 등급\n");
	//			break;	
	//		case 'D': printf("D 등급\n");
	//			break;
	//		default: printf("해당하는 조건의 값이 아닙니다.\n");
	//			break;
	//	}

	// switch문에는 조건식으로 실수형 변수와 실수형 상수를
	// 사용할 수 없습니다.
#pragma endregion

#pragma region 논리 연산자

   /*
		int flag = 0;
		int damage = 10;
		char blood = 'O';

		if (damage == 10 && blood == 'O')
		{
			   printf("AND 논리 연산자\n");
		}

		if (damage == 10 || blood == 'B')
		{
			   printf("OR 논리 연산자\n");
		}

		if (!flag)
		{
			   printf("NOT 논리 연산자\n");
		}
   */


#pragma endregion





#pragma endregion

#pragma region 사분면

   //	int x = 10;
   //	int y = 10;
   //	
   //	if (x > 0 && y > 0)
   //	{
   //		  printf("제 1 사분면\n");
   //	}
   //	else if (x < 0 && y > 0)
   //	{
   //		  printf("제 2 사분면\n");
   //	}
   //	else if (x < 0 && y < 0)
   //	{
   //		  printf("제 3 사분면\n");
   //	}
   //	else if (x > 0 && y < 0)
   //	{
   //		  printf("제 4 사분면\n");
   //	}
   //	else if (x && y == 0)
   //	{
   //		  printf("x 절편\n");
   //	}
   //	else if (x == 0 && y)
   //	{
   //		  printf("y 절편\n");
   //	}
   //	else
   //	{
   //		  printf("원점\n");
   //	}

#pragma endregion
}






