# Fact de9d60ac

Store id: e6ab958f-1668-4b65-8057-110ba72a6873

## Text

```text
def __init__(self, obj, subscript)
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
- posted_at: `2026-11-09T23:31:55.8487890+00:00`

## Data

```json
{
  "end_line": 1027,
  "entity_kind": "method",
  "parent": "Sliced",
  "start_line": 1004,
  "symbol": "Sliced.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1004,"selector":"L1004-L1027","symbol":"Sliced.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Sliced.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1027,
    "entity_kind": "method",
    "parent": "Sliced",
    "start_line": 1004,
    "symbol": "Sliced.__init__"
  },
  "id": "e6ab958f-1668-4b65-8057-110ba72a6873",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8487890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1004,
        "selector": "L1004-L1027",
        "symbol": "Sliced.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "8a44e964-f812-4871-8185-492be6d78b26",
  "subject_name": "django/db/models/expressions::Sliced.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, obj, subscript)"
}
```
