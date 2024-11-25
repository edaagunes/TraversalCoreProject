using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

		public List<Reservation> GetListWithReservationByCancel(int id)
		{
			return _reservationDal.GetListWithReservationByCancel(id);
		}

		public List<Reservation> GetListWithReservationByWaitAccepted(int id)
		{
			return _reservationDal.GetListWithReservationByWaitAccepted(id);
		}

		public List<Reservation> GetListWithReservationByWaitApproval(int id)
		{
           return _reservationDal.GetListWithReservationByWaitApproval(id);
		}

		public List<Reservation> GetListWithReservationByWaitPrevious(int id)
		{
			return _reservationDal.GetListWithReservationByWaitPrevious(id);
		}

		public void TAdd(Reservation entity)
        {
           _reservationDal.Insert(entity);
        }

        public void TDelete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

		public List<Reservation> TGetReservations()
		{
			return _reservationDal.GetReservations();
		}

		public void TSetReservationStatus(int reservationId, string status)
		{
			_reservationDal.SetReservationStatus(reservationId, status);
		}

		public void TUpdate(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
