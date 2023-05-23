﻿namespace CQRS.Domain.Queries.Person.v1.List;

public class ListPersonQuery
{
    public ListPersonQuery(string? name, string? cpf)
    {
        Name = name;
        Cpf = cpf;
    }

    public string? Name { get; set; }
    public string? Cpf { get; set; }
}