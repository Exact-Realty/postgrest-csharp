﻿#pragma warning disable CS1591
namespace Postgrest.Interfaces
{
	public interface IPostgrestQueryFilter
	{
		object? Criteria { get; }
		Constants.Operator Op { get; }
		string? Property { get; }
	}
}
