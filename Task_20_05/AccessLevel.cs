using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_05
{
    /*перечисления AccessLevel:
        • Guest (только чтение)
        • User (чтение + комментарии)
        • Moderator (удаление контента)
        • Admin (полный доступ)*/

    enum AccessLevel
    {
        Guest,
        User,
        Moderator,
        Admin
    }
}
