# Сериализация Ссылок на Сцены в Unity

![image](https://github.com/RimuruDev/Unity-SerializationSceneInEditor/assets/85500556/6bdfb05f-3a30-4f70-b97c-39087e27c904)
![image](https://github.com/RimuruDev/Unity-SerializationSceneInEditor/assets/85500556/5b4d554f-bc5d-4405-aaba-7c2c02919c1c)

## Описание
Данный проект представляет собой утилиту для Unity, позволяющую удобно сериализовать ссылки на сцены в инспекторе. Это достигается за счет использования пользовательского редактора, который облегчает выбор и хранение сцен в проекте Unity.

## Как использовать
- Добавьте скрипт `SceneReference` к GameObject в вашей сцене Unity.
- В инспекторе вы увидите поле `Scene`, в которое можно перетащить файл сцены из вашего проекта.
- Скрипт автоматически сохранит путь к сцене в свойстве `SceneName`.
- Вы можете использовать это свойство в своих скриптах для загрузки или других действий со сценами.

```csharp
SceneManager.LoadScene(sceneRef.SceneName); // К примеру вот так.
```

## Применение
Этот инструмент полезен в случаях, когда требуется ссылаться на конкретные сцены в вашем проекте Unity, но не хочется хранить их названия или пути в виде строк. Он обеспечивает удобный и безопасный способ сериализации этих ссылок и их последующего использования в игре.

## Контакты
- **Email**: rimuru.dev@gmail.com
- **GitHub**: [RimuruDev](https://github.com/RimuruDev)
- **LinkedIn**: [rimuru](https://www.linkedin.com/in/rimuru/)
- **GitHub Организации**: [Rimuru-Dev](https://github.com/Rimuru-Dev)

---

**Примечание**: Данный инструмент был разработан для использования пользователем [GammaSnaplight](https://github.com/GammaSnaplight) и поддерживается RimuruDev.

---
