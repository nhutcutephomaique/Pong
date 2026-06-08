Pong (Unity)
=================

Mô tả
-----

Phiên bản đơn giản của trò chơi Pong dùng Unity. Hai người chơi điều khiển hai thanh cố gắng chặn quả bóng và ghi điểm khi đối phương để bóng đi qua.

Cách chơi
---------

- Người chơi trái (Player 1): dùng phím `W` (lên) và `S` (xuống).
- Người chơi phải (Player 2): dùng phím `Up Arrow` (lên) và `Down Arrow` (xuống).
- Mỗi lần bóng chạm vào vùng ghi điểm của đối phương thì người kia được +1.
- Trò chơi có thể được thiết lập để hết ván ở một số điểm nhất định (tùy vào logic trong `GameManager`).

Mở và chạy project
--------------------

1. Mở Unity Hub và chọn `Add` → chọn thư mục dự án `Pong` (chứa `Assets/`, `ProjectSettings/`).
2. Mở dự án trong Unity Editor (phiên bản tương thích được lưu trong `ProjectSettings/ProjectVersion.txt`).
3. Mở scene `Assets/Scenes/SampleScene.unity` và nhấn Play.

Lưu ý quan trọng
----------------

- Nếu có lỗi liên quan đến script names, chắc chắn rằng tên file .cs trùng với tên class public bên trong (ví dụ `ScoreText.cs` chứa `public class ScoreText`).
- Gán tham chiếu trong Inspector: kéo đối tượng `scoreText` vào các trường `scoreTextLeft` / `scoreTextRight` của `GameManager`.

Điều khiển và cấu trúc dự án
----------------------------

- Thư mục chính: `Assets/` chứa script, prefab và Scene.
- Script chính: `Assets/GameManager.cs`, `Assets/script/Ball.cs`, `Assets/script/ScoreText.cs`.

Muốn chỉnh sửa
---------------

- Thay đổi điểm tối đa hoặc logic ván thắng trong `GameManager.cs`.
- Thay giao diện số điểm bằng cách sửa `ScoreText` hoặc thay prefab `scoreText.prefab`.

Credits
-------

Project mẫu: Người tạo dự án ban đầu.

Liên hệ
-------

Nếu cần trợ giúp thêm, gửi mô tả lỗi hoặc ảnh console Unity.
