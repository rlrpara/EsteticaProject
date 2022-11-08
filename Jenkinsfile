pipeline {
    agent any
    
    stages {
        stage ('Build Image'){
            stage('Clear Project'){
            steps { bat 'dotnet clean --configuration Release' }
            }
            stage('Restore Nuget'){
                steps { bat 'dotnet restore Conversor.sln -r win-x64' }
            }
        }
    }
}