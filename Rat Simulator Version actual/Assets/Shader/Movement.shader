Shader "Custom/Movement"
{
    Properties
    {
	    _Color(" Color  " , Color) = (1,1,1,1)
        _TextTurer ("Ropa (RGB)", 2D) = "white" {}
		_ValorX("Velocidad X ", Range(-1,1)) = 0
		_ValorY("Velocidad Y  ", Range(-1,1)) = 0

    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM

        #pragma surface surf Standard fullforwardshadows
        #pragma target 3.0


        sampler2D _TextTurer;
		float4 _Color;
		float _ValorX;
		float _ValorY;

        struct Input
        {
            float2 uv_TextTurer;
        };

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
		    float2 uvMovimiento = IN.uv_TextTurer;
			_ValorX = _ValorX * _Time.y;
			_ValorY = _ValorY * _Time.y;
			uvMovimiento += float2(_ValorX, _ValorY);
			
			float4 c = tex2D(_TextTurer , uvMovimiento);
			c = c *_Color;
			o.Albedo = c.rgb;
        }
        ENDCG
    }
    FallBack "Diffuse"
}