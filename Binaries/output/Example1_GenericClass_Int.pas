.info
	.source "PapyrusDotNet-Generated.psc"
	.modifyTime 1439547956
	.compileTime 1439547956
	.user "Karlj"
	.computer "CD197"
.endInfo
.userFlagsRef
	.flag conditional 1
	.flag hidden 0
.endUserFlagsRef
.objectTable
.object Example1_GenericClass_Int Form
		.userFlags 0
		.docString ""
		.autoState
		.variableTable
			.variable ::GenericVariable Int
				.userFlags 0
				.initialValue None
			.endVariable
		.endVariableTable
		.propertyTable
		.endPropertyTable
		.stateTable
			.state
				.function Set
					.userFlags 0
					.docString ""
					.return None
					.paramTable
						.param value Int
					.endParamTable
					.localTable
					.endLocalTable
					.code
						Assign ::GenericVariable value
						Return None
					.endCode
				.endFunction
				.function Get
					.userFlags 0
					.docString ""
					.return Int
					.paramTable
					.endParamTable
					.localTable
						.local V_0 Int
					.endLocalTable
					.code
						Assign V_0 ::GenericVariable
						Jump _label10
					_label10:
						Return V_0
					.endCode
				.endFunction
				.function OnInit
					.userFlags 0
					.docString ""
					.return None
					.paramTable
					.endParamTable
					.localTable
						.local ::NoneVar None
					.endLocalTable
					.code
						Return None
					.endCode
				.endFunction
			.endState
		.endStateTable
	.endObject
.endObjectTable