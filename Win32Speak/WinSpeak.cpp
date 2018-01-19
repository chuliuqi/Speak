#include "stdafx.h"
#include "WinSpeak.h"
#include <atlbase.h>

WinSpeak::WinSpeak()
{
	m_pSpVoice = NULL;
	::CoInitialize(NULL);	// COM初始化								  // 获取ISpVoice接口
	CoCreateInstance(CLSID_SpVoice, NULL, CLSCTX_INPROC_SERVER, IID_ISpVoice, (void**)&m_pSpVoice);
}

WinSpeak::~WinSpeak()
{
	if (m_pSpVoice)
	{
		m_pSpVoice->Release();
	}
	::CoUninitialize();
	
	m_pSpVoice = NULL;
}

int WinSpeak::SetVolume(int nVoice)
{
	if (m_pSpVoice)
	{
		m_pSpVoice->SetVolume(80);
	}
	return 0;
}

int WinSpeak::DoAction(LPCWSTR pSzToDeal, int nLength)
{
	if (m_pSpVoice)
	{
		m_pSpVoice->Speak(pSzToDeal, SPF_DEFAULT, NULL);
	}
	return 0;
}
