; https://github.com/dotnet/corert/blob/c6af4cfc8b625851b91823d9be746c4f7abdc667/src/Native/Runtime/i386

bits 32

global RhpNewFast
global RhpAssignRefEAX

section .text

; Probably do something here once heap
; is initialized somehow (fat chance).
;
RhpNewFast:
  ret

RhpAssignRefEAX:
  mov dword [edi], esi
  ret