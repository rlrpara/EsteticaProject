pipeline {
    agent any
    
    stages {
        stage ('Build Image'){
            steps {
                script {
                    dockerapp = docker.build("rlrpara/VendaFacilProject", '-f ./src/VendaFacil.Api/Dockerfile ./src')
                }
            }
        }
    }
}