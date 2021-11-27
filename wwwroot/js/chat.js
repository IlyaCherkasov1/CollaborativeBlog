const hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/chat")
    .build();
var postId = +$('input[name="PostId"]').val();

hubConnection.on("Send", sendFunc);

hubConnection.on("LoadMessage", function (comments) {
   
    for (let i = 0, l = comments.length; i < l; i++) {
        sendFunc(comments[i].text, comments[i].userName, comments[i].date);
    }
});


const btns = document.querySelectorAll('button[id^=but]')
btns.forEach(btn => {
    btn.addEventListener('click', event => {
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

    let chatRoomDiv = document.getElementById("chatroom");
    let firstElem = chatRoomDiv.firstChild;

    if (firstElem !== null) {
        let lastElem = chatRoomDiv.lastChild;
        chatRoomDiv.insertBefore(div1, lastElem.nextSibling);
    }
    else {
        chatRoomDiv.insertBefore(div1, firstElem);
    }
}

function insertAfter(newNode, referenceNode) {
    referenceNode.parentNode.insertBefore(newNode, referenceNode.nextSibling);
}

hubConnection.start().then(function () {
  
    hubConnection.invoke("LoadMessage", postId);
}).catch(function (err) {
    return console.error(err.toString());
});

