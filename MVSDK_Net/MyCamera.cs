using System;
using System.Runtime.InteropServices;

namespace MVSDK_Net
{
	/// <summary>
	/// 相机类
	/// </summary>
	// Token: 0x0200003C RID: 60
	public class MyCamera
	{
		/// <summary>
		/// 相机构造函数
		/// </summary>
		// Token: 0x0600005F RID: 95 RVA: 0x00002060 File Offset: 0x00000260
		public MyCamera()
		{
			this.m_DevHandle = IntPtr.Zero;
		}

		/// <summary>
		/// 获取版本信息
		/// </summary>
		/// <returns>成功时返回版本信息，失败时返回NULL</returns>
		// Token: 0x06000060 RID: 96 RVA: 0x00002073 File Offset: 0x00000273
		public static string IMV_GetVersion()
		{
			return Marshal.PtrToStringAnsi(IMVApi.IMV_GetVersion());
		}

		/// <summary>
		/// 枚举设备
		/// </summary>
		/// <param name="pDeviceList">[OUT] 设备列表</param>
		/// <param name="interfaceType">[IN] 待枚举的接口类型, 类型可任意组合,如 interfaceTypeGige | interfaceTypeUsb3</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// <para>1、当interfaceType = interfaceTypeAll  时，枚举所有接口下的在线设备</para>
		/// <para>2、当interfaceType = interfaceTypeGige 时，枚举所有GigE网口下的在线设备</para>
		/// <para>3、当interfaceType = interfaceTypeUsb3 时，枚举所有USB接口下的在线设备</para>
		/// <para>4、当interfaceType = interfaceTypeCL   时，枚举所有CameraLink接口下的在线设备</para>
		/// <para>5、该接口下的interfaceType支持任意接口类型的组合,如，若枚举所有GigE网口和USB3接口下的在线设备时,</para>
		/// <para>可将interfaceType设置为 interfaceType = interfaceTypeGige | interfaceTypeUsb3,其它接口类型组合以此类推</para>
		/// </remarks>
		// Token: 0x06000061 RID: 97 RVA: 0x0000207F File Offset: 0x0000027F
		public static int IMV_EnumDevices(ref IMVDefine.IMV_DeviceList pDeviceList, uint interfaceType)
		{
			return IMVApi.IMV_EnumDevices(ref pDeviceList, interfaceType);
		}

		/// <summary>
		/// 以单播形式枚举设备, 仅限Gige设备使用
		/// </summary>
		/// <param name="pDeviceList">[OUT] 设备列表</param>
		/// <param name="pIpAddress">[IN] 设备的IP地址</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000062 RID: 98 RVA: 0x00002088 File Offset: 0x00000288
		public static int IMV_EnumDevicesByUnicast(ref IMVDefine.IMV_DeviceList pDeviceList, string pIpAddress)
		{
			return IMVApi.IMV_EnumDevicesByUnicast(ref pDeviceList, pIpAddress);
		}

		/// <summary>
		/// 通过指定标示符创建设备句柄，如指定索引、设备键、设备自定义名、IP地址.
		/// </summary>
		/// <param name="mode">[IN] 创建设备方式</param>
		/// <param name="cameraIndex">[IN] 指定索引</param>
		/// <param name="cameraStr">[IN] 设备键、设备自定义名、IP地址</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000063 RID: 99 RVA: 0x00002094 File Offset: 0x00000294
		public int IMV_CreateHandle(IMVDefine.IMV_ECreateHandleMode mode, int cameraIndex = 0, string cameraStr = "")
		{
			if (this.m_DevHandle != IntPtr.Zero)
			{
				IMVApi.IMV_DestroyHandle(this.m_DevHandle);
				this.m_DevHandle = IntPtr.Zero;
			}
			IntPtr intPtr = IntPtr.Zero;
			if (mode == IMVDefine.IMV_ECreateHandleMode.modeByIndex)
			{
				intPtr = Marshal.AllocHGlobal(4);
				Marshal.WriteInt32(intPtr, cameraIndex);
			}
			else
			{
				intPtr = Marshal.StringToHGlobalAnsi(cameraStr);
			}
			int num = IMVApi.IMV_CreateHandle(ref this.m_DevHandle, mode, intPtr);
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
			}
			return num;
		}

		/// <summary>
		/// 销毁设备句柄
		/// </summary>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000064 RID: 100 RVA: 0x00002114 File Offset: 0x00000314
		public int IMV_DestroyHandle()
		{
			int num = IMVApi.IMV_DestroyHandle(this.m_DevHandle);
			this.m_DevHandle = IntPtr.Zero;
			return num;
		}

		/// <summary>
		/// 获取设备信息
		/// </summary>
		/// <param name="pDevInfo">[OUT] 设备信息</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000065 RID: 101 RVA: 0x00002139 File Offset: 0x00000339
		public int IMV_GetDeviceInfo(ref IMVDefine.IMV_DeviceInfo pDevInfo)
		{
			return IMVApi.IMV_GetDeviceInfo(this.m_DevHandle, ref pDevInfo);
		}

		/// <summary>
		/// 打开设备
		/// </summary>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000066 RID: 102 RVA: 0x00002147 File Offset: 0x00000347
		public int IMV_Open()
		{
			return IMVApi.IMV_Open(this.m_DevHandle);
		}

		/// <summary>
		/// 打开设备
		/// </summary>
		/// <param name="accessPermission">[IN] 控制通道权限(IMV_Open默认使用accessPermissionControl权限)</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000067 RID: 103 RVA: 0x00002154 File Offset: 0x00000354
		public int IMV_OpenEx(IMVDefine.IMV_ECameraAccessPermission accessPermission)
		{
			return IMVApi.IMV_OpenEx(this.m_DevHandle, accessPermission);
		}

		/// <summary>
		/// 判断设备是否已打开
		/// </summary>
		/// <returns>打开状态，返回true；关闭状态或者掉线状态，返回false</returns>
		// Token: 0x06000068 RID: 104 RVA: 0x00002162 File Offset: 0x00000362
		public bool IMV_IsOpen()
		{
			return IMVApi.IMV_IsOpen(this.m_DevHandle);
		}

		/// <summary>
		/// 关闭设备
		/// </summary>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000069 RID: 105 RVA: 0x0000216F File Offset: 0x0000036F
		public int IMV_Close()
		{
			return IMVApi.IMV_Close(this.m_DevHandle);
		}

		/// <summary>
		/// 设置传输类型
		/// </summary>
		/// <param name="transmissionType">传输类型结构体</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600006A RID: 106 RVA: 0x0000217C File Offset: 0x0000037C
		public int IMV_GIGE_SetTransmissionType(IMVDefine.IMV_TransMission_Type transmissionType)
		{
			return IMVApi.IMV_GIGE_SetTransmissionType(this.m_DevHandle, transmissionType);
		}

		/// <summary>
		/// 修改设备IP, 仅限Gige设备使用
		/// </summary>
		/// <param name="pIpAddress">[IN] IP地址</param>
		/// <param name="pSubnetMask">[IN] 子网掩码</param>
		/// <param name="pGateway">[IN] 默认网关</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// <para>1、调用该函数时如果pSubnetMask和pGateway都设置了有效值，则以此有效值为准;</para>
		/// <para>2、调用该函数时如果pSubnetMask和pGateway都设置了NULL，则内部实现时用它所连接网卡的子网掩码和网关代替</para>
		/// <para>3、调用该函数时如果pSubnetMask和pGateway两者中其中一个为NULL，另一个非NULL，则返回错误</para>
		/// </remarks>
		// Token: 0x0600006B RID: 107 RVA: 0x0000218A File Offset: 0x0000038A
		public int IMV_GIGE_ForceIpAddress(string pIpAddress, string pSubnetMask, string pGateway)
		{
			return IMVApi.IMV_GIGE_ForceIpAddress(this.m_DevHandle, pIpAddress, pSubnetMask, pGateway);
		}

		/// <summary>
		/// 获取设备的当前访问权限, 仅限Gige设备使用
		/// </summary>
		/// <param name="pAccessPermission">[OUT] 设备的当前访问权限</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600006C RID: 108 RVA: 0x0000219A File Offset: 0x0000039A
		public int IMV_GIGE_GetAccessPermission(ref IMVDefine.IMV_ECameraAccessPermission pAccessPermission)
		{
			return IMVApi.IMV_GIGE_GetAccessPermission(this.m_DevHandle, ref pAccessPermission);
		}

		/// <summary>
		/// 设置设备对sdk命令的响应超时时间,仅限Gige设备使用
		/// </summary>
		/// <param name="timeout">[IN] 超时时间，单位ms</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600006D RID: 109 RVA: 0x000021A8 File Offset: 0x000003A8
		public int IMV_GIGE_SetAnswerTimeout(uint timeout)
		{
			return IMVApi.IMV_GIGE_SetAnswerTimeout(this.m_DevHandle, timeout);
		}

		/// <summary>
		/// 下载设备描述XML文件，并保存到指定路径，如：D:\\xml.zip
		/// </summary>
		/// <param name="pFullFileName">[IN] 文件要保存的路径</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600006E RID: 110 RVA: 0x000021B6 File Offset: 0x000003B6
		public int IMV_DownLoadGenICamXML(string pFullFileName)
		{
			return IMVApi.IMV_DownLoadGenICamXML(this.m_DevHandle, pFullFileName);
		}

		/// <summary>
		/// 保存设备配置到指定的位置。同名文件已存在时，覆盖。
		/// </summary>
		/// <param name="pFullFileName">[IN] 导出的设备配置文件全名(含路径)，如：D:\\config.xml 或 D:\\config.mvcfg</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600006F RID: 111 RVA: 0x000021C4 File Offset: 0x000003C4
		public int IMV_SaveDeviceCfg(string pFullFileName)
		{
			return IMVApi.IMV_SaveDeviceCfg(this.m_DevHandle, pFullFileName);
		}

		/// <summary>
		/// 从文件加载设备xml配置
		/// </summary>
		/// <param name="pFullFileName">[IN] 设备配置(xml)文件全名(含路径)，如：D:\\config.xml 或 D:\\config.mvcfg</param>
		/// <param name="pErrorList">[OUT] 加载失败的属性名列表。存放加载失败的属性上限为IMV_MAX_ERROR_LIST_NUM。</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000070 RID: 112 RVA: 0x000021D2 File Offset: 0x000003D2
		public int IMV_LoadDeviceCfg(string pFullFileName, ref IMVDefine.IMV_ErrorList pErrorList)
		{
			return IMVApi.IMV_LoadDeviceCfg(this.m_DevHandle, pFullFileName, ref pErrorList);
		}

		/// <summary>
		/// 写用户自定义数据。相机内部保留32768字节用于用户存储自定义数据(此功能针对本品牌相机，其它品牌相机无此功能)
		/// </summary>
		/// <param name="pBuffer">[IN] 数据缓冲的指针</param>
		/// <param name="pLength">[IN] 期望写入的字节数 [OUT] 实际写入的字节数</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000071 RID: 113 RVA: 0x000021E1 File Offset: 0x000003E1
		public int IMV_WriteUserPrivateData(IntPtr pBuffer, ref uint pLength)
		{
			return IMVApi.IMV_WriteUserPrivateData(this.m_DevHandle, pBuffer, ref pLength);
		}

		/// <summary>
		/// 读用户自定义数据。相机内部保留32768字节用于用户存储自定义数据(此功能针对本品牌相机，其它品牌相机无此功能)
		/// </summary>
		/// <param name="pBuffer">[OUT] 数据缓冲的指针</param>
		/// <param name="pLength">[IN] 期望读出的字节数 [OUT] 实际读出的字节数</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000072 RID: 114 RVA: 0x000021F0 File Offset: 0x000003F0
		public int IMV_ReadUserPrivateData(IntPtr pBuffer, ref uint pLength)
		{
			return IMVApi.IMV_ReadUserPrivateData(this.m_DevHandle, pBuffer, ref pLength);
		}

		/// <summary>
		/// 往相机串口寄存器写数据，每次写会清除掉上次的数据(此功能只支持包含串口功能的本品牌相机)
		/// </summary>
		/// <param name="pBuffer">[IN] 数据缓冲的指针</param>
		/// <param name="pLength">[IN] 期望写入的字节数 [OUT] 实际写入的字节数</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000073 RID: 115 RVA: 0x000021FF File Offset: 0x000003FF
		public int IMV_WriteUARTData(IntPtr pBuffer, ref uint pLength)
		{
			return IMVApi.IMV_WriteUARTData(this.m_DevHandle, pBuffer, ref pLength);
		}

		/// <summary>
		/// 从相机串口寄存器读取串口数据(此功能只支持包含串口功能的本品牌相机 )
		/// </summary>
		/// <param name="pBuffer">[OUT] 数据缓冲的指针</param>
		/// <param name="pLength">[IN] 期望读出的字节数 [OUT] 实际读出的字节数</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000074 RID: 116 RVA: 0x0000220E File Offset: 0x0000040E
		public int IMV_ReadUARTData(IntPtr pBuffer, ref uint pLength)
		{
			return IMVApi.IMV_ReadUARTData(this.m_DevHandle, pBuffer, ref pLength);
		}

		/// <summary>
		/// 设备连接状态事件回调注册
		/// </summary>
		/// <param name="proc">[IN] 设备连接状态事件回调函数</param>
		/// <param name="pUser">[IN] 用户自定义数据, 可设为NULL</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// 只支持一个回调函数,且设备关闭后，注册会失效，打开设备后需重新注册
		/// </remarks>
		// Token: 0x06000075 RID: 117 RVA: 0x0000221D File Offset: 0x0000041D
		public int IMV_SubscribeConnectArg(IMVDefine.IMV_ConnectCallBack proc, IntPtr pUser)
		{
			return IMVApi.IMV_SubscribeConnectArg(this.m_DevHandle, proc, pUser);
		}

		/// <summary>
		/// 参数更新事件回调注册
		/// </summary>
		/// <param name="proc">[IN] 参数更新注册的事件回调函数</param>
		/// <param name="pUser">[IN] 用户自定义数据, 可设为NULL</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// 只支持一个回调函数,且设备关闭后，注册会失效，打开设备后需重新注册
		/// </remarks>
		// Token: 0x06000076 RID: 118 RVA: 0x0000222C File Offset: 0x0000042C
		public int IMV_SubscribeParamUpdateArg(IMVDefine.IMV_ParamUpdateCallBack proc, IntPtr pUser)
		{
			return IMVApi.IMV_SubscribeParamUpdateArg(this.m_DevHandle, proc, pUser);
		}

		/// <summary>
		/// 流通道事件回调注册
		/// </summary>
		/// <param name="proc">[IN] 流通道事件回调注册函数</param>
		/// <param name="pUser">[IN] 用户自定义数据, 可设为NULL</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// 只支持一个回调函数,且设备关闭后，注册会失效，打开设备后需重新注册
		/// </remarks>
		// Token: 0x06000077 RID: 119 RVA: 0x0000223B File Offset: 0x0000043B
		public int IMV_SubscribeStreamArg(IMVDefine.IMV_StreamCallBack proc, IntPtr pUser)
		{
			return IMVApi.IMV_SubscribeStreamArg(this.m_DevHandle, proc, pUser);
		}

		/// <summary>
		/// 消息通道事件回调注册
		/// </summary>
		/// <param name="proc">[IN] 消息通道事件回调注册函数</param>
		/// <param name="pUser">[IN] 用户自定义数据, 可设为NULL</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// 只支持一个回调函数,且设备关闭后，注册会失效，打开设备后需重新注册
		/// </remarks>
		// Token: 0x06000078 RID: 120 RVA: 0x0000224A File Offset: 0x0000044A
		public int IMV_SubscribeMsgChannelArg(IMVDefine.IMV_MsgChannelCallBack proc, IntPtr pUser)
		{
			return IMVApi.IMV_SubscribeMsgChannelArg(this.m_DevHandle, proc, pUser);
		}

		/// <summary>
		/// 设置帧数据缓存个数
		/// </summary>
		/// <param name="nSize">[IN] 缓存数量</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// 不能在拉流过程中设置
		/// </remarks>
		// Token: 0x06000079 RID: 121 RVA: 0x00002259 File Offset: 0x00000459
		public int IMV_SetBufferCount(uint nSize)
		{
			return IMVApi.IMV_SetBufferCount(this.m_DevHandle, nSize);
		}

		/// <summary>
		/// 清除帧数据缓存
		/// </summary>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600007A RID: 122 RVA: 0x00002267 File Offset: 0x00000467
		public int IMV_ClearFrameBuffer()
		{
			return IMVApi.IMV_ClearFrameBuffer(this.m_DevHandle);
		}

		/// <summary>
		/// 设置驱动包间隔时间(MS),仅对Gige设备有效
		/// </summary>
		/// <param name="nTimeout">[IN] 包间隔时间，单位是毫秒</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// 触发模式尾包丢失重传机制
		/// </remarks>
		// Token: 0x0600007B RID: 123 RVA: 0x00002274 File Offset: 0x00000474
		public int IMV_GIGE_SetInterPacketTimeout(uint nTimeout)
		{
			return IMVApi.IMV_GIGE_SetInterPacketTimeout(this.m_DevHandle, nTimeout);
		}

		/// <summary>
		/// 设置单次重传最大包个数, 仅对GigE设备有效
		/// </summary>
		/// <param name="maxPacketNum">[IN] 单次重传最大包个数</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// maxPacketNum为0时，该功能无效
		/// </remarks>
		// Token: 0x0600007C RID: 124 RVA: 0x00002282 File Offset: 0x00000482
		public int IMV_GIGE_SetSingleResendMaxPacketNum(uint maxPacketNum)
		{
			return IMVApi.IMV_GIGE_SetSingleResendMaxPacketNum(this.m_DevHandle, maxPacketNum);
		}

		/// <summary>
		/// 设置同一帧最大丢包的数量,仅对GigE设备有效
		/// </summary>
		/// <param name="maxLostPacketNum">[IN] 最大丢包的数量</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// maxLostPacketNum为0时，该功能无效
		/// </remarks>
		// Token: 0x0600007D RID: 125 RVA: 0x00002290 File Offset: 0x00000490
		public int IMV_GIGE_SetMaxLostPacketNum(uint maxLostPacketNum)
		{
			return IMVApi.IMV_GIGE_SetMaxLostPacketNum(this.m_DevHandle, maxLostPacketNum);
		}

		/// <summary>
		/// 设置U3V设备的传输数据块的数量和大小,仅对USB设备有效
		/// </summary>
		/// <param name="nNum">[IN] 传输数据块的数量(范围:5-256)</param>
		/// <param name="nSize">[IN] 传输数据块的大小(范围:8-512, 单位:KByte)</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// <para>1、传输数据块数量，范围5 - 256, 默认为64，高分辨率高帧率时可以适当增加该值；多台相机共同使用时，可以适当减小该值</para>
		/// <para>2、传输每个数据块大小，范围8 - 512, 默认为64，单位是KByte</para>
		/// </remarks>
		// Token: 0x0600007E RID: 126 RVA: 0x0000229E File Offset: 0x0000049E
		public int IMV_USB_SetUrbTransfer(uint nNum, uint nSize)
		{
			return IMVApi.IMV_USB_SetUrbTransfer(this.m_DevHandle, nNum, nSize);
		}

		/// <summary>
		/// 开始取流
		/// </summary>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600007F RID: 127 RVA: 0x000022AD File Offset: 0x000004AD
		public int IMV_StartGrabbing()
		{
			return IMVApi.IMV_StartGrabbing(this.m_DevHandle);
		}

		/// <summary>
		/// 开始取流
		/// </summary>
		/// <param name="maxImagesGrabbed">[IN] 允许最多的取帧数，达到指定取帧数后停止取流，如果为0，表示忽略此参数连续取流(IMV_StartGrabbing默认0)</param>
		/// <param name="strategy">[IN] 取流策略,(IMV_StartGrabbing默认使用grabStrartegySequential策略取流)</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000080 RID: 128 RVA: 0x000022BA File Offset: 0x000004BA
		public int IMV_StartGrabbingEx(ulong maxImagesGrabbed, IMVDefine.IMV_EGrabStrategy strategy)
		{
			return IMVApi.IMV_StartGrabbingEx(this.m_DevHandle, maxImagesGrabbed, strategy);
		}

		/// <summary>
		/// 判断设备是否正在取流
		/// </summary>
		/// <returns>正在取流，返回true；不在取流，返回false</returns>
		// Token: 0x06000081 RID: 129 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool IMV_IsGrabbing()
		{
			return IMVApi.IMV_IsGrabbing(this.m_DevHandle);
		}

		/// <summary>
		/// 停止取流
		/// </summary>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000082 RID: 130 RVA: 0x000022D6 File Offset: 0x000004D6
		public int IMV_StopGrabbing()
		{
			return IMVApi.IMV_StopGrabbing(this.m_DevHandle);
		}

		/// <summary>
		/// 注册帧数据回调函数(异步获取帧数据机制)
		/// </summary>
		/// <param name="proc">[IN] 帧数据信息回调函数，建议不要在该函数中处理耗时的操作，否则会阻塞后续帧数据的实时性</param>
		/// <param name="pUser">[IN] 用户自定义数据, 可设为NULL</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// <para>该异步获取帧数据机制和同步获取帧数据机制(IMV_GetFrame)互斥，对于同一设备，系统中两者只能选其一</para>
		/// <para>只支持一个回调函数, 且设备关闭后，注册会失效，打开设备后需重新注册</para>
		/// </remarks>
		// Token: 0x06000083 RID: 131 RVA: 0x000022E3 File Offset: 0x000004E3
		public int IMV_AttachGrabbing(IMVDefine.IMV_FrameCallBack proc, IntPtr pUser)
		{
			return IMVApi.IMV_AttachGrabbing(this.m_DevHandle, proc, pUser);
		}

		/// <summary>
		/// 获取一帧图像(同步获取帧数据机制)
		/// </summary>
		/// <param name="frame">[OUT] 帧数据信息</param>
		/// <param name="timeout">[IN] 获取一帧图像的超时时间,INFINITE时表示无限等待,直到收到一帧数据或者停止取流。单位是毫秒</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// <para>该接口不支持多线程调用。</para>
		/// <para>该同步获取帧机制和异步获取帧机制(IMV_AttachGrabbing)互斥,对于同一设备，系统中两者只能选其一。</para>
		/// <para>使用内部缓存获取图像，需要IMV_ReleaseFrame进行释放图像缓存。</para>
		/// </remarks>
		// Token: 0x06000084 RID: 132 RVA: 0x000022F2 File Offset: 0x000004F2
		public int IMV_GetFrame(ref IMVDefine.IMV_Frame frame, uint timeout)
		{
			return IMVApi.IMV_GetFrame(this.m_DevHandle, ref frame, timeout);
		}

		/// <summary>
		/// 释放图像缓存
		/// </summary>
		/// <param name="frame">[IN] 帧数据信息</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000085 RID: 133 RVA: 0x00002301 File Offset: 0x00000501
		public int IMV_ReleaseFrame(ref IMVDefine.IMV_Frame frame)
		{
			return IMVApi.IMV_ReleaseFrame(this.m_DevHandle, ref frame);
		}

		/// <summary>
		/// 帧数据深拷贝克隆
		/// </summary>
		/// <param name="frame">[IN] 克隆源帧数据信息</param>
		/// <param name="pCloneFrame">[OUT] 新的帧数据信息</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// 使用IMV_ReleaseFrame进行释放图像缓存。
		/// </remarks>
		// Token: 0x06000086 RID: 134 RVA: 0x0000230F File Offset: 0x0000050F
		public int IMV_CloneFrame(ref IMVDefine.IMV_Frame frame, ref IMVDefine.IMV_Frame pCloneFrame)
		{
			return IMVApi.IMV_CloneFrame(this.m_DevHandle, ref frame, ref pCloneFrame);
		}

		/// <summary>
		/// 获取Chunk数据(仅对GigE/Usb相机有效)
		/// </summary>
		/// <param name="frame">[IN] 帧数据信息</param>
		/// <param name="index">[IN] 索引ID</param>
		/// <param name="pChunkDataInfo">[OUT] Chunk数据信息</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000087 RID: 135 RVA: 0x0000231E File Offset: 0x0000051E
		public int IMV_GetChunkDataByIndex(ref IMVDefine.IMV_Frame frame, uint index, ref IMVDefine.IMV_ChunkDataInfo pChunkDataInfo)
		{
			return IMVApi.IMV_GetChunkDataByIndex(this.m_DevHandle, ref frame, index, ref pChunkDataInfo);
		}

		/// <summary>
		/// 获取流统计信息(IMV_StartGrabbing / IMV_StartGrabbingEx执行后调用)
		/// </summary>
		/// <param name="param">[OUT] 流统计信息数据</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000088 RID: 136 RVA: 0x0000232E File Offset: 0x0000052E
		public int IMV_GetStatisticsInfo(ref IMVDefine.IMV_StreamStatisticsInfo param)
		{
			return IMVApi.IMV_GetStatisticsInfo(this.m_DevHandle, ref param);
		}

		/// <summary>
		/// 重置流统计信息(IMV_StartGrabbing / IMV_StartGrabbingEx执行后调用)
		/// </summary>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000089 RID: 137 RVA: 0x0000233C File Offset: 0x0000053C
		public int IMV_ResetStatisticsInfo()
		{
			return IMVApi.IMV_ResetStatisticsInfo(this.m_DevHandle);
		}

		/// <summary>
		/// 判断属性是否可用
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <returns>可用，返回true；不可用，返回false</returns>
		// Token: 0x0600008A RID: 138 RVA: 0x00002349 File Offset: 0x00000549
		public bool IMV_FeatureIsAvailable(string pFeatureName)
		{
			return IMVApi.IMV_FeatureIsAvailable(this.m_DevHandle, pFeatureName);
		}

		/// <summary>
		/// 判断属性是否可读
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <returns>可读，返回true；不可读，返回false</returns>
		// Token: 0x0600008B RID: 139 RVA: 0x00002357 File Offset: 0x00000557
		public bool IMV_FeatureIsReadable(string pFeatureName)
		{
			return IMVApi.IMV_FeatureIsReadable(this.m_DevHandle, pFeatureName);
		}

		/// <summary>
		/// 判断属性是否可写
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <returns>可写，返回true；不可写，返回false</returns>
		// Token: 0x0600008C RID: 140 RVA: 0x00002365 File Offset: 0x00000565
		public bool IMV_FeatureIsWriteable(string pFeatureName)
		{
			return IMVApi.IMV_FeatureIsWriteable(this.m_DevHandle, pFeatureName);
		}

		/// <summary>
		/// 判断属性是否可流
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <returns>可流，返回true；不可流，返回false</returns>
		// Token: 0x0600008D RID: 141 RVA: 0x00002373 File Offset: 0x00000573
		public bool IMV_FeatureIsStreamable(string pFeatureName)
		{
			return IMVApi.IMV_FeatureIsStreamable(this.m_DevHandle, pFeatureName);
		}

		/// <summary>
		/// 判断属性是否有效
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <returns>有效，返回true；无效，返回false</returns>
		// Token: 0x0600008E RID: 142 RVA: 0x00002381 File Offset: 0x00000581
		public bool IMV_FeatureIsValid(string pFeatureName)
		{
			return IMVApi.IMV_FeatureIsValid(this.m_DevHandle, pFeatureName);
		}

		/// <summary>
		/// 获取属性类型
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pPropertyType">[OUT] 属性类型</param>
		/// <returns>获取成功，返回true；获取失败，返回false</returns>
		// Token: 0x0600008F RID: 143 RVA: 0x0000238F File Offset: 0x0000058F
		public bool IMV_GetFeatureType(string pFeatureName, ref IMVDefine.IMV_EFeatureType pPropertyType)
		{
			return IMVApi.IMV_GetFeatureType(this.m_DevHandle, pFeatureName, ref pPropertyType);
		}

		/// <summary>
		/// 获取整型属性值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pIntValue">[OUT] 整型属性值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000090 RID: 144 RVA: 0x0000239E File Offset: 0x0000059E
		public int IMV_GetIntFeatureValue(string pFeatureName, ref long pIntValue)
		{
			return IMVApi.IMV_GetIntFeatureValue(this.m_DevHandle, pFeatureName, ref pIntValue);
		}

		/// <summary>
		/// 获取整型属性可设的最小值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pIntValue">[OUT] 整型属性可设的最小值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000091 RID: 145 RVA: 0x000023AD File Offset: 0x000005AD
		public int IMV_GetIntFeatureMin(string pFeatureName, ref long pIntValue)
		{
			return IMVApi.IMV_GetIntFeatureMin(this.m_DevHandle, pFeatureName, ref pIntValue);
		}

		/// <summary>
		/// 获取整型属性可设的最大值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pIntValue">[OUT] 整型属性可设的最大值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000092 RID: 146 RVA: 0x000023BC File Offset: 0x000005BC
		public int IMV_GetIntFeatureMax(string pFeatureName, ref long pIntValue)
		{
			return IMVApi.IMV_GetIntFeatureMax(this.m_DevHandle, pFeatureName, ref pIntValue);
		}

		/// <summary>
		/// 获取整型属性步长
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pIntValue">[OUT] 整型属性步长</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000093 RID: 147 RVA: 0x000023CB File Offset: 0x000005CB
		public int IMV_GetIntFeatureInc(string pFeatureName, ref long pIntValue)
		{
			return IMVApi.IMV_GetIntFeatureInc(this.m_DevHandle, pFeatureName, ref pIntValue);
		}

		/// <summary>
		/// 设置整型属性值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="intValue">[IN] 待设置的整型属性值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000094 RID: 148 RVA: 0x000023DA File Offset: 0x000005DA
		public int IMV_SetIntFeatureValue(string pFeatureName, long intValue)
		{
			return IMVApi.IMV_SetIntFeatureValue(this.m_DevHandle, pFeatureName, intValue);
		}

		/// <summary>
		/// 获取浮点属性值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pDoubleValue">[OUT] 浮点属性值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000095 RID: 149 RVA: 0x000023E9 File Offset: 0x000005E9
		public int IMV_GetDoubleFeatureValue(string pFeatureName, ref double pDoubleValue)
		{
			return IMVApi.IMV_GetDoubleFeatureValue(this.m_DevHandle, pFeatureName, ref pDoubleValue);
		}

		/// <summary>
		/// 获取浮点属性可设的最小值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pDoubleValue">[OUT] 浮点属性可设的最小值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000096 RID: 150 RVA: 0x000023F8 File Offset: 0x000005F8
		public int IMV_GetDoubleFeatureMin(string pFeatureName, ref double pDoubleValue)
		{
			return IMVApi.IMV_GetDoubleFeatureMin(this.m_DevHandle, pFeatureName, ref pDoubleValue);
		}

		/// <summary>
		/// 获取浮点属性可设的最大值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pDoubleValue">[OUT] 浮点属性可设的最大值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000097 RID: 151 RVA: 0x00002407 File Offset: 0x00000607
		public int IMV_GetDoubleFeatureMax(string pFeatureName, ref double pDoubleValue)
		{
			return IMVApi.IMV_GetDoubleFeatureMax(this.m_DevHandle, pFeatureName, ref pDoubleValue);
		}

		/// <summary>
		/// 设置浮点属性值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="doubleValue">[IN] 待设置的浮点属性值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000098 RID: 152 RVA: 0x00002416 File Offset: 0x00000616
		public int IMV_SetDoubleFeatureValue(string pFeatureName, double doubleValue)
		{
			return IMVApi.IMV_SetDoubleFeatureValue(this.m_DevHandle, pFeatureName, doubleValue);
		}

		/// <summary>
		/// 获取布尔属性值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pBoolValue">[OUT] 布尔属性值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x06000099 RID: 153 RVA: 0x00002425 File Offset: 0x00000625
		public int IMV_GetBoolFeatureValue(string pFeatureName, ref bool pBoolValue)
		{
			return IMVApi.IMV_GetBoolFeatureValue(this.m_DevHandle, pFeatureName, ref pBoolValue);
		}

		/// <summary>
		/// 设置布尔属性值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="boolValue">[IN] 待设置的布尔属性值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600009A RID: 154 RVA: 0x00002434 File Offset: 0x00000634
		public int IMV_SetBoolFeatureValue(string pFeatureName, bool boolValue)
		{
			return IMVApi.IMV_SetBoolFeatureValue(this.m_DevHandle, pFeatureName, boolValue);
		}

		/// <summary>
		/// 获取枚举属性值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pEnumValue">[OUT] 枚举属性值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600009B RID: 155 RVA: 0x00002443 File Offset: 0x00000643
		public int IMV_GetEnumFeatureValue(string pFeatureName, ref ulong pEnumValue)
		{
			return IMVApi.IMV_GetEnumFeatureValue(this.m_DevHandle, pFeatureName, ref pEnumValue);
		}

		/// <summary>
		/// 设置枚举属性值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="enumValue">[IN] 待设置的枚举属性值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600009C RID: 156 RVA: 0x00002452 File Offset: 0x00000652
		public int IMV_SetEnumFeatureValue(string pFeatureName, ulong enumValue)
		{
			return IMVApi.IMV_SetEnumFeatureValue(this.m_DevHandle, pFeatureName, enumValue);
		}

		/// <summary>
		/// 获取枚举属性symbol值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pEnumSymbol">[OUT] 枚举属性symbol值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600009D RID: 157 RVA: 0x00002461 File Offset: 0x00000661
		public int IMV_GetEnumFeatureSymbol(string pFeatureName, ref IMVDefine.IMV_String pEnumSymbol)
		{
			return IMVApi.IMV_GetEnumFeatureSymbol(this.m_DevHandle, pFeatureName, ref pEnumSymbol);
		}

		/// <summary>
		/// 设置枚举属性symbol值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pEnumSymbol">[IN] 待设置的枚举属性symbol值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600009E RID: 158 RVA: 0x00002470 File Offset: 0x00000670
		public int IMV_SetEnumFeatureSymbol(string pFeatureName, string pEnumSymbol)
		{
			return IMVApi.IMV_SetEnumFeatureSymbol(this.m_DevHandle, pFeatureName, pEnumSymbol);
		}

		/// <summary>
		/// 获取枚举属性的可设枚举值的个数
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pEntryNum">[OUT] 枚举属性的可设枚举值的个数</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x0600009F RID: 159 RVA: 0x0000247F File Offset: 0x0000067F
		public int IMV_GetEnumFeatureEntryNum(string pFeatureName, ref uint pEntryNum)
		{
			return IMVApi.IMV_GetEnumFeatureEntryNum(this.m_DevHandle, pFeatureName, ref pEntryNum);
		}

		/// <summary>
		/// 获取枚举属性的可设枚举值列表
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pEnumEntryList">[OUT] 枚举属性的可设枚举值列表</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x060000A0 RID: 160 RVA: 0x0000248E File Offset: 0x0000068E
		public int IMV_GetEnumFeatureEntrys(string pFeatureName, ref IMVDefine.IMV_EnumEntryList pEnumEntryList)
		{
			return IMVApi.IMV_GetEnumFeatureEntrys(this.m_DevHandle, pFeatureName, ref pEnumEntryList);
		}

		/// <summary>
		/// 获取字符串属性值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pStringValue">[OUT] 字符串属性值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x060000A1 RID: 161 RVA: 0x0000249D File Offset: 0x0000069D
		public int IMV_GetStringFeatureValue(string pFeatureName, ref IMVDefine.IMV_String pStringValue)
		{
			return IMVApi.IMV_GetStringFeatureValue(this.m_DevHandle, pFeatureName, ref pStringValue);
		}

		/// <summary>
		/// 设置字符串属性值
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <param name="pStringValue">[IN] 待设置的字符串属性值</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x060000A2 RID: 162 RVA: 0x000024AC File Offset: 0x000006AC
		public int IMV_SetStringFeatureValue(string pFeatureName, string pStringValue)
		{
			return IMVApi.IMV_SetStringFeatureValue(this.m_DevHandle, pFeatureName, pStringValue);
		}

		/// <summary>
		/// 执行命令属性
		/// </summary>
		/// <param name="pFeatureName">[IN] 属性名</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		// Token: 0x060000A3 RID: 163 RVA: 0x000024BB File Offset: 0x000006BB
		public int IMV_ExecuteCommandFeature(string pFeatureName)
		{
			return IMVApi.IMV_ExecuteCommandFeature(this.m_DevHandle, pFeatureName);
		}

		/// <summary>
		/// 像素格式转换
		/// </summary>
		/// <param name="pstPixelConvertParam">[IN][OUT] 像素格式转换参数结构体</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// <para>只支持转化成目标像素格式gvspPixelRGB8 / gvspPixelBGR8 / gvspPixelMono8 / gvspPixelBGRA8</para>
		/// <para>通过该接口将原始图像数据转换成用户所需的像素格式并存放在调用者指定内存中。</para>
		/// <para>像素格式为YUV411Packed的时，图像宽须能被4整除</para>
		/// <para>像素格式为YUV422Packed的时，图像宽须能被2整除</para>
		/// <para>像素格式为YUYVPacked的时，图像宽须能被2整除</para>
		/// <para>转换后的图像:数据存储是从最上面第一行开始的，这个是相机数据的默认存储方向</para>
		/// </remarks>
		// Token: 0x060000A4 RID: 164 RVA: 0x000024C9 File Offset: 0x000006C9
		public int IMV_PixelConvert(ref IMVDefine.IMV_PixelConvertParam pstPixelConvertParam)
		{
			return IMVApi.IMV_PixelConvert(this.m_DevHandle, ref pstPixelConvertParam);
		}

		/// <summary>
		/// 图像翻转
		/// </summary>
		/// <param name="pstFlipImageParam">[IN][OUT] 图像翻转参数结构体</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// <para>只支持像素格式gvspPixelRGB8 / gvspPixelBGR8 / gvspPixelMono8的图像的垂直和水平翻转。</para>
		/// <para>通过该接口将原始图像数据翻转后并存放在调用者指定内存中。</para>
		/// </remarks>
		// Token: 0x060000A5 RID: 165 RVA: 0x000024D7 File Offset: 0x000006D7
		public int IMV_FlipImage(ref IMVDefine.IMV_FlipImageParam pstFlipImageParam)
		{
			return IMVApi.IMV_FlipImage(this.m_DevHandle, ref pstFlipImageParam);
		}

		/// <summary>
		/// 图像顺时针旋转
		/// </summary>
		/// <param name="pstRotateImageParam">[IN][OUT] 图像旋转参数结构体</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// <para>只支持gvspPixelRGB8 / gvspPixelBGR8 / gvspPixelMono8格式数据的90/180/270度顺时针旋转。</para>
		/// <para>通过该接口将原始图像数据旋转后并存放在调用者指定内存中。</para>
		/// </remarks>
		// Token: 0x060000A6 RID: 166 RVA: 0x000024E5 File Offset: 0x000006E5
		public int IMV_RotateImage(ref IMVDefine.IMV_RotateImageParam pstRotateImageParam)
		{
			return IMVApi.IMV_RotateImage(this.m_DevHandle, ref pstRotateImageParam);
		}

		/// <summary>
		/// 保存图像到文件
		/// </summary>
		/// <param name="pstSaveImageToFileParam">[IN] 保存图片文件参数结构体</param>
		/// <returns>成功，返回IMV_OK；错误，返回错误码</returns>
		/// <remarks>
		/// 该接口支持保存BMP/JPEG/PNG/TIFF,JPEG格式最大支持宽高为65500
		/// </remarks>
		// Token: 0x060000A7 RID: 167 RVA: 0x000024F3 File Offset: 0x000006F3
		public int IMV_SaveImageToFile(ref IMVDefine.IMV_SaveImageToFileParam pstSaveImageToFileParam)
		{
			return IMVApi.IMV_SaveImageToFile(this.m_DevHandle, ref pstSaveImageToFileParam);
		}

		// Token: 0x04000179 RID: 377
		private IntPtr m_DevHandle;
	}
}
