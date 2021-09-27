using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unkou.Entity.EntityInfoType;

namespace Unkou.Entity
{
	public interface iEntity
	{
		EntityKoumoku_MojiType SystemEntryPgmid { get; set; }
		EntityKoumoku_MojiType SystemEntryPersonCd { get; set; }
		EntityKoumoku_YmdType SystemEntryDay { get; set; }
		EntityKoumoku_MojiType SystemUpdatePgmid { get; set; }
		EntityKoumoku_MojiType SystemUpdatePersonCd { get; set; }
		EntityKoumoku_YmdType SystemUpdateDay { get; set; }
	}
}
