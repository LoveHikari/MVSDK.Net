using System;
using System.Runtime.InteropServices;

namespace MVSDK_Net
{
	// Token: 0x02000002 RID: 2
	internal class IMVApi
	{
		// Token: 0x06000001 RID: 1
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern IntPtr IMV_GetVersion();

		// Token: 0x06000002 RID: 2
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_EnumDevices(ref IMVDefine.IMV_DeviceList pDeviceList, uint interfaceType);

		// Token: 0x06000003 RID: 3
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_EnumDevicesByUnicast(ref IMVDefine.IMV_DeviceList pDeviceList, string pIpAddress);

		// Token: 0x06000004 RID: 4
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_CreateHandle(ref IntPtr handle, IMVDefine.IMV_ECreateHandleMode mode, IntPtr pIdentifier);

		// Token: 0x06000005 RID: 5
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_DestroyHandle(IntPtr handle);

		// Token: 0x06000006 RID: 6
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_GetDeviceInfo(IntPtr handle, ref IMVDefine.IMV_DeviceInfo pDevInfo);

		// Token: 0x06000007 RID: 7
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_Open(IntPtr handle);

		// Token: 0x06000008 RID: 8
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_OpenEx(IntPtr handle, IMVDefine.IMV_ECameraAccessPermission accessPermission);

		// Token: 0x06000009 RID: 9
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern bool IMV_IsOpen(IntPtr handle);

		// Token: 0x0600000A RID: 10
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_Close(IntPtr handle);

		// Token: 0x0600000B RID: 11
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_GIGE_SetTransmissionType(IntPtr handle, IMVDefine.IMV_TransMission_Type transmissionType);

		// Token: 0x0600000C RID: 12
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_GIGE_ForceIpAddress(IntPtr handle, string pIpAddress, string pSubnetMask, string pGateway);

		// Token: 0x0600000D RID: 13
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_GIGE_GetAccessPermission(IntPtr handle, ref IMVDefine.IMV_ECameraAccessPermission pAccessPermission);

		// Token: 0x0600000E RID: 14
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_GIGE_SetAnswerTimeout(IntPtr handle, uint timeout);

		// Token: 0x0600000F RID: 15
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_DownLoadGenICamXML(IntPtr handle, string pFullFileName);

		// Token: 0x06000010 RID: 16
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_SaveDeviceCfg(IntPtr handle, string pFullFileName);

		// Token: 0x06000011 RID: 17
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_LoadDeviceCfg(IntPtr handle, string pFullFileName, ref IMVDefine.IMV_ErrorList pErrorList);

		// Token: 0x06000012 RID: 18
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_WriteUserPrivateData(IntPtr handle, IntPtr pBuffer, ref uint pLength);

		// Token: 0x06000013 RID: 19
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_ReadUserPrivateData(IntPtr handle, IntPtr pBuffer, ref uint pLength);

		// Token: 0x06000014 RID: 20
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_WriteUARTData(IntPtr handle, IntPtr pBuffer, ref uint pLength);

		// Token: 0x06000015 RID: 21
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_ReadUARTData(IntPtr handle, IntPtr pBuffer, ref uint pLength);

		// Token: 0x06000016 RID: 22
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_SubscribeConnectArg(IntPtr handle, IMVDefine.IMV_ConnectCallBack proc, IntPtr pUser);

		// Token: 0x06000017 RID: 23
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_SubscribeParamUpdateArg(IntPtr handle, IMVDefine.IMV_ParamUpdateCallBack proc, IntPtr pUser);

		// Token: 0x06000018 RID: 24
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_SubscribeStreamArg(IntPtr handle, IMVDefine.IMV_StreamCallBack proc, IntPtr pUser);

		// Token: 0x06000019 RID: 25
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_SubscribeMsgChannelArg(IntPtr handle, IMVDefine.IMV_MsgChannelCallBack proc, IntPtr pUser);

		// Token: 0x0600001A RID: 26
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_SetBufferCount(IntPtr handle, uint nSize);

		// Token: 0x0600001B RID: 27
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_ClearFrameBuffer(IntPtr handle);

		// Token: 0x0600001C RID: 28
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_GIGE_SetInterPacketTimeout(IntPtr handle, uint nTimeout);

		// Token: 0x0600001D RID: 29
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_GIGE_SetSingleResendMaxPacketNum(IntPtr handle, uint maxPacketNum);

		// Token: 0x0600001E RID: 30
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_GIGE_SetMaxLostPacketNum(IntPtr handle, uint maxLostPacketNum);

		// Token: 0x0600001F RID: 31
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_USB_SetUrbTransfer(IntPtr handle, uint nNum, uint nSize);

		// Token: 0x06000020 RID: 32
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_StartGrabbing(IntPtr handle);

		// Token: 0x06000021 RID: 33
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_StartGrabbingEx(IntPtr handle, ulong maxImagesGrabbed, IMVDefine.IMV_EGrabStrategy strategy);

		// Token: 0x06000022 RID: 34
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern bool IMV_IsGrabbing(IntPtr handle);

		// Token: 0x06000023 RID: 35
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_StopGrabbing(IntPtr handle);

		// Token: 0x06000024 RID: 36
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_AttachGrabbing(IntPtr handle, IMVDefine.IMV_FrameCallBack proc, IntPtr pUser);

		// Token: 0x06000025 RID: 37
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_GetFrame(IntPtr handle, ref IMVDefine.IMV_Frame frame, uint time);

		// Token: 0x06000026 RID: 38
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_ReleaseFrame(IntPtr handle, ref IMVDefine.IMV_Frame frame);

		// Token: 0x06000027 RID: 39
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_CloneFrame(IntPtr handle, ref IMVDefine.IMV_Frame frame, ref IMVDefine.IMV_Frame pCloneFrame);

		// Token: 0x06000028 RID: 40
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_GetChunkDataByIndex(IntPtr handle, ref IMVDefine.IMV_Frame frame, uint index, ref IMVDefine.IMV_ChunkDataInfo pChunkDataInfo);

		// Token: 0x06000029 RID: 41
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_GetStatisticsInfo(IntPtr handle, ref IMVDefine.IMV_StreamStatisticsInfo param);

		// Token: 0x0600002A RID: 42
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_ResetStatisticsInfo(IntPtr handle);

		// Token: 0x0600002B RID: 43
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern bool IMV_FeatureIsAvailable(IntPtr handle, string pFeatureName);

		// Token: 0x0600002C RID: 44
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern bool IMV_FeatureIsReadable(IntPtr handle, string pFeatureName);

		// Token: 0x0600002D RID: 45
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern bool IMV_FeatureIsWriteable(IntPtr handle, string pFeatureName);

		// Token: 0x0600002E RID: 46
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern bool IMV_FeatureIsStreamable(IntPtr handle, string pFeatureName);

		// Token: 0x0600002F RID: 47
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern bool IMV_FeatureIsValid(IntPtr handle, string pFeatureName);

		// Token: 0x06000030 RID: 48
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern bool IMV_GetFeatureType(IntPtr handle, string pFeatureName, ref IMVDefine.IMV_EFeatureType pPropertyType);

		// Token: 0x06000031 RID: 49
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetIntFeatureValue(IntPtr handle, string pFeatureName, ref long pIntValue);

		// Token: 0x06000032 RID: 50
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetIntFeatureMin(IntPtr handle, string pFeatureName, ref long pIntValue);

		// Token: 0x06000033 RID: 51
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetIntFeatureMax(IntPtr handle, string pFeatureName, ref long pIntValue);

		// Token: 0x06000034 RID: 52
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetIntFeatureInc(IntPtr handle, string pFeatureName, ref long pIntValue);

		// Token: 0x06000035 RID: 53
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_SetIntFeatureValue(IntPtr handle, string pFeatureName, long intValue);

		// Token: 0x06000036 RID: 54
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetDoubleFeatureValue(IntPtr handle, string pFeatureName, ref double pDoubleValue);

		// Token: 0x06000037 RID: 55
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetDoubleFeatureMin(IntPtr handle, string pFeatureName, ref double pDoubleValue);

		// Token: 0x06000038 RID: 56
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetDoubleFeatureMax(IntPtr handle, string pFeatureName, ref double pDoubleValue);

		// Token: 0x06000039 RID: 57
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_SetDoubleFeatureValue(IntPtr handle, string pFeatureName, double doubleValue);

		// Token: 0x0600003A RID: 58
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetBoolFeatureValue(IntPtr handle, string pFeatureName, ref bool pBoolValue);

		// Token: 0x0600003B RID: 59
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_SetBoolFeatureValue(IntPtr handle, string pFeatureName, bool boolValue);

		// Token: 0x0600003C RID: 60
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetEnumFeatureValue(IntPtr handle, string pFeatureName, ref ulong pEnumValue);

		// Token: 0x0600003D RID: 61
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_SetEnumFeatureValue(IntPtr handle, string pFeatureName, ulong enumValue);

		// Token: 0x0600003E RID: 62
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetEnumFeatureSymbol(IntPtr handle, string pFeatureName, ref IMVDefine.IMV_String pEnumSymbol);

		// Token: 0x0600003F RID: 63
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_SetEnumFeatureSymbol(IntPtr handle, string pFeatureName, string pEnumSymbol);

		// Token: 0x06000040 RID: 64
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetEnumFeatureEntryNum(IntPtr handle, string pFeatureName, ref uint pEntryNum);

		// Token: 0x06000041 RID: 65
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetEnumFeatureEntrys(IntPtr handle, string pFeatureName, ref IMVDefine.IMV_EnumEntryList pEnumEntryList);

		// Token: 0x06000042 RID: 66
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_GetStringFeatureValue(IntPtr handle, string pFeatureName, ref IMVDefine.IMV_String pStringValue);

		// Token: 0x06000043 RID: 67
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_SetStringFeatureValue(IntPtr handle, string pFeatureName, string pStringValue);

		// Token: 0x06000044 RID: 68
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_ExecuteCommandFeature(IntPtr handle, string pFullFileName);

		// Token: 0x06000045 RID: 69
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int IMV_PixelConvert(IntPtr handle, ref IMVDefine.IMV_PixelConvertParam pstPixelConvertParam);

		// Token: 0x06000046 RID: 70
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_FlipImage(IntPtr handle, ref IMVDefine.IMV_FlipImageParam pstFlipImageParam);

		// Token: 0x06000047 RID: 71
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_RotateImage(IntPtr handle, ref IMVDefine.IMV_RotateImageParam pstRotateImageParam);

		// Token: 0x06000048 RID: 72
		[DllImport("MVSDKmd.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern int IMV_SaveImageToFile(IntPtr handle, ref IMVDefine.IMV_SaveImageToFileParam pstSaveImageToFileParam);
	}
}
