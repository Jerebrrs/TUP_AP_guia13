using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaClienRestApiDesktop.Dtos;

internal class FiguraDto
{
    public int? Id { get; set; }
    public int Tipo { get; set; }
    public double? Area { get; set; }
    public double? Ancho { get; set; }

    public override string ToString()
    {
        return $"Id:{Id} Tipo:{Tipo} Area:{Area} Ancho:{Ancho}";
    }
}
