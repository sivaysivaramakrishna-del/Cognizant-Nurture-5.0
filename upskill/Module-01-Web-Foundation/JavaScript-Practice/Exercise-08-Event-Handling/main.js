// JavaScript Exercise 8
const events=[{name:"Tech Innovators Meetup",category:"Technology",seats:12,date:"2026-07-10"},{name:"Music Night",category:"Music",seats:0,date:"2026-06-01"},{name:"Health Camp",category:"Health",seats:20,date:"2026-08-05"}];
const output=document.querySelector("#output");
function render(list=events){output.innerHTML=list.map(event=>'<article class="event"><h3>'+event.name+'</h3><p>'+event.category+' - Seats: '+event.seats+'</p></article>').join("");}
function addEvent(name,category){events.push({name,category,seats:10,date:"2026-09-01"});render();}
function registerUser(eventName){const event=events.find(item=>item.name===eventName);if(!event||event.seats<=0)throw new Error("Registration unavailable");event.seats-=1;render();}
function filterEventsByCategory(category,callback=render){callback([...events].filter(event=>event.category===category));}
class CommunityEvent{constructor(name,seats){this.name=name;this.seats=seats}checkAvailability(){return this.seats>0}}
document.querySelector("#filter").addEventListener("change",event=>filterEventsByCategory(event.target.value));
document.querySelector("#search").addEventListener("keydown",event=>{if(event.key==="Enter")render(events.filter(item=>item.name.toLowerCase().includes(event.target.value.toLowerCase())))});
document.querySelector("#registerForm").addEventListener("submit",async event=>{event.preventDefault();const form=event.currentTarget;if(!form.elements.email.value.includes("@")){document.querySelector("#message").textContent="Enter a valid email.";return}document.querySelector("#message").textContent="Submitting...";await new Promise(resolve=>setTimeout(resolve,400));document.querySelector("#message").textContent="Registered "+form.elements.fullName.value+" for "+form.elements.eventName.value});
document.querySelector("#load").addEventListener("click",async()=>{const response=await fetch("data/events.json");const data=await response.json();output.innerHTML=data.map(item=>'<p>'+item.name+' in '+item.city+'</p>').join("")});
console.log("Welcome to the Community Portal",Object.entries(new CommunityEvent("Demo",3)));
render();
