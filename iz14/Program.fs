open System
open System.Drawing
open System.IO
open System.Windows.Forms

let window = new Form()

let button = new System.Windows.Forms.Button()
let text_box = new System.Windows.Forms.RichTextBox()
let answer_box = new System.Windows.Forms.TextBox()
let answer_text = new System.Windows.Forms.Label()
let task = new System.Windows.Forms.Label()

window.Text <- "Задача 14"
window.Controls.Add(task)
window.Controls.Add(text_box)
window.Controls.Add(button)
window.Controls.Add(answer_text)
window.Controls.Add(answer_box)

task.Text <- "Введите текст:"
task.Dock <- System.Windows.Forms.DockStyle.Top
task.TextAlign <- System.Drawing.ContentAlignment.MiddleCenter

text_box.Width <- 250
text_box.Height <- 150
text_box.Top <- 25
text_box.Left <- 15

button.Text <- "Рассчитать"
button.Top <- 220
button.Left <- 190

answer_text.Text <- "Среднее количество знаков препинания"
answer_text.TextAlign <- System.Drawing.ContentAlignment.MiddleRight
answer_text.Top <- 185
answer_text.Width <- 160
answer_text.Left <- 0

answer_box.Top <- 187
answer_box.Left <- 165


let rec get_num (sentence : char[]) len i x = 
    if i = len then x
    else 
        if sentence.[i] = ',' || sentence.[i] = '-' || sentence.[i] = ':' || sentence.[i] = ';' then
            get_num sentence len (i + 1) (x + 1) 
        else 
            get_num sentence len (i + 1) x 

let rec sum (list : string[]) len i x = 
    if i = len then x
    else 
        sum list len (i + 1) (x + get_num (list.[i].ToCharArray()) (list.[i].Length) 0 0)

let get_answer evArgs=
    let text = text_box.Text.Split ('.', '!', '?')
    let len = text.Length
    answer_box.Text <- String.Format("{0}", (float(sum text len 0 0) / float(len)))


let _ = button.Click.Add(get_answer)

Application.Run(window)