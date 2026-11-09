# Fact 84c3703f

Store id: cf3aff55-01cf-46fc-9b12-3e2625851ffb

## Text

```text
def split_parameter_list_as_sql(self, compiler, connection)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.3373380+00:00`

## Data

```json
{
  "end_line": 581,
  "entity_kind": "method",
  "parent": "In",
  "start_line": 561,
  "symbol": "In.split_parameter_list_as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":561,"selector":"L561-L581","symbol":"In.split_parameter_list_as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::In.split_parameter_list_as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 581,
    "entity_kind": "method",
    "parent": "In",
    "start_line": 561,
    "symbol": "In.split_parameter_list_as_sql"
  },
  "id": "cf3aff55-01cf-46fc-9b12-3e2625851ffb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3373380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 561,
        "selector": "L561-L581",
        "symbol": "In.split_parameter_list_as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "6719fc8b-7926-491b-81c1-fea0c57bba00",
  "subject_name": "django/db/models/lookups::In.split_parameter_list_as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def split_parameter_list_as_sql(self, compiler, connection)"
}
```
