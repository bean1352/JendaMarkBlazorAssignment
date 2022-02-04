using JendamarkBlazorAssignment.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JendamarkBlazorAssignment.Data
{
    public class OperationService
    {
        string[] operationNames = { "Steel Operation", "Welding Operation", "Surgical Operation", "Build Operation",
                            "Assemble Operation" };
        public string[] deviceNames = { "HP", "LG", "Samsung", "Apple", "Motorolla" };

        private List<byte[]> GetImages()
        {
            string[] imageNames = { "steel.png", "welding.png", "surgery.png", "build.png", "assemble.png"};

            string workingDirectory = Environment.CurrentDirectory;

            List<byte[]> list = new();

            for (int i = 0; i < imageNames.Length; i++)
            {
                list.Add(File.ReadAllBytes($"{workingDirectory}\\Images\\{imageNames[i]}"));
            }

            return list;
        }

        public Task<Operation[]> GetOperationAsync()
        {
            List<byte[]> imageList = GetImages();

            var rng = new Random();
            return Task.FromResult(Enumerable.Range(0, 4).Select(index => new Operation
            {
                OperationID = Guid.NewGuid(),
                Name = operationNames[index],
                Device = new Device() { Name = deviceNames[index], DeviceID = Guid.NewGuid(), DeviceType = DeviceType.Camera},
                OrderInWhichToPerform = index,
                ImageData = imageList[index],
                ImageDataUrl = string.Format("data:image/jpeg;base64,{0}", Convert.ToBase64String(imageList[index]))
            }).ToArray());
        }
    }
}
