# Fact 2045d48b

Store id: 1d553940-d638-4a9f-a2eb-f90efdf71eaf

## Text

```text
def get_db_converters(self, connection)
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
- posted_at: `2026-11-09T23:31:56.4870060+00:00`

## Data

```json
{
  "end_line": 962,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 959,
  "symbol": "Field.get_db_converters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":959,"selector":"L959-L962","symbol":"Field.get_db_converters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_db_converters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 962,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 959,
    "symbol": "Field.get_db_converters"
  },
  "id": "1d553940-d638-4a9f-a2eb-f90efdf71eaf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4870060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 959,
        "selector": "L959-L962",
        "symbol": "Field.get_db_converters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "7f7eedf2-49a1-467f-9c7a-c6fb8c6f7642",
  "subject_name": "django/db/models/fields/__init__::Field.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
