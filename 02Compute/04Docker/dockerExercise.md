# Docker Exercise

## Exercise One
Take one of your interactive applications such as Hangman or shellscript project, and dockerize it
1. Write your dockerfile
2. Build the image from dockerfile with the name your-dockerhub-username/image-name:tag-name
3. Push the image to docker hub
4. Ask one of your peers to pull your image and see if they can run it

## Exercise Two (Show and Tell Monday 5/8/23)
1. Refactor your dockerfile in Exercise One to multistage build (see if you can just use the runtime)
2. Push this to dockerhub with a different tag
3. Write a github actions workflow that will run on push to a branch which will build the docker image from the dockerfile you have in your repo, and push that resulting image to dockerhub
4. In your vm, install docker and pull the published image, and run your image

Result: You should be able to play hangman or whichever console you containerized in your VM w/o having to install dotnet sdk.

## Optional Exercise
Take Template API project and write a dockerfile + a workflow file to deploy all the way to an Azure resource (Azure App Service, Azure Container Instance, etc.) - this will be fully automated, you shouldn't be changing the image name/tag name manually in Azure Portal.