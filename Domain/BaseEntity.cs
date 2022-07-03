using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
	public abstract class BaseEntity : object
	{
		public BaseEntity() : base()
		{
			Id = System.Guid.NewGuid();
		}
		public System.Guid Id { get; set; }
	}
}
