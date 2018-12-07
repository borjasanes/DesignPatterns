using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
    /// <summary>
    /// Provide a unified interface to a set of interfaces in a subsystem.
    /// Facade defines a higher-level interface that makes the subsystem easier to use.
    /// </summary>
    public interface ICustomerServiceFacade
    {
        IUserService UserService { get; set; }
        IDevicesService DevicesService { get; set; }
        INotificationService NotificationService { get; set; }
    }

    public interface IUserService
    {
        bool IsUserLocked(long userId);
        string GetUserName(long userId);
        string GetUserEmail(long userId);
        Task LockUser(long userId);
    }

    public interface IDevicesService
    {
        List<string> GetUserCoupons(long userId);
        void AsignCouponToUser(long userId, string couponId);
    }

    public interface INotificationService
    {
        Task SendNotification(long userId, string body);
    }
}
