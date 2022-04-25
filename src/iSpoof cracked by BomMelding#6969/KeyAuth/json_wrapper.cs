using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000015 RID: 21
	public class json_wrapper
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00008E10 File Offset: 0x00007010
		public json_wrapper(object obj_to_work_with)
		{
			this.object_0 = obj_to_work_with;
			Type type = this.object_0.GetType();
			this.dataContractJsonSerializer_0 = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.object_0));
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002667 File Offset: 0x00000867
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00008E64 File Offset: 0x00007064
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.dataContractJsonSerializer_0.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002685 File Offset: 0x00000885
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000082 RID: 130
		private DataContractJsonSerializer dataContractJsonSerializer_0;

		// Token: 0x04000083 RID: 131
		private object object_0;
	}
}
