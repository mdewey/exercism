using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
  private Queue<T> buffer { get; set; } = new Queue<T>();
  private int position { get; set; } = 0;
  private int capacity { get; set; }




  public CircularBuffer(int capacity)
  {
    this.capacity = capacity;
  }

  public T Read()
  {
    if (this.buffer.Count == 0)
    {
      throw new InvalidOperationException();
    }
    return this.buffer.Dequeue();
  }

  public void Write(T value)
  {
    if (this.buffer.Count >= capacity)
    {
      throw new InvalidOperationException();
    }
    this.buffer.Enqueue(value);

  }

  public void Overwrite(T value)
  {
    throw new NotImplementedException("You need to implement this function.");
  }

  public void Clear()
  {
    this.buffer = new Queue<T>();
  }
}