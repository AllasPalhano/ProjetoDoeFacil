document.getElementById("formCadastro").addEventListener("submit", async function (e) {
    e.preventDefault();

    const usuario = {
        nome: document.getElementById("cadNome").value.trim(),
        email: document.getElementById("cadEmail").value.trim(),
        senha: document.getElementById("cadSenha").value.trim(),
        telefone: document.getElementById("cadTelefone").value.trim(),
        endereco: document.getElementById("cadEndereco").value.trim(),
        cpfCnpj: document.getElementById("cadCpfCnpj").value.trim(),
        tipoPessoa: document.getElementById("cadTipoPessoa").value,
    };

    try {
        const response = await fetch("https://localhost:7048/api/usuario/cadastrar", {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(usuario),
        });

        if (!response.ok) {
            const error = await response.json();
            alert("Erro: " + error.mensagem);
            return;
        }

        alert("Cadastro realizado com sucesso!");
        window.location.href = "login.html"; // redireciona para login
    } catch (err) {
        alert("Erro ao conectar com o servidor.");
    }
});
