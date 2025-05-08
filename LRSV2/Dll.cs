namespace LRSV2;
using System.Runtime.InteropServices;


public class Dll
{
    //座位
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr getSeatHead();
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int addSeat(IntPtr head, int room, int seat, int isOccupied);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int removeSeat(IntPtr head, int room, int seat);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr findSeatByRoom(IntPtr head, int room);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr findSeatBySeat(IntPtr head, int seat);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr findSeatByIsOccupied(IntPtr head, int isOccupied);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr importSeat(IntPtr head, IntPtr seat);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int exportSeat(IntPtr head, IntPtr path);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr returnAllSeats(IntPtr head);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int cancelSeat(IntPtr head,int room,int seat);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void freeSeat(IntPtr head);

    //用户
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr getUserHead();
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int addUser(IntPtr head, IntPtr name, IntPtr email, IntPtr password, int isAdmin, IntPtr seat);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int deleteUser(IntPtr head, IntPtr email, IntPtr password);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr returnAllUser(IntPtr head, IntPtr email);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int changeUsername(IntPtr head, IntPtr name, IntPtr email);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int changePassword(IntPtr head, IntPtr email, IntPtr password);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void freeUser(IntPtr head);
    
    //统计
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr getStatisticHead();
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int deleteStatistic(IntPtr head, int room, int seat, IntPtr time);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr returnAllStatistic(IntPtr head, IntPtr user);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr findStatisticByRoom(IntPtr head, int room);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr findStatisticBySeat(IntPtr head, int seat);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr findStatisticByUser(IntPtr head, IntPtr user);

    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void clearAllStatistic(IntPtr head);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr findStatisticByTimeRange(IntPtr head, IntPtr startTime, IntPtr endTime);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void freeStatistic(IntPtr head);
    
    //保存
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int saveSeats(IntPtr head);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int saveUser(IntPtr user);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int saveStatistic(IntPtr head);
    
    //加载
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int loadSeat(IntPtr head);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int loadUser(IntPtr user);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int loadStatistic(IntPtr head);
    
    //其他
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr login(IntPtr user,IntPtr email,IntPtr password);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int reserveSeat(IntPtr head, int room, int seat, IntPtr user, IntPtr statistic);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int cancelReservation(IntPtr head, IntPtr user);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr getUserInfo(IntPtr user);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int setAsAdmin(IntPtr user, IntPtr email);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int setAsUser(IntPtr user, IntPtr email);

}