 #include <cstdint>

#ifdef __cplusplus
extern "C" {
#endif

	__declspec(dllexport) float Sum(float *Array, int length) {
		float result = 0;
		
		for (auto i = 0; i < length; ++i) {
			result += Array[i];
		}
		return result;
	}

	__declspec(dllexport) float SumXMM(float *Array, int length) {
		float result = 0;		
		float Res[4];
		int len = length * 4;
		float *p;
		p = Array;
		_asm
		{
			mov ECX
			mov EDI
			mov ESI
				mov EDI, len
				mov ECX, 0
				mov ESI, p
				pxor    xmm0, xmm0 //| 0 | 0 | 0 | 0 |
				Back :
			movups  xmm1, [ESI][ECX] //Array[ECX]
				addps   xmm0, xmm1
				add     ECX, 16
				cmp     ECX, EDI
				jne      Back
				movups Res, xmm0
				pop EDI
				pop ECX
		}

		result = Res[0] + Res[1] + Res[2] + Res[3];
		return result;//len;
	}
#ifdef __cplusplus
}
#endif