// Win32Speak.cpp : ���� DLL Ӧ�ó���ĵ���������
//

#include "stdafx.h"
#include "WinSpeak.h"

extern "C"
{
__declspec(dllexport) int  DoSpeak(LPCWSTR pSzToDeal, int nLength)
{
	if (pSzToDeal==0 || nLength<=0)
	{
		return -1;
	}
	if (pSzToDeal[nLength-1]=='\0')
	{
		return -2;
	}

	WinSpeak winSpeak;
	winSpeak.DoAction(pSzToDeal, nLength);

	return 0;  //�ɹ�
}
}