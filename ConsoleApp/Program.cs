using System.Collections;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//Задача - зробити список справ з можливістю додавати та видаляти конкретну задачу, а також ставити їй конкретний статус.
List<string> tasks = new List<string>();
List<bool> statuses = new List<bool>();

bool isWhile = true;

void AddTask()
{
    Console.WriteLine("◣✦◥▔▔▔▔▔▔▔▔▔▔▔◤✦◢");
    Console.WriteLine("Введіть назву задачі");
    Console.WriteLine("◤✦◢▁▁▁▁▁▁▁▁▁▁▁◣✦◥");
    string description = Console.ReadLine().ToString();

    tasks.Add(description);
    statuses.Add(false);
    Console.WriteLine("Задача додана.");
}
void RemoveTask()
{
    Console.WriteLine("┯━━━━━━━━━━━━━━━━━━━━▧▣▧━━━━━━━━━━━━━━━━━━━━┯");
    Console.WriteLine("➲ Ви впевнені, що хочете забрати елемент зі списку?");
    Console.WriteLine("{1 - Так. 0 - Ні}");
    Console.WriteLine("┷━━━━━━━━━━━━━━━━━━━━▧▣▧━━━━━━━━━━━━━━━━━━━━┷");
    int confirmDelete = Convert.ToInt16(Console.ReadLine());
    switch (confirmDelete)
    {
        case 0:
            break;
        case 1:
            Console.WriteLine("◣✦◥▔▔▔▔▔▔▔▔▔▔▔◤✦◢");
            Console.WriteLine("Введіть індекс задачі");
            Console.WriteLine("◤✦◢▁▁▁▁▁▁▁▁▁▁▁◣✦◥");
            int index = Convert.ToInt16(Console.ReadLine());

            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                statuses.RemoveAt(index);
                Console.WriteLine("Задача видалена.");
            }
            else
            {
                Console.WriteLine("Невірний індекс.");
            }
            break;
    }
}
void SetTaskStatus()
{
    Console.WriteLine("◣✦◥▔▔▔▔▔▔▔▔▔▔▔◤✦◢");
    Console.WriteLine("Введіть індекс задачі");
    Console.WriteLine("◤✦◢▁▁▁▁▁▁▁▁▁▁▁◣✦◥");
    int index = Convert.ToInt16(Console.ReadLine());

    if (index >= 0 && index < statuses.Count)
    {
        statuses[index] = !statuses[index];
        Console.WriteLine("Статус задачі оновлено.");
    }
    else
    {
        Console.WriteLine("Невірний індекс.");
    }
}
void ShowTasks()
{
    Console.WriteLine("━━━━━「Tasks」━━━━━");
    if (tasks.Count == 0)
    {
        Console.WriteLine("Список справ порожній.");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i}: {tasks[i]} - {(statuses[i] ? "Виконано ✓" : "В процесі ✎")}");
    }
    Console.WriteLine("━━━━━━━━━━━━━━━━━━━");
}
void ClearTasks()
{
    Console.WriteLine("┯━━━━━━━━━━━━━━━━━━━━▧▣▧━━━━━━━━━━━━━━━━━━━━┯");
    Console.WriteLine("➣ Ви впевнені, що хочете очистити список?");
    Console.WriteLine("{1 - Так. 0 - Ні}");
    Console.WriteLine("┷━━━━━━━━━━━━━━━━━━━━▧▣▧━━━━━━━━━━━━━━━━━━━━┷");
    int confirmClear = Convert.ToInt16(Console.ReadLine());
    switch (confirmClear)
    {
        case 0:
            break;
        case 1:
            tasks.Clear();
            statuses.Clear();

            Console.WriteLine("Список очищений");
            break;
        
    }
}

while (isWhile)
{
    try
    {
        Console.Clear();
        Console.WriteLine("━───────⊹⊱✙⊰⊹───────━");
        Console.WriteLine("Вітаю в менеджері списку справ! Що ви збираєтесь зробити?");
        Console.WriteLine("1.Додати елемент\n2.Забрати елемент\n3.Показати список\n4.Встановити новий статус завдання\n5.Очистити список\n0.Вийти");
        Console.WriteLine("━─────────────────────━");
        int choice = Convert.ToInt16(Console.ReadLine());
        switch (choice)
        {
            case 0:
                isWhile = false;
                break;
            case 1:
                AddTask();
                Console.WriteLine("Підтвердити продовження: ENTER");
                Console.ReadLine();
                break;
            case 2:
                RemoveTask();
                Console.WriteLine("Підтвердити продовження: ENTER");
                Console.ReadLine();
                break;
            case 3:
                ShowTasks();
                Console.WriteLine("Підтвердити продовження: ENTER");
                Console.ReadLine();
                break;
            case 4:
                SetTaskStatus();
                Console.WriteLine("Підтвердити продовження: ENTER");
                Console.ReadLine();
                break;
            case 5:
                ClearTasks();
                Console.WriteLine("Підтвердити продовження: ENTER");
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("Вибирайте число акуратніше!");
                break;
        }
    }
    catch
    {
        Console.WriteLine("Введіть правильний формат числа!");
    }
}