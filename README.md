# polyglot-backend

Experimental project where you can build the backend API with both asp.net core (Kestrel) & Express servers in  one domain app <sup> <[Desktop-server] 


<br /><br /> <canvus>

![image001](https://github.com/PrestigeDevop/polyglot-backend/assets/85388342/d657bc6c-8497-4d8b-aeca-cdd71d313fe4)


### Q&A :
Why?
---
Why not?!
I know because you can it doesn't mean you should , but as I'm learning , I use both to quickly scaffold an app and get the best from both worlds
this is a great way to test new ideas , develop rapid web API , and utilize the two  ecosystems ... in addtion to community examples 
note this project isn't production ready and it's really  bad as i'm newbie and this code needs clean up and refactoring . # You should use Blazor with JS interop instead!
this use .net minimal API and you need  node installed  +(environment path).
this approch probably doesn't use IPC ( In Process Communication ) , however it execute node modules using c# with [InodeService](https://github.com/JeringTech/Javascript.NodeJS)
<br />

---
~~I may -maynot include other servers ( i.e using Ironpython : Flask-Django ? ) or event Java Spring (using IKVM? )  and metaframeworks like next.js and sveltekit as well . (open an issue for feature request)~~ 
## So what this project include ?

-a minimal .net(8) api <br />
-express server (from nodemodules ) installed<br />
-a js library (generate QR codes) to test the api .<br />

### How to run?

you can just use ```dotnet run```  . 
<br />
if you go to the local host: (depends on the server port usally 5000)
you will get a hello world from c# .<br />

now if you visit localhost:3000 (node) you will see an error ( that because we haven't bootstrapped node  yet - just visit localhost:5000/QR which gonna run node now you can safely ignore the loading page  and visit localhost:3000)<br /> so visit this  endpoint first to trigger the service .<br />
then you can visit ```[localhost:3000/generateQR](http://localhost:3000/generateQR?url=TEST)``` inwhich you can get the result (an Image).
<br />

-note (known issue) : you can't shutdown both server at the same time ..   kestrel server using ctrl+c ( maybe needs a little more time or do it twice ) and it feels it hangs out at first but  actually it seems waiting node process to finish  the app.listen event loop?  or prehaps something else but don't worry because once you close the shell (cli) you will closed both since the main process started by c# Main.cs.
-Also we need a little improvment to redirect node stdout (i.e console.log) to the same shell pipline .

