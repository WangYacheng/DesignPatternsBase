﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBase
{
    public class Singleton
    {
        private static Singleton instance = null;
        private Singleton() { }

        public static Singleton GetSingleton()
        {
            if (instance == null) instance = new Singleton();
            return instance;
        }
    }






    /*懒汉式：类加载时没有生成单例
     *饿汉式：类加载时就生成单例
     * 
     *单例模式的应用：
     * 1. Windows的Task Manager（任务管理器）就是很典型的单例模式（这个很熟悉吧），想想看，是不是呢，你能打开两个windows task manager吗？ 不信你自己试试看哦~

       2. windows的Recycle Bin（回收站）也是典型的单例应用。在整个系统运行过程中，回收站一直维护着仅有的一个实例。
       
       3. 网站的计数器，一般也是采用单例模式实现，否则难以同步。
       
       4. 应用程序的日志应用，一般都何用单例模式实现，这一般是由于共享的日志文件一直处于打开状态，因为只能有一个实例去操作，否则内容不好追加。
       
       5. Web应用的配置对象的读取，一般也应用单例模式，这个是由于配置文件是共享的资源。
       
       6. 数据库连接池的设计一般也是采用单例模式，因为数据库连接是一种数据库资源。数据库软件系统中使用数据库连接池，主要是节省打开或者关闭数据库连接所引起的效率损耗，这种效率上的损耗还是非常昂贵的，因为何用单例模式来维护，就可以大大降低这种损耗。
       
       7. 多线程的线程池的设计一般也是采用单例模式，这是由于线程池要方便对池中的线程进行控制。
       
       8. 操作系统的文件系统，也是大的单例模式实现的具体例子，一个操作系统只能有一个文件系统。
       
       9. HttpApplication 也是单位例的典型应用。熟悉ASP.Net(IIS)的整个请求生命周期的人应该知道HttpApplication也是单例模式，所有的HttpModule都共享一个HttpApplication实例.
       
       总结以上，不难看出：
       
       单例模式应用的场景一般发现在以下条件下：
       
       （1）资源共享的情况下，避免由于资源操作时导致的性能或损耗等。如上述中的日志文件，应用配置。
       
       （2）控制资源的情况下，方便资源之间的互相通信。如线程池等。

     * */

}
