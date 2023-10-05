print.clear();
var w = wnd.find("Summary grid - Google Chrome").Activate();//find web browser window of BuilderTrends
//print.it(w);

var e = w.Elm["web:STATICTEXT", "Financial"].Find(1);
print.it(e);
e.Invoke();

    
var e2 = w.Elm["web:LINK", "Bills/POs"].Find(1);
print.it(e2);
e2.WebInvoke(2);
//w.Elm["web:LINK", "Bills/POs"].Find(1).WebInvoke();
print.it("Done!");

