const div_body = document.querySelector("#today-tasks");

window.addEventListener("DOMContentLoaded", () => {
    fetch("/Index?handler=Data")
        .then(res => res.json())
        .then(data => {
            data.forEach(item => {
                const tr = document.createElement("tr");
                tr.id = item.id;

                // Title cell
                const td_title = document.createElement("td");
                td_title.textContent = item.title;
                td_title.dataset.taskId = item.id;
                td_title.setAttribute("data-label", "Title");

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
                tr.appendChild(td_tasks);

                // Add completed style if task is done
                if (item.isChecked) {
                    tr.classList.add("completed");
                }

                // Add row to table
                div_body.appendChild(tr);
            });
        });
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
        .then(data => console.log(data))
        .catch(err => console.error("Error:", err));
    title.value = "";
    date_input.value = "";
});


document.querySelector(".done").addEventListener("click", () => {
    fetch("/Index?handler=Edit", {
        method: "PATCH",
        headers: {
            'Content-Type':'application/json'
        },
        body: JSON.stringify()
    });
});