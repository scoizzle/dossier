# Fact bd1267eb

Store id: 372baef2-b35c-472d-9085-bad66991364e

## Text

```text
def db_type_parameters(self, connection)
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
- posted_at: `2026-11-09T23:31:57.6468390+00:00`

## Data

```json
{
  "end_line": 207,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 206,
  "symbol": "GeneratedField.db_type_parameters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":206,"selector":"L206-L207","symbol":"GeneratedField.db_type_parameters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.db_type_parameters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 207,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 206,
    "symbol": "GeneratedField.db_type_parameters"
  },
  "id": "372baef2-b35c-472d-9085-bad66991364e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.6468390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 206,
        "selector": "L206-L207",
        "symbol": "GeneratedField.db_type_parameters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "ee86e996-cb65-427c-a5c5-555f19605629",
  "subject_name": "django/db/models/fields/generated::GeneratedField.db_type_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type_parameters(self, connection)"
}
```
