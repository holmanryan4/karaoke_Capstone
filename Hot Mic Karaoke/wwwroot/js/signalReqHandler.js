var connection = new signalR.HubConnectionBuilder()
    .withUrl('/Home/MessagerIndex')
    .build();

connection.on('receiveMessage', addmessageToChat);

connection.start()
    .catch(error => {
        console.error(error.message);
    });

function sendmessageToHub(message) {
    connection.invoke('sendMessage', message)
}