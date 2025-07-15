const div_body = document.querySelector("#today-tasks");

function loadTask() {
    div_body.innerHTML = "<tr><td colspan='3'>Loading...</td></tr>";

    fetch("/Index?handler=Data")
        .then(res => res.json())
        .then(data => {
            div_body.innerHTML = "";
            data.forEach(item => {
                const tr = document.createElement("tr");

                // Title cell
                const td_title = document.createElement("td");
                td_title.textContent = item.title;
                td_title.dataset.taskId = item.id;
                td_title.setAttribute("data-label", "Title");

                // Date cell
                const td_date = document.createElement("td");
                td_date.textContent = item.date;
                td_date.dataset.taskId = item.id;
                td_date.setAttribute("data-label", "Date")

                // Actions cell
                const td_tasks = document.createElement("td");
                td_tasks.classList.add("actions");
                td_tasks.setAttribute("data-label", "Actions");

                // Done button or status
                if (!item.isCompleted) {
                    const btnDone = document.createElement("button");
                    btnDone.textContent = "✔️ Done";
                    btnDone.className = "done";
                    btnDone.dataset.id = item.id;
                    btnDone.style.backgroundColor = "green";
                    td_tasks.appendChild(btnDone);
                } else {
                    const doneLabel = document.createElement("span");
                    doneLabel.textContent = "✅ Completed";
                    doneLabel.style.color = "#33b249";
                    td_tasks.appendChild(doneLabel);
                }

                // Edit button
                const btnEdit = document.createElement("button");
                btnEdit.textContent = "✏️ Edit";
                btnEdit.className = "edit";
                btnEdit.style.backgroundColor = "#ffbd03";
                btnEdit.dataset.id = item.id;

                // Remove button
                const btnRemove = document.createElement("button");
                btnRemove.textContent = "❌ Remove";
                btnRemove.style.backgroundColor = "red";
                btnRemove.className = "delete";
                btnRemove.dataset.id = item.id;

                // Append buttons
                td_tasks.appendChild(btnEdit);
                td_tasks.appendChild(btnRemove);

                // Append cells to row
                tr.appendChild(td_title);
                tr.appendChild(td_date);
                tr.appendChild(td_tasks);

                // Add row to table
                div_body.appendChild(tr);
            });
        });
}

window.addEventListener("DOMContentLoaded", () => {
    loadTask();
});

document.querySelector("form").addEventListener("submit", (e) => {
    e.preventDefault();
    const title = document.querySelector("#todo-input").value;
    const date_input = document.querySelector("#todo-date").value;
    fetch("/Index?handler=AddItem", {
        method: "POST",
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(
            {
                Title: title,
                date: date_input
            })
    }).then(res => {
        if (!res.ok) throw new Error("Network response was not ok");
        return res.json();
    })
        .then(data => {
            console.log(data);
            loadTask();
        })
        .catch(err => console.error("Error:", err));
    document.querySelector("#todo-input").value = "";
    document.querySelector("#todo-date").value = "";
});


document.getElementById("today-tasks").addEventListener("click", (e) => {
    if (e.target.classList.contains("done")) {
        fetch("/Index?handler=Completed", {
            method: "POST",
            headers: {
                'Content-Type': "application/json"
            },
            body: JSON.stringify(e.target.dataset.id)
        })
            .then(res => {
                if (!res.ok) throw new Error(res.status)
                return res.text()
            }).then(item => {
                console.log(item);
                loadTask();
            })
            .catch(err => console.error(err));
    }
});

document.getElementById("today-tasks").addEventListener("click", (e) => {

});