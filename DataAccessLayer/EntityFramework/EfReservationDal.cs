using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
	{
		public List<Reservation> GetReservations()
		{
			using (var context = new Context())
			{
				var query = context.Reservations
					.Include(x => x.Destination)
					.Include(x => x.AppUser)
					.ToList();
				return query;
			}
		}


		public List<Reservation> GetListWithReservationByWaitAccepted(int id)
		{
			using (var context = new Context())
			{
				return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserId == id).ToList();
			}
		}

		public List<Reservation> GetListWithReservationByWaitApproval(int id)
		{
			using (var context = new Context())
			{
				return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay Bekliyor" && x.AppUserId == id).ToList();
			}
		}

		public List<Reservation> GetListWithReservationByWaitPrevious(int id)
		{
			using (var context = new Context())
			{
				return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();
			}
		}

		public List<Reservation> GetListWithReservationByCancel(int id)
		{
			using (var context = new Context())
			{
				return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "İptal Edildi" && x.AppUserId == id).ToList();
			}
		}

		public void SetReservationStatus(int reservationId, string status)
		{
			using (var context = new Context())
			{
				var reservation = context.Reservations.FirstOrDefault(x => x.ReservationId == reservationId);
				if (reservation != null)
				{
					reservation.Status = status;
					context.SaveChanges();
				}
			}
		}
	}
}
