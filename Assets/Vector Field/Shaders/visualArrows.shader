Shader "Hidden/visualArrows" {
    SubShader {
        Tags { "RenderType" = "Transparent" }

        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata_t {
                float4 vertex   : POSITION;
                float4 color    : COLOR;
            };

            struct v2f {
                float4 vertex   : SV_POSITION;
                fixed4 color    : COLOR;
            }; 

            StructuredBuffer<float3> onwcjcgAXecLlQnpjGiLPJEdI;
            StructuredBuffer<float3> kHwAmbybJgsTrvsxnZvikRYqX;

            float4x4 SOTjygeaCIxYLmZgogKfIsrBU(uint LjjniwMTAplhAlUCScWTaANta, out float SdvNAgYhYGbnYZYcHqIoUsPht) { float3 bVrRmwDhHEMeKMiaFjLRhoazc = kHwAmbybJgsTrvsxnZvikRYqX[LjjniwMTAplhAlUCScWTaANta];float3 amNHrprPTbnYJeWfrfqzdvPLw   = normalize(cross(float3(0.0,1.0,0.0), bVrRmwDhHEMeKMiaFjLRhoazc));float3 bsoKfWSNlcpxLeVLQGjusKTpx      = normalize(cross(bVrRmwDhHEMeKMiaFjLRhoazc, amNHrprPTbnYJeWfrfqzdvPLw));SdvNAgYhYGbnYZYcHqIoUsPht  = length(bVrRmwDhHEMeKMiaFjLRhoazc) * 2;float3 cTuUUWvAwAUAqhOrTceWzSqHh        = SdvNAgYhYGbnYZYcHqIoUsPht > 0.2? float3(SdvNAgYhYGbnYZYcHqIoUsPht,SdvNAgYhYGbnYZYcHqIoUsPht,SdvNAgYhYGbnYZYcHqIoUsPht) : 0;float3 asaNVuDLIsjuHstCinyPTaywl     = onwcjcgAXecLlQnpjGiLPJEdI[LjjniwMTAplhAlUCScWTaANta];float4x4  aMdnfueIfRAkmFBfTWjDhpZLz = float4x4(cTuUUWvAwAUAqhOrTceWzSqHh.x,    0,        0,       asaNVuDLIsjuHstCinyPTaywl.x,0,    cTuUUWvAwAUAqhOrTceWzSqHh.y,     0,       asaNVuDLIsjuHstCinyPTaywl.y,0,       0,     cTuUUWvAwAUAqhOrTceWzSqHh.z,    asaNVuDLIsjuHstCinyPTaywl.z,0,       0,        0,              1.0);float4x4 VcsMJlWPnscBwYGTQDxumVofW = float4x4(amNHrprPTbnYJeWfrfqzdvPLw.x,  bsoKfWSNlcpxLeVLQGjusKTpx.x,  bVrRmwDhHEMeKMiaFjLRhoazc.x,  0.0,amNHrprPTbnYJeWfrfqzdvPLw.y,  bsoKfWSNlcpxLeVLQGjusKTpx.y,  bVrRmwDhHEMeKMiaFjLRhoazc.y,  0.0,amNHrprPTbnYJeWfrfqzdvPLw.z,  bsoKfWSNlcpxLeVLQGjusKTpx.z,  bVrRmwDhHEMeKMiaFjLRhoazc.z,  0.0,0.0,        0.0,             0.0,  1.0);              return mul(aMdnfueIfRAkmFBfTWjDhpZLz, VcsMJlWPnscBwYGTQDxumVofW);}

            v2f vert(appdata_t i, uint rnpuqTmipUHLmmLivogCeSfWC: SV_InstanceID) {
                v2f o;
                float CStWRsrOUBSuPUjzvnoinTJaL = 0;
                float4x4 mat = SOTjygeaCIxYLmZgogKfIsrBU(rnpuqTmipUHLmmLivogCeSfWC, CStWRsrOUBSuPUjzvnoinTJaL);
                float4 pos = mul(mat, i.vertex);
                o.vertex = UnityObjectToClipPos(pos);
                o.color = lerp(float4(0,1,0,0), float4(1,0,0,1),CStWRsrOUBSuPUjzvnoinTJaL);

                return o;
            }

            fixed4 frag(v2f i) : SV_Target {
                return i.color;
            }

            ENDCG
        }
    }
}

