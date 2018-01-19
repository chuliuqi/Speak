#pragma once

#pragma warning(disable: 4996)    
#include "sapi.h"
#include "sphelper.h"
#pragma comment(lib, "sapi.lib")

class WinSpeak
{
public:
	WinSpeak();
	~WinSpeak();

private:
	ISpVoice *m_pSpVoice;    // 重要COM接口

public:
	int SetVolume(int nVoice);
	int DoAction(LPCWSTR pSzToDeal, int nLength);
};

