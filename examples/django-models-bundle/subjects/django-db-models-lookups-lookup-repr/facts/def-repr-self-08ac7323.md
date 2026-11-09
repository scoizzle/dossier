# Fact 08ac7323

Store id: 45178c8e-fe94-4447-b4f5-23f5a2c16db4

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:44:54.8499990+00:00`

## Data

```json
{
  "end_line": 59,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 58,
  "symbol": "Lookup.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":58,"selector":"L58-L59","symbol":"Lookup.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 59,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 58,
    "symbol": "Lookup.__repr__"
  },
  "id": "45178c8e-fe94-4447-b4f5-23f5a2c16db4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8499990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 58,
        "selector": "L58-L59",
        "symbol": "Lookup.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "dbc2dba9-776d-4de8-b01e-e3547a940c00",
  "subject_name": "django/db/models/lookups::Lookup.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
