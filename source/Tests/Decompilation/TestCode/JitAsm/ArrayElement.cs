static class C {
    static int M(int[] x) {
        return x[0];
    }
}

/* asm

; Core CLR <IGNORE> on x64

C.M(Int32[])
    L0000: sub rsp, 0x28
    L0004: cmp dword ptr [rcx+8], 0
    L0008: jbe short L0012
    L000a: mov eax, [rcx+0x10]
    L000d: add rsp, 0x28
    L0011: ret
    L0012: call 0x<IGNORE>
    L0017: int3

*/