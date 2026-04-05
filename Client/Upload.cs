using WPF.Common;

public class UploadClient : AppClientBase
{
	private const string BASE = "api/upload";

	public Task<ApiResult<string>> UploadImage(string filePath, string folder)
	{
		var url = $"{BASE}/image";
		return PostImageAsync(url, filePath, folder);
	}
}