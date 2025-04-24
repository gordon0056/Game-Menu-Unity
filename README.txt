ENG
Technical designer assignment:
1. Prepare graphics based on the .psd file for insertion into the project, merge layers, overlays and effects.
2. Assemble the scene in Unity based on the .psd file (using it as a layout). The target device is iPhone 11.

Conditions:
- make the buttons clickable, with bounce animation.
- when inactive for more than 3 seconds, a particle effect appears on the buttons.
- when pressing the buttons, use the sound from the attached audio file, a fragment of the fifth second
- optimize graphics for iPhone 11.

Description of the task stages:
1. In Adobe Photoshop, layers and effects were merged and all texts and symbols were removed. Afterwards, the objects were exported to the prepared Textures folder in .PNG format.
2. A project was created in Unity on version 2021.3.13f1, configured for the iOS system, and atlases for images were added.
3. Added a canvas containing the background, a main pop-up window with an image of a crowded stack of chips, a “close” button, a “give up” button, a “continue” button, a pop-up window for “continue” bonuses.
4. A font folder was created, fonts were transferred and adapted for this project. Created shortcuts and objects that store text for each window and each button. A script has been written for the header of the main window (it tends to fall off, but it is enough to reconnect it in this case) which bends the text. An outline has been created for the text in those places where it is needed.
5. Added bounce animations for all buttons via the animation controller via the Scale parameter.
The Sound folder has been created and the sound required for pressing a button in Audacity has been processed. Added a sound component to the buttons for each object.
6. An animation of the particle system has been created, as well as a script for the timer when pressed. Changed the Clear Flags camera parameter from Skybox to Don’t Clear due to incorrect display of particle animation.
7. Created a Horizontal Layout Group for the “give up” and “continue” buttons so that the objects located on them move by a certain distance in pixels. And for the window with bonuses, a Grid Layout was created and the sprite was separately processed for expansion in case the variety is replenished with bonuses. Prefabs have also been created for these objects for editing changes.
8. A script was prepared and a config was created to edit the price value and quantity of bonuses, as well as items in the pop-up window, the parameters of the windows in which the text for translation is located were checked and adjusted.
9. A repository for this project was created and uploaded to it.

RU
Задание на технического дизайнера:
1. Подготовить для вставки в проект графику на основе .psd файла, слить слои,  наложения и эффекты.
2. Собрать сцену в Unity на основе .psd файла (используя как макет).  Целевое устройство - IPhone 11.

Условия:
- кнопки сделать нажимаемыми, с анимацией баунса.
- при бездействии более 3 секунд - на кнопках поялвяется эффект с частицами.
- принажатии на кнопки использовать звук из приложенного аудиофайла, фрагмент пятой секунды
- оптимизировать графику для IPhone 11.

Описание выполнения этапов задания:
1.В программе adobe photoshop были слиты слои, эффекты и убраны все тексты и символы. После объекты были экспортированы в заготовленную папку Textures в формате .PNG.
2. Создан проект в Unity на версии 2021.3.13f1 настроен на систему iOS, добавлены атласы для изображений.
3. Добавлен холст, на котором находится бэкграунд, основное всплывающее окно с изображением переполненного стека фишек, кнопка «закрыть», кнопка «сдаться», кнопка «продолжить», всплывающее окно для бонусов «продолжить».
4. Создана папка шрифтов, перенесены и адаптированы шрифты для данного проекта. Созданы ярлыки и объекты, в которых хранится текст для каждого окна и каждой кнопки. Написан скрипт для шапки основного окна (имеет свойство отваливаться, однако его достаточно переподключить в таком случае) который изгибает текст. Создана обводка для текста в тех местах, где она необходима.
5. Добавлены анимации баунса для всех кнопок через контроллер анимации через параметр Scale.
Создана папка Sound и обработан звук необходимый для нажатия кнопки в программе Audacity. Добавлен компонент для звука в кнопки для каждого объекта.
6. Создана анимация частиц particle system, а также скрипт для таймера при нажатии. Изменён параметр камеры Clear Flags с Skybox на Don’t Clear в связи некорректным с отображением анимации частиц.
7. Созданы Horizontal Layout Group для кнопки «сдаться» и «продолжить», чтобы объекты, находящиеся на них, сдвигались на определённое расстояние в пикселях. А для окна с бонусами создан Grid Layout и отдельно обработан спрайт для расширения в случае пополнения разнообразия бонусами. Создан также Prefabs для данных объектов для редактирования изменений.
8. Подготовлен скрипт и создан конфиг для редактирования значения цены и количества бонусов, а также предметов в всплывающем окне, проверены и отрегулированы параметры окон, в которых находится текст для перевода.
9. Создан репозиторий для данного проекта и выгружен в него. 
