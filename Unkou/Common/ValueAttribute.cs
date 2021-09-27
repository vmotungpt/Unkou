using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unkou.Common
{
	public class ValueAttribute : Attribute
	{

		private string _val;

		/// <summary>
		/// 値
		/// </summary>
		/// <returns>値</returns>
		public string Value
		{

			get
			{
				return _val;
			}

			private set
			{
				_val = value;
			}

		}

		/// <summary>
		/// 値の設定
		/// </summary>
		/// <param name="val"></param>
		public ValueAttribute(string val)
		{
			this.Value = val;
		}

	}
}
