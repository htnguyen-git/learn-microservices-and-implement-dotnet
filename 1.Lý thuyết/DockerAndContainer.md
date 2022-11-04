# DockerAndContainer
## Docker là gì
- Là open source platform
- Building, deploying, running, shipping app trên các container
- Run anywhere : local, cloude, window, linux...

## Docker container, image và registries
- Docker container = codebase + dependencies.
- Image là một static representation của app với các config và dependencies
- Khi run app : image -> docker container
- Registry : Nơi lưu trữ của docker image
- Local registry, public registry : Docker Hub, Azure Container Registry
- Developer có thể publish một docker image lên public registry
- Developer có thể lấy về một docker image từ public registry

## Sử dụng khi nào
- Triển khai microserivces
- Khi cần scale ứng dụng một cách linh hoạt
- Chỉ cần config một lần để chạy nhiều nơi
