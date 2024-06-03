Shader "Custom/GlowingLaser"
{
     Properties
    {
        _MainTex ("Main Texture", 2D) = "white" {}
        _Color ("Color", Color) = (1,0,0,1)  // Red color by default
        _EmissionColor ("Emission Color", Color) = (1,0,0,1)  // Red emission color
        _GlowIntensity ("Glow Intensity", Range(0, 10)) = 1.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        CGPROGRAM
        #pragma surface surf Lambert

        sampler2D _MainTex;
        fixed4 _Color;
        fixed4 _EmissionColor;
        half _GlowIntensity;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;
            o.Emission = _EmissionColor.rgb * _GlowIntensity;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
