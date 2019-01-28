using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DashBorad
{

    #region 仪表盘   封装
    //class DashBorad  //仪表盘
    //{
    //    public string Name;  //表盘名称
    //    private  double Value;  //表盘读数
    //    public List<零件>零件s;

    //    public double  GetValue()
    //    {
    //        return Value;
    //    }

    //    public void Rotate(double angle)  //指针转动
    //    {
    //        Value = angle;
    //        Console.WriteLine("转动了{0}度",angle);
    //    }

    //    public void Reset()  //指针复位
    //    {
    //        Value = 0;
    //        Console.WriteLine("表盘复位完成");
    //    }

    //    public void ShowValue()
    //    {
    //        Console.WriteLine("当前表盘读数{0}", Value);

    //    }

    //    public bool Save()   //将表盘读数存到数据库
    //    {
    //        数据库 dataBase = new 数据库();
    //            return  dataBase.Store(this);6
    //    }

    //}

    //class 零件 { }

    //class 数据库
    //{
    //    public bool Store(DashBorad dashBorad)
    //    {
    //        // db.GetValue;
    //        return true;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DashBorad db = new DashBorad();  //实例化

    //        db.Name = "速度表盘";
    //        db.Reset();

    //        db.Rotate(10.0);

    //        db.ShowValue();

    //        Console.Read();

    //    }

    //}
    #endregion
    #region 继承


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var dog = new Dog() { Name = "小黑" };

    //        dog.Shout();

    //        var cat = new Cat() { Name = "小猫" };

    //        cat.Shout();

    //        Console.Read();
    //    }
    //}

    ///// <summary>
    ///// 父类 animal
    ///// </summary>
    //public class Animal
    //{

    //    /// 父类的属性
    //    public string Name { get; set; }

    //}

    ///// <summary>
    ///// 狗类 继承父类animal
    ///// </summary>
    //public class Dog : Animal
    //{
    //    public void Shout()
    //    {
    //        Console.WriteLine(this.Name + ":汪汪");
    //    }
    //}

    ///// <summary>
    ///// 猫类 继承父类animal
    ///// </summary>
    //public class Cat : Animal
    //{
    //    public void Shout()
    //    {
    //        Console.WriteLine(this.Name + ":喵喵");
    //    }
    //}

    #endregion
    #region 浮点运算精度问题


    //static void Main(string[] args)
    //{
    //    double a = 3.876700875;

    //    double b = 2.6;

    //    double c = a-b;

    //    var d= Math.Round(c,5);



    //    Console.WriteLine(d.ToString("N5"));

    //    Console.Read();
    //}
    #endregion
    #region 抽象类继承

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Lead lead = new Lead();


    //        RefreshBlood(lead.leadBlood);
    //        RefreshBlood(lead.mercenary.mercenaryBlood);
    //        Thread.Sleep(1000);  //战斗1秒

    //        for (int i = 0; i < 12; i++)
    //        {
    //            lead.leadBlood.blood -= 30;
    //            lead.mercenary.mercenaryBlood.blood -= 50;

    //            RefreshBlood(lead.leadBlood);
    //            RefreshBlood(lead.mercenary.mercenaryBlood);
    //            Thread.Sleep(1000);  //战斗1秒
    //            FloodTheScreen();
    //        }

    //        Console.Read();
    //    }


    //    /// <summary>
    //    /// 刷新血条
    //    /// </summary>
    //    public static void RefreshBlood(DashBorad dashBorad)   //render
    //    {
    //        dashBorad.Render();
    //    }

    //    /// <summary>
    //    /// 刷屏  这段代码写的没用到呀
    //    /// 
    //    /// </summary>
    //    public static void FloodTheScreen()
    //    {
    //        for (int i = 1; i <= 2; i++)
    //        {
    //            Console.WriteLine();
    //        }

    //    }
    //}

    ///// <summary>
    ///// 抽象类
    ///// </summary>
    //public abstract class DashBorad    //表盘   
    //{
    //    public abstract void Render();
    //}


    ///// <summary>
    ///// 雇佣兵血量
    ///// </summary>
    //public class MercenaryBlood : DashBorad
    //{
    //    public int blood = 200;

    //    public override void Render()
    //    {
    //        Console.WriteLine("雇佣兵的血量 为 {0}", this.blood);
    //    }
    //}

    ///// <summary>
    ///// 主角血量 
    ///// </summary>
    //public class LeadBlood : DashBorad
    //{
    //    public int blood = 100;

    //    public override void Render()
    //    {
    //        Console.WriteLine("主角的血量 为 {0}", this.blood);
    //    }
    //}

    ///// <summary>
    ///// 主角
    ///// </summary>
    //public class Lead
    //{
    //    public LeadBlood leadBlood = new LeadBlood();

    //    public Mercenary mercenary = new Mercenary();

    //}

    ///// <summary>
    ///// 雇佣兵
    ///// </summary>
    //public class Mercenary
    //{
    //    public MercenaryBlood mercenaryBlood = new MercenaryBlood();
    //}
    #endregion

    #region 接口  // 语义： 能做什么


    //public class Program
    //{
    //    public static void IWantFly(IFly fly)
    //    {
    //        fly.Fly();    //fly  是接口   Fly  是方法

    //    }

    //    public static void Main(string[] args)
    //    {
    //        IWantFly(new Dove("小白"));





    //        Console.Read();
    //    }


    //}


    //public interface IFly
    //{
    //    void Fly();
    //}

    //public abstract class Vehicle
    //{

    //}

    //public class Plane : Vehicle, IFly
    //{
    //    public void Fly()
    //    {
    //        Console.WriteLine("飞机在飞");
    //    }
    //}
    //public class Car : Vehicle
    //{

    //}
    //public abstract class Animal
    //{
    //    public Animal(string name)
    //    {
    //        this.Name = name;
    //    }
    //    public string Name { get; set; }

    //    public abstract void Shout();

    //}

    //public class Dog : Animal
    //{
    //    public Dog(string name) : base(name) { }

    //    public override void Shout()
    //    {
    //        Console.WriteLine("{0}:汪汪", base.Name);
    //    }
    //    //public override void Fly()
    //    //{
    //    //    // throw new NotImplementedException();
    //    //    Console.WriteLine("I can not fly !");
    //    //}
    //}

    //public class Cat : Animal
    //{
    //    public Cat(string name) : base(name) { }

    //    public override void Shout()
    //    {
    //        Console.WriteLine("{0}:喵喵", base.Name);
    //    }
    //    //public override void Fly()
    //    //{
    //    //    // throw new NotImplementedException(); 
    //    //    Console.WriteLine("I can not fly !");
    //    //}
    //}
    //public class Duck : Animal,IFly
    //{
    //    public Duck(string name) : base(name) { }

    //    public void Fly()
    //    {
    //        Console.WriteLine("I can fly !");
    //    }

    //    public override void Shout()
    //    {
    //        Console.WriteLine("{0}:嘎嘎", base.Name);
    //    }

    //}
    //public class Dove : Animal,IFly
    //{
    //    public Dove(string name) : base(name) { }

    //    public void Fly()
    //    {
    //        Console.WriteLine("{0}   我在飞", base.Name);
    //    }

    //    public override void Shout()
    //    {
    //        Console.WriteLine("{0}:咕咕", base.Name);
    //    }
 
    //}
    #endregion
}
