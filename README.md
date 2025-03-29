# CarRentalApi
Auto nomas sistēma ļauj klientiem rezervēt automašīnas, pārvaldīt pieejamos transportlīdzekļus un sekot līdzi rezervācijām.

Galvenie biznesa lietošanas gadījumi(Use Cases):
  Pievienot jaunu automašīnu sistēmā (piem., administratori var reģistrēt jaunu auto);
  Rezervēt auto konkrētam datumam (lietotājs izvēlas auto un rezervē to);
  Iegūt informāciju par visiem pieejamajiem auto (lietotājs redz, kādi auto ir pieejami nomai);
  Iegūt informāciju par konkrētu rezervāciju (klients var apskatīt savu rezervāciju pēc ID);
  Atcelt rezervāciju (klients vai administrators var atcelt rezervāciju).

UML shēma
[Customer] 1 - * [Reservation] * - 1 [Car]

Paskaidrojums:
Viens klients var veikt vairākas rezervācijas. Viena rezervācija attiecas uz vienu automašīnu. Viena automašīna var būt vairākās rezervācijās dažādos datumos.
