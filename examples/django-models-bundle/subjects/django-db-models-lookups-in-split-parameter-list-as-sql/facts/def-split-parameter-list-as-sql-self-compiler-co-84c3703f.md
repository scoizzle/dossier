# Fact 84c3703f

Store id: 5ed6321d-526d-4fda-b3d6-64c60254ab73

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
- posted_at: `2026-11-09T23:44:55.0105750+00:00`

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
  "id": "5ed6321d-526d-4fda-b3d6-64c60254ab73",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0105750+00:00"
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
  "subject_id": "bfffd3cc-27f7-4907-8ad4-349d1353ec0c",
  "subject_name": "django/db/models/lookups::In.split_parameter_list_as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def split_parameter_list_as_sql(self, compiler, connection)"
}
```
