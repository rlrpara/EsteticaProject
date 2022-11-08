pipeline {
    agent any
    
    stages {
        stage ('Build Image'){
            steps {
                script {
                    dockerapp = docker.build("src/VendaFacil.Api", '-f ./src/Dockerfile ./src')
                }
            }
        }
    }
}