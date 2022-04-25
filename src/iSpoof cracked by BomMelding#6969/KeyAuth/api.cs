using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace KeyAuth
{
	// Token: 0x0200000B RID: 11
	public class api
	{
		// Token: 0x0600006C RID: 108 RVA: 0x000075B0 File Offset: 0x000057B0
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007648 File Offset: 0x00005848
		public void init()
		{
			this.string_1 = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.string_1, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure);
			if (response_structure.success)
			{
				this.method_0(response_structure.appinfo);
				this.string_0 = response_structure.sessionid;
				this.bool_0 = true;
			}
			else if (response_structure.message == "invalidver")
			{
				this.app_data.downloadLink = response_structure.download;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002341 File Offset: 0x00000541
		public static bool IsDebugRelease
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002344 File Offset: 0x00000544
		public void Checkinit()
		{
			if (!this.bool_0)
			{
				if (api.IsDebugRelease)
				{
					api.error("Not initialized Check if KeyAuthApp.init() does exist");
				}
				else
				{
					api.error("Please initialize first");
				}
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000077CC File Offset: 0x000059CC
		public void register(string username, string pass, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.string_1, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.string_1, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.string_1, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure);
			if (response_structure.success)
			{
				this.method_1(response_structure.info);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000792C File Offset: 0x00005B2C
		public void login(string username, string pass)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.string_1, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.string_1, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure);
			if (response_structure.success)
			{
				this.method_1(response_structure.info);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007A74 File Offset: 0x00005C74
		public void upgrade(string username, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.string_1, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			response_structure.success = false;
			this.method_2(response_structure);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007B94 File Offset: 0x00005D94
		public void license(string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.string_1, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure);
			if (response_structure.success)
			{
				this.method_1(response_structure.info);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00007CC4 File Offset: 0x00005EC4
		public void check()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure_ = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure_);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007D9C File Offset: 0x00005F9C
		public void setvar(string var, string data)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.string_1, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure_ = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure_);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00007EA4 File Offset: 0x000060A4
		public string getvar(string var)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00007FAC File Offset: 0x000061AC
		public void ban()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure_ = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure_);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00008084 File Offset: 0x00006284
		public string var(string varid)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.message;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000819C File Offset: 0x0000639C
		public List<api.msg> chatget(string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure);
			List<api.msg> result;
			if (response_structure.success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000082A4 File Offset: 0x000064A4
		public bool chatsend(string msg, string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.string_1, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure);
			return response_structure.success;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000083C0 File Offset: 0x000065C0
		public bool checkblack()
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure);
			return response_structure.success;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000084D8 File Offset: 0x000066D8
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.string_1, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.string_1, text);
			nameValueCollection["body"] = encryption.encrypt(body, this.string_1, text);
			nameValueCollection["conttype"] = encryption.encrypt(conttype, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00008628 File Offset: 0x00006828
		public byte[] download(string fileid)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.smethod_0(nameValueCollection_);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.response_structure response_structure = this.json_wrapper_0.string_to_generic<api.response_structure>(text2);
			this.method_2(response_structure);
			byte[] result;
			if (response_structure.success)
			{
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00008734 File Offset: 0x00006934
		public void log(string message)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.string_1, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			api.smethod_0(nameValueCollection_);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00008820 File Offset: 0x00006A20
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00008898 File Offset: 0x00006A98
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000088E8 File Offset: 0x00006AE8
		private static string smethod_0(NameValueCollection nameValueCollection_0)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", nameValueCollection_0);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					Thread.Sleep(1000);
					result = api.smethod_0(nameValueCollection_0);
				}
			}
			return result;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00008990 File Offset: 0x00006B90
		private void method_0(api.app_data_structure app_data_structure_0)
		{
			this.app_data.numUsers = app_data_structure_0.numUsers;
			this.app_data.numOnlineUsers = app_data_structure_0.numOnlineUsers;
			this.app_data.numKeys = app_data_structure_0.numKeys;
			this.app_data.version = app_data_structure_0.version;
			this.app_data.customerPanelLink = app_data_structure_0.customerPanelLink;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000089F4 File Offset: 0x00006BF4
		private void method_1(api.user_data_structure user_data_structure_0)
		{
			this.user_data.username = user_data_structure_0.username;
			this.user_data.ip = user_data_structure_0.ip;
			this.user_data.hwid = user_data_structure_0.hwid;
			this.user_data.createdate = user_data_structure_0.createdate;
			this.user_data.lastlogin = user_data_structure_0.lastlogin;
			this.user_data.subscriptions = user_data_structure_0.subscriptions;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00008A68 File Offset: 0x00006C68
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[0].expiry)).ToLocalTime();
			TimeSpan timeSpan = d - DateTime.Now;
			return Convert.ToString(timeSpan.Days.ToString() + " Days " + timeSpan.Hours.ToString() + " Hours Left");
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000236E File Offset: 0x0000056E
		private void method_2(api.response_structure response_structure_0)
		{
			this.response.success = response_structure_0.success;
			this.response.message = response_structure_0.message;
		}

		// Token: 0x0400004E RID: 78
		public string name;

		// Token: 0x0400004F RID: 79
		public string ownerid;

		// Token: 0x04000050 RID: 80
		public string secret;

		// Token: 0x04000051 RID: 81
		public string version;

		// Token: 0x04000052 RID: 82
		private string string_0;

		// Token: 0x04000053 RID: 83
		private string string_1;

		// Token: 0x04000054 RID: 84
		private bool bool_0;

		// Token: 0x04000055 RID: 85
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x04000056 RID: 86
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000057 RID: 87
		public api.response_class response = new api.response_class();

		// Token: 0x04000058 RID: 88
		private json_wrapper json_wrapper_0 = new json_wrapper(new api.response_structure());

		// Token: 0x0200000C RID: 12
		public class app_data_class
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000087 RID: 135 RVA: 0x00002392 File Offset: 0x00000592
			// (set) Token: 0x06000088 RID: 136 RVA: 0x0000239A File Offset: 0x0000059A
			public string numUsers { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000089 RID: 137 RVA: 0x000023A3 File Offset: 0x000005A3
			// (set) Token: 0x0600008A RID: 138 RVA: 0x000023AB File Offset: 0x000005AB
			public string numOnlineUsers { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600008B RID: 139 RVA: 0x000023B4 File Offset: 0x000005B4
			// (set) Token: 0x0600008C RID: 140 RVA: 0x000023BC File Offset: 0x000005BC
			public string numKeys { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600008D RID: 141 RVA: 0x000023C5 File Offset: 0x000005C5
			// (set) Token: 0x0600008E RID: 142 RVA: 0x000023CD File Offset: 0x000005CD
			public string version { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600008F RID: 143 RVA: 0x000023D6 File Offset: 0x000005D6
			// (set) Token: 0x06000090 RID: 144 RVA: 0x000023DE File Offset: 0x000005DE
			public string customerPanelLink { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000091 RID: 145 RVA: 0x000023E7 File Offset: 0x000005E7
			// (set) Token: 0x06000092 RID: 146 RVA: 0x000023EF File Offset: 0x000005EF
			public string downloadLink { get; set; }

			// Token: 0x04000059 RID: 89
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_0;

			// Token: 0x0400005A RID: 90
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_1;

			// Token: 0x0400005B RID: 91
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;

			// Token: 0x0400005C RID: 92
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_3;

			// Token: 0x0400005D RID: 93
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_4;

			// Token: 0x0400005E RID: 94
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_5;
		}

		// Token: 0x0200000D RID: 13
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000094 RID: 148 RVA: 0x000023F8 File Offset: 0x000005F8
			// (set) Token: 0x06000095 RID: 149 RVA: 0x00002400 File Offset: 0x00000600
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000096 RID: 150 RVA: 0x00002409 File Offset: 0x00000609
			// (set) Token: 0x06000097 RID: 151 RVA: 0x00002411 File Offset: 0x00000611
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000098 RID: 152 RVA: 0x0000241A File Offset: 0x0000061A
			// (set) Token: 0x06000099 RID: 153 RVA: 0x00002422 File Offset: 0x00000622
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600009A RID: 154 RVA: 0x0000242B File Offset: 0x0000062B
			// (set) Token: 0x0600009B RID: 155 RVA: 0x00002433 File Offset: 0x00000633
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600009C RID: 156 RVA: 0x0000243C File Offset: 0x0000063C
			// (set) Token: 0x0600009D RID: 157 RVA: 0x00002444 File Offset: 0x00000644
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600009E RID: 158 RVA: 0x0000244D File Offset: 0x0000064D
			// (set) Token: 0x0600009F RID: 159 RVA: 0x00002455 File Offset: 0x00000655
			[DataMember]
			public string downloadLink { get; set; }

			// Token: 0x0400005F RID: 95
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_0;

			// Token: 0x04000060 RID: 96
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_1;

			// Token: 0x04000061 RID: 97
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;

			// Token: 0x04000062 RID: 98
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_3;

			// Token: 0x04000063 RID: 99
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_4;

			// Token: 0x04000064 RID: 100
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_5;
		}

		// Token: 0x0200000E RID: 14
		public class Data
		{
			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000245E File Offset: 0x0000065E
			// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002466 File Offset: 0x00000666
			public string subscription { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000246F File Offset: 0x0000066F
			// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002477 File Offset: 0x00000677
			public string expiry { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002480 File Offset: 0x00000680
			// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002488 File Offset: 0x00000688
			public string timeleft { get; set; }

			// Token: 0x04000065 RID: 101
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_0;

			// Token: 0x04000066 RID: 102
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_1;

			// Token: 0x04000067 RID: 103
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;
		}

		// Token: 0x0200000F RID: 15
		public class msg
		{
			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002491 File Offset: 0x00000691
			// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002499 File Offset: 0x00000699
			public string message { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000AA RID: 170 RVA: 0x000024A2 File Offset: 0x000006A2
			// (set) Token: 0x060000AB RID: 171 RVA: 0x000024AA File Offset: 0x000006AA
			public string author { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000AC RID: 172 RVA: 0x000024B3 File Offset: 0x000006B3
			// (set) Token: 0x060000AD RID: 173 RVA: 0x000024BB File Offset: 0x000006BB
			public string timestamp { get; set; }

			// Token: 0x04000068 RID: 104
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_0;

			// Token: 0x04000069 RID: 105
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_1;

			// Token: 0x0400006A RID: 106
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;
		}

		// Token: 0x02000010 RID: 16
		public class response_class
		{
			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000AF RID: 175 RVA: 0x000024C4 File Offset: 0x000006C4
			// (set) Token: 0x060000B0 RID: 176 RVA: 0x000024CC File Offset: 0x000006CC
			public bool success { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000B1 RID: 177 RVA: 0x000024D5 File Offset: 0x000006D5
			// (set) Token: 0x060000B2 RID: 178 RVA: 0x000024DD File Offset: 0x000006DD
			public string message { get; set; }

			// Token: 0x0400006B RID: 107
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool bool_0;

			// Token: 0x0400006C RID: 108
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_0;
		}

		// Token: 0x02000011 RID: 17
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x000024E6 File Offset: 0x000006E6
			// (set) Token: 0x060000B5 RID: 181 RVA: 0x000024EE File Offset: 0x000006EE
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x000024F7 File Offset: 0x000006F7
			// (set) Token: 0x060000B7 RID: 183 RVA: 0x000024FF File Offset: 0x000006FF
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002508 File Offset: 0x00000708
			// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002510 File Offset: 0x00000710
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000BA RID: 186 RVA: 0x00002519 File Offset: 0x00000719
			// (set) Token: 0x060000BB RID: 187 RVA: 0x00002521 File Offset: 0x00000721
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000BC RID: 188 RVA: 0x0000252A File Offset: 0x0000072A
			// (set) Token: 0x060000BD RID: 189 RVA: 0x00002532 File Offset: 0x00000732
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000BE RID: 190 RVA: 0x0000253B File Offset: 0x0000073B
			// (set) Token: 0x060000BF RID: 191 RVA: 0x00002543 File Offset: 0x00000743
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000254C File Offset: 0x0000074C
			// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002554 File Offset: 0x00000754
			[DataMember(EmitDefaultValue = false, IsRequired = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000255D File Offset: 0x0000075D
			// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002565 File Offset: 0x00000765
			[DataMember(EmitDefaultValue = false, IsRequired = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000256E File Offset: 0x0000076E
			// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002576 File Offset: 0x00000776
			[DataMember]
			public List<api.msg> messages { get; set; }

			// Token: 0x0400006D RID: 109
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool bool_0;

			// Token: 0x0400006E RID: 110
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_0;

			// Token: 0x0400006F RID: 111
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_1;

			// Token: 0x04000070 RID: 112
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;

			// Token: 0x04000071 RID: 113
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_3;

			// Token: 0x04000072 RID: 114
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_4;

			// Token: 0x04000073 RID: 115
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private api.user_data_structure user_data_structure_0;

			// Token: 0x04000074 RID: 116
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private api.app_data_structure app_data_structure_0;

			// Token: 0x04000075 RID: 117
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<api.msg> list_0;
		}

		// Token: 0x02000012 RID: 18
		public class user_data_class
		{
			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000257F File Offset: 0x0000077F
			// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002587 File Offset: 0x00000787
			public string username { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002590 File Offset: 0x00000790
			// (set) Token: 0x060000CA RID: 202 RVA: 0x00002598 File Offset: 0x00000798
			public string ip { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060000CB RID: 203 RVA: 0x000025A1 File Offset: 0x000007A1
			// (set) Token: 0x060000CC RID: 204 RVA: 0x000025A9 File Offset: 0x000007A9
			public string hwid { get; set; }

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060000CD RID: 205 RVA: 0x000025B2 File Offset: 0x000007B2
			// (set) Token: 0x060000CE RID: 206 RVA: 0x000025BA File Offset: 0x000007BA
			public string createdate { get; set; }

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060000CF RID: 207 RVA: 0x000025C3 File Offset: 0x000007C3
			// (set) Token: 0x060000D0 RID: 208 RVA: 0x000025CB File Offset: 0x000007CB
			public string lastlogin { get; set; }

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060000D1 RID: 209 RVA: 0x000025D4 File Offset: 0x000007D4
			// (set) Token: 0x060000D2 RID: 210 RVA: 0x000025DC File Offset: 0x000007DC
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x04000076 RID: 118
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_0;

			// Token: 0x04000077 RID: 119
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_1;

			// Token: 0x04000078 RID: 120
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;

			// Token: 0x04000079 RID: 121
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_3;

			// Token: 0x0400007A RID: 122
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_4;

			// Token: 0x0400007B RID: 123
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private List<api.Data> list_0;
		}

		// Token: 0x02000013 RID: 19
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x000025E5 File Offset: 0x000007E5
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x000025ED File Offset: 0x000007ED
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x000025F6 File Offset: 0x000007F6
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x000025FE File Offset: 0x000007FE
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002607 File Offset: 0x00000807
			// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000260F File Offset: 0x0000080F
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060000DA RID: 218 RVA: 0x00002618 File Offset: 0x00000818
			// (set) Token: 0x060000DB RID: 219 RVA: 0x00002620 File Offset: 0x00000820
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060000DC RID: 220 RVA: 0x00002629 File Offset: 0x00000829
			// (set) Token: 0x060000DD RID: 221 RVA: 0x00002631 File Offset: 0x00000831
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000DE RID: 222 RVA: 0x0000263A File Offset: 0x0000083A
			// (set) Token: 0x060000DF RID: 223 RVA: 0x00002642 File Offset: 0x00000842
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x0400007C RID: 124
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_0;

			// Token: 0x0400007D RID: 125
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_1;

			// Token: 0x0400007E RID: 126
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_2;

			// Token: 0x0400007F RID: 127
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_3;

			// Token: 0x04000080 RID: 128
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_4;

			// Token: 0x04000081 RID: 129
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private List<api.Data> list_0;
		}
	}
}
