const hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/chat")
    .build();

hubConnection.on("Send", sendFunc);

hubConnection.on("ConnectedMessages", function (comments) {
    for (let i = 0, l = comments.length; i < l; i++) {
        sendFunc(comments[i].text, comments[i].userName, comments[i].date);
    }
});

const btns = document.querySelectorAll('button[id^=but]')
btns.forEach(btn => {
    btn.addEventListener('click', event => {
        var postId = +$('input[name="PostId"]').val();
        var message = $('textarea#messageZone').val();
        hubConnection.invoke("Send", postId, message);
    });
});

function sendFunc(message, userName, date) {

    let elem = document.createElement("p");
    elem.appendChild(document.createTextNode(message));

    let div1 = document.createElement("div");
    div1.classList.add('d-flex');

    let div2 = document.createElement("div");
    div2.classList.add('flex-shrink-0');

    let img = document.createElement("img");
    img.classList.add('rounded-circle');
    img.src = "https://dummyimage.com/50x50/ced4da/6c757d.jpg";

    let div3 = document.createElement("div");
    div3.classList.add('ms-3');

    let div4 = document.createElement("div");
    div4.classList.add('fw-bold');
    div4.innerHTML = userName;

    div1.appendChild(div2);
    div2.appendChild(img);
    div1.appendChild(div3);
    div3.appendChild(div4);
    div3.appendChild(elem);

    let firstElem = document.getElementById("chatroom").firstChild;
    document.getElementById("chatroom").insertBefore(div1, firstElem);
}


hubConnection.start();