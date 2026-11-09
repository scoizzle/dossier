# Fact 48634081

Store id: 10071ecf-015d-43aa-a1c6-e27caa5aa084

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:55.0488360+00:00`

## Data

```json
{
  "end_line": 704,
  "entity_kind": "method",
  "parent": "Regex",
  "start_line": 696,
  "symbol": "Regex.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":696,"selector":"L696-L704","symbol":"Regex.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Regex.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 704,
    "entity_kind": "method",
    "parent": "Regex",
    "start_line": 696,
    "symbol": "Regex.as_sql"
  },
  "id": "10071ecf-015d-43aa-a1c6-e27caa5aa084",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0488360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 696,
        "selector": "L696-L704",
        "symbol": "Regex.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "88af77f2-ddc4-4aff-a990-28bab0f06401",
  "subject_name": "django/db/models/lookups::Regex.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
