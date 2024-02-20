// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//Códigos do CEP
function limpa_formulário_cep() {
    //Limpa valores do formulário de cep.
    document.getElementById('rua').value = ("");
    document.getElementById('estado').value = ("");
    document.getElementById('cidade').value = ("");
}

function meu_callback(conteudo) {
    if (!("erro" in conteudo)) {
        //Atualiza os campos com os valores.
        document.getElementById('rua').value = (conteudo.logradouro);
        document.getElementById('estado').value = (conteudo.uf);
        document.getElementById('cidade').value = (conteudo.localidade);
    } //end if.
    else {
        //CEP não Encontrado.
        limpa_formulário_cep();
        alert("CEP não encontrado.");
    }
}

function VerificarCep() {
    let CEP = document.getElementById("CEP").value;

    CEP = CEP.replace(/\D/g, '');

    //Verifica se campo cep possui valor informado.
    if (CEP != "") {
        //Expressão regular para validar o CEP.
        let validacep = /^[0-9]{8}$/;
        //Valida o formato do CEP.
        if (validacep.test(CEP)) {
            //Preenche os campos com "..." enquanto consulta webservice.
            document.getElementById('rua').value = "...";
            document.getElementById('estado').value = "...";
            document.getElementById('cidade').value = "...";

            //Cria um elemento javascript.
            var script = document.createElement('script');

            //Sincroniza com o callback.
            script.src = 'https://viacep.com.br/ws/' + CEP + '/json/?callback=meu_callback';

            //Insere script no documento e carrega o conteúdo.
            document.body.appendChild(script);
        } else {
            //cep é inválido.
            limpa_formulário_cep();
            alert("Formato de CEP inválido.");
        }
    } else {
        //cep sem valor, limpa formulário.
        limpa_formulário_cep();
    }

    console.log(CEP)

}


document.getElementById("ClienteNome").addEventListener('keyup', function () {
    this.value = this.value.replace(/[0-9]*/g, '');
})

document.getElementById("ClienteTelefone").addEventListener('keyup', function () {
    this.value = this.value.replace(/[A-z]*/g, "");

})

document.getElementById("ClienteCpf").addEventListener('keyup', function () {
    this.value = this.value.replace(/[A-z]*/g, "");
})

document.getElementById("ClienteCpf").addEventListener('blur', function () {

    const cpf = this.value.split("").map((e) => parseInt(e));
    const cpfValido = validarCpf(cpf);


})




//Esta função valida o primeiro dígito verificador do CPF.
function validarPrimeiroDigito(cpf) {
    /**Para cada dígito, ele multiplica o dígito pelo peso correspondente (10 - posição) e adiciona o resultado a numero.
     * Calcula o resto da divisão por 11 do produto de numero por 10.
     * Se o resto for menor que 10, ele compara com o 10º dígito do CPF para validar o primeiro dígito verificador. Se forem iguais, retorna verdadeiro; caso contrário, retorna falso. */
    let numero = 0;
    for (let i = 0; i < 9; i++) {
        numero += cpf[i] * (10 - i);
    }
    const resto = (numero * 10) % 11;
    if (resto < 10) {
        return cpf[9] == resto;
    }
    return cpf[9] == 0;
}

//Esta função valida o segundo dígito verificador do CPF de maneira semelhante à função anterior, mas considera todos os 10 primeiros 
function validarSegundoDigito(cpf) {
    /**
     * Se algum dígito for diferente do primeiro, a variável diferente se torna verdadeira.
     * Se todos os dígitos forem iguais, diferente permanece falso.
     */
    let numero = 0;
    for (let i = 0; i < 10; i++) {
        numero += cpf[i] * (11 - i);
    }
    const resto = (numero * 10) % 11;
    if (resto < 10) {
        return cpf[10] == resto;
    }
    return cpf[10] == 0;
}

//Esta função verifica se todos os dígitos do CPF são iguais.
function validarRepetido(cpf) {
    const primeiro = cpf[0];
    let diferente = false;
    for (let i = 1; i < cpf.length; i++) {
        if (cpf[i] != primeiro) {
            diferente = true;
        }
    }
    return diferente;
}

// Esta função é a função principal que chama as funções anteriores para validar um CPF completo.
function validarCpf(cpf) {
    if (cpf.length != 11) {
        window.alert("CPF inválido!")
        this.value = ("")
        return;
    }
    if (!validarRepetido(cpf)) {
        window.alert("CPF inválido!")
        this.value = ("")
        return;
    }
    if (!validarPrimeiroDigito(cpf)) {
        window.alert("CPF inválido!")
        this.value = ("")
        return;
    }
    if (!validarSegundoDigito(cpf)) {
        window.alert("CPF inválido!")
        this.value = ("")
        return;
    }
    return true;
}



