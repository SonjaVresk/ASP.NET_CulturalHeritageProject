const questions = [
    {
        question: "Mogao Caves, a UNESCO World Heritage Site, is located in which country?",
        answers: [
            { text: "Vietnam", correct: false },
            { text: "China", correct: true },
            { text: "India", correct: false },
            { text: "Mongolia", correct: false }
        ]
    },
    {
        question: "Paphos district, Aphrodite's mythical birthplace, is located in which country?",
        answers: [
            { text: "Greece", correct: false },
            { text: "Turkey", correct: false },
            { text: "Cyprus", correct: true },
            { text: "Malta", correct: false }
        ]
    },
    {
        question: "Nubian Monuments are located in which country?",
        answers: [
            { text: "Cyprus", correct: false },
            { text: "Turkey", correct: false },
            { text: "Greece", correct: false },
            { text: "Egypt", correct: true }
        ]
    },
    {
        question: "Chartres Cathedral is located in which country?",
        answers: [
            { text: "Belgium", correct: false },
            { text: "France", correct: true },
            { text: "Luxemburg", correct: false },
            { text: "Germany", correct: false }
        ]
    },
    {
        question: "Historic City of Yazd is located in which country?",
        answers: [
            { text: "Iraq", correct: false },
            { text: "Iran", correct: true },
            { text: "Syria", correct: false },
            { text: "Jordan", correct: false }
        ]
    }
];

const questionElement = document.getElementById("question");
const answerButtons = document.getElementById("answer-buttons");
const nextButton = document.getElementById("next-btn");

let currentQuestionIndex = 0;
let score = 0;

function startQuiz() {
    currentQuestionIndex = 0;
    score = 0;
    nextButton.innerHTML = "Next";
    showQuestion();
}

function showQuestion() {
    resetState();
    let currentQuestion = questions[currentQuestionIndex];
    let questionNo = currentQuestionIndex + 1;
    questionElement.innerHTML = questionNo + ". " + currentQuestion.question;

    currentQuestion.answers.forEach(answer => {
        const button = document.createElement("button");
        button.innerHTML = answer.text;
        button.classList.add("btn");
        answerButtons.appendChild(button);
        if (answer.correct) {
            button.dataset.correct = answer.correct;
        }
        button.addEventListener("click", selectAnswer);
    })
}

function resetState() {
    nextButton.style.display = "none";
    while (answerButtons.firstChild) {
        answerButtons.removeChild(answerButtons.firstChild);
    }
}

function selectAnswer(e) {
    const selectedBtn = e.target;
    const isCorrect = selectedBtn.dataset.correct === "true";

    console.log('Selected:', selectedBtn.textContent, 'Is Correct:', isCorrect);

    if (isCorrect) {
        selectedBtn.classList.add("correct");
        score++;
    } else {
        selectedBtn.classList.add("incorrect");

        const correctBtn = Array.from(answerButtons.children).find(button => button.dataset.correct === "true");
        if (correctBtn) {
            correctBtn.classList.add("correct");
        }
    }

    Array.from(answerButtons.children).forEach(button => {
        button.disabled = true;
    });

    nextButton.style.display = "block";
}


function showScore() {
    resetState();
    questionElement.innerHTML = `You scored ${score} out of ${questions.length}!`;
    nextButton.innerHTML = "Play Again";
    nextButton.style.display = "block";
}

function handleNextButton() {
    currentQuestionIndex++;
    if (currentQuestionIndex < questions.length) {
        showQuestion();
    } else {
        showScore();
    }
}


nextButton.addEventListener("click", () => {
    if (currentQuestionIndex < questions.length) {
        handleNextButton();
    } else {
        startQuiz();
    }
});

startQuiz();