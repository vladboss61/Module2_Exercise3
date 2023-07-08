using System;


namespace Module2_Exercise3.BrokenPolymorphismExample;

public class NormalBase
{
    public virtual void DoIt()
    {
    }
}

public class NormalDerived : NormalBase
{
    public override void DoIt()
    {
    }
}

//NormalBase b = new NormalDerived();
//NormalDerived b1 = new NormalDerived();

//b.DoIt();                      // Calls NormalDerived.DoIt
//b1.DoIt();                      // Calls NormalDerived.DoIt

public class BrokenBase
{
    public virtual void DoIt()
    {
    }
}

public class BrokenDerived : BrokenBase
{
    public new void DoIt()
    {
    }
}

//BrokenBase b = new BrokenDerived();
//BrokenDerived d = new BrokenDerived();

//b.DoIt();                      // Calls BrokenBase.DoIt
//d.DoIt();                      // Calls BrokenDerived.DoIt


public class BrokenComplexBase
{
    public virtual void DoIt()
    {
        Console.WriteLine("BrokenComplexBase.DoIt");
    }
}

public class BrokenComplexDerivedFirst : BrokenComplexBase
{
    public override void DoIt()
    {
        Console.WriteLine("BrokenComplexDerivedFirst.DoIt");
    }
}

public class BrokenComplexDerivedSecond : BrokenComplexDerivedFirst
{
    public new void DoIt()
    {
        Console.WriteLine("BrokenComplexDerivedSecond.DoIt");
    }
}

//BrokenComplexBase brokenComplexBase = new BrokenComplexBase();
//brokenComplexBase.DoIt();

//BrokenComplexBase brokenComplexDerivedFirst = new BrokenComplexDerivedFirst();
//brokenComplexDerivedFirst.DoIt();

//BrokenComplexBase brokenComplexDerivedSecond = new BrokenComplexDerivedSecond();
//brokenComplexDerivedSecond.DoIt();

//BrokenComplexDerivedFirst brokenComplexDerivedFirstFromFirst = new BrokenComplexDerivedSecond();
//brokenComplexDerivedFirstFromFirst.DoIt();

//BrokenComplexDerivedSecond brokenComplexDerivedSecond = new BrokenComplexDerivedSecond();
//brokenComplexDerivedSecond.DoIt();

//Result

//BrokenComplexBase.DoIt
//BrokenComplexDerivedFirst.DoIt
//BrokenComplexDerivedFirst.DoIt
//BrokenComplexDerivedFirst.DoIt
//brokenComplexDerivedSecond.DoIt