format PE GUI 4.0 DLL
include 'win32a.inc'
section '.text' code readable executable


proc FindMax stdcall, pointerToArray:DWORD, lenghtOfArray:DWORD
local maxValue:DWORD
	pusha

	mov ebx,[pointerToArray]
	mov ecx,[lenghtOfArray]

	mov [maxValue],0

findMaxLoop:
	mov eax,[ebx] ; eax = Array[n]

	cmp eax,[maxValue]
	jl dontSetAsNewMax

	mov [maxValue],eax

dontSetAsNewMax:
	add ebx,4

	loop findMaxLoop

	popa

	mov eax,[maxValue]
ret
endp



proc FindMin stdcall, pointerToArray:DWORD, lenghtOfArray:DWORD
local minValue:DWORD
	pusha

	mov ebx,[pointerToArray]
	mov ecx,[lenghtOfArray]

	mov [minValue],255

findMinLoop:
	mov eax,[ebx] ; eax = Array[n]

	cmp eax,[minValue]
	jg dontSetAsNewMin

	mov [minValue],eax

dontSetAsNewMin:
	add ebx,4

	loop findMinLoop

	popa

	mov eax,[minValue]
ret
endp


proc Normalize stdcall, pointerToArray:DWORD, lenghtOfArray:DWORD, minValue:DWORD, maxValue:DWORD
local currentPixelValue:DWORD, value255:DWORD, normalizedPixelValue:DWORD
	pusha

	finit

	mov ebx,[pointerToArray]
	mov ecx,[lenghtOfArray]

	mov [value255],255

normalizeLoop:
	mov eax,[ebx] ; eax = Array[n]
	mov [currentPixelValue],eax

	fild [currentPixelValue]
	fild [minValue]
	fsubp

	fild[value255]
	fmulp

	fild[maxValue]
	fild[minValue]
	fsubp

	fdivp

	fistp [normalizedPixelValue]
	mov eax,[normalizedPixelValue]

	mov [ebx],eax

	add ebx,4

	loop normalizeLoop

	popa
ret
endp



proc RevertNormalization stdcall, pointerToArray:DWORD, lenghtOfArray:DWORD, minValue:DWORD, maxValue:DWORD
local normalizedPixelValue:DWORD, value255:DWORD, originalPixelValue:DWORD
	pusha

	finit

	mov ebx,[pointerToArray]
	mov ecx,[lenghtOfArray]

	mov [value255],255

revertNormalizationLoop:
	mov eax,[ebx] ; eax = Array[n]
	mov [normalizedPixelValue],eax

	fild [normalizedPixelValue]

	fild [maxValue]
	fild [minValue]
	fsubp

	fmulp

	fild [value255]
	fdivp

	fild [minValue]
	faddp

	fistp [originalPixelValue]
	mov eax,[originalPixelValue]

	mov [ebx],eax

	add ebx,4

	loop revertNormalizationLoop

	popa
ret
endp


proc AddWithWeight stdcall, pointerToFirstArray:DWORD, pointerToSecondArray:DWORD, pointerToResultArray:DWORD, lenghtOfArrays:DWORD, weight:DWORD
local firstPixelValue:DWORD, secondPixelValue:DWORD, resultPixelValue:DWORD, value100:DWORD
	pusha

	finit

	mov ebx,[pointerToFirstArray]
	mov edx,[pointerToSecondArray]
	mov ecx,[lenghtOfArrays]

	mov [value100],100

addingLoop:
	mov eax,[ebx] ; eax = FirstArray[n]
	mov [firstPixelValue],eax

	mov eax,[edx] ; eax = SecondArray[n]
	mov [secondPixelValue],eax

	fild [weight]
	fild [value100]
	fdivp

	fild [firstPixelValue]
	fmulp

	fld1

	fild [weight]
	fild [value100]
	fdivp

	fsubp

	fild [secondPixelValue]
	fmulp

	faddp

	fistp [resultPixelValue]
	mov eax,[resultPixelValue]

	push ebx
	mov ebx,[pointerToResultArray]
	mov [ebx],eax
	add ebx,4
	mov [pointerToResultArray],ebx
	pop ebx

	add ebx,4
	add edx,4

	loop addingLoop

	popa
ret
endp



proc DllOk stdcall
     invoke MessageBoxA, HWND_DESKTOP,_tresc,_tytul, MB_OK
ret
endp

section '.data' data readable writeable
 _tytul db "OK", 0
 _tresc db "Biblioteka jest dostêpna", 0

section '.idata' import data readable writeable
library user32,'USER32.DLL'
import user32,\
 MessageBoxA,'MessageBoxA'

section '.edata' export data readable
 export 'BitmapAddition.DLL',\
 FindMax,'FindMax',\
FindMin,'FindMin',\
Normalize,'Normalize',\
RevertNormalization,'RevertNormalization',\
AddWithWeight,'AddWithWeight',\
DllOk,'DllOk'

section '.reloc' fixups data readable discardable
