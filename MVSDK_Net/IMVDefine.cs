using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MVSDK_Net
{
	/// <summary>
	/// 数据结构类
	/// </summary>
	// Token: 0x02000003 RID: 3
	public class IMVDefine
	{
		/// <summary>
		/// 成功，无错误
		/// </summary>
		// Token: 0x04000001 RID: 1
		public const int IMV_OK = 0;

		/// <summary>
		/// 通用的错误
		/// </summary>
		// Token: 0x04000002 RID: 2
		public const int IMV_ERROR = -101;

		/// <summary>
		/// 错误或无效的句柄
		/// </summary>
		// Token: 0x04000003 RID: 3
		public const int IMV_INVALID_HANDLE = -102;

		/// <summary>
		/// 错误的参数
		/// </summary>
		// Token: 0x04000004 RID: 4
		public const int IMV_INVALID_PARAM = -103;

		/// <summary>
		/// 错误或无效的帧句柄
		/// </summary>
		// Token: 0x04000005 RID: 5
		public const int IMV_INVALID_FRAME_HANDLE = -104;

		/// <summary>
		/// 无效的帧
		/// </summary>
		// Token: 0x04000006 RID: 6
		public const int IMV_INVALID_FRAME = -105;

		/// <summary>
		/// 相机/事件/流等资源无效
		/// </summary>
		// Token: 0x04000007 RID: 7
		public const int IMV_INVALID_RESOURCE = -106;

		/// <summary>
		/// 设备与主机的IP网段不匹配
		/// </summary>
		// Token: 0x04000008 RID: 8
		public const int IMV_INVALID_IP = -107;

		/// <summary>
		/// 内存不足
		/// </summary>
		// Token: 0x04000009 RID: 9
		public const int IMV_NO_MEMORY = -108;

		/// <summary>
		/// 传入的内存空间不足
		/// </summary>
		// Token: 0x0400000A RID: 10
		public const int IMV_INSUFFICIENT_MEMORY = -109;

		/// <summary>
		/// 属性类型错误
		/// </summary>
		// Token: 0x0400000B RID: 11
		public const int IMV_ERROR_PROPERTY_TYPE = -110;

		/// <summary>
		/// 属性不可访问、或不能读/写、或读/写失败
		/// </summary>
		// Token: 0x0400000C RID: 12
		public const int IMV_INVALID_ACCESS = -111;

		/// <summary>
		/// 属性值超出范围、或者不是步长整数倍
		/// </summary>
		// Token: 0x0400000D RID: 13
		public const int IMV_INVALID_RANGE = -112;

		/// <summary>
		/// 设备不支持的功能	
		/// </summary>
		// Token: 0x0400000E RID: 14
		public const int IMV_NOT_SUPPORT = -113;

		/// <summary>
		/// 支持设备最大个数
		/// </summary>
		// Token: 0x0400000F RID: 15
		public const int IMV_MAX_DEVICE_ENUM_NUM = 100;

		/// <summary>
		/// 字符串最大长度
		/// </summary>
		// Token: 0x04000010 RID: 16
		public const int IMV_MAX_STRING_LENTH = 256;

		/// <summary>
		/// 失败属性列表最大长度
		/// </summary>
		// Token: 0x04000011 RID: 17
		public const int IMV_MAX_ERROR_LIST_NUM = 128;

		// Token: 0x04000012 RID: 18
		private const int IMV_GVSP_PIX_MONO = 16777216;

		// Token: 0x04000013 RID: 19
		private const int IMV_GVSP_PIX_RGB = 33554432;

		// Token: 0x04000014 RID: 20
		private const int IMV_GVSP_PIX_COLOR = 33554432;

		// Token: 0x04000015 RID: 21
		private const int IMV_GVSP_PIX_CUSTOM = -2147483648;

		// Token: 0x04000016 RID: 22
		private const int IMV_GVSP_PIX_COLOR_MASK = -16777216;

		// Token: 0x04000017 RID: 23
		private const int IMV_GVSP_PIX_OCCUPY1BIT = 65536;

		// Token: 0x04000018 RID: 24
		private const int IMV_GVSP_PIX_OCCUPY2BIT = 131072;

		// Token: 0x04000019 RID: 25
		private const int IMV_GVSP_PIX_OCCUPY4BIT = 262144;

		// Token: 0x0400001A RID: 26
		private const int IMV_GVSP_PIX_OCCUPY8BIT = 524288;

		// Token: 0x0400001B RID: 27
		private const int IMV_GVSP_PIX_OCCUPY12BIT = 786432;

		// Token: 0x0400001C RID: 28
		private const int IMV_GVSP_PIX_OCCUPY16BIT = 1048576;

		// Token: 0x0400001D RID: 29
		private const int IMV_GVSP_PIX_OCCUPY24BIT = 1572864;

		// Token: 0x0400001E RID: 30
		private const int IMV_GVSP_PIX_OCCUPY32BIT = 2097152;

		// Token: 0x0400001F RID: 31
		private const int IMV_GVSP_PIX_OCCUPY36BIT = 2359296;

		// Token: 0x04000020 RID: 32
		private const int IMV_GVSP_PIX_OCCUPY48BIT = 3145728;

		/// <summary>
		/// ExposureEnd事件ID
		/// </summary>
		// Token: 0x04000021 RID: 33
		public const int IMV_MSG_EVENT_ID_EXPOSURE_END = 36865;

		/// <summary>
		/// FrameTrigger事件ID
		/// </summary>
		// Token: 0x04000022 RID: 34
		public const int IMV_MSG_EVENT_ID_FRAME_TRIGGER = 36866;

		/// <summary>
		/// FrameStart事件ID
		/// </summary>
		// Token: 0x04000023 RID: 35
		public const int IMV_MSG_EVENT_ID_FRAME_START = 36867;

		/// <summary>
		/// AcquisitionStart事件ID
		/// </summary>
		// Token: 0x04000024 RID: 36
		public const int IMV_MSG_EVENT_ID_ACQ_START = 36868;

		/// <summary>
		/// AcquisitionTrigger事件ID
		/// </summary>
		// Token: 0x04000025 RID: 37
		public const int IMV_MSG_EVENT_ID_ACQ_TRIGGER = 36869;

		/// <summary>
		/// ReadOut事件ID
		/// </summary>
		// Token: 0x04000026 RID: 38
		public const int IMV_MSG_EVENT_ID_DATA_READ_OUT = 36870;

		/// <summary>
		/// 枚举：属性类型
		/// </summary>
		// Token: 0x02000004 RID: 4
		public enum IMV_EFeatureType
		{
			/// <summary>
			/// 整型数
			/// </summary>
			// Token: 0x04000028 RID: 40
			featureInt = 268435456,
			/// <summary>
			/// 浮点数
			/// </summary>
			// Token: 0x04000029 RID: 41
			featureFloat = 536870912,
			/// <summary>
			/// 枚举
			/// </summary>
			// Token: 0x0400002A RID: 42
			featureEnum = 805306368,
			/// <summary>
			/// 布尔
			/// </summary>
			// Token: 0x0400002B RID: 43
			featureBool = 1073741824,
			/// <summary>
			/// 字符串
			/// </summary>
			// Token: 0x0400002C RID: 44
			featureString = 1342177280,
			/// <summary>
			/// 命令
			/// </summary>
			// Token: 0x0400002D RID: 45
			featureCommand = 1610612736,
			/// <summary>
			/// 分组节点
			/// </summary>
			// Token: 0x0400002E RID: 46
			featureGroup = 1879048192,
			/// <summary>
			/// 寄存器节点
			/// </summary>
			// Token: 0x0400002F RID: 47
			featureReg = -2147483648,
			/// <summary>
			/// 未定义
			/// </summary>
			// Token: 0x04000030 RID: 48
			featureUndefined = -1879048192
		}

		/// <summary>
		/// 枚举：接口类型
		/// </summary>
		// Token: 0x02000005 RID: 5
		public enum IMV_EInterfaceType
		{
			/// <summary>
			/// 网卡接口类型
			/// </summary>
			// Token: 0x04000032 RID: 50
			interfaceTypeGige = 1,
			/// <summary>
			/// USB3.0接口类型
			/// </summary>
			// Token: 0x04000033 RID: 51
			interfaceTypeUsb3,
			/// <summary>
			/// CAMERALINK接口类型
			/// </summary>
			// Token: 0x04000034 RID: 52
			interfaceTypeCL = 4,
			/// <summary>
			/// PCIe接口类型
			/// </summary>
			// Token: 0x04000035 RID: 53
			interfaceTypePCIe = 8,
			/// <summary>
			/// 忽略接口类型
			/// </summary>
			// Token: 0x04000036 RID: 54
			interfaceTypeAll = 0,
			/// <summary>
			/// 无效接口类型
			/// </summary>
			// Token: 0x04000037 RID: 55
			interfaceInvalidType = -1
		}

		/// <summary>
		/// 枚举：设备类型
		/// </summary>
		// Token: 0x02000006 RID: 6
		public enum IMV_ECameraType
		{
			/// <summary>
			/// GIGE相机
			/// </summary>
			// Token: 0x04000039 RID: 57
			typeGigeCamera,
			/// <summary>
			/// USB3.0相机
			/// </summary>
			// Token: 0x0400003A RID: 58
			typeU3vCamera,
			/// <summary>
			/// CAMERALINK 相机
			/// </summary>
			// Token: 0x0400003B RID: 59
			typeCLCamera,
			/// <summary>
			/// PCIe相机
			/// </summary>
			// Token: 0x0400003C RID: 60
			typePCIeCamera,
			/// <summary>
			/// 未知类型
			/// </summary>
			// Token: 0x0400003D RID: 61
			typeUndefinedCamera = 255
		}

		/// <summary>
		/// 枚举：创建句柄方式
		/// </summary>
		// Token: 0x02000007 RID: 7
		public enum IMV_ECreateHandleMode
		{
			/// <summary>
			/// 通过已枚举设备的索引(从0开始，比如 0, 1, 2...)
			/// </summary>
			// Token: 0x0400003F RID: 63
			modeByIndex,
			/// <summary>
			/// 通过设备键"厂商:序列号"	
			/// </summary>		
			// Token: 0x04000040 RID: 64
			modeByCameraKey,
			/// <summary>
			/// 通过设备自定义名
			/// </summary>	
			// Token: 0x04000041 RID: 65
			modeByDeviceUserID,
			/// <summary>
			/// 通过设备IP地址
			/// </summary>
			// Token: 0x04000042 RID: 66
			modeByIPAddress
		}

		/// <summary>
		/// 枚举：访问权限
		/// </summary>
		// Token: 0x02000008 RID: 8
		public enum IMV_ECameraAccessPermission
		{
			/// <summary>
			/// GigE相机没有被连接
			/// </summary>
			// Token: 0x04000044 RID: 68
			accessPermissionOpen,
			/// <summary>
			/// 独占访问权限
			/// </summary>
			// Token: 0x04000045 RID: 69
			accessPermissionExclusive,
			/// <summary>
			/// 非独占可读访问权限
			/// </summary>
			// Token: 0x04000046 RID: 70
			accessPermissionControl,
			/// <summary>
			/// 切换控制访问权限
			/// </summary>
			// Token: 0x04000047 RID: 71
			accessPermissionControlWithSwitchover,
			/// <summary>
			/// 无法确定
			/// </summary>
			// Token: 0x04000048 RID: 72
			accessPermissionUnknown = 254,
			/// <summary>
			/// 未定义访问权限
			/// </summary>
			// Token: 0x04000049 RID: 73
			accessPermissionUndefined
		}

		/// <summary>
		/// 枚举：抓图策略
		/// </summary>
		// Token: 0x02000009 RID: 9
		public enum IMV_EGrabStrategy
		{
			/// <summary>
			/// 按到达顺序处理图片
			/// </summary>
			// Token: 0x0400004B RID: 75
			grabStrartegySequential,
			/// <summary>
			/// 获取最新的图片
			/// </summary>
			// Token: 0x0400004C RID: 76
			grabStrartegyLatestImage,
			/// <summary>
			/// 等待获取下一张图片(只针对GigE相机)
			/// </summary>
			// Token: 0x0400004D RID: 77
			grabStrartegyUpcomingImage,
			/// <summary>
			/// 未定义
			/// </summary>
			// Token: 0x0400004E RID: 78
			grabStrartegyUndefined
		}

		/// <summary>
		/// 枚举：流事件状态
		/// </summary>
		// Token: 0x0200000A RID: 10
		public enum IMV_EEventStatus
		{
			/// <summary>
			/// 正常流事件
			/// </summary>
			// Token: 0x04000050 RID: 80
			streamEventNormal = 1,
			/// <summary>
			/// 丢帧事件
			/// </summary>
			// Token: 0x04000051 RID: 81
			streamEventLostFrame,
			/// <summary>
			/// 丢包事件
			/// </summary>
			// Token: 0x04000052 RID: 82
			streamEventLostPacket,
			/// <summary>
			/// 图像错误事件
			/// </summary>
			// Token: 0x04000053 RID: 83
			streamEventImageError,
			/// <summary>
			/// 取流错误事件
			/// </summary>
			// Token: 0x04000054 RID: 84
			streamEventStreamChannelError,
			/// <summary>
			/// 太多连续重传
			/// </summary>
			// Token: 0x04000055 RID: 85
			streamEventTooManyConsecutiveResends,
			/// <summary>
			/// 太多丢包
			/// </summary>
			// Token: 0x04000056 RID: 86
			streamEventTooManyLostPacket
		}

		/// <summary>
		/// 枚举：图像转换Bayer格式所用的算法
		/// </summary>
		// Token: 0x0200000B RID: 11
		public enum IMV_EBayerDemosaic
		{
			/// <summary>
			/// 最近邻
			/// </summary>
			// Token: 0x04000058 RID: 88
			demosaicNearestNeighbor,
			/// <summary>
			/// 双线性
			/// </summary>
			// Token: 0x04000059 RID: 89
			demosaicBilinear,
			/// <summary>
			/// 边缘检测
			/// </summary>
			// Token: 0x0400005A RID: 90
			demosaicEdgeSensing,
			/// <summary>
			/// 不支持
			/// </summary>
			// Token: 0x0400005B RID: 91
			demosaicNotSupport = 255
		}

		/// <summary>
		/// 枚举：事件类型
		/// </summary>
		// Token: 0x0200000C RID: 12
		public enum IMV_EVType
		{
			/// <summary>
			/// 设备离线通知
			/// </summary>
			// Token: 0x0400005D RID: 93
			offLine,
			/// <summary>
			/// 设备在线通知
			/// </summary>
			// Token: 0x0400005E RID: 94
			onLine
		}

		/// <summary>
		/// 枚举：视频格式
		/// </summary>
		// Token: 0x0200000D RID: 13
		public enum IMV_EVideoType
		{
			/// <summary>
			/// AVI格式
			/// </summary>
			// Token: 0x04000060 RID: 96
			typeVideoFormatAVI,
			/// <summary>
			/// 不支持
			/// </summary>
			// Token: 0x04000061 RID: 97
			typeVideoFormatNotSupport = 255
		}

		/// <summary>
		/// 枚举：图像翻转类型
		/// </summary>
		// Token: 0x0200000E RID: 14
		public enum IMV_EFlipType
		{
			/// <summary>
			/// 垂直(Y轴)翻转
			/// </summary>
			// Token: 0x04000063 RID: 99
			typeFlipVertical,
			/// <summary>
			/// 水平(X轴)翻转
			/// </summary>
			// Token: 0x04000064 RID: 100
			typeFlipHorizontal
		}

		/// <summary>
		/// 枚举：顺时针旋转角度
		/// </summary>
		// Token: 0x0200000F RID: 15
		public enum IMV_ERotationAngle
		{
			/// <summary>
			/// 顺时针旋转90度
			/// </summary>
			// Token: 0x04000066 RID: 102
			rotationAngle90,
			/// <summary>
			/// 顺时针旋转180度
			/// </summary>
			// Token: 0x04000067 RID: 103
			rotationAngle180,
			/// <summary>
			/// 顺时针旋转270度
			/// </summary>
			// Token: 0x04000068 RID: 104
			rotationAngle270
		}

		/// <summary>
		/// 枚举：图像保存格式
		/// </summary>
		// Token: 0x02000010 RID: 16
		public enum IMV_ESaveFileType
		{
			/// <summary>
			/// BMP图像格式
			/// </summary>
			// Token: 0x0400006A RID: 106
			typeSaveBmp,
			/// <summary>
			/// JPEG图像格式
			/// </summary>
			// Token: 0x0400006B RID: 107
			typeSaveJpeg,
			/// <summary>
			/// PNG图像格式
			/// </summary>
			// Token: 0x0400006C RID: 108
			typeSavePng,
			/// <summary>
			/// TIFF图像格式
			/// </summary>
			// Token: 0x0400006D RID: 109
			typeSaveTiff,
			/// <summary>
			/// 未定义的图像格式
			/// </summary>
			// Token: 0x0400006E RID: 110
			typeSaveUndefined = 255
		}

		/// <summary>
		/// 枚举：图像格式
		/// </summary>
		// Token: 0x02000011 RID: 17
		public enum IMV_EPixelType
		{
			/// <summary>
			/// Undefined
			/// </summary>
			// Token: 0x04000070 RID: 112
			gvspPixelTypeUndefined = -1,
			/// <summary>
			/// Mono1p
			/// </summary>
			// Token: 0x04000071 RID: 113
			gvspPixelMono1p = 16842807,
			/// <summary>
			/// Mono2p
			/// </summary>
			// Token: 0x04000072 RID: 114
			gvspPixelMono2p = 16908344,
			/// <summary>
			/// Mono4p
			/// </summary>
			// Token: 0x04000073 RID: 115
			gvspPixelMono4p = 17039417,
			/// <summary>
			/// Mono8
			/// </summary>
			// Token: 0x04000074 RID: 116
			gvspPixelMono8 = 17301505,
			/// <summary>
			/// Mono8S
			/// </summary>
			// Token: 0x04000075 RID: 117
			gvspPixelMono8S,
			/// <summary>
			/// Mono10
			/// </summary>
			// Token: 0x04000076 RID: 118
			gvspPixelMono10 = 17825795,
			/// <summary>
			/// Mono10Packed
			/// </summary>
			// Token: 0x04000077 RID: 119
			gvspPixelMono10Packed = 17563652,
			/// <summary>
			/// Mono12
			/// </summary>
			// Token: 0x04000078 RID: 120
			gvspPixelMono12 = 17825797,
			/// <summary>
			/// Mono12Packed
			/// </summary>
			// Token: 0x04000079 RID: 121
			gvspPixelMono12Packed = 17563654,
			/// <summary>
			/// Mono14
			/// </summary>
			// Token: 0x0400007A RID: 122
			gvspPixelMono14 = 17825829,
			/// <summary>
			/// Mono16
			/// </summary>
			// Token: 0x0400007B RID: 123
			gvspPixelMono16 = 17825799,
			/// <summary>
			/// BayGR8
			/// </summary>
			// Token: 0x0400007C RID: 124
			gvspPixelBayGR8 = 17301512,
			/// <summary>
			/// BayRG8
			/// </summary>
			// Token: 0x0400007D RID: 125
			gvspPixelBayRG8,
			/// <summary>
			/// BayGB8
			/// </summary>
			// Token: 0x0400007E RID: 126
			gvspPixelBayGB8,
			/// <summary>
			/// BayBG8
			/// </summary>
			// Token: 0x0400007F RID: 127
			gvspPixelBayBG8,
			/// <summary>
			/// BayGR10
			/// </summary>
			// Token: 0x04000080 RID: 128
			gvspPixelBayGR10 = 17825804,
			/// <summary>
			/// BayRG10
			/// </summary>
			// Token: 0x04000081 RID: 129
			gvspPixelBayRG10,
			/// <summary>
			/// BayGB10
			/// </summary>
			// Token: 0x04000082 RID: 130
			gvspPixelBayGB10,
			/// <summary>
			/// BayBG10
			/// </summary>
			// Token: 0x04000083 RID: 131
			gvspPixelBayBG10,
			/// <summary>
			/// BayGR12
			/// </summary>
			// Token: 0x04000084 RID: 132
			gvspPixelBayGR12,
			/// <summary>
			/// BayRG12
			/// </summary>
			// Token: 0x04000085 RID: 133
			gvspPixelBayRG12,
			/// <summary>
			/// BayGB12
			/// </summary>
			// Token: 0x04000086 RID: 134
			gvspPixelBayGB12,
			/// <summary>
			/// BayBG12
			/// </summary>
			// Token: 0x04000087 RID: 135
			gvspPixelBayBG12,
			/// <summary>
			/// BayGR10Packed
			/// </summary>
			// Token: 0x04000088 RID: 136
			gvspPixelBayGR10Packed = 17563686,
			/// <summary>
			/// BayRG10Packed
			/// </summary>
			// Token: 0x04000089 RID: 137
			gvspPixelBayRG10Packed,
			/// <summary>
			/// BayGB10Packed
			/// </summary>
			// Token: 0x0400008A RID: 138
			gvspPixelBayGB10Packed,
			/// <summary>
			/// BayBG10Packed
			/// </summary>
			// Token: 0x0400008B RID: 139
			gvspPixelBayBG10Packed,
			/// <summary>
			/// BayGR12Packed
			/// </summary>
			// Token: 0x0400008C RID: 140
			gvspPixelBayGR12Packed,
			/// <summary>
			/// BayRG12Packed
			/// </summary>
			// Token: 0x0400008D RID: 141
			gvspPixelBayRG12Packed,
			/// <summary>
			/// BayGB12Packed
			/// </summary>
			// Token: 0x0400008E RID: 142
			gvspPixelBayGB12Packed,
			/// <summary>
			/// BayBG12Packed
			/// </summary>
			// Token: 0x0400008F RID: 143
			gvspPixelBayBG12Packed,
			/// <summary>
			/// BayGR16
			/// </summary>
			// Token: 0x04000090 RID: 144
			gvspPixelBayGR16 = 17825838,
			/// <summary>
			/// BayRG16
			/// </summary>
			// Token: 0x04000091 RID: 145
			gvspPixelBayRG16,
			/// <summary>
			/// BayGB16
			/// </summary>
			// Token: 0x04000092 RID: 146
			gvspPixelBayGB16,
			/// <summary>
			/// BayBG16
			/// </summary>
			// Token: 0x04000093 RID: 147
			gvspPixelBayBG16,
			/// <summary>
			/// RGB8
			/// </summary>
			// Token: 0x04000094 RID: 148
			gvspPixelRGB8 = 35127316,
			/// <summary>
			/// BGR8
			/// </summary>
			// Token: 0x04000095 RID: 149
			gvspPixelBGR8,
			/// <summary>
			/// RGBA8
			/// </summary>
			// Token: 0x04000096 RID: 150
			gvspPixelRGBA8 = 35651606,
			/// <summary>
			/// BGRA8
			/// </summary>
			// Token: 0x04000097 RID: 151
			gvspPixelBGRA8,
			/// <summary>
			/// RGB10
			/// </summary>
			// Token: 0x04000098 RID: 152
			gvspPixelRGB10 = 36700184,
			/// <summary>
			/// BGR10
			/// </summary>
			// Token: 0x04000099 RID: 153
			gvspPixelBGR10,
			/// <summary>
			/// RGB12
			/// </summary>
			// Token: 0x0400009A RID: 154
			gvspPixelRGB12,
			/// <summary>
			/// BGR12
			/// </summary>
			// Token: 0x0400009B RID: 155
			gvspPixelBGR12,
			/// <summary>
			/// RGB16
			/// </summary>
			// Token: 0x0400009C RID: 156
			gvspPixelRGB16 = 36700211,
			/// <summary>
			/// RGB10V1Packed
			/// </summary>
			// Token: 0x0400009D RID: 157
			gvspPixelRGB10V1Packed = 35651612,
			/// <summary>
			/// RGB10P32
			/// </summary>
			// Token: 0x0400009E RID: 158
			gvspPixelRGB10P32,
			/// <summary>
			/// RGB12V1Packed
			/// </summary>
			// Token: 0x0400009F RID: 159
			gvspPixelRGB12V1Packed = 35913780,
			/// <summary>
			/// RGB565P
			/// </summary>
			// Token: 0x040000A0 RID: 160
			gvspPixelRGB565P = 34603061,
			/// <summary>
			/// BGR565P
			/// </summary>
			// Token: 0x040000A1 RID: 161
			gvspPixelBGR565P,
			/// <summary>
			/// YUV411_8_UYYVYY
			/// </summary>
			// Token: 0x040000A2 RID: 162
			gvspPixelYUV411_8_UYYVYY = 34340894,
			/// <summary>
			/// YUV422_8_UYVY
			/// </summary>
			// Token: 0x040000A3 RID: 163
			gvspPixelYUV422_8_UYVY = 34603039,
			/// <summary>
			/// YUV422_8
			/// </summary>
			// Token: 0x040000A4 RID: 164
			gvspPixelYUV422_8 = 34603058,
			/// <summary>
			/// YUV8_UYV
			/// </summary>
			// Token: 0x040000A5 RID: 165
			gvspPixelYUV8_UYV = 35127328,
			/// <summary>
			/// YCbCr8CbYCr
			/// </summary>
			// Token: 0x040000A6 RID: 166
			gvspPixelYCbCr8CbYCr = 35127354,
			/// <summary>
			/// YCbCr422_8
			/// </summary>
			// Token: 0x040000A7 RID: 167
			gvspPixelYCbCr422_8 = 34603067,
			/// <summary>
			/// YCbCr422_8_CbYCrY
			/// </summary>
			// Token: 0x040000A8 RID: 168
			gvspPixelYCbCr422_8_CbYCrY = 34603075,
			/// <summary>
			/// YCbCr411_8_CbYYCrYY
			/// </summary>
			// Token: 0x040000A9 RID: 169
			gvspPixelYCbCr411_8_CbYYCrYY = 34340924,
			/// <summary>
			/// YCbCr601_8_CbYCr
			/// </summary>
			// Token: 0x040000AA RID: 170
			gvspPixelYCbCr601_8_CbYCr = 35127357,
			/// <summary>
			/// YCbCr601_422_8
			/// </summary>
			// Token: 0x040000AB RID: 171
			gvspPixelYCbCr601_422_8 = 34603070,
			/// <summary>
			/// YCbCr601_422_8_CbYCrY
			/// </summary>
			// Token: 0x040000AC RID: 172
			gvspPixelYCbCr601_422_8_CbYCrY = 34603076,
			/// <summary>
			/// YCbCr601_411_8_CbYYCrYY
			/// </summary>
			// Token: 0x040000AD RID: 173
			gvspPixelYCbCr601_411_8_CbYYCrYY = 34340927,
			/// <summary>
			/// YCbCr709_8_CbYCr
			/// </summary>
			// Token: 0x040000AE RID: 174
			gvspPixelYCbCr709_8_CbYCr = 35127360,
			/// <summary>
			/// YCbCr709_422_8
			/// </summary>
			// Token: 0x040000AF RID: 175
			gvspPixelYCbCr709_422_8 = 34603073,
			/// <summary>
			/// YCbCr709_422_8_CbYCrY
			/// </summary>
			// Token: 0x040000B0 RID: 176
			gvspPixelYCbCr709_422_8_CbYCrY = 34603077,
			/// <summary>
			/// YCbCr709_411_8_CbYYCrYY
			/// </summary>
			// Token: 0x040000B1 RID: 177
			gvspPixelYCbCr709_411_8_CbYYCrYY = 34340930,
			/// <summary>
			/// RGB8Planar
			/// </summary>
			// Token: 0x040000B2 RID: 178
			gvspPixelRGB8Planar = 35127329,
			/// <summary>
			/// RGB10Planar
			/// </summary>
			// Token: 0x040000B3 RID: 179
			gvspPixelRGB10Planar = 36700194,
			/// <summary>
			/// RGB12Planar 
			/// </summary>
			// Token: 0x040000B4 RID: 180
			gvspPixelRGB12Planar,
			/// <summary>
			/// RGB16Planar
			/// </summary>
			// Token: 0x040000B5 RID: 181
			gvspPixelRGB16Planar,
			/// <summary>
			/// BayerRG10p, currently used for specific project, please do not use them
			/// </summary>
			// Token: 0x040000B6 RID: 182
			gvspPixelBayRG10p = 17432664,
			/// <summary>
			/// BayerRG12p, currently used for specific project, please do not use them
			/// </summary>
			// Token: 0x040000B7 RID: 183
			gvspPixelBayRG12p = 17563737,
			/// <summary>
			/// mono1c, customized image format, used for binary output
			/// </summary>
			// Token: 0x040000B8 RID: 184
			gvspPixelMono1c = 18874623,
			/// <summary>
			/// mono1e, customized image format, used for displaying connected domain
			/// </summary>
			// Token: 0x040000B9 RID: 185
			gvspPixelMono1e = 17305599
		}

		/// <summary>
		/// 枚举：传输模式(gige)
		/// </summary>
		// Token: 0x02000012 RID: 18
		public enum IMV_TransmissionType
		{
			/// <summary>
			/// 单播模式
			/// </summary>
			// Token: 0x040000BB RID: 187
			transTypeUnicast,
			/// <summary>
			/// 组播模式
			/// </summary>
			// Token: 0x040000BC RID: 188
			transTypeMulticast
		}

		/// <summary>
		/// 字符串信息
		/// </summary>
		// Token: 0x02000013 RID: 19
		public struct IMV_String
		{
			/// <summary>
			/// 字符串.长度不超过256 
			/// </summary>
			// Token: 0x040000BD RID: 189
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string str;
		}

		/// <summary>
		/// GigE网卡信息
		/// </summary>
		// Token: 0x02000014 RID: 20
		public struct IMV_GigEInterfaceInfo
		{
			/// <summary>
			/// 网卡描述信息
			/// </summary>
			// Token: 0x040000BE RID: 190
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string description;

			/// <summary>
			/// 网卡Mac地址
			/// </summary>
			// Token: 0x040000BF RID: 191
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string macAddress;

			/// <summary>
			/// 设备Ip地址
			/// </summary>
			// Token: 0x040000C0 RID: 192
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string ipAddress;

			/// <summary>
			/// 子网掩码
			/// </summary>
			// Token: 0x040000C1 RID: 193
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string subnetMask;

			/// <summary>
			/// 默认网关
			/// </summary>
			// Token: 0x040000C2 RID: 194
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string defaultGateWay;

			/// <summary>
			/// 保留
			/// </summary>
			// Token: 0x040000C3 RID: 195
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1280)]
			public byte[] chReserved;
		}

		/// <summary>
		/// USB接口信息
		/// </summary>
		// Token: 0x02000015 RID: 21
		public struct IMV_UsbInterfaceInfo
		{
			/// <summary>
			/// USB接口描述信息
			/// </summary>
			// Token: 0x040000C4 RID: 196
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string description;

			/// <summary>
			/// USB接口Vendor ID
			/// </summary>
			// Token: 0x040000C5 RID: 197
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string vendorID;

			/// <summary>
			/// USB接口设备ID
			/// </summary>
			// Token: 0x040000C6 RID: 198
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string deviceID;

			/// <summary>
			/// USB接口Subsystem ID
			/// </summary>
			// Token: 0x040000C7 RID: 199
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string subsystemID;

			/// <summary>
			/// USB接口Revision
			/// </summary>
			// Token: 0x040000C8 RID: 200
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string revision;

			/// <summary>
			/// USB接口speed
			/// </summary>
			// Token: 0x040000C9 RID: 201
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string speed;

			/// <summary>
			/// 保留
			/// </summary>
			// Token: 0x040000CA RID: 202
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
			public byte[] chReserved;
		}

		/// <summary>
		/// GigE设备信息
		/// </summary>
		// Token: 0x02000016 RID: 22
		[StructLayout(LayoutKind.Sequential, Size = 3096)]
		public struct IMV_GigEDeviceInfo
		{
			/// <summary>
			/// 设备支持的IP配置选项
			/// </summary>
			/// <remarks>
			/// <para>value:4 相机只支持LLA</para>
			/// <para>value:5 相机支持LLA和Persistent IP</para>
			/// <para>value:6 相机支持LLA和DHCP</para>
			/// <para>value:7 相机支持LLA、DHCP和Persistent IP</para>
			/// <para>value:0 获取失败</para>
			/// </remarks>
			// Token: 0x040000CB RID: 203
			public uint nIpConfigOptions;

			/// <summary>
			/// 设备当前的IP配置选项
			/// </summary>
			/// <remarks>
			/// <para>value:4 LLA处于活动状态</para>
			/// <para>value:5 LLA和Persistent IP处于活动状态</para>
			/// <para>value:6 LLA和DHCP处于活动状态</para>
			/// <para>value:7 LLA、DHCP和Persistent IP处于活动状态</para>
			/// <para>value:0 获取失败</para>
			/// </remarks>
			// Token: 0x040000CC RID: 204
			public uint nIpConfigCurrent;

			/// <summary>
			/// 保留
			/// </summary>
			// Token: 0x040000CD RID: 205
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public uint[] nReserved;

			/// <summary>
			/// 设备Mac地址
			/// </summary>
			// Token: 0x040000CE RID: 206
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string macAddress;

			/// <summary>
			/// 设备Ip地址
			/// </summary>
			// Token: 0x040000CF RID: 207
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string ipAddress;

			/// <summary>
			/// 子网掩码
			/// </summary>
			// Token: 0x040000D0 RID: 208
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string subnetMask;

			/// <summary>
			/// 默认网关
			/// </summary>
			// Token: 0x040000D1 RID: 209
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string defaultGateWay;

			/// <summary>
			/// 网络协议版本
			/// </summary>
			// Token: 0x040000D2 RID: 210
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string protocolVersion;

			/// <summary>
			/// Ip配置有效性
			/// </summary>
			/// <remarks>
			/// <para>Ip配置有效时字符串值"Valid"</para>
			/// <para>Ip配置无效时字符串值"Invalid On This Interface"</para>
			/// </remarks>
			// Token: 0x040000D3 RID: 211
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string ipConfiguration;

			/// <summary>
			/// 保留
			/// </summary>
			// Token: 0x040000D4 RID: 212
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1536)]
			public byte[] chReserved;
		}

		/// <summary>
		/// Usb设备信息
		/// </summary>
		// Token: 0x02000017 RID: 23
		public struct IMV_UsbDeviceInfo
		{
			/// <summary>
			/// true支持，false不支持，其他值 非法。
			/// </summary>
			// Token: 0x040000D5 RID: 213
			[MarshalAs(UnmanagedType.I1)]
			public bool bLowSpeedSupported;

			/// <summary>
			/// true支持，false不支持，其他值 非法。
			/// </summary>
			// Token: 0x040000D6 RID: 214
			[MarshalAs(UnmanagedType.I1)]
			public bool bFullSpeedSupported;

			/// <summary>
			/// true支持，false不支持，其他值 非法。
			/// </summary>
			// Token: 0x040000D7 RID: 215
			[MarshalAs(UnmanagedType.I1)]
			public bool bHighSpeedSupported;

			/// <summary>
			/// true支持，false不支持，其他值 非法。
			/// </summary>
			// Token: 0x040000D8 RID: 216
			[MarshalAs(UnmanagedType.I1)]
			public bool bSuperSpeedSupported;

			/// <summary>
			/// true支持，false不支持，其他值 非法。
			/// </summary>
			// Token: 0x040000D9 RID: 217
			[MarshalAs(UnmanagedType.I1)]
			public bool bDriverInstalled;

			/// <summary>
			/// 保留
			/// </summary>
			// Token: 0x040000DA RID: 218
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public bool[] boolReserved;

			/// <summary>
			/// 保留
			/// </summary>
			// Token: 0x040000DB RID: 219
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public uint[] Reserved;

			/// <summary>
			/// 配置有效性
			/// </summary>
			// Token: 0x040000DC RID: 220
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string configurationValid;

			/// <summary>
			/// GenCP 版本
			/// </summary>
			// Token: 0x040000DD RID: 221
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string genCPVersion;

			/// <summary>
			/// U3V 版本号
			/// </summary>
			// Token: 0x040000DE RID: 222
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string u3vVersion;

			/// <summary>
			/// 设备引导号
			/// </summary>
			// Token: 0x040000DF RID: 223
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string deviceGUID;

			/// <summary>
			/// 设备系列号
			/// </summary>
			// Token: 0x040000E0 RID: 224
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string familyName;

			/// <summary>
			/// 设备序列号
			/// </summary>
			// Token: 0x040000E1 RID: 225
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string u3vSerialNumber;

			/// <summary>
			/// 设备传输速度
			/// </summary>
			// Token: 0x040000E2 RID: 226
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string speed;

			/// <summary>
			/// 设备最大供电量
			/// </summary>
			// Token: 0x040000E3 RID: 227
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string maxPower;

			/// <summary>
			/// 保留
			/// </summary>
			// Token: 0x040000E4 RID: 228
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
			public byte[] chReserved;
		}

		/// <summary>
		/// 设备通用信息
		/// </summary>
		// Token: 0x02000018 RID: 24
		public struct IMV_DeviceInfo
		{
			/// <summary>
			/// 设备类别
			/// </summary>
			// Token: 0x040000E5 RID: 229
			public IMVDefine.IMV_ECameraType nCameraType;

			/// <summary>
			/// 保留
			/// </summary>
			// Token: 0x040000E6 RID: 230
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
			public int[] nCameraReserved;

			/// <summary>
			/// 厂商:序列号
			/// </summary>
			// Token: 0x040000E7 RID: 231
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string cameraKey;

			/// <summary>
			/// 用户自定义名
			/// </summary>
			// Token: 0x040000E8 RID: 232
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string cameraName;

			/// <summary>
			/// 设备序列号
			/// </summary>
			// Token: 0x040000E9 RID: 233
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string serialNumber;

			/// <summary>
			/// 厂商
			/// </summary>
			// Token: 0x040000EA RID: 234
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string vendorName;

			/// <summary>
			/// 设备型号
			/// </summary>
			// Token: 0x040000EB RID: 235
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string modelName;

			/// <summary>
			/// 设备制造信息
			/// </summary>
			// Token: 0x040000EC RID: 236
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string manufactureInfo;

			/// <summary>
			/// 设备版本
			/// </summary>
			// Token: 0x040000ED RID: 237
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string deviceVersion;

			/// <summary>
			/// 保留
			/// </summary>
			// Token: 0x040000EE RID: 238
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1280)]
			public byte[] cameraReserved;

			/// <summary>
			/// 设备信息
			/// </summary>
			// Token: 0x040000EF RID: 239
			public IMVDefine.IMV_DeviceInfo.DeviceSpecificInfo deviceSpecificInfo;

			/// <summary>
			/// 接口类别
			/// </summary>
			// Token: 0x040000F0 RID: 240
			public IMVDefine.IMV_EInterfaceType nInterfaceType;

			/// <summary>
			/// 保留
			/// </summary>
			// Token: 0x040000F1 RID: 241
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
			public int[] nInterfaceReserved;

			/// <summary>
			/// 接口名
			/// </summary>
			// Token: 0x040000F2 RID: 242
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string interfaceName;

			/// <summary>
			/// 保留
			/// </summary>
			// Token: 0x040000F3 RID: 243
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1280)]
			public byte[] interfaceReserved;

			/// <summary>
			/// 接口信息
			/// </summary>
			// Token: 0x040000F4 RID: 244
			public IMVDefine.IMV_DeviceInfo.InterfaceInfo interfaceInfo;

			/// <summary>
			/// 设备信息
			/// </summary>
			// Token: 0x02000019 RID: 25
			[StructLayout(LayoutKind.Explicit, Size = 3096)]
			public struct DeviceSpecificInfo
			{
				/// <summary>
				/// Gige设备信息
				/// </summary>
				// Token: 0x040000F5 RID: 245
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3096, ArraySubType = UnmanagedType.I1)]
				public byte[] gigeDeviceInfo;

				/// <summary>
				/// Usb设备信息
				/// </summary>
				// Token: 0x040000F6 RID: 246
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3096, ArraySubType = UnmanagedType.I1)]
				public byte[] usbDeviceInfo;
			}

			/// <summary>
			/// 接口信息
			/// </summary>
			// Token: 0x0200001A RID: 26
			[StructLayout(LayoutKind.Explicit, Size = 2560)]
			public struct InterfaceInfo
			{
				/// <summary>
				/// GigE网卡信息
				/// </summary>
				// Token: 0x040000F7 RID: 247
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2560)]
				public byte[] gigeInterfaceInfo;

				/// <summary>
				/// Usb接口信息
				/// </summary>
				// Token: 0x040000F8 RID: 248
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2560)]
				public byte[] usbInterfaceInfo;
			}
		}

		/// <summary>
		/// 网络传输模式
		/// </summary>
		// Token: 0x0200001B RID: 27
		public struct IMV_TransMission_Type
		{
			/// <summary>
			/// 传输模式
			/// </summary>
			// Token: 0x040000F9 RID: 249
			public IMVDefine.IMV_TransmissionType eTransmissionType;

			/// <summary>
			/// 目标ip地址
			/// </summary>
			// Token: 0x040000FA RID: 250
			public uint nDesIp;

			/// <summary>
			/// 目标端口号
			/// </summary>
			// Token: 0x040000FB RID: 251
			public ushort nDesPort;

			/// <summary>
			/// 预留位
			/// </summary>
			// Token: 0x040000FC RID: 252
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
			public uint[] nReserved;
		}

		/// <summary>
		/// 加载失败的属性信息
		/// </summary>
		// Token: 0x0200001C RID: 28
		public struct IMV_ErrorList
		{
			/// <summary>
			/// 加载失败的属性个数
			/// </summary>
			// Token: 0x040000FD RID: 253
			public uint nParamCnt;

			/// <summary>
			/// 加载失败的属性集合，上限128
			/// </summary>
			// Token: 0x040000FE RID: 254
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
			public IMVDefine.IMV_String[] paramNameList;
		}

		/// <summary>
		/// 设备信息列表
		/// </summary>
		// Token: 0x0200001D RID: 29
		public struct IMV_DeviceList
		{
			/// <summary>
			/// 设备数量
			/// </summary>
			// Token: 0x040000FF RID: 255
			public uint nDevNum;

			/// <summary>
			/// 设备息列表(SDK内部缓存)，最多100设备
			/// </summary>
			// Token: 0x04000100 RID: 256
			public IntPtr pDevInfo;
		}

		/// <summary>
		/// 连接事件信息
		/// </summary>
		// Token: 0x0200001E RID: 30
		public struct IMV_SConnectArg
		{
			/// <summary>
			/// 事件类型
			/// </summary>
			// Token: 0x04000101 RID: 257
			public IMVDefine.IMV_EVType EvType;

			/// <summary>
			/// 预留字段
			/// </summary>
			// Token: 0x04000102 RID: 258
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
			public uint[] nReserve;
		}

		/// <summary>
		/// 参数更新事件信息
		/// </summary>
		// Token: 0x0200001F RID: 31
		public struct IMV_SParamUpdateArg
		{
			/// <summary>
			/// 是否是定时更新,true:表示是定时更新，false:表示非定时更新
			/// </summary>
			// Token: 0x04000103 RID: 259
			public bool isPoll;

			/// <summary>
			/// 预留字段
			/// </summary>
			// Token: 0x04000104 RID: 260
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
			public uint[] nReserve;

			/// <summary>
			/// 更新的参数个数
			/// </summary>
			// Token: 0x04000105 RID: 261
			public uint nParamCnt;

			/// <summary>
			/// 更新的参数名称集合(SDK内部缓存)
			/// </summary>
			// Token: 0x04000106 RID: 262
			public IntPtr pParamNameList;
		}

		/// <summary>
		/// 流事件信息
		/// </summary>
		// Token: 0x02000020 RID: 32
		public struct IMV_SStreamArg
		{
			/// <summary>
			/// 流通道号
			/// </summary>
			// Token: 0x04000107 RID: 263
			public uint channel;

			/// <summary>
			/// 流数据BlockID
			/// </summary>
			// Token: 0x04000108 RID: 264
			public ulong blockId;

			/// <summary>
			/// 时间戳
			/// </summary>
			// Token: 0x04000109 RID: 265
			public ulong timeStamp;

			/// <summary>
			/// 流事件状态码
			/// </summary>
			// Token: 0x0400010A RID: 266
			public IMVDefine.IMV_EEventStatus eStreamEventStatus;

			/// <summary>
			/// 事件状态错误码
			/// </summary>
			// Token: 0x0400010B RID: 267
			public uint status;

			/// <summary>
			/// 预留字段
			/// </summary>
			// Token: 0x0400010C RID: 268
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
			public uint[] nReserve;
		}

		/// <summary>
		/// 消息通道事件信息
		/// </summary>
		// Token: 0x02000021 RID: 33
		public struct IMV_SMsgChannelArg
		{
			/// <summary>
			/// 事件Id
			/// </summary>
			// Token: 0x0400010D RID: 269
			public ushort eventId;

			/// <summary>
			/// 消息通道号
			/// </summary>
			// Token: 0x0400010E RID: 270
			public ushort channelId;

			/// <summary>
			/// 流数据BlockID
			/// </summary>
			// Token: 0x0400010F RID: 271
			public ulong blockId;

			/// <summary>
			/// 时间戳
			/// </summary>
			// Token: 0x04000110 RID: 272
			public ulong timeStamp;

			/// <summary>
			/// 预留字段
			/// </summary>
			// Token: 0x04000111 RID: 273
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public uint[] nReserve;

			/// <summary>
			/// 参数个数
			/// </summary>
			// Token: 0x04000112 RID: 274
			public uint nParamCnt;

			/// <summary>
			/// 事件相关的属性名列集合(SDK内部缓存)
			/// </summary>
			// Token: 0x04000113 RID: 275
			public IntPtr pParamNameList;
		}

		/// <summary>
		/// Chunk数据信息
		/// </summary>
		// Token: 0x02000022 RID: 34
		public struct IMV_ChunkDataInfo
		{
			/// <summary>
			/// ChunkID
			/// </summary>
			// Token: 0x04000114 RID: 276
			public uint chunkID;

			/// <summary>
			/// 属性名个数
			/// </summary>
			// Token: 0x04000115 RID: 277
			public uint nParamCnt;

			/// <summary>
			/// Chunk数据对应的属性名集合(SDK内部缓存)
			/// </summary>
			// Token: 0x04000116 RID: 278
			public IntPtr pParamNameList;
		}

		/// <summary>
		/// 帧图像信息
		/// </summary>
		// Token: 0x02000023 RID: 35
		public struct IMV_FrameInfo
		{
			/// <summary>
			/// 帧Id(仅对GigE/Usb/PCIe相机有效)
			/// </summary>
			// Token: 0x04000117 RID: 279
			public ulong blockId;

			/// <summary>
			/// 数据帧状态(0是正常状态)
			/// </summary>
			// Token: 0x04000118 RID: 280
			public uint status;

			/// <summary>
			/// 图像宽度
			/// </summary>
			// Token: 0x04000119 RID: 281
			public uint width;

			/// <summary>
			/// 图像高度
			/// </summary>
			// Token: 0x0400011A RID: 282
			public uint height;

			/// <summary>
			/// 图像大小
			/// </summary>
			// Token: 0x0400011B RID: 283
			public uint size;

			/// <summary>
			/// 图像像素格式
			/// </summary>
			// Token: 0x0400011C RID: 284
			public IMVDefine.IMV_EPixelType pixelFormat;

			/// <summary>
			/// 图像时间戳(仅对GigE/Usb/PCIe相机有效)
			/// </summary>
			// Token: 0x0400011D RID: 285
			public ulong timeStamp;

			/// <summary>
			/// 帧数据中包含的Chunk个数(仅对GigE/Usb相机有效)
			/// </summary>
			// Token: 0x0400011E RID: 286
			public uint chunkCount;

			/// <summary>
			/// 图像paddingX(仅对GigE/Usb/PCIe相机有效)
			/// </summary>
			// Token: 0x0400011F RID: 287
			public uint paddingX;

			/// <summary>
			/// 图像paddingY(仅对GigE/Usb/PCIe相机有效)
			/// </summary>
			// Token: 0x04000120 RID: 288
			public uint paddingY;

			/// <summary>
			/// 图像在网络传输所用的时间(单位:微秒,非GigE相机该值为0)
			/// </summary>
			// Token: 0x04000121 RID: 289
			public uint recvFrameTime;

			/// <summary>
			/// 预留字段
			/// </summary>
			// Token: 0x04000122 RID: 290
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I4)]
			public uint[] nReserved;
		}

		/// <summary>
		/// 帧图像数据信息
		/// </summary>
		// Token: 0x02000024 RID: 36
		public struct IMV_Frame
		{
			/// <summary>
			/// 帧图像句柄(SDK内部帧管理用)
			/// </summary>
			// Token: 0x04000123 RID: 291
			public IntPtr frameHandle;

			/// <summary>
			/// 帧图像数据的内存首地址
			/// </summary>
			// Token: 0x04000124 RID: 292
			public IntPtr pData;

			/// <summary>
			/// 帧信息
			/// </summary>
			// Token: 0x04000125 RID: 293
			public IMVDefine.IMV_FrameInfo frameInfo;

			/// <summary>
			/// 预留字段
			/// </summary>
			// Token: 0x04000126 RID: 294
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
			public uint[] nReserved;
		}

		/// <summary>
		/// PCIE设备统计流信息
		/// </summary>
		// Token: 0x02000025 RID: 37
		public struct IMV_PCIEStreamStatsInfo
		{
			/// <summary>
			/// 图像错误的帧数
			/// </summary>
			// Token: 0x04000127 RID: 295
			public uint imageError;

			/// <summary>
			/// 丢包的帧数
			/// </summary>
			// Token: 0x04000128 RID: 296
			public uint lostPacketBlock;

			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x04000129 RID: 297
			public IMVDefine.IMV_PCIEStreamStatsInfo.FixedBuffer0 nReserved0;

			/// <summary>
			/// 正常获取的帧数
			/// </summary>
			// Token: 0x0400012A RID: 298
			public uint imageReceived;

			/// <summary>
			/// 帧率
			/// </summary>
			// Token: 0x0400012B RID: 299
			public double fps;

			/// <summary>
			/// 带宽(Mbps)
			/// </summary>
			// Token: 0x0400012C RID: 300
			public double bandwidth;

			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x0400012D RID: 301
			public IMVDefine.IMV_PCIEStreamStatsInfo.FixedBuffer1 nReserved;

			// Token: 0x02000026 RID: 38
			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Size = 40)]
			public struct FixedBuffer0
			{
				// Token: 0x0400012E RID: 302
				public uint FixedElementField;
			}

			// Token: 0x02000027 RID: 39
			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Size = 32)]
			public struct FixedBuffer1
			{
				// Token: 0x0400012F RID: 303
				public uint FixedElementField;
			}
		}

		/// <summary>
		/// U3V设备统计流信息
		/// </summary>
		// Token: 0x02000028 RID: 40
		public struct IMV_U3VStreamStatsInfo
		{
			/// <summary>
			/// 图像错误的帧数
			/// </summary>
			// Token: 0x04000130 RID: 304
			public uint imageError;

			/// <summary>
			/// 丢包的帧数
			/// </summary>
			// Token: 0x04000131 RID: 305
			public uint lostPacketBlock;

			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x04000132 RID: 306
			public IMVDefine.IMV_U3VStreamStatsInfo.FixedBuffer2 nReserved0;

			/// <summary>
			/// 正常获取的帧数
			/// </summary>
			// Token: 0x04000133 RID: 307
			public uint imageReceived;

			/// <summary>
			/// 帧率
			/// </summary>
			// Token: 0x04000134 RID: 308
			public double fps;

			/// <summary>
			/// 带宽(Mbps)
			/// </summary>
			// Token: 0x04000135 RID: 309
			public double bandwidth;

			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x04000136 RID: 310
			public IMVDefine.IMV_U3VStreamStatsInfo.FixedBuffer3 nReserved;

			// Token: 0x02000029 RID: 41
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 40)]
			public struct FixedBuffer2
			{
				// Token: 0x04000137 RID: 311
				public uint FixedElementField;
			}

			// Token: 0x0200002A RID: 42
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 32)]
			public struct FixedBuffer3
			{
				// Token: 0x04000138 RID: 312
				public uint FixedElementField;
			}
		}

		/// <summary>
		/// Gige设备统计流信息
		/// </summary>
		// Token: 0x0200002B RID: 43
		public struct IMV_GigEStreamStatsInfo
		{
			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x04000139 RID: 313
			public IMVDefine.IMV_GigEStreamStatsInfo.FixedBuffer4 nReserved0;

			/// <summary>
			/// 图像错误的帧数
			/// </summary>
			// Token: 0x0400013A RID: 314
			public uint imageError;

			/// <summary>
			/// 丢包的帧数
			/// </summary>
			// Token: 0x0400013B RID: 315
			public uint lostPacketBlock;

			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x0400013C RID: 316
			public IMVDefine.IMV_GigEStreamStatsInfo.FixedBuffer5 nReserved1;

			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x0400013D RID: 317
			public IMVDefine.IMV_GigEStreamStatsInfo.FixedBuffer6 nReserved2;

			/// <summary>
			/// 正常获取的帧数
			/// </summary>
			// Token: 0x0400013E RID: 318
			public uint imageReceived;

			/// <summary>
			/// 帧率
			/// </summary>
			// Token: 0x0400013F RID: 319
			public double fps;

			/// <summary>
			/// 带宽(Mbps)
			/// </summary>
			// Token: 0x04000140 RID: 320
			public double bandwidth;

			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x04000141 RID: 321
			public IMVDefine.IMV_GigEStreamStatsInfo.FixedBuffer7 nReserved;

			// Token: 0x0200002C RID: 44
			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Size = 40)]
			public struct FixedBuffer4
			{
				// Token: 0x04000142 RID: 322
				public uint FixedElementField;
			}

			// Token: 0x0200002D RID: 45
			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Size = 16)]
			public struct FixedBuffer5
			{
				// Token: 0x04000143 RID: 323
				public uint FixedElementField;
			}

			// Token: 0x0200002E RID: 46
			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Size = 20)]
			public struct FixedBuffer6
			{
				// Token: 0x04000144 RID: 324
				public uint FixedElementField;
			}

			// Token: 0x0200002F RID: 47
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 16)]
			public struct FixedBuffer7
			{
				// Token: 0x04000145 RID: 325
				public uint FixedElementField;
			}
		}

		/// <summary>
		/// 统计流信息
		/// </summary>
		// Token: 0x02000030 RID: 48
		[StructLayout(LayoutKind.Explicit)]
		public struct IMV_StreamStatisticsInfo
		{
			/// <summary>
			/// 设备类型
			/// </summary>
			// Token: 0x04000146 RID: 326
			[FieldOffset(0)]
			public IMVDefine.IMV_ECameraType nCameraType;

			/// <summary>
			/// PCIE设备统计信息
			/// </summary>
			// Token: 0x04000147 RID: 327
			[FieldOffset(8)]
			public IMVDefine.IMV_PCIEStreamStatsInfo pcieStatisticsInfo;

			/// <summary>
			/// U3V设备统计信息
			/// </summary>
			// Token: 0x04000148 RID: 328
			[FieldOffset(8)]
			public IMVDefine.IMV_U3VStreamStatsInfo u3vStatisticsInfo;

			/// <summary>
			/// Gige设备统计信息
			/// </summary>
			// Token: 0x04000149 RID: 329
			[FieldOffset(8)]
			public IMVDefine.IMV_GigEStreamStatsInfo gigeStatisticsInfo;
		}

		/// <summary>
		/// 枚举属性的枚举值信息
		/// </summary>
		// Token: 0x02000031 RID: 49
		public struct IMV_EnumEntryInfo
		{
			/// <summary>
			/// 枚举值
			/// </summary>
			// Token: 0x0400014A RID: 330
			public ulong value;

			/// <summary>
			/// symbol名
			/// </summary>
			// Token: 0x0400014B RID: 331
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string name;
		}

		/// <summary>
		/// 枚举属性的可设枚举值列表信息
		/// </summary>
		// Token: 0x02000032 RID: 50
		public struct IMV_EnumEntryList
		{
			/// <summary>
			/// 存放枚举值内存大小
			/// </summary>
			// Token: 0x0400014C RID: 332
			public uint nEnumEntryBufferSize;

			/// <summary>
			/// 存放可设枚举值列表(调用者分配缓存)
			/// </summary>
			// Token: 0x0400014D RID: 333
			public IntPtr pEnumEntryInfo;
		}

		/// <summary>
		/// 像素转换结构体
		/// </summary>
		// Token: 0x02000033 RID: 51
		public struct IMV_PixelConvertParam
		{
			/// <summary>
			/// 图像宽
			/// </summary>
			// Token: 0x0400014E RID: 334
			public uint nWidth;

			/// <summary>
			/// 图像高
			/// </summary>
			// Token: 0x0400014F RID: 335
			public uint nHeight;

			/// <summary>
			/// 像素格式
			/// </summary>
			// Token: 0x04000150 RID: 336
			public IMVDefine.IMV_EPixelType ePixelFormat;

			/// <summary>
			/// 输入图像数据
			/// </summary>
			// Token: 0x04000151 RID: 337
			public IntPtr pSrcData;

			/// <summary>
			/// 输入图像长度
			/// </summary>
			// Token: 0x04000152 RID: 338
			public uint nSrcDataLen;

			/// <summary>
			/// 图像宽填充
			/// </summary>
			// Token: 0x04000153 RID: 339
			public uint nPaddingX;

			/// <summary>
			/// 图像高填充
			/// </summary>
			// Token: 0x04000154 RID: 340
			public uint nPaddingY;

			/// <summary>
			/// 转换Bayer格式算法
			/// </summary>
			// Token: 0x04000155 RID: 341
			public IMVDefine.IMV_EBayerDemosaic eBayerDemosaic;

			/// <summary>
			/// 目标像素格式
			/// </summary>
			// Token: 0x04000156 RID: 342
			public IMVDefine.IMV_EPixelType eDstPixelFormat;

			/// <summary>
			/// 输出数据缓存(调用者分配缓存)
			/// </summary>
			// Token: 0x04000157 RID: 343
			public IntPtr pDstBuf;

			/// <summary>
			/// 提供的输出缓冲区大小
			/// </summary>
			// Token: 0x04000158 RID: 344
			public uint nDstBufSize;

			/// <summary>
			/// 输出数据长度
			/// </summary>
			// Token: 0x04000159 RID: 345
			public uint nDstDataLen;

			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x0400015A RID: 346
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public uint[] nReserved;
		}

		/// <summary>
		/// 图像翻转结构体
		/// </summary>
		// Token: 0x02000034 RID: 52
		public struct IMV_FlipImageParam
		{
			/// <summary>
			/// 图像宽
			/// </summary>
			// Token: 0x0400015B RID: 347
			public uint nWidth;

			/// <summary>
			/// 图像高
			/// </summary>
			// Token: 0x0400015C RID: 348
			public uint nHeight;

			/// <summary>
			/// 像素格式
			/// </summary>
			// Token: 0x0400015D RID: 349
			public IMVDefine.IMV_EPixelType ePixelFormat;

			/// <summary>
			/// 翻转类型
			/// </summary>
			// Token: 0x0400015E RID: 350
			public IMVDefine.IMV_EFlipType eFlipType;

			/// <summary>
			/// 输入图像数据
			/// </summary>
			// Token: 0x0400015F RID: 351
			public IntPtr pSrcData;

			/// <summary>
			/// 输入图像长度
			/// </summary>
			// Token: 0x04000160 RID: 352
			public uint nSrcDataLen;

			/// <summary>
			/// 输出数据缓存(调用者分配缓存)
			/// </summary>
			// Token: 0x04000161 RID: 353
			public IntPtr pDstBuf;

			/// <summary>
			/// 提供的输出缓冲区大小
			/// </summary>
			// Token: 0x04000162 RID: 354
			public uint nDstBufSize;

			/// <summary>
			/// 输出数据长度
			/// </summary>
			// Token: 0x04000163 RID: 355
			public uint nDstDataLen;

			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x04000164 RID: 356
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public uint[] nReserved;
		}

		/// <summary>
		/// 图像旋转结构体
		/// </summary>
		// Token: 0x02000035 RID: 53
		public struct IMV_RotateImageParam
		{
			/// <summary>
			/// 图像宽
			/// </summary>
			// Token: 0x04000165 RID: 357
			public uint nWidth;

			/// <summary>
			/// 图像高
			/// </summary>
			// Token: 0x04000166 RID: 358
			public uint nHeight;

			/// <summary>
			/// 像素格式
			/// </summary>
			// Token: 0x04000167 RID: 359
			public IMVDefine.IMV_EPixelType ePixelFormat;

			/// <summary>
			/// 旋转角度
			/// </summary>
			// Token: 0x04000168 RID: 360
			public IMVDefine.IMV_ERotationAngle eRotationAngle;

			/// <summary>
			/// 输入图像数据
			/// </summary>
			// Token: 0x04000169 RID: 361
			public IntPtr pSrcData;

			/// <summary>
			/// 输入图像长度
			/// </summary>
			// Token: 0x0400016A RID: 362
			public uint nSrcDataLen;

			/// <summary>
			/// 输出数据缓存(调用者分配缓存)
			/// </summary>
			// Token: 0x0400016B RID: 363
			public IntPtr pDstBuf;

			/// <summary>
			/// 提供的输出缓冲区大小
			/// </summary>
			// Token: 0x0400016C RID: 364
			public uint nDstBufSize;

			/// <summary>
			/// 输出数据长度
			/// </summary>
			// Token: 0x0400016D RID: 365
			public uint nDstDataLen;

			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x0400016E RID: 366
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public uint[] nReserved;
		}

		/// <summary>
		/// 保存图像结构体
		/// </summary>
		// Token: 0x02000036 RID: 54
		public struct IMV_SaveImageToFileParam
		{
			/// <summary>
			/// 图像宽
			/// </summary>
			// Token: 0x0400016F RID: 367
			public uint nWidth;

			/// <summary>
			/// 图像高
			/// </summary>
			// Token: 0x04000170 RID: 368
			public uint nHeight;

			/// <summary>
			/// 像素格式
			/// </summary>
			// Token: 0x04000171 RID: 369
			public IMVDefine.IMV_EPixelType ePixelFormat;

			/// <summary>
			/// 输入图像数据
			/// </summary>
			// Token: 0x04000172 RID: 370
			public IntPtr pSrcData;

			/// <summary>
			/// 输入数据大小
			/// </summary>
			// Token: 0x04000173 RID: 371
			public uint nSrcDataLen;

			/// <summary>
			/// 输入图片格式
			/// </summary>
			// Token: 0x04000174 RID: 372
			public IMVDefine.IMV_ESaveFileType eImageType;

			/// <summary>
			/// 输入文件路径
			/// </summary>
			// Token: 0x04000175 RID: 373
			public string pImagePath;

			/// <summary>
			/// JPG编码质量(50-99]，PNG编码质量[0-9]
			/// </summary>
			// Token: 0x04000176 RID: 374
			public uint nQuality;

			/// <summary>
			/// 转换Bayer格式算法 
			/// </summary>
			// Token: 0x04000177 RID: 375
			public IMVDefine.IMV_EBayerDemosaic eBayerDemosaic;

			/// <summary>
			/// 预留
			/// </summary>
			// Token: 0x04000178 RID: 376
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public uint[] nReserved;
		}

		/// <summary>
		/// 设备连接状态事件回调函数声明
		/// </summary>
		/// <param name="pConnectArg">[in] 回调时主动推送的设备连接状态事件信息</param>
		/// <param name="pUser">[in] 用户自定义数据</param>
		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600004C RID: 76
		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public delegate void IMV_ConnectCallBack(ref IMVDefine.IMV_SConnectArg pConnectArg, IntPtr pUser);

		/// <summary>
		/// 参数更新事件回调函数声明
		/// </summary>
		/// <param name="pParamUpdateArg">[in] 回调时主动推送的参数更新事件信息</param>
		/// <param name="pUser">[in] 用户自定义数据</param>
		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000050 RID: 80
		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public delegate void IMV_ParamUpdateCallBack(ref IMVDefine.IMV_SParamUpdateArg pParamUpdateArg, IntPtr pUser);

		/// <summary>
		/// 流事件回调函数声明
		/// </summary>
		/// <param name="pStreamArg">[in] 回调时主动推送的流事件信息</param>
		/// <param name="pUser">[in] 用户自定义数据</param>
		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000054 RID: 84
		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public delegate void IMV_StreamCallBack(ref IMVDefine.IMV_SStreamArg pStreamArg, IntPtr pUser);

		/// <summary>
		/// 消息通道事件回调函数声明
		/// </summary>
		/// <param name="pMsgChannelArg">[in] 回调时主动推送的消息通道事件信息</param>
		/// <param name="pUser">[in] 用户自定义数据</param>
		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000058 RID: 88
		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public delegate void IMV_MsgChannelCallBack(ref IMVDefine.IMV_SMsgChannelArg pMsgChannelArg, IntPtr pUser);

		/// <summary>
		/// 帧数据信息回调函数声明
		/// </summary>
		/// <param name="pFrame">[in]回调时主动推送的帧信息</param>
		/// <param name="pUser">[in] 用户自定义数据</param>
		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600005C RID: 92
		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public delegate void IMV_FrameCallBack(ref IMVDefine.IMV_Frame pFrame, IntPtr pUser);
	}
}
