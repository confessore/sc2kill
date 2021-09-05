pipeline {
    agent any
    stages {
        stage("build") {
            steps {   
                echo 'building...'
                script {
                    def test = 2 + 2 > 3 ? 'cool' : 'not cool'
                    echo test
                }
            }
        }
        stage("test") {
            steps {
                echo 'testing...'
            }
        }
        stage("deploy") {
            steps {
                echo 'deploying...'
            }
        }
    }
}
