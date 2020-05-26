open System
open System.Drawing
open System.IO
open System.Windows.Forms

let form = new Form()

let button = new System.Windows.Forms.Button()
let line_edit = new System.Windows.Forms.TextBox()
let list_box = new System.Windows.Forms.ListBox()

form.Width <- 265
form.Height <- 257
form.Text <- "Задача 11"

button.Width <- 220
button.Height <- 25
button.Top <- 40
button.Left <- 15
button.Text <- "Добавить в список"

line_edit.Width <- 220
line_edit.Height <- 20
line_edit.Top <- 15
line_edit.Left <- 15

list_box.Width <- 220
list_box.Height <- 135
list_box.Top <- 70
list_box.Left <- 15

form.Controls.Add(line_edit)
form.Controls.Add(list_box)
form.Controls.Add(button)

let add_item item = 
    list_box.Items.Add(item)

let to_list evArgs = 
    if line_edit.Text = null || line_edit.Text = "" then
        let error = MessageBox.Show("Пустое поле ввода", "Ошибка")
        error |> ignore  
    else 
        add_item(line_edit.Text) |> ignore
    line_edit.Text <- ""

let _ = button.Click.Add(to_list)

Application.Run(form)
    