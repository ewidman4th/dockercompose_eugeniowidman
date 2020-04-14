PRE
docker pull mysql

MANUAL
docker volume create session7_1
docker run --name database_container -e MYSQL_RANDOM_ROOT_PASSWORD=yes -e MYSQL_DATABASE=racketsdb -e MYSQL_USER=test -e MYSQL_PASSWORD=123456 -v session7_1:/var/lib/mysql -p 3018:3306 -d mysql

docker build -f "C:\Users\eugenio.widman\source\repos\dockertraining_compose_eugeniowidman\dockertraining_compose_eugeniowidman\Dockerfile" --force-rm -t dockercompose_eugeniowidman "C:\Users\eugenio.widman\source\repos\dockertraining_compose_eugeniowidman"
docker run --name dockercompose_app -p 8086:80 -e ConnectionStrings:RacketDB="Server=database_container;Port=3018;Database=racketdb;Uid=test;Pwd=123456" --link database_container -it dockercompose_eugeniowidman

REMOVE
docker ps
docker stop <containers ids>
docker ps -a
docker rm <containers ids>

COMPOSE
docker-compose up
Note-> API will fail since DB delays to start, after DB is ready, start API again