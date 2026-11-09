# Fact 06dbe375

Store id: 97ec8aab-0498-4c26-869d-2504a0a6d73b

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
- posted_at: `2026-11-09T23:31:57.1203360+00:00`

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
  "id": "97ec8aab-0498-4c26-869d-2504a0a6d73b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1203360+00:00"
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
  "subject_id": "84ab7a50-0a32-4c94-b1eb-83068be108f0",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
