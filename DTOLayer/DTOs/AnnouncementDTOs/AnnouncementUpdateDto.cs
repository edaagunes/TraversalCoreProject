using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.AnnouncementDTOs
{
	public class AnnouncementUpdateDto
	{
		public int AnnouncementId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime AnnouncementDate { get; set; }
	}
}
