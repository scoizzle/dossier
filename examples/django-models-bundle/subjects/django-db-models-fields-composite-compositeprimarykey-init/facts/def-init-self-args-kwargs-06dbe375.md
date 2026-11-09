# Fact 06dbe375

Store id: 9f874faa-c4db-4e05-a50e-80a872dff0b9

## Text

```text
def __init__(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.4793190+00:00`

## Data

```json
{
  "end_line": 76,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 53,
  "symbol": "CompositePrimaryKey.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":53,"selector":"L53-L76","symbol":"CompositePrimaryKey.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 76,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 53,
    "symbol": "CompositePrimaryKey.__init__"
  },
  "id": "9f874faa-c4db-4e05-a50e-80a872dff0b9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4793190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 53,
        "selector": "L53-L76",
        "symbol": "CompositePrimaryKey.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "5ede224a-7626-41b0-9f7d-f0bf181cba80",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
