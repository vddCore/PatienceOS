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