#pragma warning(disable : 4996)
#include <iostream>
using namespace std;
#include <tchar.h>

extern "C" void Proc_Sh(void);
extern "C" int a_asm = 0;
extern "C" int b_asm = 0;
extern "C" int c_asm = 0;


int main()
{

	int a, c; //начальное знаковое целое число и проверочное
	register unsigned int b; //число бит на которое будет происходить сдвиг(степень 2)
	printf("Enter a signed number \n");
	if ((scanf("%d", &a)) != 1) {
		printf("Invalid value");
		return 1;
	}
	c = a;

	printf("Enter the degree 2 \n");
	if ((scanf("%u", &b)) != 1) {
		printf("Invalid value");
		return 1;
	}

	a_asm = a;
	b_asm = b;
	Proc_Sh();

	c = c_asm;
	c = c >> b;

	if (c == a) {
		printf("Result %d\n", c_asm);
	}
	else {
		printf("Very large values \n");
	}
}