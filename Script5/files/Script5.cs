/// This finds the Bills/POs after logining in to the Summary Page

print.clear();
var w = wnd.find("*- Google Chrome").Activate();//find web browser window of BuilderTrends

var e = w.Elm["web:STATICTEXT", "Financial"].Find(10);
print.it("Find Financial");
print.it(e);

e.Invoke();
3.s();

var e2 = w.Elm["web:LINK", "Bills/POs"].Find(10);//find https://buildertrend.net/POs/PurchaseOrdersList.aspx
print.it("Find Bills/POs");
print.it(e2);
var state_e2 = e2.WebInvoke(10);
1.s();
print.it(state_e2);
print.it("Done!");


