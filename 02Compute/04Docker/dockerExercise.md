# Docker Exercise

## Exercise One
Take one of your interactive applications such as Hangman or shellscript project, and dockerize it
1. Write your dockerfile
2. Build the image from dockerfile with the name your-dockerhub-username/image-name:tag-name
3. Push the image to docker hub
4. Ask one of your peers to pull your image and see if they can run it

## Exercise Two
1. Refactor your dockerfile in Exercise One to multistage build (see if you can just use the runtime)
2. Push this to dockerhub with a different tag
3. Write a github actions workflow that will run on push to a branch which will build the docker image from the dockerfile, and push that resulting image to dockerhub

Optional (but recommended) : Get it to deploy all the way to Azure resource (Azure App Service, Azure Container Instance, etc.) in the pipeline

4. If you haven't done the optional step, in your vm, install docker and pull the published image, and run your image