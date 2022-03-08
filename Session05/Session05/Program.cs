using Session05;

string s = Console.ReadLine();
Console.WriteLine("Action (0 = Convert,1 = Uppercase,2 = Reverse)");
int act = Convert.ToInt32(Console.ReadLine());

ActionEnum actEn;
if (act == 0)
    actEn = ActionEnum.Convert;
else if (act == 1)
    actEn = ActionEnum.Uppercase;
else
    actEn = ActionEnum.Reverse;
ActionRequest request = new ActionRequest(s, actEn);
ActionResolver resolver = new ActionResolver();
ActionResponse resp = resolver.Execute(request);
Console.WriteLine(resp.Output);