# Fact 229fa643

Store id: 529fda28-91ec-4a34-84ff-8d5f2446c52e

## Text

```text
def get_attname_column(self)
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
- posted_at: `2026-11-09T23:44:50.0322330+00:00`

## Data

```json
{
  "end_line": 1021,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1018,
  "symbol": "Field.get_attname_column"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1018,"selector":"L1018-L1021","symbol":"Field.get_attname_column"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_attname_column](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1021,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1018,
    "symbol": "Field.get_attname_column"
  },
  "id": "529fda28-91ec-4a34-84ff-8d5f2446c52e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0322330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1018,
        "selector": "L1018-L1021",
        "symbol": "Field.get_attname_column"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ea8a19b0-ac12-4c17-be61-3479eb02e1c8",
  "subject_name": "django/db/models/fields/__init__::Field.get_attname_column",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname_column(self)"
}
```
