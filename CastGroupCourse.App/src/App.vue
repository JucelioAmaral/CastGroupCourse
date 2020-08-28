<template>
  <div id="app">
    <nav>
      <div class="nav-wrapper blue darken-1">
        <a href="#" class="brand-logo center">Category</a>
      </div>
    </nav>

    <div class="container">
      <ul>
        <li v-for="(erro, index) of errors" :key="index">
          campo
          <b>{{erro.field}}</b>
          - {{erro.defaultMessage}}
        </li>
      </ul>

      <table>
        <thead>
          <tr>
            <th>Id</th>
            <th>Description</th>
          </tr>
        </thead>

        <tbody>
          <tr v-for="category of categorys" :key="category.id">
            <td>{{ category.id }}</td>
            <td>{{ category.description }}</td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script>
import Category from "./services/category";

export default {
  name: "app",
  data() {
    return {
      category: {
        id: "",
        description: "",
      },
      categorys: [],
      errors: [],
    };
  },

  mounted() {
    this.listar();
  },

  methods: {
    listar() {
      Category.listar()
        .then((resposta) => {
          this.categorys = resposta.data;
        })
        .catch((e) => {
          console.log(e);
        });
    },

    salvar() {
      if (!this.category.id) {
        Category.salvar(this.category)
          .then((resposta) => {
            this.category = {};
            alert("Cadastrado com sucesso!");
            this.listar();
            this.errors = {};
          })
          .catch((e) => {
            this.errors = e.response.data.errors;
          });
      } else {
        Category.atualizar(this.category)
          .then((resposta) => {
            this.category = {};
            this.errors = {};
            alert("Atualizado com sucesso!");
            this.listar();
          })
          .catch((e) => {
            this.errors = e.response.data.errors;
          });
      }
    },

    editar(category) {
      this.category = category;
    },

    remover(category) {
      if (confirm("Deseja excluir o categoria?")) {
        Category.apagar(category)
          .then((resposta) => {
            this.listar();
            this.errors = {};
          })
          .catch((e) => {
            this.errors = e.response.data.errors;
          });
      }
    },
  },
};
</script>

<style>
</style>
