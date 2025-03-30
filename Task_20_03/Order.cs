using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    /*Напишите метод, который меняет статус заказа. Если заказ уже доставлен или отменён, запретите изменение статуса. Выводите сообщение при каждом изменении статуса (например,
    "Заказ переведён в статус: Отправлен").*/
    class Order
    {
        public OrderStatus Status { get; set; }
        public void ChangeStatus(OrderStatus newstatus)
        {       
            if (Status == OrderStatus.Delivered)
                Console.WriteLine("Нельзя изменить статус заказа, так как он уже доставлен");
            else if (Status == OrderStatus.Cancelled)
                Console.WriteLine("Нельзя изменить статус заказа, так как он был отменен");
            else 
            {
                Status = newstatus;
                Console.WriteLine($"Статус заказа изменен на {Status}");
            }
        }
    }
}
