using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using TodoApi.Models;

namespace TodoApi.DTOs;

public class TodoItemDTO
{
  public long Id { get; set; }
  public string? Name { get; set; }
  public bool IsComplete { get; set; }
  public int Order { get; set; } = 1;

  public bool MapTo(TodoItem todoItem)
  {
    if (todoItem == null) return false;

    todoItem.Name = Name;
    todoItem.IsComplete = IsComplete;
    todoItem.Order = Order;

    return true;
  }

  public TodoItem Create()
  {
    return new TodoItem
    {
      Name = Name,
      IsComplete = IsComplete,
      Order = Order
    };
  }

  public static TodoItemDTO MapFrom(TodoItem todoItem)
  {
    return new TodoItemDTO
    {
      Id = todoItem.Id,
      Name = todoItem.Name,
      IsComplete = todoItem.IsComplete,
      Order = todoItem.Order
    };
  }
}