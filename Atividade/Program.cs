using System;

 namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            int car_verd = 7,
                car_verm = 5,
                car_azul = 12,
                bone_verd = 4,
                bone_verm = 6,
                bone_azul = 5,
                brinq = 0,
                car = 0,
                bone = 0,
                cor = 0,
                soma = 0, 
                azul = 0,
                verde = 0,
                vermelho= 0;

            Console.WriteLine("#####################");
            Console.WriteLine("1 - ");
            if (brinq == car) {
                soma = (car_azul + car_verd + car_verm);
                Console.WriteLine("R - " + soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("2 - ");
            soma = 0;
            if(cor == azul)
            {
                soma = bone_azul + car_azul;
                Console.WriteLine("R - " + soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("3 - ");
            soma = 0;
            verde = 1;
            if (cor != verde)
            {
                soma = bone_azul + car_azul+ car_verm + bone_verm;
                Console.WriteLine("R - "+ soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("4 - ");
            soma = 0;
            bone = 1;
            if (brinq != bone)
            {
                soma = car_verd + car_azul + car_verm;
                Console.WriteLine("R - "+ soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("5 - ");
            soma = 0;
            bone = 0;
            if (brinq == bone && cor == vermelho)
            {
                soma =  bone_verm;
                Console.WriteLine("R - "+ soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("6 - ");
            soma = 0;
            if (cor == azul || cor == verde)
            {
                soma = bone_azul + bone_verd + car_azul + car_verd;
                Console.WriteLine("R - "+ soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("7 - ");
            soma = 0;
            verde = 0;
            car = 0;
            if (cor == verde && brinq == car)
            {
                soma = car_verd;
                Console.WriteLine("R - "+ soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("8 - ");
            soma = 0;
            if (cor == azul || cor == vermelho && brinq == car)
            {
                soma = car_verm;
                Console.WriteLine("R - "+ soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("9 - ");
            soma = 0;
            if ((cor == azul || cor == vermelho) && brinq == car)
            {
                soma = car_azul + car_verm;
                Console.WriteLine("R - "+ soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("10 - ");
            soma = 0;
            azul = 1;
            vermelho = 1;
            if (cor != azul && brinq == car || cor != vermelho)
            {
                soma = car_verd;
                Console.WriteLine("R - "+ soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("11 - ");
            soma = 0;
            azul = 1;
            vermelho = 1;
            if (cor != azul && (brinq == car || cor != vermelho))
            {
                soma = car_verd + car_verm;
                Console.WriteLine("R - "+ soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("12 - ");
            soma = 0;
            verde = 1;
            if (cor != verde && brinq == bone || cor != vermelho)
            {
                soma = bone_azul;
                Console.WriteLine("R - "+ soma);
            }
            Console.WriteLine("#####################");
            Console.WriteLine("13 - ");
            soma = 0;
            azul = 0;
            bone = 0;
            verde = 0;
            if (cor == azul && brinq == bone && cor == verde)
            {
                soma = bone_azul + bone_verd;
                Console.WriteLine("R - "+ soma);
            }
            Console.WriteLine("#####################");

            Console.ReadKey();

        }
    }
}
