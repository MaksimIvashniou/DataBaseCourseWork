Сущности:
«Company» - для хранения информации о предприятии;
«Employee» - для хранения информации о сотрудниках предприятия.
«Position» - для хранения информации о ролях сотрудников.
«Permission» - хранит в себе информацию о разрешения ролей сотрудников.
«PersonalInfo» - для хранения информации о персональных данных сотрудника.
«WeldingMachine» - для хранения информации о сварочном аппарате.
«ModelOfWeldingMachine» - для хранения информации о модели сварочного аппарата.
«ModelCharacteristic» - для хранения информации о характеристиках сварочных аппаратов.
«WorkObject» - для хранения информации об объекте.
«WorkObjectResult» - для хранения информации о прогрессе объекта.
«WorkObjectTask» - для хранения информации о задании на объекте
«WorkObjectTaskResult» - для хранения информации о прогрессе задания.
«BookingWorkObjectTask» - для хранения информации о резервировании сварочного оборудования на задание объекта.

Связи:

«Company» : «Employee»								||	(1 : M)
«Company» : «WeldingMachine»						||	(1 : M)
«Company» : «WorkObject»							||	(1 : M)

«Employee» : «PersonalInfo»							||	(1 : 1)
«Employee» : «Position»								||	(1 : M)
«Position» : «Permission»							||	(M : M) [PositionPermissions]

«WeldingMachine» : «ModelOfWeldingMachine»			||	(1 : M)
«ModelOfWeldingMachine» : «ModelCharacteristic»		||	(1 : 1)

«WorkObject» : «WorkObjectResult»					||	(1 : 1)
«WorkObject» : «WorkObjectTask»						||	(1 : M)

«Employee» : «BookingWorkObjectTask»				||	(1 : M)
«WeldingMachine» : «BookingWorkObjectTask»			||	(1 : M)
«WorkObjectTask» : «BookingWorkObjectTask»			||	(1 : 1)
«BookingWorkObjectTask» : «CompanyObjectTaskResult»	||	(1 : 1)

