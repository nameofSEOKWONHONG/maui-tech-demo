using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday.MobileApplication.Services
{
    /// <summary>
    /// OCR에 필요한 사진 파일 업로드 및 해석 데이터 서버 전송
    /// </summary>
    public partial class OcrService : ObservableObject
    {
        private const string NCP_OCR_URI = "";
        private readonly HttpClient _httpClient;
        public OcrService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(NCP_OCR_URI);
        }

        /// <summary>
        /// OCR 업로드 및 해당 결과를 반환한다.
        /// </summary>
        /// <returns></returns>
        public async Task OcrStart()
        {

        }

        /// <summary>
        /// 사진은 스토리지로 전송하고, 파일정보와 해석된 OCR 데이터를 서버로 전송한다.
        /// </summary>
        /// <returns></returns>
        public async Task Send()
        {

        }
    }
}
