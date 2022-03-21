#include <iostream>
using namespace std;
#include <tchar.h>

extern "C" void Proc_Sh(void);
extern "C" unsigned int a_asm = 0;
extern "C" unsigned int b_asm = 0;
extern "C" unsigned int c_asm = 0;


int main()
{
	int a = 0, b = 0;
	try
	{
		printf("Enter the a: ");
		cin >> a;
	}
	catch (...)
	{
		printf("\nThe value of %i is not interval [0..%d]!", a, USHRT_MAX);
		getchar();
	}
	try
	{
		printf("Enter the b: ");
		cin >> b;
	}
	catch (...)
	{
		printf("\nThe value of %i is not interval [0..%d]!", b, USHRT_MAX);
		getchar();
	}
	
	a_asm = a;
	b_asm = b;

	Proc_Sh();
	printf("\n(ASM) c = %d\n", c_asm);
}