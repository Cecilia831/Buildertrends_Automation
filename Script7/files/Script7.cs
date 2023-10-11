//. This find the right project name with ID # (pretypied)
//-----------------------------------------------
// Edit to have seperate variables year and pro#
//-----------------------------------------------
print.clear();
//script.setup(trayIcon: true, sleepExit: true);


var w = wnd.find(1, "Purchase Orders - Google Chrome", "Chrome_WidgetWin_1").Activate();
3.s();
var e = w.Elm["web:TEXT", prop: "@id=JobSearch"].Find(-1);/*image:WkJNG4EIAAQid/crSJPmbW1BQOF7IBn2SLnXHnRwPJerH24BJ5EHigFgjDGGr9UKGl0nESs6m9FCRLUiYbvt2cTd+dfI/bXhs1aJAQ==*/
1.s();
if(e == null) { print.it("not found"); }
if(e.Value != "") { e.Value = "" ;}
1.s();
e.Focus();
keys.send("23","-","005");

2.s();
print.it(e);

var bucket = w.Elm["web:STATICTEXT", "23-005*"].Find(1);/*image:WkJNG7UIAMT/x+7thqjUwZP0E0AVoErvu4vIiVGqykk3kXe33KlTNR8bm2ieJ/aUCy0LaDShaasLx7IWx6SFYwJVqIxFqkhBS1gIPcmxmAxfqvrEwCN4RRU9LAJYgWhg25aDIsjM9Uh19z5vliZG4GaHkJ+Xjnf+Bm31pXB3skNVsQT//97j8mIb4WGB+Pd+h6nhDpzvLyM1PhK3V8cY7KwHjd8wIKPjXKOJtMbqaM9BYkaZXwcoi4wQL0hUeiCRkRpL5Hdhsli1pn/Ul/nS7gneRY2SeBpgxI2Q/U2Dkkf1Ro148yeUPHr0ILIwnBmyBM/EkkcNr7F09JA8Ol+shvQB7iK/ndXxZvIo8ecWREcPxSaLFTM8DWi+nOMkAJdOZH9ug+bJLm6U9YzS8gMNgFv6gHWYP3EMZIgsyiLG9PU63EcPtMYG5h42wNnwNHmU7DkZvCgjOvMRugDZH2xQziUV7okHWmQfA/TpgQFoMrYwymfQD83FGBGzmlSExO9jT0UMZdLdG5s0h5NEqhLl8o8sMgLA0J8Y8G3JAA==*/
print.it(bucket);
3.s();
bucket.Invoke();
print.it("Done!");

