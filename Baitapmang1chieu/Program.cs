// Bài 1. Nhập và xuất mảng
// Viết chương trình:
// Nhập số phần tử n
// Nhập các phần tử của mảng số nguyên
// Xuất mảng ra màn hình
// Ví dụ
// Nhap n = 5
// 1
// 3
// 5
// 7
// 9
// Mang:
// 1 3 5 7 9
/*Console.WriteLine("Nhap vao so n:");
int soN1 = int.Parse(Console.ReadLine());
int[] arr1 = new int[soN1];
for (int i = 0; i < soN1; i++)
{
    Console.WriteLine($"Nhap gia tri cho phan tu {i+1}:");
    arr1[i] = int.Parse(Console.ReadLine());
}

foreach (int i in arr1)
{
    Console.Write(i+" ");
}
Console.WriteLine();*/
// Bài 2. Tính tổng mảng
// Nhập mảng gồm n số nguyên.
// Tính:
// S = a[0] + a[1] + ... + a[n-1]
/*Console.WriteLine("Nhap vao so n:");
int soN2 = int.Parse(Console.ReadLine());
int[] arr2 = new int[soN2];
for (int i = 0; i < soN2; i++)
{
    Console.WriteLine($"Nhap gia tri cho phan tu {i+1}:");
    arr2[i] = int.Parse(Console.ReadLine());
}
int sumArr2 = 0;
foreach (int i in arr2)
{
    sumArr2 += i;
}
Console.WriteLine("Tong cua mang la: " + sumArr2);*/
// Bài 3. Tính trung bình cộng
// Tính giá trị trung bình của các phần tử trong mảng.
// Ví dụ
// 1 2 3 4 5
// TBC = 3
int[] arr3 = { 1, 2, 3, 4, 5 };
int average = 0;
foreach (int i in arr3)
{
    average += i;
}
average = average / arr3.Length;
Console.WriteLine("Trung binh cac phan tu cua mang la: " + average);
// Bài 4. Đếm số chẵn
// Nhập mảng số nguyên.
// Đếm có bao nhiêu số chẵn.
// Ví dụ
// 1 2 3 4 5 6
// Ket qua: 3
int[] arr4 = { 1, 2, 3, 4, 5 , 6 };
int soChan = 0;
foreach (int i in arr4)
{
    if (i % 2 == 0) soChan++; 
}
Console.WriteLine("So so chan: " + soChan);
// Bài 5. Tìm số lớn nhất
// Tìm phần tử lớn nhất trong mảng.
// Ví dụ
// 5 2 9 7 1
// Max = 9
int[] arr5 = { 5, 2, 9, 7, 1 };
int maxArr5 = arr5[0];
foreach (int i in arr5)
{
    if (maxArr5 < i) maxArr5 = i;
}
Console.WriteLine("So lon nhat la: " + maxArr5);
// Bài 6. Tìm số nhỏ nhất
// Tìm phần tử nhỏ nhất trong mảng.
int[] arr6 = { 5, 2, 9, 7, 1 };
int minArr6 = arr5[0];
foreach (int i in arr6)
{
    if (minArr6 > i) minArr6 = i;
}
Console.WriteLine("So nho nhat la: " + minArr6);
// Bài 7. Tìm vị trí phần tử lớn nhất
// Cho mảng số nguyên.
// Tìm:
// Giá trị lớn nhất
// Vị trí xuất hiện đầu tiên của nó
// Ví dụ
// 2 5 9 1 9
// Max = 9
// Vi tri = 2
int[] arr7 = { 2, 5 , 9, 1, 9 };
int maxArr7 = arr7[0];
int maxIndex = 0;
for (int i = 0; i < arr7.Length; i++)
{
    if (maxArr7 < arr7[i])
    {
        maxArr7 = arr7[i];
        maxIndex = i;
    }
}
Console.WriteLine("Vi tri so lon nhat la: " + maxIndex);
// Bài 8. Tính tổng số dương
// Tính tổng các phần tử > 0.
// Ví dụ
// -1 2 3 -4 5
// Tong = 10
int sumArr8 = 0;
int[] arr8 = { -1, 2, 3, -4, 5 };
foreach (int i in arr8)
{
    if (i > 0)
    {
        sumArr8 += i;
    }
}
Console.WriteLine("Tong cac so duong la: " + sumArr8);
// Bài 9. Đếm số âm
// Đếm số lượng phần tử âm trong mảng.
int[] arr9 = { -1, 2, -3, 4, -5 };
int soAm = 0;
foreach (int i in arr9)
{
    if (i < 0) soAm++;
}
Console.WriteLine("So cac so am la: " + soAm);
// Bài 10. Tìm số chia hết cho 3
// Liệt kê tất cả phần tử chia hết cho 3.
// Ví dụ
// 1 3 6 7 9
// 3 6 9
int[] arr10 = { 1, 3, 6, 7, 9 };
foreach (int i in arr10)
{
    if (i % 3 == 0)
    {
        Console.Write(i+" ");
    }
}
Console.WriteLine();
// Bài 11. Đảo ngược mảng
// Input
// 1 2 3 4 5
// Output
// 5 4 3 2 1
int[] arr11 = { 1, 2, 3, 4, 5 };
for (int i = 0; i < arr11.Length / 2; i++)
{
    int temp = arr11[i];
    arr11[i] = arr11[arr11.Length - i - 1];
    arr11[arr11.Length - i - 1] = temp;
}
foreach (int i in arr11)
{
    Console.Write(i+" ");
}
Console.WriteLine();
// Bài 12. Tính tổng phần tử ở vị trí chẵn
// Tính tổng:
// a[0] + a[2] + a[4] + ...
int [] arr12 = { 1, 2, 3, 4, 5 ,7 , 9 };
int sumArr12 = 0;
for (int i = 0; i < arr12.Length; i++)
{
    if (i % 2 == 0)
    {
        sumArr12 += arr12[i];
    }
}
Console.WriteLine("Tong cac so o vi tri chan la: " + sumArr12);
// Bài 13. Kiểm tra mảng tăng dần
// Kiểm tra mảng có tăng dần hay không.
// Ví dụ
// 1 2 3 4 5
// => Tang dan
// 1 5 3 4
// => Khong tang dan
bool tangDan = true;
int[] arr13 = { 1, 2, 6, 4, 5 };
for (int i = 0; i < arr13.Length - 1; i++)
{
    if (arr13[i + 1] < arr13[i])
    {
        tangDan = false;
        break;
    }
}
Console.WriteLine("Mang tang dan: "+ tangDan);
// Bài 14. Tìm phần tử xuất hiện nhiều nhất
// Ví dụ:
// 1 2 2 3 2 4 4
// Ket qua: 2
// So lan: 3
int [] arr14 = { 1, 2, 2, 3, 2, 4, 4 , 6 };
for (int i = 0; i < arr14.Length; i++)
{
    for (int j = 0; j < arr14.Length - 1 - i; j++)
    {
        if (arr14[j] > arr14[j + 1])
        {
            int temp = arr14[j];
            arr14[j] = arr14[j + 1];
            arr14[j + 1] = temp;
        }
    }
}
int countNum = 0;
int maxCount = 0;
int maxCountValue = 0;
for (int i = 1; i < arr14.Length; i++)
{
    if (arr14[i] == arr14[i - 1])
    {
        countNum++;
    }
    else
    {
        countNum = 1;
    }
    if (countNum > maxCount)
    {
        maxCount = countNum;
        maxCountValue = arr14[i];
    }
}
Console.WriteLine("so lap nhieu nhat la: "+maxCountValue+" so lan lap la: " + maxCount);
// Bài 15. Tìm số nguyên tố trong mảng
// Liệt kê các số nguyên tố.
// Ví dụ
// 1 2 3 4 5 6 7
// 2 3 5 7
int[] arr15 = { 1, 2, 3, 4, 5, 6, 7 };
foreach (int i in arr15)
{
    if (i <= 1) continue;
    bool soNguyenTo = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            soNguyenTo = false;
            break;
        }
    }
    if (soNguyenTo) Console.Write(i+" ");
}
Console.WriteLine();
// Bài 16. Đếm số nguyên tố
// Đếm số lượng số nguyên tố trong mảng.
int [] arr16 = { 1, 2, 3, 4, 5, 6, 7 , 8, 11 };
int countSoNguyenTo = 0;
foreach (int i in arr16)
{
    if (i <= 1) continue;
    bool soNguyenTo = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            soNguyenTo = false;
            break;
        }
    }
    if (soNguyenTo) countSoNguyenTo++;
}
Console.WriteLine("So so nguyen to la: " + countSoNguyenTo);
// Bài 17. Tìm số nguyên tố lớn nhất
// Ví dụ
// 2 7 11 4 5
// Ket qua: 11
int[] arr17 = { 2, 5, 7, 11, 4, 5 };
int soNguyenToMax = -1;
foreach (int i in arr17)
{
    if (i <= 1) continue;
    bool soNguyenTo = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            soNguyenTo = false;
            break;
        }
    }
    if (soNguyenTo && i > soNguyenToMax) soNguyenToMax = i;
}
Console.WriteLine("So so nguyen to lon nhat la: " + soNguyenToMax);
// Bài 18. Tìm số lớn thứ hai
// Ví dụ
// 2 8 5 9 7
// Ket qua: 8
// Không được sắp xếp mảng.
int[] arr18 = { 2, 8, 5 ,9, 7 };
int soNguyenToLN = -1;
int soNguyenToL2 = -1;
foreach (int i in arr18)
{
    if (i <= 1) continue;
    bool soNguyenTo = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            soNguyenTo = false;
            break;
        }
    }
    if (soNguyenTo && i > soNguyenToLN)
    {
        soNguyenToL2 = soNguyenToLN;
        soNguyenToLN = i;
    }
    else if (soNguyenTo &&  i > soNguyenToL2 && i < soNguyenToLN)
    {
        soNguyenToL2 = i;
    }
}
Console.WriteLine("So so nguyen to lon thu hai la: " + soNguyenToL2);
// Bài 19. Chèn phần tử vào cuối mảng
// Nhập thêm số x.
// Xuất mảng sau khi thêm.
/*int [] arr19 = { 2, 5, 7, 11, 4, 5 };
int[] mangDaChen = new int[arr19.Length+1];
Console.WriteLine("Nhap gia tri can chen:");
int giaTriChen = int.Parse(Console.ReadLine());
for (int i = 0; i < arr19.Length; i++)
{
    mangDaChen[i] = arr19[i];
}
mangDaChen[arr19.Length] = giaTriChen;
arr19 =  mangDaChen;
foreach (int i in arr19)
{
    Console.Write(i+" ");
}
Console.WriteLine();*/
// Bài 20. Xóa phần tử tại vị trí k
// Ví dụ
// 1 2 3 4 5
// k = 2
// 1 2 4 5
/*int[] arr20 = { 2, 5, 7, 11, 4, 5 };
int[] mangDaXoa = new int[arr20.Length - 1];
Console.WriteLine("Nhap vi tri can xoa:");
int viTriXoa = int.Parse(Console.ReadLine());
for (int i = 0; i < viTriXoa; i++)
{
    mangDaXoa[i] = arr20[i];
}
for (int i = viTriXoa; i < mangDaXoa.Length; i++)
{
    mangDaXoa[i] = arr20[i+1];
}
arr20 = mangDaXoa;
foreach (int i in arr20)
{
    Console.Write(i+" ");
}
Console.WriteLine();*/
// Bài 21. Sắp xếp tăng dần (Bubble Sort)
// Tự cài đặt Bubble Sort bằng vòng lặp.
// Ví dụ
// 5 1 8 2 4
// 1 2 4 5 8
int [] arr21 = { 5, 1 ,8, 2, 4 };
for (int i = 0; i < arr21.Length; i++)
{
    for (int j = 0; j < arr21.Length - 1 - i; j++)
    {
        if (arr21[j] > arr21[j + 1])
        {
            int temp = arr21[j];
            arr21[j] = arr21[j + 1];
            arr21[j + 1] = temp;
        }
    }
}
foreach (int i in arr21)
{
    Console.Write(i+" ");
}
Console.WriteLine();
// Bài 22. Sắp xếp giảm dần
// Không dùng:
// Array.Sort()
int [] arr22 = { 5, 1 ,8, 2, 4 };
for (int i = 0; i < arr22.Length; i++)
{
    for (int j = 0; j < arr22.Length - 1 - i; j++)
    {
        if (arr22[j] < arr22[j + 1])
        {
            int temp = arr22[j];
            arr22[j] = arr22[j + 1];
            arr22[j + 1] = temp;
        }
    }
}
foreach (int i in arr22)
{
    Console.Write(i+" ");
}
Console.WriteLine();
// Bài 23. Tìm kiếm tuyến tính
// Nhập số x.
// Kiểm tra xem x có trong mảng hay không.
// Ví dụ
// Nhap x = 7
// Co trong mang tai vi tri 3
int[] arr23 = { 5, 1 ,8, 2, 4 };
Console.WriteLine("Nhap vao so nguyen x de kiem tra:");
int soX = int.Parse(Console.ReadLine());
bool coTrongMang = false;
for (int i = 0; i < soX; i++)
{
    if (arr23[i] == soX)
    {
        Console.Write("Co trong mang tai vi tri: "+i);
        coTrongMang = true;
        break;
    }
}
if (!coTrongMang)
{
    Console.WriteLine("So da nhap khong co trong mang");
}
// Bài 24. Xóa tất cả số âm
// Ví dụ
// 1 -2 3 -4 5
// Ket qua:
// 1 3 5
int[] arr24 = { 2, -5, -7, 11, -4, 5 };
int countSoAm = 0;
foreach (int i in arr24)
{
    if (i < 0) countSoAm++;
}
int soPhanTU = 0;
int[] mangDaXoaSoAm = new int[arr24.Length - countSoAm];
for (int i = 0; i < arr24.Length; i++)
{
    if (arr24[i] < 0) continue;
    mangDaXoaSoAm[soPhanTU] = arr24[i];
    soPhanTU++;
}
arr24 = mangDaXoaSoAm;
foreach (int i in arr24)
{
    Console.Write(i+" ");
}
Console.WriteLine();

// Bài 25. Tách mảng chẵn và lẻ
// Input
// 1 2 3 4 5 6
// Output
// Mang chan:
// 2 4 6
// Mang le:
// 1 3 5


// Bài 26. Tìm cặp phần tử có tổng bằng X
// Input
// 1 2 3 4 5
// X = 7
// Output
// 2 + 5 = 7
// 3 + 4 = 7


// Bài 27. Loại bỏ phần tử trùng lặp
// Input
// 1 2 2 3 4 4 5
// Output
// 1 2 3 4 5


// Bài 28. Trộn hai mảng
// Input
// A: 1 2 3
// B: 4 5 6
// Output
// 1 2 3 4 5 6


// Bài 29. Quản lý điểm sinh viên
// Nhập điểm của n sinh viên.
// Yêu cầu:
// 1. Xuất danh sách điểm
// 2. Tính điểm trung bình
// 3. Tìm điểm cao nhất
// 4. Tìm điểm thấp nhất
// 5. Đếm số sinh viên đạt (>= 5)
// 6. Đếm số sinh viên giỏi (>= 8)
// 7. Sắp xếp điểm tăng dần
// 8. Sắp xếp điểm giảm dần


// Bài 30. Phân tích mảng số nguyên
// Viết chương trình thực hiện menu:
// 1. Nhap mang
// 2. Xuat mang
// 3. Tong cac phan tu
// 4. Tim Max
// 5. Tim Min
// 6. Dem so chan
// 7. Dem so le
// 8. Sap xep tang
// 9. Sap xep giam
// 0. Thoat
// Sử dụng:
// while(true)
// {
//     // menu
// }
// Bài này tổng hợp gần như toàn bộ kiến thức:
// Vòng lặp for
// while
// Mảng 1 chiều
// Điều kiện if
// Hàm
// Thuật toán duyệt mảng
// Sắp xếp cơ bản