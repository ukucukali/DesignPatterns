﻿namespace SingleResponsibilityPrinciple.ExampleTwo.GoodPractice;

public interface IProductRepository
{
    public void Connect();

    public void Add<T>(T dbObject);
}


