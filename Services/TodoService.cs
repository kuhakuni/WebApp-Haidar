using WebApp.Models;
using WebApp.Helpers;
using System.Net.Http.Json;
namespace WebApp.Services;

public class TodoService
{
	HttpClient _client;

	public TodoService(HttpClient client)
	{
		_client = client;
		_client.BaseAddress = Configuration.BaseUrl;
        }

    public async Task AddTodo(Todo todo)
	{
		var response = await _client.PostAsJsonAsync("todo", todo);
        response.EnsureSuccessStatusCode();
    }

	public async Task AddTodoDetail(TodoDetail todoDetail)
	{
		throw new NotImplementedException();
	}

	public async Task DeleteTodo(string todoId)
	{
		var response = await _client.DeleteAsync($"todo?todoId={todoId}");
        response.EnsureSuccessStatusCode();
    }

	public async Task<TodoDetail> DeleteTodoDetail(int id)
	{
		throw new NotImplementedException();
	}

	public async Task<Todo> GetTodoById(string todoId)
	{
		var response = await _client.GetFromJsonAsync<Todo>($"todo/{todoId}");
        return response;
    }

	public Task<TodoDetail> GetTodoDetailById(int id)
	{
		throw new NotImplementedException();
	}

	public Task<List<TodoDetail>> GetTodoDetails(string todoId)
	{
		throw new NotImplementedException();
	}

	public async Task<List<Todo>> GetTodos()
	{
        var response = await _client.GetFromJsonAsync<List<Todo>>("todo?pageNumber=1&pageSize=1000");
		return response;

    }

	public async Task<Todo> UpdateTodo(Todo todo)
	{
		throw new NotImplementedException();
	}

	public async Task<TodoDetail> UpdateTodoDetail(TodoDetail todoDetail)
	{
		throw new NotImplementedException();
	}
}
