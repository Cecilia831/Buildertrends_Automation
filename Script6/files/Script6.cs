//. This create New Job from scratch
print.clear();
//script.setup(trayIcon: true, sleepExit: true);

var w = wnd.find("Purchase Orders - Google Chrome").Activate();
3.s();

var e = w.Elm["web:BUTTON", "New Job"].Find(10);
3.s();
print.it(e);
e.WebInvoke(1);
5.s();

var w2 = wnd.find(1, "Choose How You Would Like to Start - Buildertrend - Google Chrome", "Chrome_WidgetWin_1");
3.s();

var e2 = w.Elm["web:BUTTON", " Create from Scratch"].Find(-1);
if(e == null) { print.it("not found");}
e2.WebInvoke(2);
   